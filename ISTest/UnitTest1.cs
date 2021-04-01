using ISAutoFrameWork.Base;
using ISTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace ISTest
{
    [TestClass]
    public class UnitTest1
    {
        string url = "http://eaapp.somee.com/";

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);
            Login();
        }

        private  void Login()
        {

            HomePage homePage = new HomePage();
            homePage.clickLogin();
            LoginPage loginPage = new LoginPage();
            loginPage.login("admin","password");

            DriverContext.Driver.Quit();
        }
    }
}