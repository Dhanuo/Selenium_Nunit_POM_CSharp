using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using PageObjectModel;

namespace TestModel
{
    public class BaseTest
    {
        public IWebDriver driver;
        public Page page;

        [SetUp]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://bbc.co.uk";

            page = new BasePage(driver);
        }

        [TearDown]
        public void TestTearDown()
        {
            driver.Quit();
        }
    }
}
