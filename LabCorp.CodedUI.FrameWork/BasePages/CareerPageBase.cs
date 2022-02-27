using LabCorp.CodedUI.FrameWork.LabCorp.CodedUI.FrameWork;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LabCorp.CodedUI.FrameWork.BasePages
{
    public class CareerPageBase : PageBase
    {
        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Careers') and @class='no-ext ext']")]
        public IWebElement CareerLinkText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Search job title or location') and @class='sr-only']")]
        public IWebElement JobSearchText{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder ='Search job title or location']")]
        public IWebElement JobSearchBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder ='Search for job']")]
        public IWebElement SearchForJobTitleBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//i [@class='icon icon-search-icon']")]
        public IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ppc-content[key ='gdpr-allowCookiesText']")]
        public IWebElement AllowCookie { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id$=ph-ph-search-backdrop]")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Refine your search')]")]
        public IWebElement RefineYourSearchText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Apply Now')]")]
        public IWebElement ApplyButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[contains(@data-ph-at-id, 'jobdescription-text')]/div/p[2]")]
        public IWebElement SecondParagraphText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id$=txtUserName]")]
        public IWebElement UserId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id$=txtPassword]")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id$=chkRemeberUserName]")]
        public IWebElement RememberMe { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id$=btnLogin]")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id$=hlnkForgotPassword]")]
        public IWebElement ForgotPasswordHyperLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id$=linkContactUs]")]
        public IWebElement ContactUsHyperLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[href*='http://www.gainsco.com']")]

        public IWebElement CorporateSiteHyperLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[href*='http://www.verisign.com/ssl/ssl-information-center/']")]
        public IWebElement AboutSslCertificatesHyperLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[href*='http://www.gainsco.com/agentapp']")]

        public IWebElement AgentAppointmentFormHyperLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id$=rfvAgency]")]
        public IWebElement CodeRequiredFieldValidator { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id$=rfvUserName]")]
        public IWebElement UserIdRequiredFieldValidator { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id$=rfvPassword]")]
        public IWebElement PasswordRequiredFieldValidator { get; set; }

        public CareerPageBase(IWebDriver webDriver) : base(webDriver) { }

        public override void GoTo()
        {
            string url = BaseAddress;
            WebDriver.Navigate().GoToUrl(url);
        }

        public void ClickOnCareerLink()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[contains(text(),'Careers') and @class='no-ext ext']")));
            CareerLinkText.Click();
        }

        public void SwitchCareerPage()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            //IWebElement element = wait.Until(ExpectedConditions.(By.CssSelector("[href*='/Secured/MyAccount.aspx']")));

            //<a title="Update my name, address, and password." href="/Secured/MyAccount.aspx">Naseef</a>


            var careerPageWindow = WebDriver.WindowHandles[1];
            WebDriver.SwitchTo().Window(careerPageWindow);
            
        }

        public override bool IsAt()
        {
            if (
               UserId.Text == string.Empty
               && Password.Text == string.Empty
               && LoginButton.GetAttribute("value") == "Log-In"
               && ForgotPasswordHyperLink.Text == "Forgot your password?"
               && ContactUsHyperLink.Text == "Contact Us"
               && CorporateSiteHyperLink.Text == "corporate site"
               && AboutSslCertificatesHyperLink.Text == "ABOUT SSL CERTIFICATES"
               && AgentAppointmentFormHyperLink.Text == "this form")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAtWelcomePage()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[href*='/Secured/MyAccount.aspx']")));

            //<a title="Update my name, address, and password." href="/Secured/MyAccount.aspx">Naseef</a>


            var welcomePageWindow = WebDriver.WindowHandles[0];
            string txt = WebDriver.SwitchTo().Window(welcomePageWindow).Url;

            return WebDriver.SwitchTo().Window(welcomePageWindow).Url == BaseAddress + "Secured/Welcome.aspx";
        }

        public void CreateNewBrowserSession()
        {
            WebDriver.Navigate().GoToUrl("about:blank");
        }

        public bool IsAtContactPage()
        {
            var arizonaWindow = WebDriver.WindowHandles[0];
            string txt = WebDriver.SwitchTo().Window(arizonaWindow).Url;

            return WebDriver.SwitchTo().Window(arizonaWindow).Url == BaseAddress + "GeneralInfo.aspx?Content=ContactUs";
        }

        public bool IsAtForgotPasswordPage()
        {
            string pageLoadedText = "Please enter your agent code and user id below and click the Submit button to reset your password";

            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            bool isAtForgotPasswordPage = wait.Until<bool>(x => x.PageSource.Contains(pageLoadedText));

            return isAtForgotPasswordPage;
        }

        public bool IsAtCareerPage()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[contains(text(),'Search job title or location') and @class='sr-only']")));
            AllowCookie.Click();
            return element != null ? true : false;
        }

        public void WriteTextOnJobSearchBox()
        {
            SearchForJobTitleBox.Click();
            SearchForJobTitleBox.SendKeys("QA Test Automation Developer");
            
        }
        
        public void PressOnEnter()
        {
            
            SearchForJobTitleBox.SendKeys(Keys.Enter);
       }

        public void CLickOnCorrectJobTitle()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[contains(text(),'Refine your search ') and @data-ph-at-id='heading-text']")));
            IList <IWebElement> elements = WebDriver.FindElements(By.XPath("//* [@ph-tevent='job_click']"));
            IWebElement firstElement = elements[0];
            var a = firstElement.Text;
            //IWebElement applynow = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[contains(text(),'Apply Now')]")));

            if ("QA Automation Engineer (Remote)" == firstElement.Text)
            {
                firstElement.Click();
            }
            else
            {
                for (int i = 0; i < elements.Count; i++)
                {
                    if ("QA Automation Engineer (Remote)" == elements[i].Text)
                    {
                        elements[i].Click();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        public bool IsJobTitleCorrect()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[contains(text(),'Apply Now')]")));
            IWebElement jobTitle = WebDriver.FindElement(By.XPath("//*[@class='job-title']"));
            if ("QA Automation Engineer (Remote)" == jobTitle.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsJobLocationCorrect()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[contains(text(),'Apply Now')]")));
            IWebElement joblocation = WebDriver.FindElement(By.XPath("//*[@class='au-target job-location']"));
            if ("Location\r\nBoston, Massachusetts, United States" == joblocation.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsJobIDCorrect()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[contains(text(),'Apply Now')]")));
            IWebElement jobID = WebDriver.FindElement(By.XPath("//*[@class='au-target jobId']"));
            if ("Job Id : 22-78060" == jobID.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSecondParagraphContainCorrectSentence()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[contains(text(),'Apply Now')]")));
            IWebElement paragraph = WebDriver.FindElement(By.XPath(".//*[contains(@data-ph-at-id, 'jobdescription-text')]/div/p[2]"));
            var text  = paragraph.Text;
            if (text.Contains("We're looking for a QA Automation Engineer to help us build out our test automation suites"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifySecondBullentPoint()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[contains(text(),'Apply Now')]")));
            IWebElement bulletPoint = WebDriver.FindElement(By.XPath(".//*[contains(@data-ph-at-id, 'jobdescription-text')]/div/ul/li[2]"));
            var text = bulletPoint.Text;
            if (text.Contains("Develop new tests in Java/Kotlin with the aim of covering 6 apps across iOS and Android."))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifyThirdRequirement()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(ConfigurationData.TimeSpanWaitTicks));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[contains(text(),'Apply Now')]")));
            IWebElement requirementText = WebDriver.FindElement(By.XPath(".//*[contains(@data-ph-at-id, 'jobdescription-text')]/div[2]/div/ul/li[3]"));
            var text = requirementText.Text;
            if (text.Contains("Some who has experienced the lifecycle of creating in-house automated tests using Appium for Native mobile applications. We'd like to leverage your experience to identify what we need to do get it right!"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
