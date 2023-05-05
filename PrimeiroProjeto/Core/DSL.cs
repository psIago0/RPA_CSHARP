using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Core
{
    public class DSL : GlobalConfig
    {
        #region Métodos interação
        public void Click(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public void SendKey(string xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        public void ClickId(string id)
        {
            driver.FindElement(By.Id(id)).Click();
        }

        public void SendKeyId(string id, string value)
        {
            driver.FindElement(By.Id(id)).SendKeys(value);
        }

        public void SelectOption(string xpath, string value)
        {
            IList<IWebElement> options = driver.FindElements(By.XPath(xpath));
            foreach (IWebElement option in options)
            {
                if (option.Text == value)
                {
                    option.Click();
                }
            }
        }

        public void Find(string xpath)
        {
            driver.FindElement(By.XPath(xpath));
        }

        #endregion

        #region Métodos manipulação
        public static void Wait(int time)
        {
            Thread.Sleep(time);
        }

        #endregion

        #region Métodos atribuição
        public string GetValue(string xpath)
        {
            var text = driver.FindElement(By.XPath(xpath)).Text;
            return text;
        }
        public void ValidValue(string xpath, string value)
        {
            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));
        }

        #endregion

    }
}
