Feature: CustomListDisplayPart6
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS10988 @DAS11951 @Cleanup
Scenario: EvergreenJnr_DevicesLists_CheckThatUserIsNotAbleToCreateListsWithSameName
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "TestList993785" name on "Devices" page
	Then "TestList993785" list is displayed to user
	When User navigates to the "All Devices" list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "City" filter where type is "Equals" with added column and "London" Lookup option
	Then "City" filter is added to the list
	When User clicks Save button on the list panel
	Then User type "TestList993785" into Custom list name field
	Then Save button is inactive for Custom list

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11655 @DAS11666 @DAS12156 @Cleanup
Scenario Outline: EvergreenJnr_DevicesLists_CheckThatTheSavedListWithOwnerDisplayNameFilterIsDisplayed
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Owner Display Name" filter where type is "<OperatorValues>" with added column and following value:
	| Values |
	|        |
	Then "Owner Display Name" filter is added to the list
	When User create dynamic list with "TestList274E0A" name on "Devices" page
	Then "TestList274E0A" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "TestList274E0A" list
	Then "TestList274E0A" list is displayed to user 
	And Column is displayed in following order:
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	And URL contains "<URL>"

Examples:
	| OperatorValues | URL                          |
	| Empty          | evergreen/#/devices?$listid= |
	| Not empty      | evergreen/#/devices?$listid= |

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS11015 @DAS11951 @Cleanup
Scenario: EvergreenJnr_DevicesLists_CheckThatUserIsNotAbleToCreateListsWithLongNames
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "1234567890123456789012345678901234567890" name on "Devices" page
	Then "1234567890123456789012345678901234567890" list is displayed to user
	When User duplicates list with "1234567890123456789012345678901234567890" name
	Then "123456789012345678901234567890123456782" list is displayed to user
	When User removes custom list with "123456789012345678901234567890123456782" name
	Then list with "123456789012345678901234567890123456782" name is removed
	When User removes custom list with "1234567890123456789012345678901234567890" name
	Then list with "1234567890123456789012345678901234567890" name is removed
	When User clicks the Actions button
	And User select all rows
	And User selects "Create static list" in the Actions dropdown
	When User create static list with "1234567890123456789012345678901234567890111" name
	Then list name automatically changed to "1234567890123456789012345678901234567890" name
	And "1234567890123456789012345678901234567890" list is displayed to user

@Evergreen @AllLists @EvergreenJnr_ListPanel @CustomListDisplay @DAS11342
Scenario Outline: EvergreenJnr_AllLists_CheckThatAllListsNamesAreDisplayedCorrectly
	When User clicks '<ListName>' on the left-hand menu
	Then '<AllListName>' list should be displayed to the user
	Then "<AllListName>" list name is displayed correctly

Examples:
	| ListName     | AllListName      |
	| Devices      | All Devices      |
	| Applications | All Applications |
	| Users        | All Users        |
	| Mailboxes    | All Mailboxes    |