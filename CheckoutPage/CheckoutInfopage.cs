using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SeleniumTest.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;



namespace SeleniumTest.CheckoutPage
{
    [TestFixture]
    public class CheckoutInfopage
    {
        [Test]
        public void Infopage(IWebDriver driver) 
        {
            //Arrange
            IWebElement firstName = driver.FindElement(By.Id("first-name"));
            firstName.SendKeys("Niv");
            IWebElement lastName = driver.FindElement(By.Id("last-name"));
            lastName.SendKeys("S");
            IWebElement postalcode = driver.FindElement(By.Id("postal-code"));
            postalcode.SendKeys("742792");
            IWebElement Btn_Continue = driver.FindElement(By.XPath("//*[@id=\"continue\"]"));
            Btn_Continue.Click();

            //Act
            // If input fields are empty in this page, check for error message displaye and report failure
            if (driver.Url.Equals("https://www.saucedemo.com/checkout-step-one.html"))
                    {
                 IWebElement errMessage = driver.FindElement(By.TagName("h3"));

                //Assert
                if (errMessage.Displayed == true)
                   Assert.Fail(errMessage.Text);
            }
                }
    }
}
