using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCsharp.Pages
{
    public  class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver) { }
        IWebElement Checkout => driver.FindElement(By.Id("checkout"));
        public void ClickCheckout()
        {
            Click(Checkout);
        }
        public bool IsOnPage() 
        { 
        
            Wait(Checkout, 5);
            return Checkout.Displayed;
        }
    }
}
