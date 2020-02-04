Feature: FiltersFunctionalityPart12
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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

