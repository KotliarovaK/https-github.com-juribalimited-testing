Feature: Owner_ProjectDetails_Projects_DevicesDetails
	Runs tests for Owner field on Project Details tab for Devices Details Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI 4/14/20: DAS20672 will be fixed only for 'X_Ray'
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

#AnnI 4/14/20: DAS20672 will be fixed only for 'X_Ray'
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

#AnnI 4/14/20: DAS20672 will be fixed only for 'X_Ray'
@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS20214 @Cleanup @X_Ray
Scenario: EvergreenJnr_DevicesList_ChecksthatThePermissionForProjectComputerObjectEditorRoleIsWorkingCorrectlyForTheOwnerField
	When User create new User via API
	| Username       | Email | FullName | Password  | Roles                          |
	| UserDAS20214_1 | Value | DAS20214 | m!gration | Project Computer Object Editor |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	When User enters "My Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User navigates to the 'Team Members' left menu item
	When User clicks 'ADD MEMBERS' button
	When User selects following Objects from the expandable multiselect
	| Objects        |
	| UserDAS20214_1 |
	And User clicks 'ADD USERS' button
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

#AnnI 4/14/20: DAS20672 will be fixed only for 'X_Ray'
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS20214 @Cleanup @X_Ray
Scenario: EvergreenJnr_MailboxesList_ChecksthatThePermissionForProjectMailboxObjectEditorRoleIsWorkingCorrectlyForTheOwnerField
	When User create new User via API
	| Username       | Email | FullName | Password  | Roles                         |
	| UserDAS20214_2 | Value | DAS20214 | m!gration | Project Mailbox Object Editor |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	When User enters "My Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User navigates to the 'Team Members' left menu item
	When User clicks 'ADD MEMBERS' button
	When User selects following Objects from the expandable multiselect
	| Objects        |
	| UserDAS20214_2 |
	And User clicks 'ADD USERS' button
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

#AnnI 4/14/20: DAS20672 will be fixed only for 'X_Ray'
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS20214 @Cleanup @X_Ray
Scenario: EvergreenJnr_ApplicationList_ChecksthatThePermissionForProjectApplicationObjectEditorRoleIsWorkingCorrectlyForTheOwnerField
	When User create new User via API
	| Username       | Email | FullName | Password  | Roles                             |
	| UserDAS20214_3 | Value | DAS20214 | m!gration | Project Application Object Editor |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	When User enters "My Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User navigates to the 'Team Members' left menu item
	When User clicks 'ADD MEMBERS' button
	When User selects following Objects from the expandable multiselect
	| Objects        |
	| UserDAS20214_3 |
	And User clicks 'ADD USERS' button
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

#AnnI 4/15/20: DAS20672 will be fixed only for 'X_Ray'
@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS20214 @DAS20839 @X_Ray
Scenario: EvergreenJnr_DevicesList_ChecksThatEmptyOwnerFieldOnProjectDetailsTabIsDisplayedCorrectly
	When User navigates to the 'Device' details page for the item with '14' ID
	Then Details page for '0405FHJHVG45U71' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Device Owner' field
	When User enters 'Jon' in the 'User' autocomplete field and selects 'BCLABS\03C54BC1198843A4A03 (88868) - Jones, Tina' value
	When User clicks 'UPDATE' button on popup
	When User clicks 'UPDATE' button on popup
	Then following content is displayed on the Details Page
	| Title        | Value       |
	| Device Owner | Jones, Tina |
	When User clicks on edit button for 'Device Owner' field
	When User enters '71622' in the 'User' autocomplete field and selects 'UK\Unknown (71622) - Unknown' value
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner will be changed to Unknown' text is displayed on inline tip banner
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner successfully updated to Unknown' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title        | Value |
	| Device Owner | Empty |