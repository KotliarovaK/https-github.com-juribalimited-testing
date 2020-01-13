Feature: CheckHistoryContainOnlyOnboardAction
	Runs test related to Grid functionality on history page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13959 @Projects
Scenario: EvergreenJnr_AdminPage_CheckHistoryContainOnlyOnboardActionIn1803Rollout
	When User navigates to "1803 Rollout" project details
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'History' left menu item
	Then Counter shows "405" found rows
	Then following checkboxes are displayed in the filter dropdown menu for the 'Action' column:
	| Values                     |
	| Onboard Application Object |
	| Onboard Device Object      |
	| Onboard User Object        |
	When User unchecks following checkboxes in the filter dropdown menu for the 'Action' column:
	| checkboxes                 |
	| Onboard Application Object |
	| Onboard User Object        |
	Then Rows counter shows "60" of "405" rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13959 @Projects
Scenario: EvergreenJnr_AdminPage_CheckHistoryContainOnlyOnboardActionInEmailMigration
	When User navigates to "Email Migration" project details
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'History' left menu item
	Then Counter shows "1,527" found rows
	Then following checkboxes are displayed in the filter dropdown menu for the 'Action' column:
	| Values                     |
	| Onboard Application Object |
	| Onboard Mailbox Object     |
	| Onboard User Object        |
	| Re-onboard Mailbox Object  |
	| Re-onboard User Object     |
	When User unchecks following checkboxes in the filter dropdown menu for the 'Action' column:
	| checkboxes                 |
	| Onboard User Object        |
	Then Rows counter shows "807" of "1,527" rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13959 @Projects
Scenario: EvergreenJnr_AdminPage_CheckHistoryContainOnlyOnboardActionInUserEvergreenCapacityProject
	When User navigates to "User Evergreen Capacity Project" project details
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'History' left menu item
	Then Counter shows "60,306" found rows
	Then following checkboxes are displayed in the filter dropdown menu for the 'Action' column:
	| Values                     |
	| Onboard Application Object |
	| Onboard Device Object      |
	| Onboard User Object        |
	When User unchecks following checkboxes in the filter dropdown menu for the 'Action' column:
	| checkboxes                 |
	| Onboard Application Object |
	| Onboard Device Object      |
	Then Rows counter shows "41,340" of "60,306" rows