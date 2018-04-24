﻿using System;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;

namespace Appium.Integration.Tests.Helpers
{
    public class Caps
    {
        public static DesiredCapabilities getIos102Caps(string app)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "10.2");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "iPhone Simulator");
            capabilities.SetCapability(MobileCapabilityType.AppiumVersion, "1.7.1");
            capabilities.SetCapability(MobileCapabilityType.App, app);
            return capabilities;
        }

        public static DesiredCapabilities getIos112Caps(string app)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "11.2");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "iPad Air 2");
            capabilities.SetCapability(MobileCapabilityType.App, app);
            return capabilities;
        }

        public static DesiredCapabilities getIos92Caps(string app)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "9.2");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "iPhone Simulator");
            capabilities.SetCapability(MobileCapabilityType.App, app);
            return capabilities;
        }

        public static DesiredCapabilities getIos113Caps(string app)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "11.3");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "iPhone Simulator");
            capabilities.SetCapability(MobileCapabilityType.App, app);
            return capabilities;
        }

        public static DesiredCapabilities getAndroid501Caps(string app)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "5.0.1");
            capabilities.SetCapability(AndroidMobileCapabilityType.AppPackage, "io.appium.android.apis");
            capabilities.SetCapability(AndroidMobileCapabilityType.AppActivity, ".Apidemos");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "Android Emulator");
            capabilities.SetCapability(MobileCapabilityType.App, app);
            return capabilities;
        }

        public static DesiredCapabilities getAndroid19Caps(string app)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "4.4.2");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "Android Emulator");
            capabilities.SetCapability(MobileCapabilityType.App, app);
            return capabilities;
        }

        public static DesiredCapabilities getSelendroid19Caps(string app)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "4.4.2");
            capabilities.SetCapability(MobileCapabilityType.AutomationName, "selendroid");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "Android Emulator");
            capabilities.SetCapability(MobileCapabilityType.App, app);
            return capabilities;
        }
    }
}