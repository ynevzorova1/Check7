using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Check7
{

    public class UnitTest1
    {

        IWebDriver driver;

        [Test]

        public void Test()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://old.qalight.com.ua/zapisatsya-na-kursy");

           ICollection<IWebElement> count = driver.FindElements(By.XPath("//div[@id='footer_social']/ul/li"));

            Assert.AreEqual(count.Count, 7,"Элементов не 7");
        }


    }
}
