using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace BBCProjectDemo.Support
{
    public static class Extensions
    {
        public static IWebElement FindElementWithWait(this IWebDriver driver, By by)
        {
            Thread.Sleep(1000);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            return wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public static List<IWebElement> FindMultipleElementWithWait(this IWebDriver driver, By by)
        {
            Thread.Sleep(1000);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            return wait.Until(x => x.FindElements(by)).ToList();
        }

        public static bool WaitForDisplay(this IWebDriver driver, By by)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            return wait.Until(ExpectedConditions.ElementIsVisible(by)).Displayed;
        }

        public static bool WaitForMultipleDisplay(this IWebDriver driver, By by)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            return wait.Until(x => x.FindElements(by)).FirstOrDefault()!.Displayed;
        }

        public static void ClickViaJs(this IWebDriver driver, By element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();",
                driver.FindElement(element));
        }

        public static string AddRelativepath(this string text)
        {
            return text + new Random().Next(1, 9999) + "@yahoo.com";
        }
    }
}
