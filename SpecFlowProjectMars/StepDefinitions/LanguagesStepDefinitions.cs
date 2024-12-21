using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Log;
using SpecFlowProjectMars.Drivers;
using SpecFlowProjectMars.Utilities;
using System;
using System.Numerics;
using TechTalk.SpecFlow;
using Testing_Project_Mars_SpecFlow.Pages;

namespace SpecFlowProjectMars.StepDefinitions
{
    [Binding]
    public class LanguagesStepDefinitions : CommonDriver

    {
        ProfilePage profilePageObj = new ProfilePage();

        LanguageModel _languageModel;

        public LanguagesStepDefinitions()
        {
            _languageModel = new LanguageModel();
        }

        [Given(@"I navigate to languages sub-tab")]
        public void GivenINavigateToLanguagesSub_Tab()
        {
            profilePageObj.ClickSpecific(_driver, "languages tab", "wait_click");
        }

        //Add Language
        [Given(@"I clean all existing data")]
        public void WhenICleanAllExistingData()
        {
            profilePageObj.CleanRecords(_driver, "language table", "language rows", "remove language btns");
        }

        [Then(@"I click on Add New button")]
        public void ThenIClickOnAddNewButton()
        {
            profilePageObj.ClickSpecific(_driver, "add new language", "wait_click");

        }

        [Then(@"I enter language as '([^']*)' and select level as '([^']*)'")]
        public void ThenIEnterLanguageAsAndSelectLevelAs(string language, string level)
        {
            _languageModel.Language = language;
            _languageModel.Level = level;

            profilePageObj.EnterTxtLangOrSkill(_driver, "language textbox", "level dropdown", _languageModel.Language, _languageModel.Level, "by value");

        }


        [Then(@"I click Add button")]
        public void ThenIClickAddButton()
        {
            profilePageObj.ClickSpecific(_driver, "add button", "just_click");

        }

        [Then(@"I should be able to add new language successfully with '([^']*)' & '([^']*)'")]
        public void ThenIShouldBeAbleToAddNewLanguageSuccessfullyWith(string language, string level)
        {
            profilePageObj.AssertPopUp(_driver, "added", "Fail to view success message!");

            profilePageObj.AssertDisplayTxt(_driver, "language", _languageModel.Language, "Fail to add new language!");

            profilePageObj.AssertDisplayTxt(_driver, "language level", _languageModel.Level, "Fail to add new language level!");
        }

        //Add language with invalid data
        [Given(@"I clean all existing record")]
        public void GivenICleanAllExistingRecord()
        {
            profilePageObj.CleanRecords(_driver, "language table", "language rows", "remove language btns");
        }

        [Then(@"I click on Add New button to activate form")]
        public void WhenIClickOnAddNewButtonToActivateForm()
        {
            profilePageObj.ClickSpecific(_driver, "add new language", "wait_click");

        }

        [Then(@"I enter invalid data as '([^']*)' and select level as '([^']*)'")]
        public void ThenIEnterInvalidDataAsAndSelectLevelAs(string language, string level)
        {
            _languageModel.Language = language;
            _languageModel.Level = level;

            profilePageObj.EnterTxtLangOrSkill(_driver, "language textbox", "level dropdown", language, level, "by value");
        }

        [Then(@"I try to click Add button")]
        public void ThenITryToClickAddButton()
        {
            profilePageObj.ClickSpecific(_driver, "add button", "just_click");
        }

        [Then(@"I should not be able to add new language with '([^']*)'")]
        public void ThenIShouldNotBeAbleToAddNewLanguageWith(string language)
        {
            profilePageObj.AssertDisplayTxt(_driver, "language", _languageModel.Language, "Fail to avalidate data");
        }


        //Add language without data
        [When(@"I click on Add New button to activate language form")]
        public void WhenIClickOnAddNewButtonToActivateLanguageForm()
        {
            profilePageObj.ClickSpecific(_driver, "add new language", "wait_click");

        }

        [Then(@"I try to click Add button to add new record")]
        public void ThenITryToClickAddButtonToAddNewRecord()
        {
            profilePageObj.ClickSpecific(_driver, "add button", "wait_click");
        }

        [Then(@"I should not be able to add language and see warning message")]
        public void ThenIShouldNotBeAbleToAddLanguageAndSeeWarningMessage()
        {
            
            profilePageObj.AssertPopUp(_driver, "Please enter", "Fail to view warning message!");

        }

        //Edit language
        [When(@"I click on edit icon button")]
        public void WhenIClickOnEditIconButton()
        {
            profilePageObj.ClickSpecific(_driver, "edit language btn", "wait_click");

        }

        [Then(@"I update language as '([^']*)' and select level as '([^']*)'")]
        public void WhenIUpdateLanguageAsAndSelectLevelAs(string language, string level)
        {
            _languageModel.Language = language;
            _languageModel.Level = level;

            profilePageObj.EnterTxtLangOrSkill(_driver, "language textbox", "level dropdown", _languageModel.Language, _languageModel.Level, "by value");

        }

        [Then(@"I click Update button")]
        public void ThenIClickUpdateButton()
        {
            profilePageObj.ClickSpecific(_driver, "update button", "just_click");

        }

        [Then(@"I should be able to update language successfully with '([^']*)' & '([^']*)'")]
        public void ThenIShouldBeAbleToUpdateLanguageSuccessfullyWith(string language, string level)
        {
            profilePageObj.AssertPopUp(_driver, "updated", "Fail to view success message!");

            profilePageObj.AssertDisplayTxt(_driver, "language", _languageModel.Language, "Fail to edit language!");

            profilePageObj.AssertDisplayTxt(_driver, "language level", _languageModel.Level, "Fail to edit language level!");
        }

        //Edit language invalid data
        [When(@"I click on edit icon button to activate form")]
        public void WhenIClickOnEditIconButtonToActivateForm()
        {
            profilePageObj.ClickSpecific(_driver, "edit language btn", "wait_click");

        }

        [Then(@"I update language '([^']*)' and select level  '([^']*)'")]
        public void WhenIUpdateLanguageAndSelectLevel(string language, string level)
        {
            _languageModel.Language = language;
            _languageModel.Level = level;

            profilePageObj.EnterTxtLangOrSkill(_driver, "language textbox", "level dropdown", _languageModel.Language, _languageModel.Level, "by value");

        }

        [Then(@"I try click Update button")]
        public void ThenITryClickUpdateButton()
        {
            profilePageObj.ClickSpecific(_driver, "update button", "just_click");
        }

        [Then(@"I should not be able to update language with '([^']*)'")]
        public void ThenIShouldNotBeAbleToUpdateLanguageWith(string language)
        {
            profilePageObj.AssertDisplayTxt(_driver, "language", _languageModel.Language, "Fail to validate data");

        }


        //Edit language same data
        [When(@"I click on edit icon button to activate language form")]
        public void WhenIClickOnEditIconButtonToActivateLanguageForm()
        {
            profilePageObj.ClickSpecific(_driver, "edit language btn", "wait_click");

        }

        [Then(@"I try click Update button to update")]
        public void ThenITryClickUpdateButtonToUpdate()
        {
            profilePageObj.ClickSpecific(_driver, "update button", "just_click");

        }

        [Then(@"I should not be able to update language and see warning message")]
        public void ThenIShouldNotBeAbleToUpdateLanguageAndSeeWarningMessage()
        {
            profilePageObj.AssertPopUp(_driver, "already added", "Fail to view warning message!");
        }

        //Edit language without data
        [When(@"I click on edit icon to activate language form")]
        public void WhenIClickOnEditIconToActivateLanguageForm()
        {
            profilePageObj.ClickSpecific(_driver, "edit language btn", "wait_click");
        }

        [Then(@"I clear existing language and level")]
        public void ThenIClearExistingLanguageAndLevel()
        {
            profilePageObj.ClearTextBox(_driver, "language textbox");

            profilePageObj.SelectOption(_driver, "level dropdown", "Language Level", "by text");
        }

        [Then(@"I try click Update to update record")]
        public void ThenITryClickUpdateToUpdateRecord()
        {
            profilePageObj.ClickSpecific(_driver, "update button", "just_click");
        }

        [Then(@"should not allow to update language and see warning message")]
        public void ThenShouldNotAllowToUpdateLanguageAndSeeWarningMessage()
        {
            profilePageObj.AssertPopUp(_driver, "enter language and level", "Fail to view warning message!");
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
            profilePageObj.AssertPopUp(_driver, "deleted", "Fail remove language!");
        }
    }
}