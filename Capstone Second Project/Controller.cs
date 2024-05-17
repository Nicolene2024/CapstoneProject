using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Capstone_Second_Project
{
    public class Controller
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenHomePage()
        {
            PageHome.OpenHomePage(driver);
        }

        [Test]

        public void Login() 
        {
            Assert.Pass();
        }

        [Test]

        public void SelectCategory() 
        {
            Assert.Pass();
        }

        [Test]

        public void ChangeDisplayView() 
        {
            Assert.Pass();
        }

        [Test]

        public void AddProduct() 
        {
            Assert.Pass();
        }

        //[Test]

        //public void() { }
    }
}