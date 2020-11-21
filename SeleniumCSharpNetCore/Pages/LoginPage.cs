using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    public class LoginPage : DriverHelper
    { 
        IWebElement txtUserName => Driver.FindElement(By.Id("UserName"));
        IWebElement txtPassWord => Driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@type='submit']"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassWord.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
