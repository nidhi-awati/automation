﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumNunitFramework.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.TestUtilities
{
    public class BrowserActions :BaseSetup
    {
        public static void Type(By field, string value) 
        { 
            driver.FindElement(field).SendKeys(value);
        }

        public static void Click(By field) 
        { 
            driver.FindElement(field).Click();
            
        }

        public static void Clicks(By enter)
        {
            driver.FindElement(enter).SendKeys(Keys.Enter);
        }


        public static void MouseEvent(By field)
        {
            driver.FindElement(field).Click();
        }

        public static void ScrollUpDown(By field)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }


    }
}
