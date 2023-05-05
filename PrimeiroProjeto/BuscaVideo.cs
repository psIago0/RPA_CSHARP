using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace PrimeiroProjeto
{
    class BuscaVideo : Begin
    {

        [Test]
        public void Test()
        {


            // guarda em uma variavel o cpf que foi gerado

            driver.FindElement(By.XPath("//*[@id=\"texto_cpf\"]/span"));

            var cpfGerado = driver.FindElement(By.XPath("//*[@id=\"texto_cpf\"]")).Text;

            // clica em validador de cpf
            Click("//*[@id=\"top-nav\"]/li[37]/a");

            // passa o cpf a ser validado no campo
            SendKey("//*[@id=\"txt_cpf\"]", cpfGerado);

            // clica em validar cpf
            Click("//*[@id=\"bt_validar_cpf\"]");

            Assert.Pass();

        }
        private void Click(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }
        private void SendKey(string xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        private void ClickId(string id)
        {
            driver.FindElement(By.Id(id)).Click();
        }
        private void SendKeyId(string id, string value)
        {
            driver.FindElement(By.Id(id)).SendKeys(value);
        }
    }
}
