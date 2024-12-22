using OpenQA.Selenium.BiDi.Modules.Log;
using SpecFlowProjectMars.Drivers;
using SpecFlowProjectMars.Utilities;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;
using Testing_Project_Mars_SpecFlow.Pages;

namespace SpecFlowProjectMars.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions : CommonDriver
    {
        ProfilePage profilePageObj = new ProfilePage();

        SkillModel _skillModel;

        public SkillsStepDefinitions()
        {
            _skillModel = new SkillModel();
        }


        //Navigate to skill tab
        [Given(@"I navigate to skills sub-tab")]
        public void GivenINavigateToSkillsSub_Tab()
        {
            profilePageObj.ClickSpecific(_driver, "skills tab", "wait_click");
        }

        //Add new skill
        [Given(@"I clean up existing records")]
        public void GivenICleanUpExistingRecords()
        {
            profilePageObj.CleanRecords(_driver, "skill table", "skill rows", "remove skill btns");
        }

        [Then(@"I click on Add New button to add new skill")]
        public void ThenIClickOnAddNewButtonToAddNewSkill()
        {
            profilePageObj.ClickSpecific(_driver, "add new skill", "wait_click");

        }

        [Then(@"I enter skill as '([^']*)' and select level as '([^']*)'")]
        public void ThenIEnterSkillAsAndSelectLevelAs(string skill, string level)
        {
            _skillModel.Skill = skill;
            _skillModel.Level = level;

            profilePageObj.EnterTxtLangOrSkill(_driver, "skill textbox", "level dropdown", _skillModel.Skill, _skillModel.Level, "by value");

        }

        [Then(@"I click Add button to save skill")]
        public void ThenIClickAddButtonToSaveSkill()
        {
            profilePageObj.ClickSpecific(_driver, "add button", "just_click");
        }

        [Then(@"I should be able to add new skill successfully with '([^']*)' & '([^']*)'")]
        public void ThenIShouldBeAbleToAddNewSkillSuccessfullyWith(string skill, string level)
        {
            profilePageObj.AssertPopUp(_driver, "added", "Fail to view success message!");

            profilePageObj.AssertDisplayTxt(_driver, "skill", _skillModel.Skill, "Fail to add new skill!");

            profilePageObj.AssertDisplayTxt(_driver, "skill level", _skillModel.Level, "Fail to add new skill level!");
        }

        //Add new skill with invalid data
        [Given(@"I clean up existing skills")]
        public void GivenICleanUpExistingSkills()
        {
            profilePageObj.CleanRecords(_driver, "skill table", "skill rows", "remove skill btns");
        }

        [Then(@"I click Add New button to activate form")]
        public void ThenIClickAddNewButtonToActivateForm()
        {
            profilePageObj.ClickSpecific(_driver, "add new skill", "wait_click");
        }

        [Then(@"I enter skill '([^']*)' and select level '([^']*)'")]
        public void ThenIEnterSkillAndSelectLevel(string skill, string level)
        {
            _skillModel.Skill = skill;
            _skillModel.Level = level;

            profilePageObj.EnterTxtLangOrSkill(_driver, "skill textbox", "level dropdown", _skillModel.Skill, _skillModel.Level, "by value");
        }

        [Then(@"I click Add button to add new record")]
        public void ThenIClickAddButtonToAddNewRecord()
        {
            profilePageObj.ClickSpecific(_driver, "add button", "just_click");
        }

        [Then(@"I should not be able to add new skill")]
        public void ThenIShouldNotBeAbleToAddNewSkill()
        {
            profilePageObj.AssertDisplayTxt(_driver, "skill", _skillModel.Skill, "Fail to validate data!");
        }

        //Add skill without data
        [When(@"I click on Add New button to use the form")]
        public void WhenIClickOnAddNewButtonToUseTheForm()
        {
            profilePageObj.ClickSpecific(_driver, "add new skill", "wait_click");
        }

        [Then(@"I try to save new skill")]
        public void ThenITryToSaveNewSkill()
        {
            profilePageObj.ClickSpecific(_driver, "add button", "just_click");
        }

        [Then(@"I should not be able to add new skill and see warning message")]
        public void ThenIShouldNotBeAbleToAddNewSkillAndSeeWarningMessage()
        {
            profilePageObj.AssertPopUp(_driver, "enter skill and experience level", "Fail to validate data!");
        }

        //Edit skill
        [When(@"I click on edit icon buttond to activate form")]
        public void WhenIClickOnEditIconButtondToActivateForm()
        {
            profilePageObj.ClickSpecific(_driver, "edit skill btn", "wait_click");
        }

        [When(@"I update skill as '([^']*)' and select level as '([^']*)'")]
        public void WhenIUpdateSkillAsAndSelectLevelAs(string skill, string level)
        {
            _skillModel.Skill = skill;
            _skillModel.Level = level;

            profilePageObj.EnterTxtLangOrSkill(_driver, "skill textbox", "level dropdown", _skillModel.Skill, _skillModel.Level, "by value");
        }

        [Then(@"I click Update button to save skill")]
        public void ThenIClickUpdateButtonToSaveSkill()
        {
            profilePageObj.ClickSpecific(_driver, "update button", "just_click");

        }

        [Then(@"I should be able to update skill successfully with '([^']*)' & '([^']*)'")]
        public void ThenIShouldBeAbleToUpdateSkillSuccessfullyWith(string testing, string beginner)
        {
            profilePageObj.AssertPopUp(_driver, "updated", "Fail to view success message!");

            profilePageObj.AssertDisplayTxt(_driver, "skill", _skillModel.Skill, "Fail to update  skill!");

            profilePageObj.AssertDisplayTxt(_driver, "skill level", _skillModel.Level, "Fail to update skill level!");
        }

        //Edit skill with invalid data
        [When(@"I try to activate form by clicking on edit icon button")]
        public void WhenITryToActivateFormByClickingOnEditIconButton()
        {
            profilePageObj.ClickSpecific(_driver, "edit skill btn", "wait_click");
        }

        [When(@"I try update skill as '([^']*)' and select level as '([^']*)'")]
        public void WhenITryUpdateSkillAsAndSelectLevelAs(string skill, string level)
        {
            _skillModel.Skill = skill;
            _skillModel.Level = level;

            profilePageObj.EnterTxtLangOrSkill(_driver, "skill textbox", "level dropdown", _skillModel.Skill, _skillModel.Level, "by value");
        }

        [Then(@"I click Update button to update record")]
        public void ThenIClickUpdateButtonToUpdateRecord()
        {
            profilePageObj.ClickSpecific(_driver, "update button", "just_click");
        }

        [Then(@"I should be not able to update skill")]
        public void ThenIShouldBeNotAbleToUpdateSkill()
        {
            profilePageObj.AssertDisplayTxt(_driver, "skill", _skillModel.Skill, "Fail to validate data!");        
        }

        //Edit skill same inputs
        [When(@"I try to open form by clicking on edit icon")]
        public void WhenITryToOpenFormByClickingOnEditIcon()
        {
            profilePageObj.ClickSpecific(_driver, "edit skill btn", "wait_click");
        }

        [Then(@"I try click Update button to save skill")]
        public void ThenITryClickUpdateButtonToSaveSkill()
        {
            profilePageObj.ClickSpecific(_driver, "update button", "just_click");
        }

        [Then(@"I should not be able to update skill and see warning")]
        public void ThenIShouldNotBeAbleToUpdateSkillAndSeeWarning()
        {
            profilePageObj.AssertPopUp(_driver, "already added", "Fail to view success message!");
        }

        //Edit without data
        [When(@"I try to open form by clicking on edit button")]
        public void WhenITryToOpenFormByClickingOnEditButton()
        {
            profilePageObj.ClickSpecific(_driver, "edit skill btn", "wait_click");
        }

        [Then(@"I remove existing skill and level")]
        public void ThenIRemoveExistingSkillAndLevel()
        {
            profilePageObj.ClearTextBox(_driver, "skill textbox");

            profilePageObj.SelectOption(_driver, "level dropdown", "Skill Level", "by text");
        }

        [Then(@"I try click Update button to save record")]
        public void ThenITryClickUpdateButtonToSaveRecord()
        {
            profilePageObj.ClickSpecific(_driver, "update button", "just_click");
        }

        [Then(@"should not allow to update skill and see warning")]
        public void ThenShouldNotAllowToUpdateSkillAndSeeWarning()
        {
            profilePageObj.AssertPopUp(_driver, "enter skill and experience level", "Fail to view success message!");
        }


        //Delete skill
        [When(@"I click on delete icon button to delete skill")]
        public void WhenIClickOnDeleteIconButtonToDeleteSkill()
        {
            profilePageObj.ClickSpecific(_driver, "remove skill btn", "wait_click");
        }

        [Then(@"I should be able to delete skill successfully")]
        public void ThenIShouldBeAbleToDeleteSkillSuccessfully()
        {
            profilePageObj.AssertPopUp(_driver, "deleted", "Fail to remove skill record!");

        }
    }
}
