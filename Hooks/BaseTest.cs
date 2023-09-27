using BBCProjectDemo.Drivers;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;

namespace BBCProjectDemo.Hooks
{
    [Binding]

    public class BaseTest : DriverHelper
    {        
            IObjectContainer container;
            public BaseTest(IObjectContainer objectContainer)
            {
                container = objectContainer;
            }
             

            //private readonly DriverHelper driverHelper;
            //IWebDriver driver;
            //public BaseTest(DriverHelper driverHelper)
            //{
            //    this.driverHelper = driverHelper;
            //    driver = DriverHelper.driver;
            //}

            [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized", "--Incognito");
            options.AddArguments("--no-sandbox");
            options.AddArgument("--headless");
            options.AddArguments("disable-infobars");
            options.AddExcludedArgument("enable-automation");
            options.AddArguments("--disable-dev-shm-usage");
            driver = new ChromeDriver(options);
            container.RegisterInstanceAs(driver);
 
        }
              
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
