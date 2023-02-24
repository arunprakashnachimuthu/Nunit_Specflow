namespace SimpleTestProject.Hooks
{
    using BoDi;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System.IO;
    using System.Reflection;
    using TechTalk.SpecFlow;

    [Binding]
    public class DriverSetup
    {
        private IObjectContainer _objectContainer;
        public IWebDriver Driver;

        public DriverSetup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            
            string outputDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);                          
            Driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs(Driver);
        }

    }
}

