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
	Then Details page for '01ONL5I8LY44R3' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	Then select all rows checkbox is checked
	And following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	When User deselect all rows on the grid
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
	Then Details page for '01ONL5I8LY44R3' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	Then select all rows checkbox is checked
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
	Then Details page for '03AK1ZP1C9MPFV' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	And 'Offboarding device 03AK1ZP1C9MPFV. Offboarding an object deletes all project related information about it.' text is displayed on popup

#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Devices @EvergreenJnr_ItemDetails @Offboard @DAS17912 @Cleanup @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatGreenBannerIsNotVisibleOnTheOtherPagesAfterTheObjectWasSuccessfullyQueuedForTheOffboarding
	When User navigates to the 'Device' details page for '03AK1ZP1C9MPFV' item
	Then Details page for '03AK1ZP1C9MPFV' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	And User clicks 'OFFBOARD' button on popup 
	And User clicks 'OFFBOARD' button on popup 
	Then 'The device was successfully queued for offboarding from USE ME FOR AUTOMATION(DEVICE SCHDLD)' text is displayed on inline success banner
	When User navigates to the 'Projects Summary' left submenu item
	Then inline info banner is not displayed
	Then inline success banner is not displayed

@Evergreen @Devices @EvergreenJnr_ItemDetails @Offboard @DAS18036
Scenario: EvergreenJnr_DevicesList_CheckThatAddingAndRemovingColumnsInPopUpWorksCorrectly
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
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
	| Bucket       |
	When User deselect all rows on the grid
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	| Bucket       |
	When User selects all rows on the grid
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	| Bucket       |
	When User clicks following checkboxes from Column Settings panel for the 'Owner' column:
	| checkboxes   |
	| Username     |
	| Display Name |
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Domain       |
	| Owner        |
	| Bucket       |
	When User clicks following checkboxes from Column Settings panel for the 'Owner' column:
	| checkboxes   |
	| Display Name |
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Display Name |
	| Domain       |
	| Owner        |
	| Bucket       |
	When User clicks following checkboxes from Column Settings panel for the 'Owner' column:
	| checkboxes |
	| Username   |
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Username     |
	| Display Name |
	| Domain       |
	| Owner        |
	| Bucket       |

#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Devices @EvergreenJnr_ItemDetails @Offboard @DAS18026 @Cleanup @Not_Ready
Scenario: EvergreenJnr_DevicesList_CheckThatErrorIsNotDisplayedForAssociatedObjectsOnOffboardingPopUpWhenMainObjectWasAlreadyOffboardedWithAssociatedObjectsFromAnotherTabOrByAnotherUser
	When User navigates to the 'Device' details page for 'M2IMTW2YFVK1KLT' item
	Then Details page for 'M2IMTW2YFVK1KLT' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User navigates to 'evergreen/#/device/3105/projects/project?$projectId=56' URL in a new tab
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks 'OFFBOARD' button
	When User clicks 'OFFBOARD' button on popup 
	When User clicks 'OFFBOARD' button on popup 
	When User switches to previous tab
	When User clicks 'OFFBOARD' button
	Then 'This device has been offboarded from User Evergreen Capacity Project' text is displayed on inline tip banner
	Then 'OFFBOARD' button is disabled