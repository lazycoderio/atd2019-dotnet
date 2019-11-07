using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using workshop.Data;
using workshop.Pages;

namespace workshop.Examples
{
    class DeclarativeTest  : Base.Base
    {
        [Test]
        public void Imperative()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            String username = "standard_user";
            String password = "secret_sauce";

            HomePage homePage = new HomePage(driver);
            homePage.getUsername().SendKeys(username);
            homePage.getPassword().SendKeys(password);
            homePage.getSubmit().Click();

            Assert.That("https://www.saucedemo.com/inventory.html".Equals(driver.Url), "The URL is not correct");
        }

        [Test]
        public void Declarative()
        {
            HomePage homePage = HomePage.Visit(driver);
            User user = User.valid();

            homePage.Signin(user);

            InventoryPage inventoryPage = new InventoryPage(driver);
            Assert.That(inventoryPage.onPage());
        }

     //   public DeclarativeTest(Platforms platform, Browsers browser, string version = "0") : base(platform, browser, version){}
    }
}
