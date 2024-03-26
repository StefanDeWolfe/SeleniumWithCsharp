using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCsharp.Pages
{
    internal class CheckoutCompletePage : BasePage
    {
        public CheckoutCompletePage(IWebDriver driver) : base(driver) { }
        IWebElement BackHomeBtn => driver.FindElement(By.Id("back-to-products"));
        public void ClickBackHome()
        {
            Wait(BackHomeBtn);
            Click(BackHomeBtn);
        }
        public bool IsOnPage()
        {
            Wait(BackHomeBtn, 5);
            return BackHomeBtn.Displayed;
        }
    }
}
