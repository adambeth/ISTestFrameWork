using ISAutoFrameWork.Base;
using OpenQA.Selenium;

namespace ISTest.Pages
{
    public class EmployeePage : BasePage
    {
        private IWebElement BtnSearch
        {
            get { return this.Driver.FindElement(By.CssSelector("input[value='Search']")); }
        }

        private IWebElement SearchTetBox
        {
            get { return this.Driver.FindElement(By.Name("searchTerm")); }
        }


        public void ClickSearch()
        {
            BtnSearch.Click();
        }

        public EmployeePage SearchItem(string term)
        {
            SearchTetBox.SendKeys(term);
            ClickSearch();

            return new EmployeePage();
        }
    }
}