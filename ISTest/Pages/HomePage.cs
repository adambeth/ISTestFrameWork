using ISAutoFrameWork.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ISTest.Pages
{
    public class HomePage : BasePage
    {
        


        private IWebElement lnkLogin
        {
            get { return this._driver.FindElement(By.LinkText("Login")); }
        }


        public void clickLogin()
        {

            lnkLogin.Click();
        }


    }
}