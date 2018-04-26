using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumWorkshop.PageObjects
{
    class MainPage
    {
        IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SearchMenu()
        {
            return driver.FindElement(By.CssSelector("#search_query_top"));

        }
    }
}
