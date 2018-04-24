using System;
using Appium.Integration.Tests.Helpers;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;

namespace Appium.Integration.Tests.iOS
{
    [TestFixture]
    public class iOSMonoDebugTimeoutTest
    {
        private IOSDriver<AppiumWebElement> driver;

        [TestFixtureSetUp]
        public void beforeAll()
        {
            DesiredCapabilities capabilities = Caps.getIos113Caps(Apps.get("iosUICatalogApp"));

            Uri serverUri = AppiumServers.LocalServiceURIForIOS;
            driver = new IOSDriver<AppiumWebElement>(serverUri, capabilities, Env.INIT_TIMEOUT_SEC);
            driver.Manage().Timeouts().ImplicitWait = Env.IMPLICIT_TIMEOUT_SEC;
        }

        [TestFixtureTearDown]
        public void AfterEach()
        {
            if (driver != null)
            {
                driver.Quit();
            }

            AppiumServers.StopLocalService();
        }

        [Test()]
        public void ScrollToExactTestCase()
        {
            // Step over this line and add a watch for driver.PageSource - you'll see it times out
            System.Diagnostics.Debug.Write(driver.PageSource);
        }
    }
}
