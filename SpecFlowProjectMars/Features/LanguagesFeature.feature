Feature: Languages

Testing langueages feature in profile page

Background: 
	Given I navigate to languages sub-tab


@Add_Languages
Scenario: 01) Add new language
	Given I clean all existing data
	Then I click on Add New button
	And I enter language as 'Eng' and select level as 'Native/Bilingual' 
	Then I click Add button
	Then I should be able to add new language successfully with 'Eng' & 'Native/Bilingual'

@Add_Languages_Negative
Scenario Outline: 02) Add new language with invalid data
	Given I clean all existing record 
	Then I click on Add New button to activate form
	And I enter invalid data as '<Language>' and select level as '<Level>' 
	Then I try to click Add button
	Then I should not be able to add new language with '<language>'
	Examples: 
	| Language | Level            |
	| =+       | Native/Bilingual |
	| .?       | Basic            |
	| ""       | Fluent           |

@Add_Languages_Negative
Scenario: 03) Add new language without enter data
	When I click on Add New button to activate language form
	Then I try to click Add button to add new record
	Then I should not be able to add language and see warning message

@Edit_Languages
Scenario: 04) Edit existing language
	When I click on edit icon button
	Then I update language as 'Vn' and select level as 'Fluent' 
	Then I click Update button
	Then I should be able to update language successfully with 'Vn' & 'Fluent'

@Edit_Languages_Negative
Scenario Outline: 05) Edit existing language with invalid data
	When I click on edit icon button to activate form
	Then I update language '<Language>' and select level  '<Level>' 
	Then I try click Update button
	Then I should not be able to update language with '<Language>'
	Examples: 
	| Language | Level            |
	| ???      | Basic            |
	| ---      | Native/Bilingual |
	| ///      | Fluent           |

@Edit_Languages_Negative
Scenario: 06) Edit existing language with same data
	When I click on edit icon button to activate language form
	Then I try click Update button to update
	Then I should not be able to update language and see warning message

@Edit_Languages_Negative
Scenario: 07) Edit existing language without data
	When I click on edit icon to activate language form
	Then I clear existing language and level
	Then I try click Update to update record
	Then should not allow to update language and see warning message

@Delete_Languages
Scenario: 08) Delete existing language
	When I click on delete icon button
	Then I should be able to delete language successfully

