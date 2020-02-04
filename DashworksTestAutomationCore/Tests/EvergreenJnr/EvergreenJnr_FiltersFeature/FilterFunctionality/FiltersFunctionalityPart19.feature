Feature: FiltersFunctionalityPart19
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartI
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	When User add "Device Owner Building" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Owner City" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| Belfast        | Used on device      |
	| Los Angeles    | Entitled to device  |
	|                | Installed on device |
	And User Add And "Device Owner Compliance" filter where type is "Does not equal" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Red                | Used on device      |
	|                    | Entitled to device  |
	|                    | Installed on device |
	And User Add And "Device Owner Country" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association             |
	| Empty          | Not installed on device |
	|                | Not entitled to device  |
	|                | Not used on device      |
	Then "846" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Department" filter where type is "Equals" with selected Expanded Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Finance            | Used on device      |
	| Sales              | Entitled to device  |
	| Support            | Installed on device |
	| Technology         |                     |
	And User Add And "Device Owner Description" filter where type is "Does not begin with" with following Value and Association:
	| Values | Association         |
	| pro       | Not installed on device     |
	Then "854" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartIII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Display Name" filter where type is "Contains" with following Value and Association:
	| Values  | Association         |
	| Aceline | Entitled to device  |
	|         | Installed on device |
	And User Add And "Device Owner Domain" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Owner Email Address" filter where type is "Ends with" with following Value and Association:
	| Values          | Association         |
	| demo.juriba.com | Entitled to device  |
	|                 | Installed on device |
	And User Add And "Device Owner Enabled" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| TRUE               | Entitled to device  |
	|                    | Installed on device |
	Then "23" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartIV
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Floor" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| Empty          | Entitled to device  |
	|                | Installed on device |
	And User Add And "Device Owner Given Name" filter where type is "Does not end with" with following Value and Association:
	| Values | Association         |
	| sdsds  | Entitled to device  |
	|        | Installed on device |
	Then "1,139" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartV
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Home Directory" filter where type is "Begins with" with following Value and Association:
	| Values         | Association         |
	| \\\\fileserver | Used on device      |
	|                | Entitled to device  |
	|                | Installed on device |
	And User Add And "Device Owner Home Drive" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association        |
	| H:                 | Entitled to device |
	And User Add And "Device Owner Username" filter where type is "Does not equal" with following Value and Association:
	| Values     | Association             |
	| ZZW1565756 | Not installed on device |
	When User Add And "Device Owner Last Logon Date" filter where type is "Before" with following Data and Association:
	| Values     | Association        |
	| 8 Aug 2019 | Entitled to device |
	And User Add And "Device Owner Key" filter where type is "Greater than" with following Number and Association:
	| Number | Association        |
	| 4      | Entitled to device |
	And User Add And "Device Owner Region" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association        |
	| Empty          | Entitled to device |
	| US-E           |                    |
	Then "213" rows are displayed in the agGrid