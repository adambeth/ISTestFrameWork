using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;


namespace ISAutoFrameWork.Base
{
    public class DriverFactory
    {
        public static void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {

                case BrowserType.FireFox:


                    var capabilities = new FirefoxOptions();
                    capabilities.AddAdditionalCapability(capabilities.BrowserName,"firefox");
                    capabilities.BrowserVersion = "86.0";

                    DriverContext.Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);

                    break;
                case BrowserType.Chrome:
                    //var caps = new ChromeOptions();
                    //caps.BrowserVersion = "89";
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }

        }
    }
}