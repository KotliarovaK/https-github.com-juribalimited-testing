Feature: FiltersFunctionalityPart20
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17557
Scenario: EvergreenJnr_DevicesList_CheckThatSerialNumberToETLComputerAdded
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "Serial Number" filter where type is "Not empty" with added column and following value:
	| Values        |
	And User Add And "Serial Number" filter where type is "Does not equal" with added column and following value:
	| Values        |
	| CET2826853682 |
	And User Add And "Serial Number" filter where type is "Contains" with added column and following value:
	| Values |
	| 034    |
	And User Add And "Serial Number" filter where type is "Does not contain" with added column and following value:
	| Values |
	| 9889   |
	And User Add And "Serial Number" filter where type is "Does not begin with" with added column and following value:
	| Values |
	| davi   |
	And User Add And "Serial Number" filter where type is "Ends with" with added column and following value:
	| Values |
	| 4      |
	| 5      |
	| 8      |
	| 6      |
	And User Add And "Serial Number" filter where type is "Does not end with" with added column and following value:
	| Values |
	| 436    |
	Then "54" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS17715 @Cleanup
Scenario: EvergreenJnr_DevicedList_CheckCustomFieldsUsingInFilterAndProjectCreation
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "ComputerCustomField" filter where type is "Equals" with added column and following value:
	| Values      |
	| 0.606355351 |
	Then "1" rows are displayed in the agGrid
	And There are no errors in the browser console
	When User create dynamic list with "TestList_DAS17715" name on "Devices" page
	Then "TestList_DAS17715" list is displayed to user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Projects' header is displayed to user
	When User enters 'TestProjectFor17715' text to 'Project Name' textbox
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	And There are no errors in the browser console


