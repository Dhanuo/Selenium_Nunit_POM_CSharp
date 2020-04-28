using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace PageObjectModel
{
    public abstract class Page
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        public Page(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(30));
        }

        //Abstract Methods
        public abstract string GetPageTitle();

        public abstract string GetPageHeader(By locator);

        public abstract IWebElement GetElement(By locator);

        public abstract void WaitForElementPresent(By locator);

        public abstract void WaitForPageTitle(string title);

        //Gneric Method to create pages
        public TPage Create<TPage>()
        where TPage : Page
        {
            var constructor = typeof(TPage).GetTypeInfo().GetConstructors().FirstOrDefault();
            var page = constructor.Invoke(new object[] { driver }) as TPage;
            return page;
        }
    }
}
