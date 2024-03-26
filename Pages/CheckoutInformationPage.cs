using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCsharp.Pages
{
    public class CheckoutInformationPage : BasePage
    {
        public CheckoutInformationPage(IWebDriver driver) : base(driver) { }
        IWebElement FirstName => driver.FindElement(By.Id("first-name"));
        IWebElement LastName => driver.FindElement(By.Id("last-name"));
        IWebElement Zipcode => driver.FindElement(By.Id("postal-code"));
        IWebElement ContinueBtn => driver.FindElement(By.Id("postal-code"));
        public void FilloutCheckoutInformation(string firstName, string lastName, string zipCode)
        {
            Wait(FirstName, 5);
            SendKeys(FirstName, firstName);
            SendKeys(LastName, lastName);
            SendKeys(Zipcode, zipCode);
            Wait(ContinueBtn, 5);
            Submit(ContinueBtn);
        }
        public bool IsOnPage()
        {
            Wait(ContinueBtn, 5);
            return ContinueBtn.Displayed;
        }
    }
}
