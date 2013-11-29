using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace YahooSearch
{
    [TestClass]
    public class YahooTests
    {
        [TestMethod]
        public void Should_Search_Odesk_In_Yahoo()
        {
            IWebDriver web = new FirefoxDriver ();
            web.Navigate().GoToUrl("http://www.amazon.com/Best-Sellers-Books-Science-Fiction-Fantasy/zgbs/books/25/ref=zg_bs_nav_b_1_b");
        }
    }
}
