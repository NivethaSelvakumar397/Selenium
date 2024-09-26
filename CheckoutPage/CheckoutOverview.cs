using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.CheckoutPage
{
    public class CheckoutOverview
    {
        public void COOverview(IWebDriver driver) {
            IWebElement Btn_Finish = driver.FindElement(By.Id("finish"));
            Btn_Finish.Click();
        }

    }
}
