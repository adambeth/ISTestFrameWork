using OpenQA.Selenium;

namespace ISAutoFrameWork.Base
{
    public abstract class BasePage : Base
    {
        public readonly IWebDriver Driver;
        public BasePage()
        {
            this.Driver = DriverContext.Driver;
        }

    }
}
