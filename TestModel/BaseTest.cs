﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using PageObjectModel;
using System.IO;
using System.Reflection;

namespace TestModel
{
    public class BaseTest
    {
        public IWebDriver driver;
        public Page page;

        [SetUp]
        public void TestSetup()
        {
            //Get the Chrome Driver Path
            string outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string relativePath = @"..\..\bin\Debug\Drivers\ChromeDriver";

            string chromeDriverPath = Path.GetFullPath(Path.Combine(outPutDirectory, relativePath));

            ChromeOptions options = new ChromeOptions();           

            options.AddArgument(chromeDriverPath);           
                        
            driver = new ChromeDriver(options);

            //Open Chrome Driver in Maximize mode
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
