Feature: FiltersFunctionalityPart18
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15082 @DAS17717
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device IP Address" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device IPv6 Address" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Manufacturer" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Memory (GB)" filter where type is "Greater than" with following Number and Association:
	| Number | Association     |
	| 0      | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Model" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	Then "1,032" rows are displayed in the agGrid
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartIII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device TPM Enabled" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| FALSE              | Used on device      |
	| TRUE               | Entitled to device  |
	| UNKNOWN            | Installed on device |
	And User Add And "Device TPM Version" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Target Drive Free Space (GB)" filter where type is "Greater than" with following Number and Association:
	| Number | Association         |
	| 0      | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Type" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| Data Centre    | Used on device      |
	| Desktop        | Entitled to device  |
	| Laptop         | Installed on device |
	| Mobile         |                     |
	| Other          |                     |
	| Virtual        |                     |
	Then "361" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceDeviceOperatingSystemItemsCounterI
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device OS Architecture" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Empty              | Used on device      |
	| 32                 | Entitled to device  |
	| 64                 | Installed on device |
	And User Add And "Device OS Branch" filter where type is "Does not equal" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association             |
	| Current Branch     | Not entitled to device  |
	|                    | Not installed on device |
	|                    | Not used on device      |
	And User Add And "Device OS Full Name" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| Android 4.3    | Used on device      |
	| Empty          | Entitled to device  |
	| Android 4.4    | Installed on device |
	| Android 5.0    |                     |
	| Android 5.1    |                     |
	Then "4" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS15082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceDeviceOperatingSystemItemsCounterII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device OS Servicing State" filter where type is "Does not equal" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Empty              | Used on device      |
	|                    | Entitled to device  |
	|                    | Installed on device |
	And User Add And "Device OS Version Number" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| 10.0           | Used on device      |
	| 10.0.10240     | Entitled to device  |
	| Empty          | Installed on device |
	| 10.0.15063     |                     |
	| 10.0.14393     |                     |
	And User Add And "Device Service Pack or Build" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues  | Association         |
	| Service Pack 1  | Used on device      |
	| Empty           | Entitled to device  |
	| No Service Pack | Installed on device |
	| Service Pack 2  |                     |
	| Service Pack 3  |                     |
	Then "170" rows are displayed in the agGrid