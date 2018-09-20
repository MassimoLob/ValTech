using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Training_1
{

    public class ValtechPage
    {
        IWebDriver driver = new ChromeDriver();
        IWebElement RecentBlogsText => driver.FindElement(By.XPath("//h2[contains(text(),'recent blogs')]"));
        IWebElement AboutNav => driver.FindElement(By.XPath("//span[contains(text(),'About')]"));
        IWebElement AboutPageText => driver.FindElement(By.XPath("//h1[contains(text(),'About')]"));
        IWebElement ServicesNav => driver.FindElement(By.XPath("//span[contains(text(),'Services')]"));
        IWebElement ServicesPageText => driver.FindElement(By.XPath("//h1[contains(text(),'Services')]"));
        IWebElement WorkNav => driver.FindElement(By.XPath("//span[contains(text(),'Work')]"));
        IWebElement WorkPageText => driver.FindElement(By.XPath("//h1[contains(text(),'Work')]"));
        IWebElement ContactUsLink => driver.FindElement(By.XPath("//a[contains(text(),'Our offices')]"));
        IList<IWebElement> OfficeCount => driver.FindElements(By.CssSelector("h2.office__heading"));


        public void GoToHomepage()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.valtech.co.uk");
        }

        public void AssertBlogText()
        {
            Assert.That(RecentBlogsText, Contains.Substring("recent blogs"), "Error message");
        }

        public void NavigatePages()
        {
            ServicesNav.Click();
            Assert.That(ServicesPageText, Contains.Substring("Services"), "Error message");
            WorkNav.Click();
            Assert.That(WorkPageText, Contains.Substring("Work"), "Error message");
            AboutNav.Click();
            Assert.That(AboutPageText, Contains.Substring("About"), "Error message");
        }

        public void NumberOffices()
        {
            ContactUsLink.Click();
            Console.WriteLine("Number of Offices in total is " + OfficeCount.Count);
        }
    }
}
