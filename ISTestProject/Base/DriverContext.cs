using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using OpenQA.Selenium;

namespace ISAutoFrameWork.Base
{
    public static class DriverContext
    {
        private static IWebDriver _driver;

          public static IWebDriver Driver
        {
            get { return _driver; }

            set { _driver = value; }
        }
    }
}