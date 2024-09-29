using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.HeapProfiler;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumTest.Properties;

namespace SeleniumTest.ProductPage.ProductDisplayPage
{
     public class Driver
    
    {
        public static void Main(string[] args)
        {
            //Browser Navigation
             IWebDriver driver = new FirefoxDriver();  
            driver.Navigate().GoToUrl("https://saucedemo.com/");

            //Call necessary classes to access respective functionalities
            SignInPage.SignInfunctiona signin=new SignInPage.SignInfunctiona();
            signin.SignInPage(driver);
            ProductAddition prodAdd = new ProductAddition();
            prodAdd.ProductAdd(driver);
            AddtoCart cart = new AddtoCart();
            cart.addtocart(driver);
            CheckoutPage.CheckoutInfopage checkoutInfopage = new CheckoutPage.CheckoutInfopage();   
            checkoutInfopage.Infopage(driver);
            CheckoutPage.CheckoutOverview overviewpage = new CheckoutPage.CheckoutOverview();
            overviewpage.COOverview(driver);


        }
        
    }
}