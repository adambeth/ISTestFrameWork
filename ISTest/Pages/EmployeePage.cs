using ISAutoFrameWork.Base;
using OpenQA.Selenium;

namespace ISTest.Pages
{
    public class EmployeePage : BasePage
    {

        public class GenericList<T>
        {
            public void Add(T input) { }
        }
        private IWebElement BtnSearch
        {
            get { return this.Driver.FindElement(By.CssSelector("input[value='Search']")); }
            
        }
        private IWebElement SearchTetBox
        {
            get { return this.Driver.FindElement(By.Name("searchTerm")); }
        }

        private IWebElement BtnCreateNewEmployee
        {
            get
            {
                return this.Driver.FindElement(By.LinkText("Create New"));
            }
        }


        public void ClickSearch()
        {
            BtnSearch.Click();
        }

        public EmployeePage ClickCreateNewEmployee()
        {

            BtnCreateNewEmployee.Click();
            return new EmployeePage();
        }

        public EmployeePage SearchItem(string term)
        {
            SearchTetBox.SendKeys(term);
            ClickSearch();

            return new EmployeePage();
        }
    }
}