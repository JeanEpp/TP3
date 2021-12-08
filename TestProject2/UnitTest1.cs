using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject2
{
    class Selenium_Demo
    {
        String test_url = "http://localhost:57270/";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            driver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application");
            driver.Manage().Window.Maximize();
        }

        [Test, Order(1)]
        public void test_register()
        {
            driver.Url = test_url;
            System.Threading.Thread.Sleep(2000);
            IWebElement searchLink = driver.FindElement(By.XPath("//*[@id='navbarSupportedContent']/div/div[3]/ul[2]/li[3]/a"));
            searchLink.Click();
            searchLink = driver.FindElement(By.XPath("/html/body/div/div/div/form/div[3]/p/a"));
            searchLink.Click();
            IWebElement Firstname = driver.FindElement(By.Id("FirstName"));
            Firstname.SendKeys("Jean");
            IWebElement Lastname = driver.FindElement(By.Id("LastName"));
            Lastname.SendKeys("Epp");
            IWebElement Email = driver.FindElement(By.Id("Email"));
            Email.SendKeys("jeanepp99@gmail.com");
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("1234");
            IWebElement PasswordConfirm = driver.FindElement(By.Id("PasswordConfirm"));
            PasswordConfirm.SendKeys("1234");
            searchLink = driver.FindElement(By.XPath("//*[@id='client']/form/button"));
            searchLink.Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@action='/login']"));
            Console.WriteLine("Test Register Passed");
        }

        [Test, Order(2)]
        public void test_login()
        {
            driver.Url = test_url;
            System.Threading.Thread.Sleep(2000);
            IWebElement searchLink = driver.FindElement(By.XPath("//*[@id='navbarSupportedContent']/div/div[3]/ul[2]/li[3]/a"));
            searchLink.Click();
            IWebElement Email = driver.FindElement(By.Id("Email"));
            Email.SendKeys("jeanepp99@gmail.com");
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("1234");
            searchLink = driver.FindElement(By.XPath("/html/body/div/div/div/form/button"));
            searchLink.Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='searchStr']"));
            Console.WriteLine("Test Login Passed");
        }

        [Test, Order(3)]
        public void test_logout()
        {
            driver.Url = test_url;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            System.Threading.Thread.Sleep(2000);
            IWebElement searchLink = driver.FindElement(By.XPath("//*[@id='navbarSupportedContent']/div/div[3]/ul[2]/li[3]/a"));
            searchLink.Click();
            IWebElement Email = driver.FindElement(By.Id("Email"));
            Email.SendKeys("jeanepp99@gmail.com");
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("1234");
            searchLink = driver.FindElement(By.XPath("/html/body/div/div/div/form/button"));
            searchLink.Click();
            System.Threading.Thread.Sleep(2000);
            searchLink = driver.FindElement(By.XPath("//*[@id='navbarSupportedContent']/div/div[3]/ul[2]/li[3]/a"));
            searchLink.Click();
            System.Threading.Thread.Sleep(2000);
            searchLink = driver.FindElement(By.XPath("/html/body/div/div/div/div/button"));
            js.ExecuteScript("arguments[0].scrollIntoView();", searchLink);
            System.Threading.Thread.Sleep(2000);
            searchLink = driver.FindElement(By.XPath("/html/body/div/div/div/div/button"));
            searchLink.Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div/div/div/form"));
            Console.WriteLine("Test Logout Passed");
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}