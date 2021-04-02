using OpenQA.Selenium;

namespace ISAutoFrameWork.Base
{
    public abstract class BasePage : Base
    {

        /*
         * Creates Driver and set the driver context for all children
         * This is the page constructor without using the PageFactory Method
         * ToDo remove once page factor deprecated in Selenium 4
         */
        public readonly IWebDriver Driver;
        public BasePage()
        {
            this.Driver = DriverContext.Driver;
        }

    }
}
