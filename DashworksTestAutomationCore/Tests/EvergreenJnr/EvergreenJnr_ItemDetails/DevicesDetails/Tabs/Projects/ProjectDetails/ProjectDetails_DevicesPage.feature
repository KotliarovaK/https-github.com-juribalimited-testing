﻿Feature: ProjectDetails_DevicesPage
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
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Device Owner' field
	Then 'UPDATE' button is disabled on popup
	Then 'Retain the existing owner as a user of this device' checkbox is disabled
	When User enters 'Austin O. Ball' in the 'User' autocomplete field and selects 'US-W\ADL183503 (19831) - Austin O. Ball' value
	Then "Retain the existing owner as a user of this device" checkbox is not disabled
	Then 'Retain the existing owner as a user of this device' checkbox is checked
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner will be changed to Austin O. Ball' text is displayed on inline tip banner
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner successfully updated to Austin O. Ball' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title        | Value          |
	| Device Owner | Austin O. Ball |
	When User clicks on edit button for 'Device Owner' field
	When User enters 'Felicienne Vadnais' in the 'User' autocomplete field and selects 'FR\AAV4528222 (6) - Felicienne Vadnais' value
	When User clicks 'UPDATE' button on popup
	When User clicks 'UPDATE' button on popup
	Then following content is displayed on the Details Page
	| Title        | Value              |
	| Device Owner | Felicienne Vadnais |
	When User navigates to the 'Users' left menu item
	When User enters "Austin O. Ball" text in the Search field for "Display Name" column
	Then 'Austin O. Ball' content is displayed in the 'Display Name' column
	When User enters "Felicienne Vadnais" text in the Search field for "Display Name" column
	Then 'Felicienne Vadnais' content is displayed in the 'Display Name' column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS20214 @X_Ray
Scenario: EvergreenJnr_DevicesList_ChecksThatThePopupForChangingTheOwnerOnProjectDetailsTabIsDisplayedCorrectlyWithSelectedCheckbox
	When User navigates to the 'Device' details page for '01N3Y2GUS6XTK7' item
	Then Details page for '01N3Y2GUS6XTK7' item is displayed to the user
	When User selects 'Devices Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Device Owner' field
	Then 'UPDATE' button is disabled on popup
	Then 'Retain the existing owner as a user of this device' checkbox is disabled
	When User enters 'Snow' in the 'User' autocomplete field and selects 'UK\ACG370114 (5539) - James N. Snow' value
	Then "Retain the existing owner as a user of this device" checkbox is not disabled
	Then 'Retain the existing owner as a user of this device' checkbox is checked
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner will be changed to James N. Snow' text is displayed on inline tip banner
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner successfully updated to James N. Snow' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title        | Value         |
	| Device Owner | James N. Snow |
	When User clicks on edit button for 'Device Owner' field
	When User enters 'Mc Millan' in the 'User' autocomplete field and selects 'UK\ACD252468 (15419) - Nicolas O. Mc Millan' value
	When User unchecks 'Retain the existing owner as a user of this device' checkbox
	When User clicks 'UPDATE' button on popup
	When User clicks 'UPDATE' button on popup
	Then following content is displayed on the Details Page
	| Title        | Value                |
	| Device Owner | Nicolas O. Mc Millan |
	When User navigates to the 'Users' left menu item
	Then 'James N. Snow' content is not displayed in the 'Display Name' column
	When User enters "Nicolas O. Mc Millan" text in the Search field for "Display Name" column
	Then 'Nicolas O. Mc Millan' content is displayed in the 'Display Name' column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS20214 @Cleanup @X_Ray
Scenario: EvergreenJnr_DevicesList_ChecksthatThePermissionForProjectComputerObjectEditorRoleIsWorkingCorrectlyForTheOwnerField
	When User create new User via API
	| Username       | Email | FullName | Password  | Roles                          |
	| UserDAS20214_1 | Value | DAS20214 | m!gration | Project Computer Object Editor |
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username       | Password  |
 	| UserDAS20214_1 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
		#Devices
	When User navigates to the 'Device' details page for the item with '1703' ID
	Then Details page for 'CDBR7TV3Y9T2ITS' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Device Owner' field
		#Applications
	When User navigates to the 'Application' details page for the item with '966' ID
	Then Details page for 'ActiveCGM Browser Netscape Plugin V6P07' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then button for editing the 'App Owner' field is not displayed
		#Mailboxes
	When User navigates to the 'Mailbox' details page for the item with '44237' ID
	Then Details page for '02BE025D56CF4899889@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Mailbox Owner' field is not displayed

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS20214 @Cleanup @X_Ray
Scenario: EvergreenJnr_MailboxesList_ChecksthatThePermissionForProjectMailboxObjectEditorRoleIsWorkingCorrectlyForTheOwnerField
	When User create new User via API
	| Username       | Email | FullName | Password  | Roles                         |
	| UserDAS20214_2 | Value | DAS20214 | m!gration | Project Mailbox Object Editor |
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username       | Password  |
 	| UserDAS20214_2 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
		#Devices
	When User navigates to the 'Device' details page for the item with '1703' ID
	Then Details page for 'CDBR7TV3Y9T2ITS' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Device Owner' field is not displayed
		#Applications
	When User navigates to the 'Application' details page for the item with '966' ID
	Then Details page for 'ActiveCGM Browser Netscape Plugin V6P07' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then button for editing the 'App Owner' field is not displayed
		#Mailboxes
	When User navigates to the 'Mailbox' details page for the item with '44237' ID
	Then Details page for '02BE025D56CF4899889@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Mailbox Owner' field

@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS20214 @Cleanup @X_Ray
Scenario: EvergreenJnr_ApplicationList_ChecksthatThePermissionForProjectApplicationObjectEditorRoleIsWorkingCorrectlyForTheOwnerField
	When User create new User via API
	| Username       | Email | FullName | Password  | Roles                             |
	| UserDAS20214_3 | Value | DAS20214 | m!gration | Project Application Object Editor |
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username       | Password  |
 	| UserDAS20214_3 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
		#Devices
	When User navigates to the 'Device' details page for the item with '1703' ID
	Then Details page for 'CDBR7TV3Y9T2ITS' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Device Owner' field is not displayed
		#Applications
	When User navigates to the 'Application' details page for the item with '966' ID
	Then Details page for 'ActiveCGM Browser Netscape Plugin V6P07' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'App Owner' field
		#Mailboxes
	When User navigates to the 'Mailbox' details page for the item with '44237' ID
	Then Details page for '02BE025D56CF4899889@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Mailbox Owner' field is not displayed