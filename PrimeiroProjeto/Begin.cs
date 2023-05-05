using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace PrimeiroProjeto
{
    public class Begin
    {
        public IWebDriver driver;

        [SetUp]
        public void InicioTeste()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.4devs.com.br/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            // clica em gerador de número de cpf
            Click("//*[@id=\"wrapper-content\"]/div[1]/div[1]/a/div[1]/img");

            try
            {
                Click("//*[@id=\"iat-adhesion-close-button\"]/button");
            }
            catch { }

            // pega todos os elementos do select do estado de origem do cpf
            IList<IWebElement> estados = driver.FindElements(By.XPath("//*[@id=\"cpf_estado\"]/option"));
            foreach (IWebElement estado in estados)
            {
                if (estado.Text == "SP")
                {
                    estado.Click();
                }
            }

            // clica no botao de gerar cpf
            ClickId("bt_gerar_cpf");

            /*

            // guarda em uma variavel o cpf que foi gerado
            var cpfGerado = driver.FindElement(By.XPath("//*[@id=\"texto_cpf\"]")).Text;

            // clica em validador de cpf
            Click("//*[@id=\"top-nav\"]/li[37]/a");

            // passa o cpf a ser validado no campo
            SendKey("//*[@id=\"txt_cpf\"]", cpfGerado);

            // clica em validar cpf
            Click("//*[@id=\"bt_validar_cpf\"]");

            */

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

        [TearDown]
        public void FimDoTeste() 
        {
            driver.Quit();
        }
    }
 }