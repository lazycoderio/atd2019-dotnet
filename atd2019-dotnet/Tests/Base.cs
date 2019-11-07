using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace workshop.Base
{
    [TestFixture]
    [Parallelizable]
    public class Base
    {
        protected IWebDriver driver;

        
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}