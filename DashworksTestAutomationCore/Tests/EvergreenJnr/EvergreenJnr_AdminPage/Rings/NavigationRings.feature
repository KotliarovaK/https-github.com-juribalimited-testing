Feature: NavigationRings
	Navigation

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS12452 @DAS14698
Scenario: EvergreenJnr_AdminPage_CheckNavigationToDevicesListFromProjectsRingsList
	When User navigates to "2004 Rollout" project details
	When User navigates to the 'Rings' left menu item
	When User clicks content from "Devices" column
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "2004: Ring" filter is added to the list
	Then Values is displayed in added filter info
	| Values     |
	| Unassigned |
	Then Options is displayed in added filter info
	| Values |
	| is     |
	Then "(2004: Ring = Unassigned)" text is displayed in filter container

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS14903 @DAS15180
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectPageDisplayedWhenOpeningNotExistingRingDetails
	When User navigates to "2004 Rollout" project details
	When User navigates to the 'Rings' left menu item
	When User enters "Unassigned" text in the Search field for "Ring" column
	When User clicks content from "Ring" column
	Then "Default Ring" checkbox is checked and cannot be unchecked
	When User tries to open same page with non existing item id
	Then Page not found displayed for the user
	Then There are only 'Page not found' errors in console

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS20159
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectPageDisplayedWhenAfterClickingGridValue
	When User navigates to "Mailbox Evergreen Capacity Project" project details
	When User navigates to the 'Rings' left menu item
	When User enters "Unassigned" text in the Search field for "Ring" column
	When User clicks content from "Mailboxes" column
	Then 'All Mailboxes' list should be displayed to the user