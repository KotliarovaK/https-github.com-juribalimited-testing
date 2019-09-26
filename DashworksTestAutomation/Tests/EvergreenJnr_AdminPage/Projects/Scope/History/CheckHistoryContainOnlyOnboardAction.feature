Feature: CheckHistoryContainOnlyOnboardAction
	Runs test related to Grid functionality on history page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13959 @Projects
Scenario: EvergreenJnr_AdminPage_CheckHistoryContainOnlyOnboardActionIn1803Rollout
	When User navigates to "1803 Rollout" project details
	And User selects "Scope" tab on the Project details page
	And User selects "History" tab on the Project details page
	Then Counter shows "409" found rows
	When User clicks String Filter button for "Action" column on the Admin page
	Then following String Values are displayed in the filter on the Details Page
	| Values                     |
	| Offboard Device Object     |
	| Onboard Application Object |
	| Onboard Device Object      |
	| Onboard User Object        |
	When User selects "Onboard Application Object" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "Onboard User Object" checkbox from String Filter with item list on the Admin page
	Then Rows counter shows "64" of "409" rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13959 @Projects
Scenario: EvergreenJnr_AdminPage_CheckHistoryContainOnlyOnboardActionInEmailMigration
	When User navigates to "Email Migration" project details
	And User selects "Scope" tab on the Project details page
	And User selects "History" tab on the Project details page
	Then Counter shows "1,527" found rows
	When User clicks String Filter button for "Action" column on the Admin page
	Then following String Values are displayed in the filter on the Details Page
	| Values						|
	| Onboard Application Object	|
	| Onboard Mailbox Object		|
	| Onboard User Object			|
	| Re-onboard Mailbox Object		|
	| Re-onboard User Object        |
	When User selects "Onboard User Object" checkbox from String Filter with item list on the Admin page
	Then Rows counter shows "807" of "1527" rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13959 @Projects
Scenario: EvergreenJnr_AdminPage_CheckHistoryContainOnlyOnboardActionInUserEvergreenCapacityProject
	When User navigates to "User Evergreen Capacity Project" project details
	And User selects "Scope" tab on the Project details page
	And User selects "History" tab on the Project details page
	Then Counter shows "60,371" found rows
	When User clicks String Filter button for "Action" column on the Admin page
	Then following String Values are displayed in the filter on the Details Page
	| Values                     |
	| Offboard Device Object     |
	| Onboard Application Object |
	| Onboard Device Object      |
	| Onboard User Object        |
	When User selects "Onboard Application Object" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "Onboard Device Object" checkbox from String Filter with item list on the Admin page
	Then Rows counter shows "41405" of "60371" rows
