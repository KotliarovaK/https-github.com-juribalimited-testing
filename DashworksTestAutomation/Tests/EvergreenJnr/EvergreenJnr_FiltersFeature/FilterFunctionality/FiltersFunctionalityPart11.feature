Feature: FiltersFunctionalityPart11
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13331
Scenario: EvergreenJnr_DevicesList_ChecksThatUsedByDevicesOwnerApplicationToDeviceAssociationReturnCorrectData
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Key" filter where type is "Equals" with following Number and Association:
	| Number | Association            |
	| 86     | Used by device's owner |
	Then "Application whose Key" filter is added to the list
	And "Application whose Key is 86 used by device's owner" is displayed in added filter info
	And "154" rows are displayed in the agGrid

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13145
Scenario Outline: EvergreenJnr_AllLists_ChecksThatApplicationFilterIsNotExcludedApplicationsWhichAreNotLinkedToAnyDevices
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application" filter
	And User clicks in search field for selected Association filter
	Then "50 of 2223 shown" results are displayed in the Filter panel
	And the following values are displayed for "Application" filter on "<PageName>" page:
	| Value                               |
	| Acrobat Reader 6.0.1 (500)          |
	| ACT Data Collection Packages (1104) |
	Then "ACT Data Collection Packages (1104)" is displayed after "Acrobat Reader 6.0.1 (500)" in Application list filter
	When User enters "1104" text in Search field at selected Lookup Filter
	Then "1 shown" results are displayed in the Filter panel
	And "ACT Data Collection Packages (1104)" value is displayed for selected Lookup Filter

Examples:
	| PageName |
	| Devices  |
	#| Users    |