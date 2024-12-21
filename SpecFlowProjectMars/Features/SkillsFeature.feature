Feature: Skills

Testing skills feature in profile page
Background: 
	Given I navigate to skills sub-tab

@Add_Skills
Scenario: 01) Add new skill
	Given  I clean up existing records
	Then I click on Add New button to add new skill
	And I enter skill as 'Typing' and select level as 'Intermediate' 
	Then I click Add button to save skill
	Then I should be able to add new skill successfully with 'Typing' & 'Intermediate'

@Add_Skills_Negative
Scenario Outline: 02) Add new skill with invalid data
	Given  I clean up existing skills
	Then I click Add New button to activate form
	And I enter skill '<Skill>' and select level '<Level>' 
	Then I click Add button to add new record
	Then I should not be able to add new skill
	Examples: 
	| Skill | Level        |
	| =+    | Intermediate |
	| \|?   | Beginner     |
	| :{}   | Expert       |

@Add_Skills_Negative
Scenario: 03) Add new skill without data
	When I click on Add New button to use the form
	Then I try to save new skill
	Then I should not be able to add new skill and see warning message
	
@Edit_Skills
Scenario: 04) Edit existing skill
	When I click on edit icon buttond to activate form
	And I update skill as 'Testing' and select level as 'Beginner'
	Then I click Update button to save skill
	Then I should be able to update skill successfully with 'Testing' & 'Beginner'

@Edit_Skills_Negative
Scenario Outline: 05) Edit existing skill
	When I try to activate form by clicking on edit icon button
	And I try update skill as 'Testing' and select level as 'Beginner'
	Then I click Update button to update record
	Then I should be not able to update skill 
	Examples: 
	| Skill | Level        |
	| **    | Intermediate |
	| $%    | Beginner     |
	| {}()  | Expert       |

@Edit_Skills_Negative
Scenario: 06) Edit existing skill with same data
	When I try to open form by clicking on edit icon
	Then I try click Update button to save skill
	Then I should not be able to update skill and see warning

@Edit_Skills_Negative
Scenario: 07) Edit existing skill without data
	When I try to open form by clicking on edit button
	Then I remove existing skill and level
	Then I try click Update button to save record
	Then should not allow to update skill and see warning

@Delete_Skills
Scenario: 08) Delete existing skill
	When I click on delete icon button to delete skill
	Then I should be able to delete skill successfully