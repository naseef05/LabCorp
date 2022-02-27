using LabCorp.CodedUI.FrameWork.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCorp.CodedUI.FrameWork.Pages
{
    public static partial class Pages
    {
        private static CareerPage _careerPage = null;

        public static CareerPage CareerPage
        {
            get
            {
                if (_careerPage == null)
                {
                    IWebDriver driver = new DriverFactory(DriverType).GetDriver();

                    _careerPage = new CareerPage(driver);

                    PageFactory.InitElements(driver, _careerPage);
                }
                return _careerPage;
            }
            set
            {
                _careerPage = value;
            }
        }
    }
}
