
using Autothon2019.Helpers.Mobile.Appium;

namespace Autothon2019.Helpers.Mobile.Screens
{
    public class BaseScreen
    {
        public static MobileApplication App;

        /// <summary>
        /// Creates an instance of AndroidDriver.
        /// </summary>
        public static void InitializeSession()
        {
            App = new MobileApplication();
            App.StartSession();
        }

        /// <summary>
        /// closes the Appium session.
        /// </summary>
        public static void DeleteSession()
        {
            App.EndSession();
        }
    }
}
