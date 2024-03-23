using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeleniumWithCsharp.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        public BasePage(IWebDriver driver) { this.driver = driver; }
        public void Wait(IWebElement element)
        {
            Wait(element, 5);
        }
        public void Wait(IWebElement element, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(d => element.Displayed);
        }
        public void Click(IWebElement element)
        {
            Wait(element);
            element.Click();
        }
        public void SendKeys(IWebElement element, string str)
        {
            Wait(element);
            element.SendKeys(str);
        }
        public void Submit(IWebElement element)
        {
            Wait(element);
            element.Submit();
        }
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool IsElementDisplayed(IWebElement element)
        {
            return element.Displayed;
        }

        public string GetElementText(IWebElement element)
        {
            Wait(element);
            return element.Text;
        }

        public bool IsElementEnabled(IWebElement element)
        {
            return element.Enabled;
        }
        public IWebElement GetElementByID(string id)
        {
            return driver.FindElement(By.Id(id));
        }

    }
}
