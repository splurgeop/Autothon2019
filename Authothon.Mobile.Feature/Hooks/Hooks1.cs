using System;

using TechTalk.SpecFlow;
using Autothon2019.Helpers.Mobile.Screens;

namespace Authothon.Mobile.Feature.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //implement logic that has to run before executing each scenario
            BaseScreen.InitializeSession();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            // implement logic that has to run after executing each scenario
            BaseScreen.DeleteSession();
        }
    }
}
