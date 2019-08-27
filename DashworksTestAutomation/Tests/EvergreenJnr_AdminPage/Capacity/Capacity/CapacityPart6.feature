Feature: CapacityPart6
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS15266 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatEnableCapacityCheckboxIsDisplayedOnTheCapacityDetailsScreen
	When Project created via API and opened
	| ProjectName       | Scope       | ProjectTemplate | Mode               |
	| 15266_TestProject | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	Then "Enable Capacity" checkbox is unchecked on the Admin page
	Then "Enforce capacity on self service pages" checkbox is greyed out on the Admin page
	Then "Enforce capacity on project object page" checkbox is greyed out on the Admin page
	When User clicks "Enable Capacity" checkbox on the Project details page
	Then "Enable Capacity" checkbox is checked on the Admin page
	Then "Enforce capacity on self service pages" checkbox is unchecked on the Admin page
	Then "Enforce capacity on project object page" checkbox is unchecked on the Admin page
	When User clicks "Enforce capacity on self service pages" checkbox on the Project details page
	Then "Enforce capacity on self service pages" checkbox is checked on the Admin page
	When User clicks "Enable Capacity" checkbox on the Project details page
	Then "Enable Capacity" checkbox is unchecked on the Admin page
	Then "Enforce capacity on self service pages" checkbox is greyed out on the Admin page
	Then "Enforce capacity on project object page" checkbox is greyed out on the Admin page
	When User clicks "Enable Capacity" checkbox on the Project details page
	When User clicks "Enforce capacity on project object page" checkbox on the Project details page
	When User clicks "Enable Capacity" checkbox on the Project details page
	Then "Enable Capacity" checkbox is unchecked on the Admin page
	Then "Enforce capacity on self service pages" checkbox is greyed out on the Admin page
	Then "Enforce capacity on project object page" checkbox is greyed out on the Admin page
	When User clicks "Enable Capacity" checkbox on the Project details page
	When User clicks "Enforce capacity on project object page" checkbox on the Project details page
	When User clicks "Enforce capacity on self service pages" checkbox on the Project details page
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS15585
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageAboutUnconfirmedChangesAppears
	When User navigates to "1803 Rollout" project details
	And User clicks "Capacity" tab
	And User clicks "Enable Capacity" checkbox on the Project details page
	And User selects "Units" tab on the Project details page
	Then "You have unsaved changes. Are you sure you want to leave the page?" text is displayed in the warning message
	Then "YES" button is displayed in the warning message
	Then "NO" button is displayed in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS17409 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_ChecksThatWhenValueIsZeroThenBlankShouldBeDisplayed
	When User navigates to "1803 Rollout" project details
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User enters "Evergreen Capacity Unit 3" text in the Search field for "Capacity Unit" column
	Then "" content is displayed in "Devices" column
	And "" content is displayed in "Users" column
	And "" tooltip displayed in "Slots" column
	And "" tooltip displayed in "Devices" column
	And "" tooltip displayed in "Users" column
	When User enters "Birmingham" text in the Search field for "Capacity Unit" column
	Then "" content is displayed in "Applications" column
	And "2" content is displayed in "Slots" column
	And "2" tooltip displayed in "Slots" column
	When User clicks content from "Slots" column
	Then URL contains "/capacity/slots/:Birmingham"
	And "Capacity Slot" column content is displayed in the following order:
	| Items                |
	| Birmingham Morning   |
	| Birmingham Afternoon |