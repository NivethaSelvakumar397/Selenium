using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumTest.SignInPage
{
    [TestFixture]
    public class SignInfunctiona 
    {
        [Test]
        public void SignInPage(IWebDriver driver)
        {
            //Arrange
            IWebElement userName = driver.FindElement(By.Id("user-name"));
            userName.Click();
            userName.SendKeys("standard_user");
            IWebElement passWord = driver.FindElement(By.Id("password"));
            passWord.Click();
            passWord.SendKeys("secret_sauce");
            IWebElement loginButton = driver.FindElement(By.Id("login-button"));
            loginButton.Click();

            //Act
            //Check if credentials are valid, If not check for error message display and report failure
            if (driver.Url.Equals("https://www.saucedemo.com/")) { 
            IWebElement errorMsg = driver.FindElement(By.TagName("h3"));

            //Assert
            if (errorMsg.Displayed == true)
            Assert.Fail(errorMsg.Text);
        }
        }
    }
}
