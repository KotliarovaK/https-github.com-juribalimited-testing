Feature: DevicesDetails_Projects_ProjectsSummary
	Runs related tests for Projects > Projects Summary tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16117 @DAS16222 @DAS16309
Scenario: EvergreenJnr_DevicesList_CheckThatReadinessValuesInDdlOnProjectsTabAreDisplayedCorrectly
	When User navigates to the 'Device' details page for '0G0WTR5KN85N2X' item
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Projects Summary' left submenu item
	And User opens 'Project' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Project Type" checkbox on the Column Settings panel
	And User select "Path" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User clicks on 'Readiness' column header
	Then color data is sorted by 'Readiness' column in descending order
	When User clicks on 'Readiness' column header
	Then color data is sorted by 'Readiness' column in ascending order
	Then All text is not displayed for "Readiness" column in the String Filter