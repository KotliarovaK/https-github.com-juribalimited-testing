Feature: Offboard_DevicesPage
	Runs Offboard Devices Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#TODO create API ONBOARDING step;
	#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Devices @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000 @Cleanup @Not_Ready
Scenario: EvergreenJnr_DevicesList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithNoAssotiatedDevicesOnDevicesPage
	When User navigates to the 'Device' details page for '01ONL5I8LY44R3' item
	Then Details page for "01ONL5I8LY44R3" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'OFFBOARD' button 
	Then Dialog Pop-up is displayed for User
	And 'Offboard all associated users' checkbox is checked
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	And User selects state 'true' for 'Offboard all associated users' checkbox
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| ABQ575757        |
	Then " UK\ABQ575757" chip have tooltip with "UK\ABQ575757" text
	When User clicks 'OFFBOARD' button in Dialog Pop-up
	And User clicks 'OFFBOARD' button in Dialog Pop-up
	#going to check the object state
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "USE ME FOR AUTOMATION(DEVICE SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Scope' left menu item
	And User selects "History" tab on the Project details page
	Then '01ONL5I8LY44R3' content is displayed in the 'Item' column
	And 'ABQ575757' content is displayed in the 'Item' column
	And 'ABS188911' content is not displayed in the 'Item' column

	#TODO create API ONBOARDING step;
	#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Devices @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000 @Cleanup @Not_Ready
Scenario: EvergreenJnr_DevicesList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithAssotiatedDevicesOnDevicesPage
	When User navigates to the 'Device' details page for '01ONL5I8LY44R3' item
	Then Details page for "01ONL5I8LY44R3" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'OFFBOARD' button 
	Then Dialog Pop-up is displayed for User
	And 'Offboard all associated users' checkbox is checked
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	When User clicks 'OFFBOARD' button in Dialog Pop-up
	And User clicks 'OFFBOARD' button in Dialog Pop-up 
	#going to check the object state
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "USE ME FOR AUTOMATION(DEVICE SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Scope' left menu item
	And User selects "History" tab on the Project details page
	Then '01ONL5I8LY44R3' content is displayed in the 'Item' column
	And 'ABS188911' content is displayed in the 'Item' column

@Evergreen @Devices @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000
Scenario: EvergreenJnr_DevicesList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithoutUserOnDevicesPage
	When User navigates to the 'Device' details page for '03AK1ZP1C9MPFV' item
	Then Details page for "03AK1ZP1C9MPFV" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'OFFBOARD' button 
	Then Dialog Pop-up is displayed for User
	And following text 'Offboarding device 03AK1ZP1C9MPFV. Offboarding an object deletes all project related information about it.' is displayed in Dialog Pop-up

#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Devices @EvergreenJnr_ItemDetails @Offboard @DAS17912 @Cleanup @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatGreenBannerIsNotVisibleOnTheOtherPagesAfterTheObjectWasSuccessfullyQueuedForTheOffboarding
	When User navigates to the 'Device' details page for '03AK1ZP1C9MPFV' item
	Then Details page for "03AK1ZP1C9MPFV" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'OFFBOARD' button 
	And User clicks 'OFFBOARD' button in Dialog Pop-up 
	And User clicks 'OFFBOARD' button in Dialog Pop-up 
	Then Success message is displayed and contains "The device was successfully queued for offboarding from USE ME FOR AUTOMATION(DEVICE SCHDLD)" text
	When User navigates to the "Projects Summary" sub-menu on the Details page
	Then Success message is not displayed

@Evergreen @Devices @EvergreenJnr_ItemDetails @Offboard @DAS18036
Scenario: EvergreenJnr_DevicesList_CheckThatAddingAndRemovingColumnsInPopUpWorksCorrectly
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks 'OFFBOARD' button 
	Then Dialog Pop-up is displayed for User
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	And User selects state 'true' for 'Offboard all associated users' checkbox
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	And User selects state 'false' for 'Offboard all associated users' checkbox
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	When User have opened Column Settings for "Owner" column
	And User clicks Column button on the Column Settings panel
	And User select "Username" checkbox on the Column Settings panel
	And User select "Display Name" checkbox on the Column Settings panel
	And User select "Domain" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Owner        |
	When User have opened Column Settings for "Owner" column
	And User clicks Column button on the Column Settings panel
	And User select "Domain" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Domain       |
	| Owner        |
	When User have opened Column Settings for "Owner" column
	And User clicks Column button on the Column Settings panel
	And User select "Username" checkbox on the Column Settings panel
	And User select "Display Name" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |