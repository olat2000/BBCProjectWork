using BBCProjectDemo.Drivers;
using BBCProjectDemo.PageObjects;
using BBCProjectWork;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BBCProjectDemo.StepDefinitions
{
    [Binding]
    public class BBCRegSteps : DriverHelper
    {
        BBCRegPage bBBCRegPage;
        public BBCRegSteps(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            bBBCRegPage = container.Resolve<BBCRegPage>();
        }
        //BBCRegPage bBBCRegPage = new BBCRegPage(); //if using static driver
        ////BBCRegPage bBBCRegPage; // without static driver
        ////private readonly DriverHelper driverHelper;
        //IWebDriver driver;
        //public BBCRegSteps(DriverHelper driverHelper)  // without the static all these will be needed
        //{
        //    //this.driverHelper = driverHelper;
        //    //bBBCRegPage = new BBCRegPage(driverHelper);
        //    driver = DriverHelper.driver;
        //}

        [Given(@"a user navigate to BBC website")]
        public void GivenAUserNavigateToBBCWebsite()
        {
            driver.Navigate().GoToUrl(Credentials.BBCurl);
        }

        [When(@"user click on sign in")]
        public void WhenUserClickOnSignIn()
        {
             bBBCRegPage.ClickSignin();
        }

        [When(@"user click on register now")]
        public void WhenUserClickOnRegisterNow()
        {
             bBBCRegPage.ClickOnRegisterNow();
        }

        [When(@"user click on thirteen or over")]
        public void WhenUserClickOnThirteenOrOver()
        {
            bBBCRegPage.ClickOnThirteenOrOver();
        }

        [When(@"user enter their Day of Birth")]
        public void WhenUserEnterTheirDayOfBirth()
        {
            bBBCRegPage.EnterDayofBirth(Credentials.DOB);
        }

        [When(@"user enter their Month of Birth")]
        public void WhenUserEnterTheirMonthOfBirth()
        {
            //string month = new DateTime().Date.Month.ToString("MM");
            bBBCRegPage.EnteMonthofBirth(Credentials.MonthOfBirth);
        }

        [When(@"user enter their Year of Birth")]
        public void WhenUserEnterTheirYearOfBirth()
        {
            //string month = new DateTime().Date.Year.ToString("YY");
            bBBCRegPage.EnterYearofBirth(Credentials.YearOfBirth);
        }

        [When(@"user click on continue button")]
        public void WhenUserClickOnContinueButton()
        {
            bBBCRegPage.ClickSubmit();
        }

        [When(@"user enter their Email")]
        public void WhenUserEnterTheirEmail()
        {
            bBBCRegPage.EnterEmail(string.Format(Credentials.Email, new Random().Next(1, 999)));
        }

        [When(@"user their Pword")]
        public void WhenUserTheirPword()
        {
            bBBCRegPage.EnterPassword(Credentials.Password);
        }

        [When(@"user enter their Postcode")]
        public void WhenUserEnterTheirPostcode()
        {
            bBBCRegPage.EnterPostCode(Credentials.Postcode);
        }

        [When(@"user select their gender")]
        public void WhenUserSelectTheirGender()
        {
            bBBCRegPage.SelectGender(Credentials.Gender);
        }

        [When(@"user click on Register button")]
        public void WhenUserClickOnRegisterButton()
        {
            bBBCRegPage.ClickRegisterBtn();
        }

        [Then(@"BBC Homepage is displayed")]
        public void ThenBBCHomepageIsDisplayed()
        {
            Assert.IsTrue(bBBCRegPage.BBCHomepageIsDisplayed());
        }
    }
}
