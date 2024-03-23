using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeleniumWithCsharp.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) {  }
        // Elements
        IWebElement UserName => driver.FindElement(By.Id("user-name"));
        IWebElement Password => driver.FindElement(By.Id("password"));
        IWebElement LoginBtn => driver.FindElement(By.Id("login-button"));
        IWebElement LoginError => driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div/div/form/div[3]/h3"));
        //Page specific methods
        public void Login(string userName, string password)
        {
            SendKeys(UserName, userName);
            SendKeys(Password, password);
            Submit(LoginBtn);
        }
        public bool IsOnPage()
        {
            Wait(UserName);
            return UserName.Displayed && Password.Displayed && LoginBtn.Displayed;
        }
        public bool IsLockedOut()
        {
            return IsElementDisplayed(LoginError);
        }
        public string GetLockedOutText()
        {
            return GetElementText(LoginError);
        }
    }
}
