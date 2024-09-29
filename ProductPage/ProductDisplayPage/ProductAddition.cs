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
    public class ProductAddition
    {
       public void ProductAdd(IWebDriver driver)
        { 

            String text = Resources.StringValue;
            //Product names are entered as comma separated values, hence spliting them
            //Make sure to enter a - inbetween each word in Product name in Resources file
            //To add a product, add the string "add-to-cart" before the product name
            //To remove a product, add the string "Remove-" before the product name
            string[] names= text.Split(',');
            int count= names.Length;
            for (int i = 0; i < count; i++)
            {
                IWebElement productAdd = driver.FindElement(By.Id(names[i]));
                productAdd.Click();
            }
          
        }
    }
}
