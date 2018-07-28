using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
namespace testingProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //!Make sure to add the path to where you extracting the chromedriver.exe:
            IWebDriver driver = new ChromeDriver(@"C:\Users\BGH49120\Desktop\Vinutha\testingProj\packages\Selenium.Chrome.WebDriver.2.35\driver"); //<-Add your path
            driver.Navigate().GoToUrl(@"https://www.facebook.com/");
            Thread.Sleep(30000);
            string profileViewr = @"100008128007122,100011009291654,100024225983615,100022767035803,100023355675948,100013836965841,100023982074543,100001974926214,100023658485630,100002815647459,100002509990208,100000189462928,100001481421848,100008229677138,100025189875033,100007124411345,100020404332194,100001709588683,100013622465518,100002403179165,100003732735766,100004411333820,100003656244571,100001575064565,100025096623965,100003164321744,100024951074625,100024393152620,100003915902010,100024056530674,100011989333979,100001477102185,100001524009302,100025126862308,100025024025036,100008175875016,100024480379186,100010012158954,100003937291090,100024799320180";
            var ShowProfileinLoop = profileViewr.Split(',');
            foreach(var s in ShowProfileinLoop)
            {
                Thread.Sleep(10000);
                driver.Navigate().Back();
                driver.Navigate().GoToUrl(@"https://www.facebook.com/" + s);
            }
        }
    }
}
