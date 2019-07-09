Feature: CheckAllColumnsApi
	Check all columns via API

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_Columns
Scenario: EvergreenJnr_DevicesList_CheckAllColumns 
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
