using Aquality.Selenium.Browsers;
using NUnit.Framework;

namespace SimpleTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var browser = AqualityServices.Browser;
            browser.Maximize();
            browser.GoTo("https://www.google.com/");
            Assert.AreEqual(browser.CurrentUrl, "https://www.google.com/", "not the same url");
            browser.Quit();
        }
    }
}