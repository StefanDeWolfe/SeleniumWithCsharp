using OpenQA.Selenium;
using SeleniumWithCsharp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCsharp.Tests
{
    public class EndToEndGUITest : BaseGUITest
    {
        public EndToEndGUITest() : base()
        {

        }

        [Test]
        [Category("smoke")]
        [Category("e2e")]
        //[TestCaseSource(nameof(Login))]
        public void ShopForSingleItem()
        {
            string UserName = "standard_user";
            string Password = "secret_sauce";
            string ItemToBuyId = "add-to-cart-sauce-labs-backpack";
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login(UserName, Password);
            InventoryPage inventoryPage = new InventoryPage(driver);
            Assert.IsTrue(inventoryPage.IsOnPage());

            inventoryPage.AddInventoryItemToCart(ItemToBuyId);
            //Assert.IsTrue(inventoryPage.GetInventoryItemText(ItemToBuyId).Equals("Remove"));

        }
       
    }
}
