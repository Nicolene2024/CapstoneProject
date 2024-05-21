using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using SikuliSharp;
using System.Text;
using OpenQA.Selenium.Support.UI;
using WindowsInput;
using WindowsInput.Native;
using NUnit.Framework;


namespace Capstone_Project
{
    public class Tests
    {
        ISikuliSession session;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Chrome browser is displayed & Home page is displayed
            //Open chrome browser and navigate to "https://demowebshop.tricentis.com"
            session = Sikuli.CreateSession();
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com");
            //Verify page title displays Demo Web Shop
            String PageTitle = driver.Title;
            Assert.True(PageTitle.Contains("Demo Web Shop"));
            Thread.Sleep(500);
            //Login page is displayed
            //Click on Login link in the page header
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")).Click();
            //Verify that the Entry box header is Returning Customer
            String DisplayNameAttribute = "Returning Customer";
            Assert.True(DisplayNameAttribute.Contains("Returning Customer"));
            //Enter email adress
            driver.FindElement(By.Id("Email")).SendKeys("nicoleer@pepkorit.com");
            Thread.Sleep(300);
            //Enter password
            driver.FindElement(By.Id("Password")).SendKeys("password");
            Thread.Sleep(500);
            //Home page is displayed
            //Click Login button
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/form/div[5]/input")).Click();
            //Verify user email is displayed in page header
            String EmailAddressAttribute = "nicoleer@pepkorit.com";
            Assert.True(EmailAddressAttribute.Contains("nicoleer@pepkorit.com"));
            //Select the Jewelry option under the Categories section
            //Jewelry downloads page is displayed
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/div[2]/ul/li[6]/a")).Click();
            //Verify that the url contains Jewelry
            List<string> urlList = new List<string>();
            urlList.Add("https://demowebshop.tricentis.com/jewelry");
            bool isContains = urlList.Any(x => x.Contains("Jewelry"));
            //Select the List option under the View as dropdown
            //Products will be displayed underneath each other
            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id=\"products-viewmode\"]/option[2]")).Click();

            //Add product to the cart
            string path = @"C:\Users\NICOLEER\Documents\Capstone\Images\Create_Your_Own_Jewelry.png";
            IPattern pattern = Patterns.FromFile(path);
            session.Click(pattern); 
        }
    }
} 


    

    



    

        
        
            
        
        

            
           