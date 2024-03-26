using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCsharp.Pages
{
    public class CheckoutOverviewPage : BasePage
    {
        public CheckoutOverviewPage(IWebDriver driver) : base(driver) { }
        IWebElement FinishBtn => driver.FindElement(By.Id("finish"));
        IWebElement CancelBtn => driver.FindElement(By.Id("cancel"));
        public void ClickFinish()
        {
            Wait(FinishBtn, 5);
            Click(FinishBtn);
        }
        public void ClickCancel()
        {
            Wait(CancelBtn, 5);
            Click(CancelBtn);
        }
        public bool IsOnPage()
        {
            Wait(FinishBtn, 5);
            return FinishBtn.Displayed;
        }
    }
}
