Feature: Offboard_UsersPage
	Runs Offboard Users Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000 @Cleanup @Not_Ready
Scenario: EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithNoAssotiatedDevicesOnUsersPage
	When User navigates to the 'User' details page for '01F6D54271D74F1BB8D' item
	#When User clicks "Users" on the left-hand menu
	#Then "All Users" list should be displayed to the user
	#When User perform search by "01F6D54271D74F1BB8D"
	#And User click content from "Username" column
	Then Details page for "01F6D54271D74F1BB8D" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Dialog Pop-up is displayed on the Item Details page
	Then following text 'Offboarding user BCLABS\01F6D54271D74F1BB8D (McGinley, Marilyn). Select any associated mailboxes below to offboard at the same time. Offboarding an object deletes all project related information about it.' is displayed in Dialog Pop-up
	Then 'Offboard all associated users' checkbox is checked in Dialog Pop-up
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Hostname     |
	| Owner        |
	Then User clicks 'Offboard all associated users' checkbox in Dialog Pop-up
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 02X387UQLFP3ISU  |
	Then "02X387UQLFP3ISU" chip have tooltip with "02X387UQLFP3ISU" text
	When User clicks the "OFFBOARD" Action button
	When User clicks the "OFFBOARD" Action button
	#going to check the object state
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "USE ME FOR AUTOMATION(USR SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User navigates to the 'Scope' left menu item
	And User selects "History" tab on the Project details page
	Then "01F6D54271D74F1BB8D" content is displayed in "Item" column
	Then "02X387UQLFP3ISU" content is displayed in "Item" column
	Then '02UXAL8OAR3K1O' content is not displayed in the 'Item' column

@Evergreen @Users @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000 @Cleanup @Not_Ready
Scenario: EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithAssotiatedDevicesOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "All Users" list should be displayed to the user
	When User perform search by "01F6D54271D74F1BB8D"
	And User click content from "Username" column
	Then Details page for "01F6D54271D74F1BB8D" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Dialog Pop-up is displayed on the Item Details page
	Then following text 'Offboarding user BCLABS\01F6D54271D74F1BB8D (McGinley, Marilyn). Select any associated mailboxes below to offboard at the same time. Offboarding an object deletes all project related information about it.' is displayed in Dialog Pop-up
	Then 'Offboard all associated users' checkbox is checked in Dialog Pop-up
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Hostname     |
	| Owner        |
	When User clicks the "OFFBOARD" Action button
	When User clicks the "OFFBOARD" Action button
	#going to check the object state
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "USE ME FOR AUTOMATION(USR SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User navigates to the 'Scope' left menu item
	And User selects "History" tab on the Project details page
	Then '01F6D54271D74F1BB8D' content is displayed in the 'Item' column
	Then '02X387UQLFP3ISU' content is displayed in the 'Item' column

@Evergreen @Users @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000
Scenario: EvergreenJnr_UsersList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithoutUserOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "All Users" list should be displayed to the user
	When User perform search by "0088FC8A50DD4344B92"
	And User click content from "Username" column
	Then Details page for "0088FC8A50DD4344B92" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Dialog Pop-up is displayed on the Item Details page
	And following text 'Offboarding user BCLABS\0088FC8A50DD4344B92 (Barland, Steinar). Offboarding an object deletes all project related information about it.' is displayed in Dialog Pop-up