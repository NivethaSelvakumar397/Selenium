using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTest.ProductPage.ProductDisplayPage;
using System.Diagnostics.Contracts;
using OpenQA.Selenium.Firefox;
using SeleniumTest.Properties;
using static System.Net.Mime.MediaTypeNames;

namespace SeleniumTest.ProductPage.ProductDisplayPage
{
    public class AddtoCart
    {
        public void addtocart(IWebDriver driver)
        {
            IWebElement cart = driver.FindElement(By.Id("shopping_cart_container"));
            cart.Click();

            IWebElement Btn_checkout = driver.FindElement(By.Id("checkout"));
            Btn_checkout.Click();
        }
    }
}
