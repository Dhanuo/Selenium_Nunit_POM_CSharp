using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using SeleniumExtras.WaitHelpers;



namespace PageObjectModel
{
    public class BasePage : Page
    {       

        public BasePage(IWebDriver driver) : base(driver)
        {
            
        }       

        public override IWebElement GetElement(By locator)
        {
            IWebElement element = null;
            try
            {
                element = driver.FindElement(locator);
                return element;
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("some error occured while creating the element {0}", locator.ToString()));
                Console.WriteLine(e.Message);
            }
            return element;
        }

        public override string GetPageHeader(By locator)
        {
            return driver.FindElement(locator).Text;         
        }

        public override string GetPageTitle()
        {
            return driver.Title;
        }

        public override void WaitForElementPresent(By locator)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(locator));

            }
            catch(Exception e)
            {
                Console.WriteLine(string.Format("Exception occurred while waitForElementPresent {0}", locator.ToString()));
                Console.WriteLine(e.StackTrace);
            }
            
        }

        public override void WaitForPageTitle(string title)
        {
            try
            {
                wait.Until(ExpectedConditions.TitleContains(title));

            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("Exception occurred while waitForPageTitle {0}", title));
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
