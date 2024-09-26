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
