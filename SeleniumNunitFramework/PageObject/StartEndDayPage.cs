﻿using OpenQA.Selenium;
using SeleniumNunitFramework.TestSetup;
using SeleniumNunitFramework.TestUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SeleniumNunitFramework.PageObject
{
    public class StartEndDayPage : BaseSetup
    {
        By Email = By.XPath("//input[@placeholder='hello@gmail.com']");
        By Password = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]");
        By LoginButton = By.XPath("//button[normalize-space()='Login']");
        By StartDayBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[3]/div[1]/a[1]/div[1]");
        By StartBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[6]/div[1]/button[1]");
        By StopDayBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[3]/div[1]/a[1]/div[1]/img[1]");
        By StopBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[6]/div[1]/button[1]");
        By CloseBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[2]/div[1]/button[1]");

        public void StartDayPage(string email, string pass)
        {
            BrowserActions.Type(Email, email);
            BrowserActions.Type(Password, pass);
            Thread.Sleep(5000);
            BrowserActions.Click(LoginButton);
            Thread.Sleep(5000);
            BrowserActions.Click(StartDayBtn);
            Thread.Sleep(5000);
            BrowserActions.Click(StartBtn);
            Thread.Sleep(5000);
            BrowserActions.Click(CloseBtn);
            Thread.Sleep(10000);
            BrowserActions.Click(StopDayBtn);
            Thread.Sleep(5000);
            BrowserActions.Click(StopBtn);
            Thread.Sleep(5000);
            BrowserActions.Click(CloseBtn);


        }

       /* public void StopDayPage(string email, string pass)
        {
            BrowserActions.Type(Email, email);
            BrowserActions.Type(Password, pass);
            BrowserActions.Click(LoginButton);
            Thread.Sleep(15000);
            BrowserActions.Click(StopDayBtn);
            BrowserActions.Click(StopBtn);
            BrowserActions.Click(CloseBtn);

        }*/


    }
}
