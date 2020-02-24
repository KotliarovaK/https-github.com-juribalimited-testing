Feature: ProjectDetails_DevicesPage
	Runs Projec tDetails tests on Devices Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS19884
Scenario: EvergreenJnr_DevicesList_ChecksThatAppOwnerLinkFromProjectDetailsTabForProjectModeRedirectToCorrectTabWithSelectedProject
	When User navigates to the 'Device' details page for 'H9XKR00M5DLCNU' item
	Then Details page for 'H9XKR00M5DLCNU' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks "Ruth S. Douglas" link on the Details Page
	Then Details page for 'WZW872666 (Ruth S. Douglas)' item is displayed to the user
	Then 'User Evergreen Capacity Project' content is displayed in 'Item Details Project' dropdown
	Then 'Details' left menu item is expanded
	Then 'User' left submenu item is active
	Then 'Projects' left menu item is collapsed