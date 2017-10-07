﻿using System;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using CrossLayer.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace Factory.SetUp
{
    /// <summary>
    /// Initialize the Appium Driver.
    /// </summary>
    /// <seealso cref="Factory.SetUp.ISetUpWebDriver" />
    public class SetUpWebDriver : ISetUpWebDriver
    {
        private const string AndroidApplicationPath = @"\Factory.SetUp\binaries\mylist.apk";

        private static AppiumDriver<AndroidElement> _appiumDriver;
        private static IWebDriver _webDriver;

        /// <summary>
        /// See Wiki to set up the desired capabilities.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Desired+Capabilities+Required+for+Selenium+and+Appium+Tests"/>
        /// See Wiki to use the Platform Configuration tool.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Platform+Configurator#/"/>
        /// See Wiki to see the supported android emulator devices.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Supported+Android+Emulators"/>
        /// </summary>
        public AppiumDriver<AndroidElement> SetUpAndroidWebDriver()
        {
            if (_appiumDriver != null)
            {
                return _appiumDriver;
            }

            // Parameter to set saucelabs dashboard configuration in order to add the current scenario and if fails or not the test
            Configuration.IsSaucelabsConfiguration = false;

            var appFullPath = Directory.GetParent(Directory.GetCurrentDirectory()) + AndroidApplicationPath;

            // Set up capabilities.
            // See Appium Capabilities wiki.
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "6");
            capabilities.SetCapability("fastReset", true);
            capabilities.SetCapability("app", appFullPath);

            // To see the device name with the cmd console check adb devices -l
            capabilities.SetCapability("deviceName", "generic_x86");

            _appiumDriver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(60));

            return _appiumDriver;
        }

        /// <summary>
        /// See Wiki to set up the desired capabilities.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Desired+Capabilities+Required+for+Selenium+and+Appium+Tests"/>
        /// </summary>
        public AppiumDriver<AndroidElement> SetUpAndroidDeviceDriver()
        {
            if (_appiumDriver != null)
            {
                return _appiumDriver;
            }

            // Parameter to set saucelabs dashboard configuration in order to add the current scenario and if fails or not the test
            Configuration.IsSaucelabsConfiguration = false;

            var appFullPath = Directory.GetParent(Directory.GetCurrentDirectory()) + AndroidApplicationPath;

            // Set up capabilities.
            // See Appium Capabilities wiki.
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "6.0.1");
            capabilities.SetCapability("fastReset", "True");
            capabilities.SetCapability("app", appFullPath);

            // To see the device name with the cmd console check adb devices -l
            capabilities.SetCapability("deviceName", "trlte");

            _appiumDriver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(600));

            return _appiumDriver;
        }

        /// <summary>
        /// See Wiki to set up the desired capabilities.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Desired+Capabilities+Required+for+Selenium+and+Appium+Tests"/>
        /// Upload app: curl -u erniqa:4e3d7e6a-0694-4794-8722-e4fcc6aef6e7 -X POST -H "Content-Type: application/octet-stream" https://saucelabs.com/rest/v1/storage/erniqa/mylist.apk?overwrite=true --data-binary @/mylist.apk
        /// See Wiki to use the Platform Configuration tool.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Platform+Configurator#/"/>
        /// See Wiki to see the supported android emulator devices.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Supported+Android+Emulators"/>
        /// </summary>
        public AppiumDriver<AndroidElement> SetUpAndroidSauceLabsDriver()
        {
            if (_appiumDriver != null)
            {
                return _appiumDriver;
            }

            // Parameter to set saucelabs dashboard configuration in order to add the current scenario and if fails or not the test
            Configuration.IsSaucelabsConfiguration = true;

            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "7.0");
            capabilities.SetCapability("deviceName", "Android GoogleAPI Emulator");
            capabilities.SetCapability("app", "sauce-storage:mylist.apk");
            capabilities.SetCapability("username", "Outsource");
            capabilities.SetCapability("accessKey", "e2cb260f-7805-4685-828e-af1065b61447");
            capabilities.SetCapability("name", Configuration.CurrentScenario);

            _appiumDriver = new AndroidDriver<AndroidElement>(new Uri("http://ondemand.saucelabs.com:80/wd/hub"), capabilities, TimeSpan.FromSeconds(600));

            return _appiumDriver;
        }

        /// <summary>
        /// Closes the android driver.
        /// </summary>
        public void CloseAndroidDriver()
        {
            if (Configuration.IsSaucelabsConfiguration)
            {
                ((IJavaScriptExecutor)_appiumDriver).ExecuteScript("sauce:job-result=" + (Configuration.IsPass ? "passed" : "failed"));
            }

            _appiumDriver?.Dispose();
            _appiumDriver = null;
        }

        /// <summary>
        /// Makes the screenshot.
        /// </summary>
        /// <param name="scenario">The scenario.</param>
        public void MakeScreenshot(string scenario)
        {
            var screenshot = ((ITakesScreenshot) _appiumDriver).GetScreenshot();
            var dateTime = $"{DateTime.Now.ToString("d-M-yyyy HH-mm-ss", CultureInfo.InvariantCulture)}_{scenario}.jpeg";
            screenshot.SaveAsFile(dateTime, ImageFormat.Jpeg);
        }
    }
}
