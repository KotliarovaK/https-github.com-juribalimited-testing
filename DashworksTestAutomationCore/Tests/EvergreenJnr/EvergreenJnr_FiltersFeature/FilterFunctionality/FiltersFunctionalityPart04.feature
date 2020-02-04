Feature: FiltersFunctionalityPart04
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11559
Scenario: EvergreenJnr_DevicesList_CheckThatErrorsDoNotAppearWhenAddingAdvancedAndStandardFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Import" filter where type is "Equals" with Selected Value and following Association:
	| SelectedList | Association    |
	| Altiris      | Used on device |
	And User add "Boot Up Date" filter where type is "Equals" with added column and following value:
	| Values      |
	| 07 Dec 2017 |
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11741 @DAS13001
Scenario: EvergreenJnr_DevicesList_CheckThatErrorsDoNotAppearAndFullDataIsDisplayedWhenAddingDifferentFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Application Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues          |
	| Red                     |
	| Blue                    |
	| Out Of Scope            |
	| Light Blue              |
	| Brown                   |
	| Amber                   |
	| Really Extremely Orange |
	| Purple                  |
	| Green                   |
	| Grey                    |
	| None                    |
	When User Add And "Windows7Mi: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then full list content is displayed to the user
	And There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11838 @DAS13001
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheTargetAppReadinessItemIsMatchingTheCaption
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "ComputerSc: Target App Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues     |
	| <SelectedCheckbox> |
	Then '<ColorName>' content is displayed in all 'ComputerSc: Target App Readiness' column
	Then '<SelectedCheckbox>' path is displayed in the 'ComputerSc: Target App Readiness' column

Examples:
	| SelectedCheckbox        | ColorName               |
	| Red                     | RED                     |
	| Blue                    | BLUE                    |
	| Light Blue              | LIGHT BLUE              |
	| Brown                   | BROWN                   |
	| Amber                   | AMBER                   |
	| Really Extremely Orange | REALLY EXTREMELY ORANGE |
	| Purple                  | PURPLE                  |
	| Green                   | GREEN                   |
	| Grey                    | GREY                    |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11838
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheApplicationRationalisationItemIsMatchingTheCaption
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "ComputerSc: Application Rationalisation" filter where type is "Equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| <SelectedCheckbox> |
	Then '<SelectedCheckbox>' content is displayed in all 'ComputerSc: Application Rationalisation' column
	Then '<SelectedCheckbox>' path is displayed in the 'ComputerSc: Application Rationalisation' column

Examples:
	| SelectedCheckbox |
	| FORWARD PATH     |
	| KEEP             |
	| RETIRE           |
	| UNCATEGORISED    |

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12076 @DAS12351
Scenario: EvergreenJnr_DevicesList_CheckThatColumnIsEmptyWhenEqualNoneAndContainsContentWhenDoesnotequalNoneForWindows7MiCategoryFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| None               |
	Then Content is empty in the column
	| ColumnName           |
	| Windows7Mi: Category |
	When User add "Windows7Mi: Category" filter where type is "Does not equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| None               |
	When User clicks on 'Windows7Mi: Category' column header
	Then Content is present in the newly added column
	| ColumnName           |
	| Windows7Mi: Category |