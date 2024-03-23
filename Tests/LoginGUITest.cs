using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithCsharp.Pages;
using SeleniumWithCsharp.Models;
using System;

namespace SeleniumWithCsharp.Tests
{
    public class LoginGUITest: BaseGUITest
    {
        public LoginGUITest(): base() {

        }

        [Test]
        [Category("smoke")]
        [Category("login")]
        //[TestCaseSource(nameof(Login))]
        public void LoginAndLogoffWithStandardUser()
        {
            string UserName = "standard_user";
            string Password = "secret_sauce";
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login(UserName, Password);
            InventoryPage inventoryPage = new InventoryPage(driver);
            Assert.IsTrue(inventoryPage.IsOnPage());
            inventoryPage.Logoff();
            Assert.IsTrue(loginPage.IsOnPage());
        }

        [Test]
        [Category("smoke")]
        [Category("login")]
        //[TestCaseSource(nameof(Login))]
        public void LoginWithLockedoutUser()
        {
            string UserName = "locked_out_user";
            string Password = "secret_sauce";
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login(UserName, Password);
            Assert.IsTrue(loginPage.IsLockedOut());
            Assert.IsTrue(loginPage.GetLockedOutText().Equals("Epic sadface: Sorry, this user has been locked out."));
        }

    }
}