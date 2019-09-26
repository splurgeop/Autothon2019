using System;
using Autothon2019.Helpers.Mobile.Enviornment;
using Autothon2019.Helpers.Mobile.Appium.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Autothon2019.Helpers.Mobile.Appium
{
    /// <summary>
    /// A driver wrapper class.
    /// </summary>
    public class MobileApplication
    {
        public IWebDriver Driver { get; private set; }

        public void StartSession()
        {
            Driver = DriverProvider.GetAndroidDriver(); ;
        }

        public void EndSession()
        {
            Driver.Quit();
        }

        public bool IsShownWithinTimeout(By locator)
        {
            try
            {
                WaitUntil(ExpectedConditions.ElementIsVisible(locator));
                return true;
            }
            catch (ElementNotVisibleException)
            {
                return false;
            }
        }

        public void Click(By locator)
        {
            WaitUntil(ExpectedConditions.ElementToBeClickable(locator));
            FindElement(locator).Click();
        }

        public void SendEnterKey(By locator)
        {
            TypeText(locator, Keys.Enter);
        }

        public void TypeText(By locator, string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return;
            }
            
            WaitUntil(ExpectedConditions.ElementIsVisible(locator));
            FindElement(locator).SendKeys(text);
        }

        public IWebElement FindElement(By locator)
        {
            WaitUntil(ExpectedConditions.ElementExists(locator));
            return Driver.FindElement(locator);
        }

        public void WaitUntil(Func<IWebDriver, object> until)
        {
            WaitUntil(until, Config.TimeOut);
        }

        public void WaitUntil(Func<IWebDriver, object> until, int seconds)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(until);
        }
    }
}
   
