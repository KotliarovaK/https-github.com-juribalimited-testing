Feature: FiltersFunctionality
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17004
Scenario: EvergreenJnr_UsersList_CheckDepartmentLevelFilterItems
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	And User add "Department Level 1" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Sales            |
	| Finance         |
	And User Add And "Department Level 2" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Marketing      |
	And User Add And "Department Level 3" filter where type is "Does not equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Admin              |
	| Support            |
	| Helpdesk           |
	Then "1,800" rows are displayed in the agGrid

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17004
Scenario: EvergreenJnr_ApplicationsList_CheckDepartmentLevelFilterItems
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Department Level 1" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Sales              | Used on device      |
	| Support            | Entitled to device  |
	| Technology         | Installed on device |
	Then "854" rows are displayed in the agGrid

@Evergreen @Mailboxes @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17004
Scenario: EvergreenJnr_MailboxesList_CheckDepartmentLevelFilterItems
	When User clicks 'Mailboxes' on the left-hand menu
	And User clicks the Filters button
	And User add "Department Level 1" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Support            |
	| Technology         |
	Then "6,707" rows are displayed in the agGrid

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS16912
Scenario Outline: EvergreenJnr_AllLists_CheckThatComplinceNoneOptionIsTranslatedInFilter
	When User clicks '<ListName>' on the left-hand menu
	And User language is changed to "Deutsch" via API
	And User clicks refresh button in the browser
	And User clicks the Filters button
	And user select "<TranslatedColumnName>" filter
	Then Following checkboxes are available for current opened filter:
	| checkboxes |
	| Unbekannt  |
	| Rot        |
	| Bernstein  |
	| Grün       |
	| Keine      |

Examples: 
	| ListName     | TranslatedColumnName        |
	| Devices      | Anwendungskonformität       |
	| Users        | Geräteanwendungskonformität |
	| Applications | Konformität                 |
	| Mailboxes    | Konformität des Inhabers    |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartI
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	When User add "Device CPU Architecture" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device CPU Speed (GHz)" filter where type is "Does not equal" with following Number and Association:
	| Number | Association     |
	| 0      | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Format" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device HDD Total Size (GB)" filter where type is "Greater than" with following Number and Association:
	| Number | Association     |
	| 0      | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	Then "2,128" rows are displayed in the agGrid