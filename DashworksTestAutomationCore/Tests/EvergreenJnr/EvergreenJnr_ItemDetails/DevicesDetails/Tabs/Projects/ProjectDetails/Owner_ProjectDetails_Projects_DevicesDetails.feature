Feature: Owner_ProjectDetails_Projects_DevicesDetails
	Runs tests for Owner field on Project Details tab for Devices Details Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20214 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatThePopupForChangingTheOwnerOnProjectDetailsTabIsDisplayedCorrectly
	When User resync 'Device' objects for 'User Evergreen Capacity Project' project
	| values          |
	| 5L8ROLREPYGEYES |
	When User navigates to the 'Device' details page for '5L8ROLREPYGEYES' item
	Then Details page for '5L8ROLREPYGEYES' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Device Owner' field
	Then 'UPDATE' button is disabled on popup
	Then 'Retain the existing owner as a user of this device' checkbox is disabled
	When User enters '111' in the 'User' autocomplete field and selects 'BCLABS\065A1846F11140798A8 (88763) - Siddu, Arjun' value
	Then 'Retain the existing owner as a user of this device' checkbox is checked
	When User unchecks 'Retain the existing owner as a user of this device' checkbox
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner will be changed to Siddu, Arjun' text is displayed on inline tip banner
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner successfully updated to Siddu, Arjun' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title        | Value        |
	| Device Owner | Siddu, Arjun |
	When User clicks on edit button for 'Device Owner' field
	When User enters '232' in the 'User' autocomplete field and selects 'AU\ADA242322 (27427) - Chad A. Rosario' value
	When User unchecks 'Retain the existing owner as a user of this device' checkbox
	When User clicks 'UPDATE' button on popup
	When User clicks 'UPDATE' button on popup
	Then following content is displayed on the Details Page
	| Title        | Value           |
	| Device Owner | Chad A. Rosario |
	When User navigates to the 'Users' left menu item
	When User enters "Chad A. Rosario" text in the Search field for "Display Name" column
	Then 'Chad A. Rosario' content is displayed in the 'Display Name' column
	When User enters "Percy Guertin" text in the Search field for "Display Name" column
	Then 'Percy Guertin' content is not displayed in the 'Display Name' column
	When User enters "Siddu, Arjun" text in the Search field for "Display Name" column
	Then 'Siddu, Arjun' content is not displayed in the 'Display Name' column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20214 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatThePopupForChangingTheOwnerOnProjectDetailsTabIsDisplayedCorrectlyWithSelectedCheckbox
	When User resync 'Device' objects for 'User Evergreen Capacity Project' project
	| values         |
	| JWTSMWCX0VR4D5 |
	When User navigates to the 'Device' details page for 'JWTSMWCX0VR4D5' item
	Then Details page for 'JWTSMWCX0VR4D5' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title        | Value          |
	| Device Owner | Pamela L. Knox |
	When User clicks on edit button for 'Device Owner' field
	Then 'UPDATE' button is disabled on popup
	Then 'Retain the existing owner as a user of this device' checkbox is disabled
	When User enters '111' in the 'User' autocomplete field and selects 'BCLABS\07EB3DA466FE44408F6 (91114) - Vergara, Margarita' value
	Then 'Retain the existing owner as a user of this device' checkbox is checked
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner will be changed to Vergara, Margarita' text is displayed on inline tip banner
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner successfully updated to Vergara, Margarita' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title        | Value              |
	| Device Owner | Vergara, Margarita |
	When User clicks on edit button for 'Device Owner' field
	When User enters '232' in the 'User' autocomplete field and selects 'BCLABS\2287232EF3CE43D980E (90351) - Brunson, Larry' value
	When User clicks 'UPDATE' button on popup
	When User clicks 'UPDATE' button on popup
	Then following content is displayed on the Details Page
	| Title        | Value          |
	| Device Owner | Brunson, Larry |
	When User navigates to the 'Users' left menu item
	When User enters "Pamela L. Knox" text in the Search field for "Display Name" column
	Then 'Pamela L. Knox' content is displayed in the 'Display Name' column
	When User enters "Vergara, Margarita" text in the Search field for "Display Name" column
	Then 'Vergara, Margarita' content is displayed in the 'Display Name' column
	When User enters "Brunson, Larry" text in the Search field for "Display Name" column
	Then 'Brunson, Larry' content is displayed in the 'Display Name' column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20214 @Cleanup
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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20214 @DAS20839 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatEmptyOwnerFieldOnProjectDetailsTabIsDisplayedCorrectly
	When User resync 'Device' objects for 'User Evergreen Capacity Project' project
	| values          |
	| 0405FHJHVG45U71 |
	When User navigates to the 'Device' details page for the item with '14' ID
	Then Details page for '0405FHJHVG45U71' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title        | Value          |
	| Device Owner | Gaetane Lanoie |
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

	#AnnI 5/20/20: This functionality ready only for 'Yellow_Dwarf'
@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20257 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_DevicesList_CheckThatTheRadioButtonForRemovingOwnerIsWorkingCorrectly
	#with owner
	When User navigates to the 'Device' details page for the item with '1' ID
	Then Details page for '00BDM1JUR8IF419' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Device Owner' field
	Then 'UPDATE' button is disabled on popup
	Then 'Retain the existing owner as a user of this device' checkbox is disabled
	When User enters '111' in the 'User' autocomplete field and selects 'UK\ACI066204 (11114) - Roger M. Turner' value
	Then 'UK\ACI066204 (11114) - Roger M. Turner' content is displayed in 'User' autocomplete
	Then 'UPDATE' button is not disabled on popup
	When User checks 'Remove owner' radio button
	Then '' content is displayed in 'User' autocomplete
	Then 'UPDATE' button is not disabled on popup
	Then 'Retain the existing owner as a user of this device' checkbox is enabled
	#without owner
	When User navigates to the 'Device' details page for the item with '16720' ID
	Then Details page for 'XYQHP376EA8FVM' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Device Owner' field
	Then 'UPDATE' button is disabled on popup
	Then 'Retain the existing owner as a user of this device' checkbox is disabled
	Then 'Remove owner' radio button is disabled

	#AnnI 5/20/20: This functionality ready only for 'Yellow_Dwarf'
@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20257 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_DevicesList_CheckThatRemovingOwnerIsWorkingCorrectlyOnDevicesDetailsPage
	When User resync 'Device' objects for 'Havoc (Big Data)' project
	| values         |
	| NHGXHWZV66RDOW |
	When User navigates to the 'Device' details page for the item with '13414' ID
	Then Details page for 'NHGXHWZV66RDOW' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
		#S1
	Then following content is displayed on the Details Page
	| Title        | Value          |
	| Device Owner | Randi P. Evans |
	When User clicks on edit button for 'Device Owner' field
	When User checks 'Remove owner' radio button
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner will be removed' text is displayed on inline tip banner
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner successfully removed' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title        | Value |
	| Device Owner |       |
	When User navigates to the 'Users' left menu item
	When User enters "HET299182" text in the Search field for "User" column
	Then "HET299182" content is displayed for "User" column
	Then "FALSE" content is displayed for "Owner" column
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'RESYNC' button
	When User clicks 'RESYNC' button on popup
		#S2
	Then following content is displayed on the Details Page
	| Title        | Value          |
	| Device Owner | Randi P. Evans |
	When User clicks on edit button for 'Device Owner' field
	When User checks 'Remove owner' radio button
	When User unchecks 'Retain the existing owner as a user of this device' checkbox
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner will be removed' text is displayed on inline tip banner
	When User clicks 'UPDATE' button on popup
	Then 'Device Owner successfully removed' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title        | Value |
	| Device Owner |       |
	When User navigates to the 'Users' left menu item
	Then 'No users found for this device' message is displayed on empty greed