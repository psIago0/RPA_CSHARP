﻿using NUnit.Framework;
using System.Threading;

namespace PrimeiroProjeto.Page
{
    public class ValidaCpfPage : GeraCpfPage
    {
        public string GuardaCpf()
        {
            Find("//*[@id=\'texto_cpf\']/span");
            string cpfGerado = GetValue("//*[@id=\'texto_cpf\']");
            return cpfGerado;
        }

        public void FechaAnuncio1()
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

        public void AbreValidador()
        {
            Click("//*[@id='top-nav']/li[37]/a");
        }

        public void EscreveCpf (string cpf)
        {
            SendKey("//*[@id=\'txt_cpf\']", cpf);
        }
        public void FechaAnuncio2()
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

        public void ValidarCpf()
        {
            Click("//*[@id=\"bt_validar_cpf\"]");
        }

        public void ConfereValidacao()
        {
            Wait(3000);
            string resultado = GetValue("//*[@id='texto_resposta']");
            System.Console.WriteLine("resultado: {0}.", resultado);
        }
    }
}
