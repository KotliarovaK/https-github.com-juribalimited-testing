Feature: FiltersFunctionalityPart12
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13377
Scenario: EvergreenJnr_ApplicationsList_ChecksThatApplicationNameIsDisplayedAfterUsingTargetAppFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Barry'sUse: Target App" filter where type is "Equals" with added column and Lookup option
	| SelectedValues         |
	| Python 2.2a4 (SMS_GEN) |
	Then "Barry'sUse: Target App" filter is added to the list
	And "Barry'sUse: Target App is Python 2.2a4 (SMS_GEN)" is displayed in added filter info
	When User click content from "Application" column
	Then User click back button in the browser
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Barry'sUse: Target App is Python 2.2a4 (SMS_GEN)" is displayed in added filter info

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13381 @DAS14603
Scenario Outline: EvergreenJnr_AllLists_ChecksThatFilterInfoIsDisplayedCorrectlyAfterSelectingObjectAndThenReturningBackToSerachResult
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| <FilterValue>      |
	Then "<FilterName>" filter is added to the list
	And "<FilterInfo>" is displayed in added filter info
	When User perform search by "<Search>"
	And User click content from "<ColumnName>" column
	Then User click back button in the browser
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "<FilterInfo>" is displayed in added filter info

Examples: 
	| PageName     | ColumnName    | FilterName                               | FilterValue    | Search                                     | FilterInfo                                                 |
	| Devices      | Hostname      | Babel(Engl: Category                     | None           | 00KLL9S8NRF0X6                             | Babel(Engl: Category is None                               |
	| Devices      | Hostname      | Babel(Engl: In Scope                     | FALSE          | 00I0COBFWHOF27                             | Babel(Engl: In Scope is False                              |
	| Devices      | Hostname      | ComputerSc: Path                         | Request Type A | 47NK3ATE5DM2HD                             | ComputerSc: Path is Request Type A                         |
	| Applications | Application   | Havoc(BigD: Hide from End Users          | UNKNOWN        | Adobe Flash Player 10 ActiveX (10.0.12.36) | Havoc(BigD: Hide from End Users is Unknown                 |
	| Applications | Application   | MigrationP: Core Application             | FALSE          | Adobe Download Manager 2.0 (Remove Only)   | MigrationP: Core Application is False                      |
	| Mailboxes    | Email Address | EmailMigra: Mobile Devices \ Device Type | Not Identified | 238BAE24882E48BFA9F@bclabs.local           | EmailMigra: Mobile Devices \ Device Type is Not Identified |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12214
Scenario: EvergreenJnr_ApplicationsList_CheckThatFiltersWorksProperlyWithPositiveAndNegativeAssociation
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "After" with following Data and Association:
	| Values     | Association                             |
	| 1 May 2011 | Has used app                            |
	|            | Entitled to app                         |
	|            | Owns a device which app was used on     |
	|            | Owns a device which app is entitled to  |
	|            | Owns a device which app is installed on |
	Then "1,206" rows are displayed in the agGrid
	When User click Edit button for " Last Logon Date" filter
	Then only positive Associations is displayed
	When User is deselect "Has used app" in Association
	And User is deselect "Entitled to app" in Association
	And User is deselect "Owns a device which app was used on" in Association
	And User is deselect "Owns a device which app is entitled to" in Association
	And User is deselect "Owns a device which app is installed on" in Association
	And User select "Has not used app" in Association
	Then only negative Associations is displayed
	When User select "Not entitled to app" in Association
	And User select "Does not own a device which app was used on" in Association
	And User select "Does not own a device which app is entitled to" in Association
	And User select "Does not own a device which app is installed on" in Association
	And User clicks Save filter button
	Then "2,223" rows are displayed in the agGrid
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Name" filter where type is "Begins with" with following Value and Association:
	| Values | Association    |
	| Adobe  | Used on device |
	When User click Edit button for "Application " filter
	Then only positive Associations is displayed
	When User is deselect "Used on device" in Association
	And User select "Not used on device" in Association
	Then only negative Associations is displayed

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12211
Scenario: EvergreenJnr_ApplicationsList_CheckThatResultsAreDifferentWhenApplyingEqualAndDoesntEqualValues
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Does not equal" with following Data and Association:
	| Values      | Association  |
	| 26 Apr 2018 | Has used app |
	Then "100" rows are displayed in the agGrid
	When User click Edit button for " Last Logon Date" filter
	Then User changes filter type to "Equals"
	Then message 'No applications found' is displayed to the user 