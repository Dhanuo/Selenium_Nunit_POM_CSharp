using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public class NewsPage : BasePage
    {
        //page objects
        private By homeLink = By.LinkText("Home");

        public NewsPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement GetHomeLink()
        {
            return GetElement(homeLink);
        }

        public string GetNewsPageTitle()
        {
            return GetPageTitle();
        }

        public HomePage GotoHomePage()
        {
            GetHomeLink().Click();
            return Create<HomePage>();
        }
    }
}
