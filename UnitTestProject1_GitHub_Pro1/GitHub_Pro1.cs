using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace UnitTestProject1_GitHub_Pro1
{
    [TestClass]
    public class GitHub_Pro1
    {
        [TestMethod]
        public void WebdriverSetUp()
        {
            var _Options = new ChromeOptions();
            _Options.AddArgument("--headless");
            _Options.AddArgument("--sandbox");
            _Options.AddArgument("--disable-dev-shm-usage");
            //new DriverManager();
            IWebDriver _Drivar = new ChromeDriver();
            _Drivar.Navigate().GoToUrl("https://adactinhotelapp.com/");
            _Drivar.Manage().Window.Maximize();
            _Drivar.FindElement(By.XPath("//input[@id='username']")).SendKeys("nagalakshmin");
            _Drivar.FindElement(By.XPath("//input[@id='password']")).SendKeys("l@kshmin");
            _Drivar.FindElement(By.XPath("//input[@id='login']")).Click();
            Thread.Sleep(10000);
            _Drivar.Quit();
        }
    }
}
