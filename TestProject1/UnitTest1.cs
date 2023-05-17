using NUnit.Framework;
using OpenQA.Selenium;


namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Edge.EdgeDriver();
            driver.Navigate().GoToUrl("https://cian.ru");
            driver.Manage().Window.Maximize();
        }

        private readonly By _singInButton = By.XPath($"//*[@id=\"header-frontend\"]/div[2]/div/div/a/span");
        private readonly By _AuthInputButton = By.XPath($"/html/body/div[3]/div/div/div[2]/div/div/div/div[2]/div/form/div[1]/div[1]/div/input");
        private const string _login = "vladimir-andreev-2013@yandex.ru";


        [Test]
        public void Test1()
        {
            var singIn = driver.FindElement(_singInButton);
            singIn.Click();

            var login = driver.FindElement(_AuthInputButton);
            login.SendKeys(_login);


        }

        [TearDown]
        public void Teardown()
        {

        }
        private IWebDriver driver;
    }
}