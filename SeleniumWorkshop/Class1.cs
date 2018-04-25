using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumWorkshop
{
    [TestFixture]
    public class Class1
    {

        private ChromeDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [Test]
        public void My_First_Webdiver()
        {

            Assert.AreEqual(4, 5);
            driver.Quit();              // zamyka wszystkie okna, by zamknąć tylko ostanite aktywne okno pisz driver.Close();
        }

        [Test]
        public void My_Second_Webdiver_2()
        {
            Assert.AreEqual(4, 5);
            driver.Quit();
        }

        [Test]
        public void CheckURLwithExpected()
        {
            string expectedURL = "http://automationpractice.com/index.php";

            Assert.AreEqual(expectedURL, driver.Url, "not the same URL");
        }

        [Test]
        public void CheckTitleWithExpected()
        {
            string expectedTitle = "My Store";

            Assert.AreEqual(expectedTitle, driver.Title, "Title is not the same");
        }

        [Test]
        public void CheckID()
        {
            var search_box = driver.FindElementById("search_query_top");
            var expectedSearchText = "Search";
            Assert.AreEqual(expectedSearchText, search_box.Text, "Error");
        }

        [Test]
        public void ObjectText()
        {
            var search_box = driver.FindElementById("search_query_top");
            var expectedSearchText = "Search";
            Assert.AreEqual(expectedSearchText, search_box.Text, "Error");

        }

        [Test]
        public void ObjectTextDivID()
        {
            var search_box = driver.FindElementById("contact-link");
            var expectedSearchText = "Contact us";
            Assert.AreEqual(expectedSearchText, search_box.Text, "Text diff");
        }

        [Test]
        public void ClikIfURLcorrect()
        {
            var search_box = driver.FindElementById("contact-link");
            search_box.Click();
            
            string currentURL = driver.Url;
           
            string expectedURL = "http://automationpractice.com/index.php?controller=contact";

            Assert.AreEqual(expectedURL, currentURL, "Click leads to diff URL");
        }

        [Test]
        public void CheckTextbySelectro()
        {
            var receivedtext = driver.FindElementByCssSelector("#homefeatured > li:nth-child(2) > div > div.right-block > h5 > a").Text;
            
            string expectedTest1 = "Blouse";

            Assert.AreEqual(expectedTest1, receivedtext, "Diff test description");
        }

        [Test]
        public void CheckTextbySelectroNext()
        {
            var receivedtext = driver.FindElementByCssSelector("#homefeatured > li:nth-child(2) > div > div.right-block > h5 > a").Text;

            string expectedTest1 = "Blouse";

            Assert.AreEqual(expectedTest1, receivedtext, "Diff test description");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();         // to żeby zadziałało poza tym testem to musimy stworzyć webdriver dla wszystkich testów "private ChromeDriver driver" za klasa, oraz w setupie "driver = new ChromeDriver();"
        }
    }
}
