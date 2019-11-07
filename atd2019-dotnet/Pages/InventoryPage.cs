using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using workshop.Data;

namespace workshop.Pages
{
    class InventoryPage
    {
        private IWebDriver driver;
        private static String url = "https://www.saucedemo.com/inventory.html";

        public static InventoryPage Visit(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(url);
            return new InventoryPage(driver);
        }

        public InventoryPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Boolean onPage()
        {
            return driver.Url.Equals(url);
        }

        public IWebElement getInventoryItem(String product)
        {
            IList<IWebElement> items = driver.FindElements(By.ClassName("inventory_item_label"));
            foreach (IWebElement item in items)
            {
                if (item.Text.Contains(product))
                {
                    return item.FindElement(By.TagName("a"));
                }
            }
            return null;
        }

        public void selectProduct(Product product)
        {
            getInventoryItem(product.GetName()).Click();
        }
    }
}
