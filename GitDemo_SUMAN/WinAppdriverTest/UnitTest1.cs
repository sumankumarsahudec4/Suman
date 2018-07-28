using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System.Diagnostics;
namespace WinAppdriverTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string CalculatorAppId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
        //Microsoft.WindowsCalculator_8wekyb3d8bbwe
        protected static WindowsDriver<WindowsElement> session;
        [TestMethod]
        public void TestMethod1()
        {
            Process myProcess = new Process();

                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = @"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe"; ;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
            if (session == null)
            {
                DesiredCapabilities appCapabilities = new DesiredCapabilities();
                appCapabilities.SetCapability("app", CalculatorAppId);
                appCapabilities.SetCapability("deviceName", "WindowsPC");
                session = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appCapabilities);
                Assert.IsNotNull(session);
                //session.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1.5));
            }
        }

        public static void setup()
        {
            try
            {
                dynamic CalculatorSession;
                DesiredCapabilities capabilities = new DesiredCapabilities();
                capabilities.SetCapability("app", "C:\\Windows\\System32\\calc.exe");
                CalculatorSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), capabilities);
                //CalculatorSession.Manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
            }
            catch (Exception e)
            {
            }
            finally
            {
            }
        }
    }
}
