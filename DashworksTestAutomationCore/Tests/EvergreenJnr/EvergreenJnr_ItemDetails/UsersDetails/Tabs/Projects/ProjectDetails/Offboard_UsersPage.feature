Feature: Offboard_UsersPage
	Runs Offboard Users Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#TODO create API ONBOARDING step;
	#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Users @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000 @Cleanup @Not_Ready
Scenario: EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithNoAssotiatedDevicesOnUsersPage
	When User navigates to the 'User' details page for '01F6D54271D74F1BB8D' item
	Then Details page for '01F6D54271D74F1BB8D' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	Then select all rows checkbox is checked
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Hostname     |
	| Owned        |
	When User deselect all rows on the grid
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 02X387UQLFP3ISU  |
	When User clicks 'OFFBOARD' button on popup
	And User clicks 'OFFBOARD' button on popup
	#going to check the object state
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "USE ME FOR AUTOMATION(USR SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'History' left menu item
	Then '01F6D54271D74F1BB8D' content is displayed in the 'Item' column
	And '02X387UQLFP3ISU' content is displayed in the 'Item' column
	And '03AK1ZP1C9MPFV' content is not displayed in the 'Item' column

	#TODO create API ONBOARDING step;
	#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Users @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000 @Cleanup @Not_Ready
Scenario: EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithAssotiatedDevicesOnUsersPage
	When User navigates to the 'User' details page for '01F6D54271D74F1BB8D' item
	Then Details page for '01F6D54271D74F1BB8D' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	Then select all rows checkbox is checked
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Hostname     |
	| Owned        |
	When User clicks 'OFFBOARD' button on popup
	And User clicks 'OFFBOARD' button on popup
	#going to check the object state
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "USE ME FOR AUTOMATION(USR SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'History' left menu item
	Then '01F6D54271D74F1BB8D' content is displayed in the 'Item' column
	And '02X387UQLFP3ISU' content is displayed in the 'Item' column

@Evergreen @Users @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000
Scenario: EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithoutUserOnUsersPage
	When User navigates to the 'User' details page for '0088FC8A50DD4344B92' item
	Then Details page for '0088FC8A50DD4344B92' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	And 'Offboarding user BCLABS\0088FC8A50DD4344B92 (Barland, Steinar). Offboarding an object deletes all project related information about it.' text is displayed on popup

@Evergreen @Users @EvergreenJnr_ItemDetails @Offboard @DAS18036 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatAddingAndRemovingColumnsInPopUpWorksCorrectly
	When User navigates to the 'User' details page for '0137C8E69921432992B' item
	Then Details page for '0137C8E69921432992B' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	And following columns are displayed on the Item details page:
	| ColumnName         |
	| Email Address      |
	| Owner Display Name |
	| Owned              |
	| Bucket             |
	When User deselect all rows on the grid
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Email Address      |
	| Owner Display Name |
	| Owned              |
	| Bucket             |
	When User selects all rows on the grid
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Email Address      |
	| Owner Display Name |
	| Owned              |
	| Bucket             |
	When User clicks following checkboxes from Column Settings panel for the 'Owned' column:
	| checkboxes         |
	| Email Address      |
	| Owner Display Name |
	Then following columns are displayed on the Item details page:
	| ColumnName |
	| Owned      |
	| Bucket     |
	When User clicks following checkboxes from Column Settings panel for the 'Owned' column:
	| checkboxes         |
	| Owner Display Name |
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Owner Display Name |
	| Owned              |
	| Bucket             |
	When User clicks following checkboxes from Column Settings panel for the 'Owned' column:
	| checkboxes    |
	| Email Address |
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Email Address      |
	| Owner Display Name |
	| Owned              |
	| Bucket             |