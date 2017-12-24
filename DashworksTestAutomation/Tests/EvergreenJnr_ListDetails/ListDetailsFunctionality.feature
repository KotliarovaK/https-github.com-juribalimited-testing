@retry:1
Feature: ListDetailsFunctionality
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS-10880 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatRenamingAListWorkingCorrectlyForDynamicLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<Columnname>' column header
	Then data in table is sorted by '<Columnname>' column in descending order
	When User create custom list with "TestList" name
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User changes list name to "RenamedList"
	#Then "RenamedList" name is displayed in list details panel
	Then "RenamedList" list is displayed to user

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS-10880 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_CheckThatRenamingAListWorkingCorrectlyForStaticLists
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	And User create static list with "Static List TestName" name
	When User clicks the List Details button
	Then List details panel is displayed to the user
	When User changes list name to "RenamedList"
	#Then "RenamedList" name is displayed in list details panel
	Then "RenamedList" list is displayed to user

Examples: 
	| PageName     | Columnname    |
	| Devices      | Hostname      |
	| Users        | Username      |
	| Applications | Application   |
	| Mailboxes    | Email Address |