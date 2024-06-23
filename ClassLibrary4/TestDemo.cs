using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace AutomationTest
{
    [TestClass]
    public class TestDemo
    {

        private IWebDriver? driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (driver != null) 
            {
                driver.Quit();
                driver.Dispose();
            } 

        }


/*        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Ok");
            Assert.AreEqual(5, ConsoleApp2.Program.add(2, 3));

        }*/

        [TestMethod]
        public void AutoTestDemo()
        {

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            driver.Navigate().GoToUrl("https://anupdamoda.github.io/AceOnlineShoePortal/index.html");
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            driver.FindElement(By.XPath("//*[@id=\"menuToggle\"]/input")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"menu\"]/a[2]/li")).Click();

            driver.FindElement(By.XPath("//*[@id=\"usr\"]")).SendKeys("sa");
            driver.FindElement(By.XPath("//*[@id=\"pwd\"]")).SendKeys("sa");
            driver.FindElement(By.XPath("//*[@id=\"second_form\"]/input")).Click();

            IWebElement webElement = driver.FindElement(By.XPath("//*[@id=\"ShoeType\"]"));
            String actualFirstCategory = webElement.Text;
            String expectedFirstCategory = "Formal Shoes";
            Assert.AreEqual(expectedFirstCategory, actualFirstCategory);

            driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr[1]/td[6]/button")).Click();

            string text = driver.FindElement(By.XPath("/html/body/center[1]/h1")).Text;
            Assert.AreEqual("Added to Cart Successfully !!!", text);


        }
    }
}
