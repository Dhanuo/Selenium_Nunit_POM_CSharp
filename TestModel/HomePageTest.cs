using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PageObjectModel;

namespace TestModel
{
    public class HomePageTest : BaseTest
    {
        [Test]
        public void HomePageTitleTest()
        {            
            Assert.AreEqual("BBC - Home", page.Create<HomePage>().GetHomePageTitle());        
        }

        [Test]
        public void HomePageHeaderTest()
        {          
            Assert.AreEqual("Welcome to the BBC", page.Create<HomePage>().GetHomePageHeader());
        }

        [Test]
        public void GotoNewsPageTest()
        {            
            NewsPage newsPage = page.Create<HomePage>().GotoNewsPage();            

            Assert.AreEqual("Home - BBC News", newsPage.GetNewsPageTitle());
        }
    }
}
