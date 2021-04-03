using NUnit.Framework;

namespace ISAutoFrameWork.Base
{
    /*
     * This is the Base class for all the other Base Classes
     */
    public class Base : DriverFactory
    {
        //private readonly DriverFactory _driverFactory = new DriverFactory();

        //Hold context of the current page
        public BasePage CurrentPage { get; set; }
        [SetUp]
        public void Initialize()
        {
            DriverFactory.OpenBrowser(BrowserType.Chrome);
            string url = "http://eaapp.somee.com/";
            DriverContext.Driver.Navigate().GoToUrl(url);
        }
    }
}