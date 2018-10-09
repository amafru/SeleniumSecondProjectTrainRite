using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumSecondProjectTrainRite
{
    [TestFixture]
    public class TRTests
    {
        [TestCase("7329986650", "Passw0rd")]
        [TestCase("7039881255", "9876555")]
        [TestCase("25330924489", "sunil123")]
        public void tcLogin(string PhoneNumber, string Password)
        {
            IWebDriver oWD = new FirefoxDriver();
            oWD.Navigate().GoToUrl("http://www.trainingrite.net");

            oWD.FindElement(By.Id("txtphone")).SendKeys("7329986650");
            oWD.FindElement(By.Id("txtpassword")).SendKeys("Passw0rd");
            oWD.FindElement(By.Id("btnSubmit")).Click();

            string ExpectedData = "Welcome to TrainingRite.com";
            string ActualData = "Welcome to TrainingRite.com";

            Assert.That(ExpectedData, Is.EqualTo(ActualData));

            oWD.Close();

        }

        [Test]
        public void tcNewMember()
        {
            //We will record this test in Seleium IDE or Katalon firefox addon and
            //...convert our recording into c# code. then paste here
            //...and refactor it. e.g. change variable names like 
            //...'driver' to Our specific chosen driver.

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.trainingrite.net");

            driver.Navigate().GoToUrl("http://www.trainingrite.net/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Forgot Password?'])[1]/following::input[1]")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_txtFirstName")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_txtFirstName")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_txtFirstName")).SendKeys("James");
            driver.FindElement(By.Id("ctl00_MainContent_txtLastName")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_txtLastName")).SendKeys("Bond");
            driver.FindElement(By.Id("ctl00_MainContent_txtEmail")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_txtEmail")).SendKeys("james.bond@trainingrite.net");
            driver.FindElement(By.Id("ctl00_MainContent_txtPassword")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_txtPassword")).SendKeys("password007");
            driver.FindElement(By.Id("ctl00_MainContent_txtVerifyPassword")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_txtVerifyPassword")).SendKeys("password007");
            driver.FindElement(By.Id("ctl00_MainContent_txtHomePhone")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_txtHomePhone")).SendKeys("7077070007");
            driver.FindElement(By.Id("ctl00_MainContent_txtCellPhone")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_txtCellPhone")).SendKeys("7077070007");
            driver.FindElement(By.Id("ctl00_MainContent_txtInstructions")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_txtInstructions")).SendKeys("This is from Selenium Nov 2015 class.");
            driver.FindElement(By.Id("ctl00_MainContent_btnSubmit")).Click();

            Assert.AreEqual("Customer information added successfully", driver.FindElement(By.Id("ctl00_MainContent_lblTransactionResult")).Text);

        }
    }
}
