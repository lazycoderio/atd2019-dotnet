using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace workshop.Pages
{
    class BasePage
    {
        protected IWebDriver driver;


        public IWebElement Find(By locator)
        {
            return driver.FindElement(locator);
        }

        public void Type(String text, By locator)
        {
            Find(locator).SendKeys(text);
        }

        public void Click(By locator)
        {
            Find(locator).Click();
        }
    }
}
