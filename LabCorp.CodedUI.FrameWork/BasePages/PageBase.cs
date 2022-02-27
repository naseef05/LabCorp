using LabCorp.CodedUI.FrameWork.LabCorp.CodedUI.FrameWork;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCorp.CodedUI.FrameWork.BasePages
{
    public abstract class PageBase
    {
        public int SleepTimeInMilliseconds = (int)ConfigurationData.SleepTime;

        public IWebDriver WebDriver { get; set; }

        protected PageBase() { }
        public PageBase(IWebDriver webDriver) { this.WebDriver = webDriver; }

        public string BaseAddress
        {
            get { return ConfigurationManager.AppSettings["BaseAddress"]; }
        }

        public abstract void GoTo();

        public abstract bool IsAt();

        public void GoToHomePage()
        {
            //Log4NetHelper.GetXmlLogger(typeof(TestLogger));
            string url = BaseAddress;
            // Log4NetHelper.GetXmlLogger(typeof(TestLogger));
            WebDriver.Navigate().GoToUrl(url);
            //Log4NetHelper.GetXmlLogger(typeof(TestLogger));
        }

        public bool IsAtHomePage()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[id$=btnLogin]")));

            return true;
        }

        public virtual void CloseBrowser()
        {
            if (WebDriver is InternetExplorerDriver || WebDriver is ChromeDriver)
            {
                WebDriver.Close();
                WebDriver.Quit();
            }

            if (WebDriver is FirefoxDriver)
            {
                try
                {
                    IJavaScriptExecutor js = WebDriver as IJavaScriptExecutor;
                    WebDriver.Close();
                    WebDriver.Quit();
                }
                catch
                { }
            }
        }
    }
}
