Feature: Offboard_MailboxesPage
	Runs Offboard Mailboxes Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#TODO create API ONBOARDING step;
	#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000 @Cleanup @Not_Ready
Scenario: EvergreenJnr_MailboxesList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithNoAssotiatedDevicesOnMailboxesPage
	When User navigates to the 'Mailbox' details page for '01DEAC5F18B34084B04@bclabs.local' item
	Then Details page for '01DEAC5F18B34084B04@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
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
	| SelectedRowsName    |
	| 01DEAC5F18B34084B04 |
	When User clicks 'OFFBOARD' button on popup
	And User clicks 'OFFBOARD' button on popup
	#going to check the object state
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "USE ME FOR AUTOMATION(MAIL SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'History' left menu item
	Then '01DEAC5F18B34084B04@bclabs.local' content is displayed in the 'Item' column
	And '01DEAC5F18B34084B04' content is displayed in the 'Item' column
	And 'svc_dashworks' content is not displayed in the 'Item' column

	#TODO create API ONBOARDING step;
	#tag 'not_rady' added because need to create Cleanup (DAS-18070)
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000 @DAS18067 @Cleanup @Not_Ready
Scenario: EvergreenJnr_MailboxesList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithAssotiatedDevicesOnPageMailboxes
	When User navigates to the 'Mailbox' details page for '01DEAC5F18B34084B04@bclabs.local' item
	Then Details page for '01DEAC5F18B34084B04@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
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
	Then 'The selected objects were successfully queued for offboarding from USE ME FOR AUTOMATION(MAIL SCHDLD)' text is displayed on inline success banner
	#going to check the object state
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "USE ME FOR AUTOMATION(MAIL SCHDLD)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'History' left menu item
	Then '01DEAC5F18B34084B04@bclabs.local' content is displayed in the 'Item' column
	And '01DEAC5F18B34084B04' content is displayed in the 'Item' column

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Offboard @DAS17964 @DAS17990 @DAS17000
Scenario: EvergreenJnr_MailboxesList_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindowWithoutUserOnMailboxesPage
	When User navigates to the 'Mailbox' details page for 'alex.cristea@juriba.com' item
	Then Details page for 'alex.cristea@juriba.com' item is displayed to the user
	When User selects 'Email Migration' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	Then 'Offboarding mailbox alex.cristea@juriba.com (Alex Cristea). Offboarding an object deletes all project related information about it.' text is displayed on popup

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Offboard @DAS18785
Scenario: EvergreenJnr_MailboxesList_CheckThatLinkOnTheOffboardPopupForTheAssociatedUserRedirectsCorrectly
	When User navigates to the 'Mailbox' details page for '0286449FB2C34A12809@bclabs.local' item
	Then Details page for '0286449FB2C34A12809@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	And User clicks 'OFFBOARD' button 
	Then popup is displayed to User
	When User clicks "0286449FB2C34A12809" link on the Details Page
	Then Details page for '0286449FB2C34A12809 (McFadden, Susan)' item is displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @Offboard @DAS19175 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_CheckThatAddingAndRemovingColumnsInPopUpWorksCorrectly
	When User navigates to the 'Mailbox' details page for '0141713E5CF84ADE907@bclabs.local' item
	Then Details page for '0141713E5CF84ADE907@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
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