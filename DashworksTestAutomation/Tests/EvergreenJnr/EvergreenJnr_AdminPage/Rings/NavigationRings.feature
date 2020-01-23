Feature: NavigationRings
	Navigation

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS12452 @DAS14698
Scenario: EvergreenJnr_AdminPage_CheckNavigationToDevicesListFromProjectsRingsList
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "1803 Rollout" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Rings' left menu item
	Then '1' content is displayed in the 'Devices' column
	When User clicks content from "Devices" column
	Then 'All Devices' list should be displayed to the user
	Then "1" rows are displayed in the agGrid
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "1803: Ring" filter is added to the list
	And Values is displayed in added filter info
	| Values     |
	| Unassigned |
	And Options is displayed in added filter info
	| Values |
	| is     |
	And "(1803: Ring = Unassigned)" text is displayed in filter container

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS14903 @DAS15180
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectPageDisplayedWhenOpeningNotExistingRingDetails
	When User navigates to "1803 Rollout" project details
	When User navigates to the 'Rings' left menu item
	When User enters "Unassigned" text in the Search field for "Ring" column
	When User clicks content from "Ring" column
	Then "Default Ring" checkbox is checked and cannot be unchecked
	When User tries to open same page with non existing item id
	Then Page not found displayed for the user
	Then There are only 'Page not found' errors in console