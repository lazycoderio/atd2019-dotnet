using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace workshop.Pages
{
    class ProductPage
    {
        private IWebDriver driver;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement GetAddToCartButton()
        {
            return driver.FindElement(By.ClassName("btn_inventory"));
        }

        public IWebElement GetCartButton()
        {
            return driver.FindElement(By.ClassName("shopping_cart_link"));
        }

        public void AddToCart()
        {
            GetAddToCartButton().Click();
        }

        public void Checkout()
        {
            GetCartButton().Click();
        }
    }
}
