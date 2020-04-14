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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS20214 @X_Ray
Scenario: EvergreenJnr_DevicesList_ChecksThatThePopupForChangingTheOwnerOnProjectDetailsTabIsDisplayedCorrectly
	When User navigates to the 'Device' details page for '00CWZRC4UK6W20' item
	Then Details page for '00CWZRC4UK6W20' item is displayed to the user
	When User selects 'Devices Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Project Details' field
	When User clicks on edit button for 'Device Owner' field
	Then 'UPDATE' button is disabled on popup
	Then 'Retain the existing owner as a user of this device' checkbox is disabled
	When User selects 'UK\ACG370114 (5539) - James N. Snow' option from 'User' autocomplete
	Then "Retain the existing owner as a user of this device" checkbox is not disabled
	Then 'Retain the existing owner as a user of this device' checkbox is checked
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner will be changed to James N. Snow' text is displayed on inline tip banner
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner successfully updated to James N. Snow' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title        | Value         |
	| Device Owner | James N. Snow |