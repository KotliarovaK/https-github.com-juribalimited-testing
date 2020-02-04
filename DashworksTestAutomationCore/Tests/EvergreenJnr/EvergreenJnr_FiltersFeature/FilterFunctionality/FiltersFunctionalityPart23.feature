Feature: FiltersFunctionalityPart23
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersFunctionality @DAS19384
Scenario: EvergreenJnr_ApplicationsList_CheckzzMailboxAuOwnerInScopeFilterWork
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                 |
	| zMailboxAu: Owner In Scope |
	Then Content is present in the newly added column
	| ColumnName                 |
	| zMailboxAu: Owner In Scope |
	Then "14,784" rows are displayed in the agGrid
	When User clicks on 'zMailboxAu: Owner In Scope' column header
	Then data in table is sorted by 'zMailboxAu: Owner In Scope' column in descending order
	When User clicks on 'zMailboxAu: Owner In Scope' column header
	Then data in table is sorted by 'zMailboxAu: Owner In Scope' column in ascending order
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "zMailboxAu: Owner In Scope" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| FALSE              |
	| Empty              |
	Then "zMailboxAu: Owner In Scope" filter is added to the list
	Then "14,784" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS19550
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoErrorDisplayedWhenFilteringListBySavedList
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Device Owner (Saved List)" filter where type is "In list" with selected Checkboxes and following Association:
	| SelectedCheckboxes      | Association    |
	| Users with Device Count | Used on device |
	Then There are no errors in the browser console

@Evergreen @Devices @Evergreen_FiltersFeature @DAS19157 @Cleanup
Scenario: EvergreenJnr_CheckThatThereIsNoAbilityToUseListAsFilterOptionIfItHasReferenceFiltersForCurrentProjectAsProjectScopeList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User add "1803: In Scope" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | TRUE           |
	Then table content is present
	When User create dynamic list with "ListForDAS19157" name on "Devices" page
	Then "ListForDAS19157" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When user select "Device (Saved List)" filter
	Then 'ListForDAS19157' checkbox is not displayed

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS19669
Scenario Outline: EvergreenJnr_AllLists_CheckThatFilterStaysWorkingAfterAddingDepartmentFilter
	When User clicks '<List>' on the left-hand menu
	When User clicks the Filters button
	When User add "<Filter>" filter where type is "Equals" with added column and "Empty" Tree List option
	Then table content is present
	When User clicks refresh button in the browser
	Then table content is present
	When User clicks the Filters button
	Then "<Filter> is Empty" is displayed in added filter info

Examples:
	| List      | Filter           |
	| Devices   | Owner Department |
	| Users     | Department       |
	| Mailboxes | Owner Department |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS19669
Scenario: EvergreenJnr_Applications_CheckThatFilterStaysWorkingAfterAddingDepartmentFilter
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Device Owner Department" filter where type is "Equals" with following Tree List option and Association:
	| Value | Association    |
	| Empty | Used on device |
	Then table content is present
	When User clicks refresh button in the browser
	Then table content is present
	When User clicks the Filters button
	Then "Device Owner whose Department is Empty used on device" is displayed in added filter info

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS19460
Scenario: EvergreenJnr_Devices_CheckThatCorrectOptionsAreDisplayedForOwnerStatusFilter
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "1803: Owner Status" filter
	Then Following checkboxes are available for current opened filter:
    | checkboxes    |
    | Empty         |
    | Not Onboarded |
    | Onboarded     |
    | Offboarded    |