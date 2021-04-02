using ISAutoFrameWork.Base;
using OpenQA.Selenium;

namespace ISTest.Pages
{
    public class LoginPage : BasePage
    {

 

        private IWebElement txtUserName
        {
            get
            {
                return this.Driver.FindElement(By.Id("UserName"));
            }

        }


        private IWebElement txtPassword
        {
            get
            {
                return this.Driver.FindElement(By.Id("Password"));
            }
        }

        private IWebElement btnLogin
        {
            get

            {
                return this.Driver.FindElement(By.CssSelector("input[value='Log in']"));
            }
        }

        private IWebElement BtnEmployeeList
        {
            get
            {
                return this.Driver.FindElement(By.LinkText("Employee List"));
            }
        }
        public EmployeePage login(string username, string password)
        {

            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            btnLogin.Click();
            return new EmployeePage();

        }

        public EmployeePage ClickEmployeeList()
        {
            BtnEmployeeList.Click();
            return new EmployeePage();
        }
    }
}