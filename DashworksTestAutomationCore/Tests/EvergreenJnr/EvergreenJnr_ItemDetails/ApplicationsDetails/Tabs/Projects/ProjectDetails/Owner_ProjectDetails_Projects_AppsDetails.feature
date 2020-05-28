Feature: Owner_ProjectDetails_Projects_AppsDetails
	Runs tests for Owner field on Project Details tab for Apps Details Page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user
	
	#AnnI 2/21/20: need to add 'Cleanup' for Owner field;
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20214 @Cleanup
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

	#AnnI 5/20/20: This functionality ready only for 'Yellow_Dwarf'
	#AnnI 2/21/20: need to add 'Cleanup' for Owner field;
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20257 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_ApplicationsList_CheckThatTheRadioButtonForRemovingOwnerIsWorkingCorrectly
	#with owner
	When User navigates to the 'Application' details page for the item with '435' ID
	Then Details page for 'AP00159 - Oracle Jinitiator 1.1.8.16' item is displayed to the user
	When User selects 'Barry's User Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'App Owner' field
	Then 'UPDATE' button is disabled on popup
	When User enters '111' in the 'User' autocomplete field and selects 'DEV50\boldingg (31113) - Gary E. Bolding' value
	Then 'DEV50\boldingg (31113) - Gary E. Bolding' content is displayed in 'User' autocomplete
	Then 'UPDATE' button is not disabled on popup
	When User checks 'Remove owner' radio button
	Then '' content is displayed in 'User' autocomplete
	Then 'UPDATE' button is not disabled on popup
	#without owner
	When User navigates to the 'Application' details page for the item with '14' ID
	Then Details page for 'Mindreef SOAPscope 4.0' item is displayed to the user
	When User selects 'Computer Scheduled Test (Jo)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'App Owner' field
	Then 'UPDATE' button is disabled on popup
	Then 'Remove owner' radio button is disabled

	#AnnI 5/20/20: This functionality ready only for 'Yellow_Dwarf'
	#AnnI 2/21/20: need to add 'Cleanup' for Owner field;
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectDetailsTab @OwnerField @DAS20257 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_ApplicationsList_CheckThatRemovingOwnerIsWorkingCorrectlyOnAppsDetailsPage
	When User navigates to the 'Application' details page for the item with '823' ID
	Then Details page for 'Add-ons' item is displayed to the user
	When User selects 'Barry's User Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
		#S1
	Then following content is displayed on the Details Page
	| Title     | Value        |
	| App Owner | Jack I. Bean |
	When User clicks on edit button for 'App Owner' field
	When User checks 'Remove owner' radio button
	When User clicks 'UPDATE' button on popup
	Then 'Application Owner will be removed' text is displayed on inline tip banner
	When User clicks 'UPDATE' button on popup
	Then 'Application Owner successfully removed' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title     | Value |
	| App Owner |       |
	When User clicks 'RESYNC' button
	When User clicks 'RESYNC' button on popup
	Then following content is displayed on the Details Page
	| Title     | Value        |
	| App Owner | Jack I. Bean |