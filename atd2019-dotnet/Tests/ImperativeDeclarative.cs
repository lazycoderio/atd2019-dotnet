using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using workshop.Data;
using workshop.Pages;

namespace workshop.Exercises
{
    class ImperativeDeclarative : Base.Base
    {
        [Test]
        public void Imperative()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");

            InventoryPage inventoryPage = new InventoryPage(driver);
            inventoryPage.getInventoryItem("Sauce Labs Bike Light").Click();

            ProductPage productPage = new ProductPage(driver);
            productPage.GetAddToCartButton().Click();
            productPage.GetCartButton().Click();

            CartPage cartPage = new CartPage(driver);
            Assert.That("Sauce Labs Bike Light" == cartPage.getItemName());
        }

        [Test]
        public void Declarative()
        {
            Product product = Product.Valid();

            InventoryPage inventoryPage = InventoryPage.Visit(driver);
            inventoryPage.selectProduct(product);

            ProductPage productPage = new ProductPage(driver);
            productPage.AddToCart();
            productPage.Checkout();

            CartPage cartPage = new CartPage(driver);
            Assert.That(cartPage.hasProduct(product));
        }
    }
}
