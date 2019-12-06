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
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	And 'Offboard all associated users' checkbox is checked
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	When User selects state 'true' for 'Offboard all associated users' checkbox
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| ABQ575757        |
	Then " UK\ABQ575757" chip have tooltip with "UK\ABQ575757" text
	When User clicks 'OFFBOARD' button on popup
	And User clicks 'OFFBOARD' button on popup
	#going to check the object state
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "USE ME FOR AUTOMATION(DEVICE SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'History' left menu item
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
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	And 'Offboard all associated users' checkbox is checked
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	When User clicks 'OFFBOARD' button on popup
	And User clicks 'OFFBOARD' button on popup 
	#going to check the object state
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "USE ME FOR AUTOMATION(DEVICE SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'History' left menu item
	Then '01ONL5I8LY44R3' content is displayed in the 'Item' column
	And 'ABS188911' content is displayed in the 'Item' column

@Evergreen @Devices @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000
Scenario: EvergreenJnr_DevicesList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithoutUserOnDevicesPage
	When User navigates to the 'Device' details page for '03AK1ZP1C9MPFV' item
	Then Details page for "03AK1ZP1C9MPFV" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(USR SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	And 'Offboarding device 03AK1ZP1C9MPFV. Offboarding an object deletes all project related information about it.' text is displayed on popup

#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Devices @EvergreenJnr_ItemDetails @Offboard @DAS17912 @Cleanup @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatGreenBannerIsNotVisibleOnTheOtherPagesAfterTheObjectWasSuccessfullyQueuedForTheOffboarding
	When User navigates to the 'Device' details page for '03AK1ZP1C9MPFV' item
	Then Details page for "03AK1ZP1C9MPFV" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	And User clicks 'OFFBOARD' button on popup 
	And User clicks 'OFFBOARD' button on popup 
	Then 'The device was successfully queued for offboarding from USE ME FOR AUTOMATION(DEVICE SCHDLD)' text is displayed on success inline tip banner
	When User navigates to the 'Projects Summary' left submenu item
	Then Success message is not displayed

@Evergreen @Devices @EvergreenJnr_ItemDetails @Offboard @DAS18036
Scenario: EvergreenJnr_DevicesList_CheckThatAddingAndRemovingColumnsInPopUpWorksCorrectly
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "USE ME FOR AUTOMATION(DEVICE SCHDLD)" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	When User selects state 'true' for 'Offboard all associated users' checkbox
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	When User selects state 'true' for 'Offboard all associated users' checkbox
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	When User opens 'Owner' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Username" checkbox on the Column Settings panel
	And User select "Display Name" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Domain       |
	| Owner        |
	When User opens 'Owner' column settings
	And User select "Display Name" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Display Name |
	| Domain       |
	| Owner        |
	When User opens 'Owner' column settings
	And User select "Username" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |

#tag 'not_rady' added because this bug is fixed only for Spectrum
#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Devices @EvergreenJnr_ItemDetails @Offboard @DAS18026 @Cleanup @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatErrorIsNotDisplayedForAssociatedObjectsOnOffboardingPopUpWhenMainObjectWasAlreadyOffboardedWithAssociatedObjectsFromAnotherTabOrByAnotherUser
	When User navigates to the 'Device' details page for 'M2IMTW2YFVK1KLT' item
	Then Details page for "M2IMTW2YFVK1KLT" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User navigates to "evergreen/#/device/3105/projects/project?$projectId=56" URL in a new tab
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'OFFBOARD' button
	When User clicks 'OFFBOARD' button on popup 
	When User clicks 'OFFBOARD' button on popup 
	When User switches to previous tab
	When User clicks 'OFFBOARD' button
	Then Warning message with "This device has already been offboarded from User Evergreen Capacity Project" text is displayed on the Project Details Page
	Then 'OFFBOARD' button is disabled