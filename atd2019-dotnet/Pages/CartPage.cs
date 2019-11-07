using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using workshop.Data;

namespace workshop.Pages
{
    class CartPage
    {
        private IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public String getItemName()
        {
            return driver.FindElement(By.ClassName("inventory_item_name")).Text;
        }

        public Boolean hasProduct(Product product)
        {
            IList<IWebElement> items = driver.FindElements(By.ClassName("inventory_item_name"));
            foreach (IWebElement item in items)
            {
                if (item.Text.Equals(product.GetName()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
