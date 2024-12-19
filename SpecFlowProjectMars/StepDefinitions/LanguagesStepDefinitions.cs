using OpenQA.Selenium;
using SpecFlowProjectMars.Drivers;
using System;
using TechTalk.SpecFlow;
using Testing_Project_Mars_SpecFlow.Pages;

namespace SpecFlowProjectMars.StepDefinitions
{
    [Binding]
    public class LanguagesStepDefinitions : CommonDriver
    {
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"I navigate to languages sub-tab")]
        public void GivenINavigateToLanguagesSub_Tab()
        {
            profilePageObj.ClickSpecific(_driver, "languages tab", "wait_click");
        }

        //Add Language
        [Given(@"I clean all existing data")]
        public void WhenICleanAllExistingData()
        {
            profilePageObj.CleanRecords(_driver, "language row", "remove language btns");
        }

        [Then(@"I click on Add New button")]
        public void ThenIClickOnAddNewButton()
        {
            profilePageObj.ClickSpecific(_driver, "add new language", "wait_click");

        }

        [Then(@"I enter language as '([^']*)' and select level as '([^']*)'")]
        public void ThenIEnterLanguageAsAndSelectLevelAs(string eng, string p1)
        {
            throw new PendingStepException();
        }


        [Then(@"I click Add button")]
        public void ThenIClickAddButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to add new language successfully with '([^']*)' & '([^']*)'")]
        public void ThenIShouldBeAbleToAddNewLanguageSuccessfullyWith(string eng, string p1)
        {
            throw new PendingStepException();
        }

        //Add language with invalid data
        [Given(@"I clean all existing record")]
        public void GivenICleanAllExistingRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"I click on Add New button to activate form")]
        public void WhenIClickOnAddNewButtonToActivateForm()
        {
            throw new PendingStepException();
        }

        [Then(@"I enter invalid data as '([^']*)' and select level as '([^']*)'")]
        public void ThenIEnterInvalidDataAsAndSelectLevelAs(string p0, string p1)
        {
            throw new PendingStepException();
        }

        [Then(@"I try to click Add button")]
        public void ThenITryToClickAddButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should not be able to add new language")]
        public void ThenIShouldNotBeAbleToAddNewLanguage()
        {
            throw new PendingStepException();
        }

        //Add language without data
        [When(@"I click on Add New button to activate language form")]
        public void WhenIClickOnAddNewButtonToActivateLanguageForm()
        {
            throw new PendingStepException();
        }

        [Then(@"I try to click Add button to add new record")]
        public void ThenITryToClickAddButtonToAddNewRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"I should not be able to add language and see warning message")]
        public void ThenIShouldNotBeAbleToAddLanguageAndSeeWarningMessage()
        {
            throw new PendingStepException();
        }

        //Edit language
        [When(@"I click on edit icon button")]
        public void WhenIClickOnEditIconButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I update language as '([^']*)' and select level as '([^']*)'")]
        public void WhenIUpdateLanguageAsAndSelectLevelAs(string vn, string fluent)
        {
            throw new PendingStepException();
        }

        [Then(@"I click Update button")]
        public void ThenIClickUpdateButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to update language successfully with '([^']*)' & '([^']*)'")]
        public void ThenIShouldBeAbleToUpdateLanguageSuccessfullyWith(string vn, string fluent)
        {
            throw new PendingStepException();
        }

        //Edit language invalid data
        [When(@"I click on edit icon button to activate form")]
        public void WhenIClickOnEditIconButtonToActivateForm()
        {
            throw new PendingStepException();
        }

        [Then(@"I update language '([^']*)' and select level  '([^']*)'")]
        public void WhenIUpdateLanguageAndSelectLevel(string p0, string test)
        {
            throw new PendingStepException();
        }

        [Then(@"I try click Update button")]
        public void ThenITryClickUpdateButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should not be able to update language")]
        public void ThenIShouldNotBeAbleToUpdateLanguage()
        {
            throw new PendingStepException();
        }

        //Edit language without data
        [When(@"I click on edit icon button to activate language form")]
        public void WhenIClickOnEditIconButtonToActivateLanguageForm()
        {
            throw new PendingStepException();
        }

        [Then(@"I try click Update button to update")]
        public void ThenITryClickUpdateButtonToUpdate()
        {
            throw new PendingStepException();
        }

        [Then(@"I should not be able to update language and see warning message")]
        public void ThenIShouldNotBeAbleToUpdateLanguageAndSeeWarningMessage()
        {
            throw new PendingStepException();
        }

        //Delete language
        [When(@"I click on delete icon button")]
        public void WhenIClickOnDeleteIconButton()
        {
            profilePageObj.ClickSpecific(_driver, "remove language btn", "wait_click");
        }

        [Then(@"I should be able to delete language successfully")]
        public void ThenIShouldBeAbleToDeleteLanguageSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
