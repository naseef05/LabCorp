using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabCorp.CodedUI.FrameWork.Selenium;
using TechTalk.SpecFlow;
using LabCorp.CodedUI.FrameWork.Pages;

namespace LabCorp.CodedUI_Tests.Steps
{
    [Binding]
    [Category("CareerSearch")]
    [Scope(Feature = "CareerSearch")]
    class CareerSearchSteps
    {
        [Given(@"I have access to labcorp website")]
        public void GivenIHaveAccessToLabcorpWebsite()
        {
            Pages.CareerPage.GoTo();
        }

        [When(@"I click on career tab")]
        public void WhenIClickOnCareerTab()
        {
            Pages.CareerPage.ClickOnCareerLink();
            Pages.CareerPage.SwitchCareerPage();
        }

        [Then(@"I will be redirected to career page")]
        public void ThenIWillBeRedirectedToCareerPage()
        {
            Assert.IsTrue(Pages.CareerPage.IsAtCareerPage());
        }

        [Given(@"I am at career page")]
        public void GivenIAmAtCareerPage()
        {
            SuccessfullyNavigateToCareerSearchPage();
        }

        [Given(@"I write postion name QA Analyst")]
        public void GivenIWritePostionNameQAAnalyst()
        {
            Pages.CareerPage.WriteTextOnJobSearchBox();
        }

        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
            Pages.CareerPage.PressOnEnter();
        }

        [Then(@"job title job location job display and other three verification")]
        public void ThenJobTitleJobLocationJobDisplayAndOtherThreeVerification()
        {
            Pages.CareerPage.CLickOnCorrectJobTitle();
            Assert.IsTrue(Pages.CareerPage.IsJobTitleCorrect());
            Assert.IsTrue(Pages.CareerPage.IsJobLocationCorrect());
            Assert.IsTrue(Pages.CareerPage.IsJobIDCorrect());
            Assert.IsTrue(Pages.CareerPage.IsSecondParagraphContainCorrectSentence());
            Assert.IsTrue(Pages.CareerPage.VerifySecondBullentPoint());
            Assert.IsTrue(Pages.CareerPage.VerifyThirdRequirement());
        }


        public void SuccessfullyNavigateToCareerSearchPage()
        {
            GivenIHaveAccessToLabcorpWebsite();
            WhenIClickOnCareerTab();
            ThenIWillBeRedirectedToCareerPage();
        }

        [AfterScenario]
        public void CleanUp()
        {
            Pages.CareerPage.CloseBrowser();
            Pages.CareerPage = null;
        }




    }
}
