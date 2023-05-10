using NUnit.Framework;
using System.Threading;
using System;
using System.IO;

namespace PrimeiroProjeto.Page
{
    public class ValidaCpfPage : GeraCpfPage
    {
        public string GuardarCpf()
        {
            Find("//*[@id=\'texto_cpf\']/span");
            string cpfGerado = GetValue("//*[@id=\'texto_cpf\']");
            return cpfGerado;
        }

        public string[] LerArquivoCpf()
        {
            string[] cpfs = File.ReadAllLines(caminhoDataBase + "/cpf.txt");
            return cpfs;
        }

        public void FecharAnuncio1()
        {
            try
            {
                Click("//*[@id=\"iat-adhesion-close-button\"]/button");
            }
            catch
            {
                Assert.Pass();
            }
        }

        public void AbrirValidador()
        {
            Click("//*[@id='top-nav']/li[37]/a");
        }

        public void FecharAnuncio2()
        {
            try
            {
                Click("//*[@id=\"close\"]");
            }
            catch
            {
                Assert.Pass();
            }
        }

        public void EscreverCpf(string cpf)
        {
            SendKey("//*[@id=\'txt_cpf\']", cpf);
        }
        public void LimparCpf()
        {
            Clear("//*[@id=\'txt_cpf\']");
        }

        public void ValidarCpf()
        {
            Click("//*[@id=\"bt_validar_cpf\"]");
        }

        public void ConferirValidacao()
        {
            Wait(3000);
            string resultado = GetValue("//*[@id='texto_resposta']");
            Console.WriteLine("resultado: {0}.", resultado);
        }
    }
}
