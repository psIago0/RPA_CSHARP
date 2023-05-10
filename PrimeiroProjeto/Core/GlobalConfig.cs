using OpenQA.Selenium;

namespace PrimeiroProjeto.Core
{
    public class GlobalConfig
    {
        // Define 'driver' como trigger para os WebElements
        public IWebDriver driver;

        public bool driverQuit = true;

        public bool headlessTest = false;

        public string caminhoDataBase = "C:\\WEBSITES\\Projetos_C#\\PrimeiroProjeto\\DataBase";

    }
}
