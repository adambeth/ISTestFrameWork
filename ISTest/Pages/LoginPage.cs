using System.Threading;
using ISAutoFrameWork.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ISTest.Pages
{
    public class LoginPage : BasePage
    {

 

        private IWebElement txtUserName
        {
            get
            {
                return this._driver.FindElement(By.Id("UserName"));
            }

        }


        private IWebElement txtPassword
        {
            get
            {
                return this._driver.FindElement(By.Id("Password"));
            }
        }

        private IWebElement btnLogin
        {
            get

            {
                return this._driver.FindElement(By.CssSelector("input[value='Log in']"));
            }
        }


        public void login(string username, string password)
        {

            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            btnLogin.Click();

        }
    }
}