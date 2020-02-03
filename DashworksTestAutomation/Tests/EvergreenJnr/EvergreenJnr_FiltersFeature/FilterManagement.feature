Feature: FilterManagement
	Runs Dynamic Filters Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11678
Scenario: EvergreenJnr_DevicesList_CheckThatTheSaveButtonIsNotAvailableWhenEnteringInvalidData
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Build Date" filter where type is "Equals" with added column and following value:
	| Values |
	| 1      |
	Then Save button is not available on the Filter panel

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11738 @DAS12194 @DAS12199 @DAS12220
Scenario: EvergreenJnr_UsersList_CheckThatToolTipShownWithEditFilterTextWhenEditingAFilterDisplayed 
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User navigate to Edit button for "Compliance" filter
	Then tooltip is displayed with "Edit Filter" text for edit filter button

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13182
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddNewOptionAvailableAfterClickOnAllOptionInListsPanelWhileFiltersSectionExpanded
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	When User navigates to the "<LinkName>" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And Add New button is displayed on the Filter panel

	Examples:
		| ListName     | LinkName         |
		| Devices      | All Devices      |
		| Users        | All Users        |
		| Applications | All Applications |
		| Mailboxes    | All Mailboxes    |

@Evergreen @Devices @Users @Applications @Mailboxes @FiltersDisplay @ColumnsDisplay @DAS17943
Scenario Outline: EvergreenJnr_AdminPage_CheckThaSearchfieldHasProperPlaceholderForFiltersAndColumns
	When User clicks '<PageName>' on the left-hand menu
	Then '<ListName>' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then Filter Searchfield placeholder is 'Search filters'
	When User clicks the Columns button
	Then Columns Searchfield placeholder is 'Search columns'

	Examples:
		| PageName     | ListName         |
		| Devices      | All Devices      |
		| Users        | All Users        |
		| Applications | All Applications |
		| Mailboxes    | All Mailboxes    |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS12819 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatTheUserDescriptionFieldIsNotDisplayedForEmptyNotEmptyOptions
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Description" filter where type is "Contains" with following Value and Association:
		| Values | Association     |
		| Aw     | Entitled to app |
	Then "3" rows are displayed in the agGrid
	When User create dynamic list with "UsersDescriptionFilterList" name on "Applications" page
	Then "UsersDescriptionFilterList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "User " filter
	And User select "Empty" Operator value
	Then User Description field is not displayed
	When User select "Not empty" Operator value
	Then User Description field is not displayed 
	
@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11760 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatTheSaveButtonIsNotAvailableWithoutTheFilterValue
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application Name" filter
	And User enters "testText" text in Search field at selected Filter
	And User clicks Add button for input filter value
	And User select "Not entitled to device" Association for Application filter with Lookup value
	When User clicks 'UPDATE' button 
	Then "Application whose Name is testText not entitled to device" is displayed in added filter info
	When User create dynamic list with "TestListF58LY5" name on "Devices" page
	Then Edit List menu is not displayed
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Application " filter
	Then Search field in selected Filter is empty

@Evergreen @Mailboxes @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12543 @DAS13001 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckThatEditFilterElementsBlockIsDisplayedCorrectlyOnTheFiltersPanel
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "EmailMigra: Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Light Blue     |
	Then Content is present in the newly added column
	| ColumnName            |
	| EmailMigra: Readiness |
	When User create dynamic list with "TestListF544Y5" name on "Mailboxes" page
	Then "TestListF544Y5" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
	| Values     |
	| Light Blue |
	When User click Edit button for "EmailMigra: Readiness" filter
	Then "Add column" checkbox is checked
	And "EmailMigra: Readiness" filter is displayed in the Filters panel