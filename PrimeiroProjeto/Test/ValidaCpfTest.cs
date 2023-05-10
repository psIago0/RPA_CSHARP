using System;
using NUnit.Framework;
using PrimeiroProjeto.Page;

namespace PrimeiroProjeto.Test
{
    public class ValidaCpfTest : ValidaCpfPage
    {
        public void ValidaCpf()
        {
            //string cpfGerado = GuardarCpf();
            string[] cpfsGerados = LerArquivoCpf();
            FecharAnuncio1();
            AbrirValidador();
            int i = 0;
            foreach (string cpf in cpfsGerados)
            {
                i += 1;
                Console.WriteLine(cpf + " " + i);
                LimparCpf();
                EscreverCpf(cpf);
                ValidarCpf();
            }
            // ConfereValidacao();
        }
    }
}
