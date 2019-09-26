Feature: NavigationRings
	Navigation

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS12452 @DAS14698
Scenario: EvergreenJnr_AdminPage_CheckNavigationToDevicesListFromProjectsRingsList
	When User clicks 'Admin' on the left-hand menu
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "1803 Rollout" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Rings' left menu item
	Then "1" content is displayed in "Devices" column
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
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User navigates to the 'Rings' left menu item
	And User enters "Unassigned" text in the Search field for "Ring" column
	And User clicks content from "Ring" column
	Then "Default Ring" checkbox is checked and cannot be unchecked
	When User tries to open same page with "88888888" item id
	Then Page not found displayed for the user
	And There are only 'Page not found' errors in console