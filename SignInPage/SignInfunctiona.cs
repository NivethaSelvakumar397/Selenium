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
    public class SignInfunctiona 
    {
        public void SignInPage(IWebDriver driver)
        {
            IWebElement userName = driver.FindElement(By.Id("user-name"));
            userName.Click();
            userName.SendKeys("standard_user");
            IWebElement passWord = driver.FindElement(By.Id("password"));
            passWord.Click();
            passWord.SendKeys("secret_sauce");
            IWebElement loginButton = driver.FindElement(By.Id("login-button"));
            loginButton.Click();
            if (driver.Url.Equals("https://www.saucedemo.com/")) { 
            IWebElement errorMsg = driver.FindElement(By.TagName("h3"));
            if (errorMsg.Displayed == true)
            Assert.Fail(errorMsg.Text);
        }
        }
    }
}
