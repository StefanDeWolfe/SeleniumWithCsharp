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
            string firstName = "John";
            string lastName = "Doe";
            string zipCode = "12345";


            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login(UserName, Password);
            InventoryPage inventoryPage = new InventoryPage(driver);
            Assert.IsTrue(inventoryPage.IsOnPage());

            inventoryPage.AddInventoryItemToCart(ItemToBuyId);
            //Assert.IsTrue(inventoryPage.GetInventoryItemText(ItemToBuyId).Equals("Remove"));
            inventoryPage.ClickShoppingCart();

            CartPage cartPage = new CartPage(driver);
            cartPage.ClickCheckout();

            CheckoutInformationPage checkoutInformationPage = new CheckoutInformationPage(driver);
            Assert.IsTrue(checkoutInformationPage.IsOnPage());
            checkoutInformationPage.FilloutCheckoutInformation(firstName, lastName, zipCode);

            CheckoutOverviewPage checkoutOverview = new CheckoutOverviewPage(driver);
            Assert.IsTrue(checkoutOverview.IsOnPage());
            checkoutOverview.ClickFinish();

            CheckoutCompletePage checkoutCompletePage = new CheckoutCompletePage(driver);
            Assert.IsTrue(checkoutCompletePage.IsOnPage());
            checkoutCompletePage.ClickBackHome();

            inventoryPage.Logoff();
            Assert.IsTrue(loginPage.IsOnPage());
        }
       
    }
}
