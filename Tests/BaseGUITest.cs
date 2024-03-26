using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithCsharp.Pages;

namespace SeleniumWithCsharp.Tests
{
    public class BaseGUITest
    {
        protected string websiteURL = "https://www.saucedemo.com";
        protected IWebDriver driver;
        public BaseGUITest() {

        }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(websiteURL);
        }

        [TearDown]
        public void Teardown()
        {
            //driver.Dispose();
            //driver.Quit();
        }
    }
}