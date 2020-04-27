Feature: DevicesDetails_Projects_ProjectsSummary
	Runs related tests for Projects > Projects Summary tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectsSummaryTab @DAS16117 @DAS16222 @DAS16309
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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectsSummaryTab @DAS20496 @X_Ray
Scenario: EvergreenJnr_DevicesList_CheckThatSelectAllCheckboxInTheSelectColumnFilterIsDisplayedCorrectlyOnProjectSummaryTab
	When User navigates to the 'Device' details page for '001PSUMZYOW581' item
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Projects Summary' left submenu item
	When User opens 'Project' column settings
	And User clicks Column button on the Column Settings panel
	Then Select All checkbox have indeterminate checked state
	When User selects all rows on the grid
	Then Select All checkbox have full checked state
	When User deselect all rows on the grid
	Then Select All checkbox have unchecked state
	When User selects all rows on the grid
	Then Select All checkbox have full checked state
	When User select "Key" checkbox on the Column Settings panel
	Then Select All checkbox have indeterminate checked state