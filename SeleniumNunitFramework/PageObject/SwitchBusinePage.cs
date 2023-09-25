using OpenQA.Selenium;
using SeleniumNunitFramework.TestSetup;
using SeleniumNunitFramework.TestUtilities;
using System;
using System.Threading;

public class SwitchBusinePage : BaseSetup
{
    By Email = By.XPath("//input[@placeholder='hello@gmail.com']");
    By Password = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]");
    By LoginButton = By.XPath("//button[normalize-space()='Login']");
    //By EyeIcon = By.XPath("//span[2]//*[name()='svg']");
    By DropDownBtn = By.XPath("/html/body/div[1]/div/div[1]/div[1]/div/div[2]/div/div[2]/div[2]/div");
    By BusinessSelectionBtn = By.XPath("/html/body/div[1]/div/div[1]/div[1]/div/div[2]/div/div[2]/div[3]/div[1]/div/div[2]/div");
    By BusinessDropDownInput = By.XPath("/html/body/div[1]/div/div[1]/div[1]/div/div[2]/div/div[2]/div[3]/div[1]/div/div[2]/div/div[1]/div[1]");
    public void SwitchBusin(string email, string pass, string businessname)
    {
        BrowserActions.Type(Email, email);
        BrowserActions.Type(Password, pass);
        BrowserActions.Click(LoginButton);
        Thread.Sleep(20000);
        BrowserActions.Click(DropDownBtn);
      //  BrowserActions.Click(BusinessSelectionBtn);
        BrowserActions.Click(BusinessSelectionBtn);
        BrowserActions.Type(BusinessSelectionBtn, businessname);
        BrowserActions.Clicks(BusinessSelectionBtn);
    }

}

