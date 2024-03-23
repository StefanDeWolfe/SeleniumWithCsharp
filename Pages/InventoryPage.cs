using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCsharp.Pages
{
    public class InventoryPage : BasePage
    {
        public InventoryPage(IWebDriver driver) : base(driver) { }
        // Elements
        IWebElement ShoppingCart => driver.FindElement(By.Id("shopping_cart_container"));
        IWebElement HamburgerButton => driver.FindElement(By.Id("react-burger-menu-btn"));
        IWebElement LoginOffBtn => driver.FindElement(By.Id("logout_sidebar_link"));


        // //*[@id="add-to-cart-sauce-labs-backpack"]
        // //*[@id="add-to-cart-sauce-labs-fleece-jacket"]
        //Page specific methods
        //*[@id="logout_sidebar_link"]
        public bool IsOnPage()
        {
            Wait(ShoppingCart);
            return ShoppingCart.Displayed && HamburgerButton.Displayed;
        }
        public void Logoff()
        {
            Click(HamburgerButton); 
            Click(LoginOffBtn);
        }
        public void ClickShoppingCart()
        {
            Click(ShoppingCart);
        }
        public void AddInventoryItemToCart(string id)
        {
            IWebElement item = GetElementByID(id);
            Wait(item);
            Click(item);
        }
        public ReadOnlyCollection<IWebElement> GetAllInventoryItems()
        {
            return driver.FindElement(By.ClassName("inventory_list")).FindElements(By.ClassName("inventory_item"));
        }
        public string GetInventoryItemText(string id)
        {
            IWebElement item = GetElementByID(id);
            Wait(item);
            return item.Text;
        }
    }
}
