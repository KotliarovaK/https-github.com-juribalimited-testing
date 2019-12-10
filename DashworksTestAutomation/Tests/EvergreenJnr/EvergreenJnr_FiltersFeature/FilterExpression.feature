Feature: FilterExpression
	Runs Filter Expression related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Evergreen_FiltersFeature @DAS17016
Scenario: EvergreenJnr_DevicesPage_CheckThatFilterExpressionCanBeSelected
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "Equals" with added column and following value:
	| Values         |
	| 00I0COBFWHOF27 |
	When User clicks Filter Expression icon in Filter Panel
	Then Filter Expression displayed within Filter Panel
	When User double clicks Filter Expression text
	Then '00I0COBFWHOF27' text is highlighted