using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWorkshop.PageObjects
{
    public class ContactUs
    {
        IWebDriver driver;
        public ContactUs(IWebDriver driver)
        {
            this.driver = driver;
        }
                
        public IWebElement SendButton()
        {
            return driver.FindElement(By.CssSelector("#submitMessage > span"));

        }

        public IWebElement EmailAddress()
        {
            return driver.FindElement(By.CssSelector("#email"));

        }

        public IWebElement OrderReferrence()
        {
            return driver.FindElement(By.CssSelector("#id_order"));

        }

        public IWebElement EmailMessageText()
        {
            return driver.FindElement(By.CssSelector("#message"));

        }

        public IWebElement ChooseSubjectHeading(int childNo)
        {

            return driver.FindElement(By.CssSelector($"#id_contact > :nth-child({childNo})"));

            // driver.FindElementByCssSelector("#id_contact > :nth-child(3)").Click();

        }
    }

}
