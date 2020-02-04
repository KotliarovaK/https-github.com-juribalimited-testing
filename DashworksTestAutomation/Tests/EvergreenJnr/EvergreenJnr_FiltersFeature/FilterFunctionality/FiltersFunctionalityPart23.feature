Feature: FiltersFunctionalityPart23
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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