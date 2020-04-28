using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public class HomePage : BasePage
    {
        //page objects
        //Encapsulation implemented
        private By newsLink = By.LinkText("News");
        private By searchButton = By.Id("orb-search-button");
        private By dateTime = By.XPath("//time[@class='hp - banner__date gel - pica']");
        private By header = By.XPath("//h2[text()='Welcome to the BBC']");

        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        //getters of page objects

        public IWebElement GetNewsLink()
        {
            return GetElement(newsLink);
        }

        public IWebElement GetSearchButton()
        {
            return GetElement(searchButton);
        }

        public string GetHomePageTitle()
        {
            return GetPageTitle();
        }

        public string GetHomePageHeader()
        {
            return GetPageHeader(header);
        }

        public string GetDateTime()
        {
            return GetElement(dateTime).Text;
        }

        public NewsPage GotoNewsPage()
        {
            GetNewsLink().Click();
            return Create<NewsPage>();
        }
    }
}
