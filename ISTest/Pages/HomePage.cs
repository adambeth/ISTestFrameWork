using ISAutoFrameWork.Base;
using OpenQA.Selenium;

namespace ISTest.Pages
{
    public class HomePage : BasePage
    {
        private IWebElement LnkLogin
        {
            get { return this.Driver.FindElement(By.LinkText("Login")); }
        }

    

        public LoginPage ClickLogin()
        {
            LnkLogin.Click();
            return new LoginPage();
        }
    }
}