
using System;
using Autothon2019.Helpers.Mobile.Enviornment;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace Autothon2019.Helpers.Mobile.Appium.Drivers
{

    /// <summary>
    /// In this class, we are creating an instance of an Android/ios driver with the settings mentioned in App.config.
    /// </summary>
    public class DriverProvider

    {
        public static AndroidDriver driver;
        public static IWebDriver GetAndroidDriver()
        {

            var caps = new RemoteSessionSettings();
            
            caps.AddMetadataSetting("name",Config.Name);
            caps.AddMetadataSetting("username",Config.Username);
            caps.AddMetadataSetting("password", Config.Password);
            caps.AddMetadataSetting("browserName",Config.Browser);
            caps.AddMetadataSetting("platform", Config.PlatformName);

            driver = (AndroidDriver)new RemoteWebDriver(new Uri(Config.AppiumServerUrl), caps);

            Assert.IsNull(driver.Context);
            return driver;
        }

         }
}


