using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace PrimeiroProjeto.Core
{
    public class Begin : DSL
    {
        public void AbreGoogle()
        {
            var headlessMode = new ChromeOptions();
            headlessMode.AddArgument("window-size-=1366x768");
            headlessMode.AddArgument("disk-cache-size=0");
            headlessMode.AddArgument("headless");

            var devMode = new ChromeOptions();
            devMode.AddArgument("disk-cache-size=0");
            devMode.AddArgument("start-maximized");

            if (headlessTest) {  driver = new ChromeDriver(headlessMode); }
            else { driver = new ChromeDriver(devMode); driverQuit = false; }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }
        [SetUp]
        public void InicioTeste()
        {
            AbreGoogle();
            driver.Navigate().GoToUrl("https://www.4devs.com.br/");
        }

        [TearDown]
        public void FimDoTeste()
        {
            if (driverQuit) driver.Quit();
        }
    }
}