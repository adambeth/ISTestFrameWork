using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace ISAutoFrameWork.Base
{
    public abstract class BasePage
    {
        public readonly IWebDriver _driver;
        public BasePage()
        {
            this._driver = DriverContext.Driver;
        }

    }
}
