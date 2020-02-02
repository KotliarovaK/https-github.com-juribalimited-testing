Feature: FiltersFunctionalityPart24
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS19713
Scenario: EvergreenJnr_ApplicationsList_CheckThatErrorsDoNotAppearWhenAddingInvalidDateFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When user select "Boot Up Date" filter
	When User changes filter date to "13 Dec 2017"
	When User changes filter date to "R."
	When User select "Installed on device" in Association
	When User clicks 'ADD' button
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11087 @DAS12114 @DAS12698
Scenario: EvergreenJnr_DevicesList_CheckThatDateAndTimeFiltersWithEqualsValuesAreWorkingCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Computer Information ---- Text fill; Text fill; \ Date & Time Task" filter where type is "Equals" with added column and following value:
		| Values      |
		| 22 Nov 2012 |
	Then "Windows7Mi: Computer Information ---- Text fill; Text fill; \ Date & Time Task" filter is added to the list
	Then "16" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11087 @DAS11090 @DAS12114 @DAS12698
Scenario Outline: EvergreenJnr_DevicesList_CheckThatDateAndTimeFiltersWithDoesNotEqualValuesAreWorkingCorrectly
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Does not equal" with added column and following value:
		| Values  |
		| <Value> |
	Then "<FilterName>" filter is added to the list
	And "<RowCount>" rows are displayed in the agGrid

	Examples:
		| FilterName                                                                     | Value       | RowCount |
		| Windows7Mi: Computer Information ---- Text fill; Text fill; \ Date & Time Task | 22 Nov 2012 | 17,263   |
		| Build Date                                                                     | 6 Nov 2004  | 17,278   |

#Then "71" rows are displayed in the agGrid
@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS11552 @DAS12207
Scenario: EvergreenJnr_UsersList_CheckThatRelevantDataSetBeDisplayedAfterResettingFilter
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "Equals" with added column and following checkboxes:
		| SelectedCheckboxes |
		| Empty              |
	Then "Enabled" filter is added to the list
	And message 'No users found' is displayed to the user
	When User have reset all filters
	Then 'All Users' list should be displayed to the user
	And "41,339" rows are displayed in the agGrid

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS11552
Scenario: EvergreenJnr_ApplicationsList_CheckThatRelevantDataSetBeDisplayedAfterRemovingFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Import Type" filter where type is "Equals" with added column and following checkboxes:
		| SelectedCheckboxes |
		| App-V              |
	Then "Import Type" filter is added to the list
	And message 'No applications found' is displayed to the user
	When User have removed "Import Type" filter
	Then 'All Applications' list should be displayed to the user
	And "2,223" rows are displayed in the agGrid

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS11552
Scenario: EvergreenJnr_MailboxesList_CheckThatRelevantDataSetBeDisplayedAfterNavigatingToANewList
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "Does not equal" with added column and following checkboxes:
		| SelectedCheckboxes |
		| FALSE              |
		| TRUE               |
	Then "Enabled" filter is added to the list
	And message 'No mailboxes found' is displayed to the user
	When User navigates to the "All Mailboxes" list
	Then 'All Mailboxes' list should be displayed to the user
	And "14,784" rows are displayed in the agGrid

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11663
Scenario: EvergreenJnr_DevicesList_CheckThatRowCountIsNotDisplayedWhenNoObjectsAreFoundAfterApplyingAFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "Equals" with added column and following value:
		| Values  |
		| Example |
	Then "Hostname" filter is added to the list
	And "" rows are displayed in the agGrid