using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Xray_JiraIntegration.StepDef
{
    [Binding]
    public class CBALogin
    {
        private IWebDriver driver;
        public CBALogin(IWebDriver _driver)
        {
            driver = _driver;
        }
        [Given(@"I enter CBA url in Browser")]
        public void GivenIEnterCBAUrlInBrowser()
        {
            driver.Navigate().GoToUrl("https://www.my.commbank.com.au/netbank/Logon/Logon.aspx");
        }

        [Then(@"I enter ""(.*)"" in ClientNumber field")]
        public void ThenIEnterInClientNumberField(int clientNumber)
          
        {
            string clientnumber = clientNumber.ToString();
          driver.FindElement(By.Id("txtMyClientNumber_field")).SendKeys(clientnumber);
        }


        [Then(@"I enter ClientNumber in ClientNumber field")]
        public void ThenIEnterClientNumberInClientNumberField(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            
          
        }
        [Then(@"I enter ""(.*)"" in password field")]
        public void ThenIEnterInPasswordField(string password)
        {
            driver.FindElement(By.Id("txtMyPassword_field")).SendKeys(password);
        }


        [Then(@"I enter Password in password field")]
        public void ThenIEnterPasswordInPasswordField(Table table)
        {

            dynamic data = table.CreateDynamicInstance();
            driver.FindElement(By.Id("txtMyPassword_field")).SendKeys((String)data.Password);

        }

        [Then(@"Click LogOn button")]
        public void ThenClickLogOnButton()
        {
            driver.FindElement(By.Id("btnLogon_field")).Click();
        }

        [Then(@"verify successful login")]
        public void ThenVerifySuccessfulLogin()
        {
            var element = driver.FindElement(By.ClassName("LastLogon"));
            Assert.That(element.Text, Is.Not.Null, "Header Text is not Found");

        }

        [Then(@"click logout")]
        public void ThenClickLogout()
        {
            driver.FindElement(By.Id("ctl00_HeaderControl_logOffLink")).Click();
        }

        [Then(@"verify Login Error Message")]
        public void ThenVerifyLoginErrorMessage()
        {

            var element = driver.FindElement(By.XPath("//*[@class='validation']"));
            Assert.That(element.Text, Is.Not.Null, "Header Text is not Found");

        }
    }
}


