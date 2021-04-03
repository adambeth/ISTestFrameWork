using System;
using ISAutoFrameWork.Base;
using ISTest.Pages;
using NUnit.Framework;

namespace ISTest
{
    [TestFixture]
    public class UnitTest1 : Base
    {
        string url = "http://eaapp.somee.com/";



        [Test]
        public void TestMethod1()
        {
            Login();
        }

        private void Login()
        {
            HomePage homePage = new HomePage();
            CurrentPage = homePage.ClickLogin();
            ((LoginPage) CurrentPage).login("admin", "password");
            //((LoginPage) CurrentPage).ClickEmployeeList();
            CurrentPage = ((LoginPage) CurrentPage).ClickEmployeeList();
            ((EmployeePage) CurrentPage).SearchItem("Hello");
            CurrentPage = ((EmployeePage) CurrentPage).ClickCreateNewEmployee();
            DriverContext.Driver.Quit();
        }
    }
}