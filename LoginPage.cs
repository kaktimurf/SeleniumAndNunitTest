using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumLearn
{
    class LoginPage
    {
        IWebDriver driver;
        [SetUp]
        public void BrowserOpen()
        {
            driver = new ChromeDriver("C:\\Program Files\\Google\\Chrome\\Application");
            driver.Manage().Window.Maximize();
        }
        
        [Test]
        public void Login()
        {
            driver.Url = "https://ogrposta.selcuk.edu.tr/";
            Thread.Sleep(4000);
            IWebElement element = driver.FindElement(By.XPath("//*[@id='username']"));
            element.SendKeys("ogrNo@ogr.selcuk.edu.tr");//öğrenci epostası
            element = driver.FindElement(By.XPath("//*[@id='password']"));
            element.SendKeys("ogrPassword");//öğrenci parolası
            element = driver.FindElement(By.XPath("//*[@type='submit' and contains(@class,DwtButton)]"));
            element.Click();
            driver.Manage().Timeouts();
            Thread.Sleep(10000);
            Thread.Sleep(5000);

        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
