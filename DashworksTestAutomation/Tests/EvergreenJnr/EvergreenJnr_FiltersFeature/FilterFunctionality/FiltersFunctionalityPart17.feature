Feature: FiltersFunctionality
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user



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