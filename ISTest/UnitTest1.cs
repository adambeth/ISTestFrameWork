using ISAutoFrameWork.Base;
using ISTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace ISTest
{
    [TestClass]
    public class UnitTest1 : Base
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
            CurentPage = homePage.ClickLogin();
            ((LoginPage) CurentPage).login("admin","password");
            //((LoginPage) CurentPage).ClickEmployeeList();
            CurentPage = ((LoginPage)CurentPage).ClickEmployeeList();
            ((EmployeePage)CurentPage).SearchItem("Hello");

            //((EmployeePage)CurentPage).SearchItem("Test");


            //DriverContext.Driver.Quit();
        }
    }
}