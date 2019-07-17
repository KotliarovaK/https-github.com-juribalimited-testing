Feature: CapacityPart6
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS15266 @Delete_Newly_Created_Project
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