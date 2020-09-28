using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumMobileTestingLearning
{
    public class OpenApp
    {
       public AndroidDriver<AndroidElement> driver;
       public AppiumOptions options = new AppiumOptions();

        public OpenApp()
        {

        }

        [SetUp]
        public void InitDevice()
        {
            //DesiredCapabilities cap;
            //AppiumDriver<AndroidElement> driver;
            //cap = new DesiredCapabilities();
            //cap.SetCapability("plateformName", "Android");
            //cap.SetCapability("devicename", "Pixel 2 API 30");
            //cap.SetCapability("apppackage", "com.oneclickhse.oneclickhseapp99");
            //driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

          
            options.PlatformName = "Android";
            options.AddAdditionalCapability("plateformName", "Android");
            options.AddAdditionalCapability("deviceName", "emulator-5554");
            options.AddAdditionalCapability("appPackage", "com.oneclickhse.oneclickhseapp99");
            //options.AddAdditionalCapability("platformVersion", "PlatformV");
            //options.AddAdditionalCapability("automationName", "UiAutomator2");
            //options.AddAdditionalCapability("appActivity", "host.exp.exponent.LauncherActivity");

            Uri url = new Uri("http://localhost:4723/wd/hub");

            driver = new AndroidDriver<AndroidElement>(url, options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);

            // Some example selectors
            //driver.FindElementByClassName("android.widget.EditText").SendKeys("test");
            //driver.FindElement(MobileBy.AndroidUIAutomator("new UiSelector().className(\"android.widget.EditText\").instance(1)")).SendKeys(Username);
        }

        [Test]
        public void FirstTextCase()
        {

        }

        public void CloseDriver()
        {
            driver.Quit();
        }
    }
}
