using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectMars.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions
    {
        [Given(@"I navigate to skills sub-tab")]
        public void GivenINavigateToSkillsSub_Tab()
        {
            throw new PendingStepException();
        }

        //Add new skill
        [Given(@"I clean up existing records")]
        public void GivenICleanUpExistingRecords()
        {
            throw new PendingStepException();
        }

        [Then(@"I click on Add New button to add new skill")]
        public void ThenIClickOnAddNewButtonToAddNewSkill()
        {
            throw new PendingStepException();
        }

        [Then(@"I enter skill as '([^']*)' and select level as '([^']*)'")]
        public void ThenIEnterSkillAsAndSelectLevelAs(string typing, string intermediate)
        {
            throw new PendingStepException();
        }

        [Then(@"I click Add button to save skill")]
        public void ThenIClickAddButtonToSaveSkill()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to add new skill successfully with '([^']*)' & '([^']*)'")]
        public void ThenIShouldBeAbleToAddNewSkillSuccessfullyWith(string typing, string intermediate)
        {
            throw new PendingStepException();
        }

        //Add new skill with invalid data
        [Given(@"I clean up existing skills")]
        public void GivenICleanUpExistingSkills()
        {
            throw new PendingStepException();
        }

        [Then(@"I click Add New button to activate form")]
        public void ThenIClickAddNewButtonToActivateForm()
        {
            throw new PendingStepException();
        }

        [Then(@"I enter skill '([^']*)' and select level '([^']*)'")]
        public void ThenIEnterSkillAndSelectLevel(string p0, string p1)
        {
            throw new PendingStepException();
        }

        [Then(@"I click Add button to add new record")]
        public void ThenIClickAddButtonToAddNewRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"I should not be able to add new skill")]
        public void ThenIShouldNotBeAbleToAddNewSkill()
        {
            throw new PendingStepException();
        }

        //Add skill without data
        [When(@"I click on Add New button to use the form")]
        public void WhenIClickOnAddNewButtonToUseTheForm()
        {
            throw new PendingStepException();
        }

        [Then(@"I try to save new skill")]
        public void ThenITryToSaveNewSkill()
        {
            throw new PendingStepException();
        }

        [Then(@"I should not be able to add new skill and see warning message")]
        public void ThenIShouldNotBeAbleToAddNewSkillAndSeeWarningMessage()
        {
            throw new PendingStepException();
        }

        //Edit skill
        [When(@"I click on edit icon buttond to activate form")]
        public void WhenIClickOnEditIconButtondToActivateForm()
        {
            throw new PendingStepException();
        }

        [When(@"I update skill as '([^']*)' and select level as '([^']*)'")]
        public void WhenIUpdateSkillAsAndSelectLevelAs(string testing, string beginner)
        {
            throw new PendingStepException();
        }

        [Then(@"I click Update button to save skill")]
        public void ThenIClickUpdateButtonToSaveSkill()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to update skill successfully with '([^']*)' & '([^']*)'")]
        public void ThenIShouldBeAbleToUpdateSkillSuccessfullyWith(string testing, string beginner)
        {
            throw new PendingStepException();
        }

        //Edit skill with invalid data
        [When(@"I try to activate form by clicking on edit icon button")]
        public void WhenITryToActivateFormByClickingOnEditIconButton()
        {
            throw new PendingStepException();
        }

        [When(@"I try update skill as '([^']*)' and select level as '([^']*)'")]
        public void WhenITryUpdateSkillAsAndSelectLevelAs(string testing, string beginner)
        {
            throw new PendingStepException();
        }

        [Then(@"I click Update button to update record")]
        public void ThenIClickUpdateButtonToUpdateRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be not able to update skill")]
        public void ThenIShouldBeNotAbleToUpdateSkill()
        {
            throw new PendingStepException();
        }

        //Edit skill without inputs
        [When(@"I try to open form by clicking on edit icon")]
        public void WhenITryToOpenFormByClickingOnEditIcon()
        {
            throw new PendingStepException();
        }

        [Then(@"I try click Update button to save skill")]
        public void ThenITryClickUpdateButtonToSaveSkill()
        {
            throw new PendingStepException();
        }

        [Then(@"I should not be able to update skill and see warning")]
        public void ThenIShouldNotBeAbleToUpdateSkillAndSeeWarning()
        {
            throw new PendingStepException();
        }

        //Delete skill
        [When(@"I click on delete icon button to delete skill")]
        public void WhenIClickOnDeleteIconButtonToDeleteSkill()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to delete skill successfully")]
        public void ThenIShouldBeAbleToDeleteSkillSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
