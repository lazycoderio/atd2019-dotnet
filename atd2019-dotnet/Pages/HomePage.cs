using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using workshop.Data;

namespace workshop.Pages
{
    class HomePage : BasePage
    {
        private By username = By.Id("user-name");
        private By password = By.Id("password");
        private By submit = By.ClassName("btn_action");

        public static HomePage Visit(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
            return new HomePage(driver);
        }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Signin(User user)
        {
            Type(user.getUsername(), username);
            Type(user.getUsername(), username);
            Click(submit);
        }

        // These are here for previous exercises
        public IWebElement getUsername()
        {
            return Find(By.Id("user-name"));
        }
        public IWebElement getPassword()
        {
            return Find(By.Id("password"));
        }
        public IWebElement getSubmit()
        {
            return Find(By.ClassName("btn_action"));
        }
    }
}
