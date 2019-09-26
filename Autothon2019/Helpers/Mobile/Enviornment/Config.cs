using System;
using System.Configuration;


namespace Autothon2019.Helpers.Mobile.Enviornment
{
    public class Config
    {
        
        public static string PlatformName
            => ConfigurationManager.AppSettings["platformName"];
        public static int TimeOut
            => Convert.ToInt32(ConfigurationManager.AppSettings["timeOut"]);
        public static string AppiumServerUrl
            => ConfigurationManager.AppSettings["appiumServerUrl"];
        public static string Name
           => ConfigurationManager.AppSettings["name"];
        public static string Username
           => ConfigurationManager.AppSettings["username"];
        public static string Password
           => ConfigurationManager.AppSettings["password"];
        public static string Browser
           => ConfigurationManager.AppSettings["browsername"];
    }
}

