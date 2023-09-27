using BBCProjectDemo.Drivers;
using BBCProjectDemo.Support;
using BoDi;
using OpenQA.Selenium;


namespace BBCProjectDemo.PageObjects
{
    class BBCRegPage : DriverHelper
    {
        public BBCRegPage(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
             
        }
        //IWebDriver driver;
        //public BBCRegPage(DriverHelper driverHelper)
        //{
        //    this.driverHelper = driverHelper;
        //    driver = DriverHelper.driver;
        //}

        private By signIn = By.CssSelector(".ssrcss-qgttmg-AccountText.e1gviwgp4");
        private By registerNow = By.XPath("//span[normalize-space()='Register now']");
        private By thirteenOrOver = By.XPath("//*[@class='sb-flex-container']/a");
        private IWebElement dayofBirth => driver.FindElement(By.CssSelector("#day-input"));

        private By monthofBirth = By.XPath("//input[@id='month-input']");
        private By yearofBirth = By.XPath("//input[@id='year-input']");
        private By continueButton = By.CssSelector("#submit-button");
        private By email = By.CssSelector("#user-identifier-input");
        private By password = By.CssSelector("#password-input");
        private By postCode = By.CssSelector("#postcode-input");
        private By gender = By.CssSelector("#gender-input");
        private By registerbuttn = By.CssSelector("#submit-button");
        private readonly DriverHelper driverHelper;

        public void ClickSignin()
        {
            driver.WaitForDisplay(signIn);
            driver.FindElementWithWait(signIn).Click();
        }

        public void ClickOnRegisterNow()
        {
            driver.WaitForDisplay(registerNow);
            driver.FindElementWithWait(registerNow).Click();
        }

        public void ClickOnThirteenOrOver()
        {
            var ele = driver.FindMultipleElementWithWait(thirteenOrOver);
            foreach (var item in ele)
            {
                if (item.Text == "13 or over")
                {
                    item.Click();
                }
                else if(item.Text == "13 - 17")
                { 
                    item.Click();
                }

            }
        }

        public void EnterDayofBirth(string dayofBirthValue)
        {
            driver.FindElementWithWait(By.CssSelector("#day-input")).SendKeys(dayofBirthValue);
            
        }
    
        public void EnteMonthofBirth(string monthValue)
        {
           driver.FindElementWithWait(monthofBirth).SendKeys(monthValue);
        }

        public void EnterYearofBirth(string yearofBirthValue) => driver.FindElement(yearofBirth).SendKeys(yearofBirthValue);

        public void ClickSubmit() => driver.FindElement(continueButton).Click();

        public void EnterEmail(string emailValue) => driver.FindElementWithWait(email).SendKeys(emailValue);

        public void EnterPassword(string passWord) => driver.FindElementWithWait(password).SendKeys(passWord);

        public void EnterPostCode(string postCodeValue) => driver.FindElementWithWait(postCode).SendKeys(postCodeValue);

        public void SelectGender(string genderValue) => driver.FindElementWithWait(gender).SendKeys(genderValue);

        public void ClickRegisterBtn() => driver.ClickViaJs(registerbuttn); //driver.FindElementWithWait(registerbuttn).Click();

        public bool BBCHomepageIsDisplayed() => driver.FindElementWithWait(By.CssSelector("h1[class='sb-heading--headlineSmall sb-heading--bold'] span")).Displayed;
    }   
}

