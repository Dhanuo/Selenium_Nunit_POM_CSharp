using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PageObjectModel;

namespace TestModel
{
    public class NewsPageTest : BaseTest
    {
        [Test]
        public void NewsPageTitle()
        {
            NewsPage newsPage = page.Create<HomePage>().GotoNewsPage();            

            Assert.AreEqual("Home - BBC News", newsPage.GetNewsPageTitle());
        }

        [Test]
        public void GotoHomePageTest()
        {
            NewsPage newsPage = page.Create<HomePage>().GotoNewsPage();
            
            HomePage homePage = newsPage.GotoHomePage();

            Assert.AreEqual("BBC - Home", homePage.GetHomePageTitle());
        }
    }
}
