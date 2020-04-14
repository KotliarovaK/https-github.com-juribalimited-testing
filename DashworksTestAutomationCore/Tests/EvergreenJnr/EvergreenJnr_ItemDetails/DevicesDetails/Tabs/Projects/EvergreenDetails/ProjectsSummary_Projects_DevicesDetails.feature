Feature: ProjectsSummary_Projects_DevicesDetails
	Runs related tests for Projects > Projects Summary tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI 4/14/20: DAS20672 will be fixed only for 'X_Ray'
@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS20745 @X_Ray
Scenario: EvergreenJnr_DevicesList_ChecksThatToolTipIsDisplayedForExternalLinksOnProjectsSummarySubtab
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Projects Summary' left submenu item
	Then 'Devices Evergreen Capacity Project' tooltip is displayed for 'Devices Evergreen Capacity Project' content in the 'Project' column