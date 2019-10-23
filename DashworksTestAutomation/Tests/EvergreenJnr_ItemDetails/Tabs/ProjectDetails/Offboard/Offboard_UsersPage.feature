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
	Then Details page for "01F6D54271D74F1BB8D" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then Dialog Pop-up is displayed for User
	And 'Offboard all associated devices' checkbox is checked
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Hostname     |
	| Owned        |
	And User selects state 'true' for 'Offboard all associated devices' checkbox
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 02X387UQLFP3ISU  |
	Then " 02X387UQLFP3ISU" chip have tooltip with "02X387UQLFP3ISU" text
	When User clicks 'OFFBOARD' button in Dialog Pop-up
	And User clicks 'OFFBOARD' button in Dialog Pop-up
	#going to check the object state
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "USE ME FOR AUTOMATION(USR SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'History' left menu item
	Then "01F6D54271D74F1BB8D" content is displayed in "Item" column
	And "02X387UQLFP3ISU" content is displayed in "Item" column
	And '03AK1ZP1C9MPFV' content is not displayed in the 'Item' column

	#TODO create API ONBOARDING step;
	#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Users @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000 @Cleanup @Not_Ready
Scenario: EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithAssotiatedDevicesOnUsersPage
	When User navigates to the 'User' details page for '01F6D54271D74F1BB8D' item
	Then Details page for "01F6D54271D74F1BB8D" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then Dialog Pop-up is displayed for User
	And 'Offboard all associated devices' checkbox is checked
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Hostname     |
	| Owned        |
	When User clicks 'OFFBOARD' button in Dialog Pop-up
	And User clicks 'OFFBOARD' button in Dialog Pop-up
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
	Then Details page for "0088FC8A50DD4344B92" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then Dialog Pop-up is displayed for User
	And following text 'Offboarding user BCLABS\0088FC8A50DD4344B92 (Barland, Steinar). Offboarding an object deletes all project related information about it.' is displayed in Dialog Pop-up