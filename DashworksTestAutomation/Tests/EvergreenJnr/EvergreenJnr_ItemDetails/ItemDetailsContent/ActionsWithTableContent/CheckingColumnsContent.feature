Feature: CheckingColumnsContent
	Runs Item Details Checking Columns Content related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS11479 @DAS12321 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_CheckThatLinksAndImageItemAreDisplayedInTheNameAndDisplayNameColumns
	When User navigates to the 'Mailbox' details page for '00C8BC63E7424A6E862@bclabs.local' item
	Then Details page for '00C8BC63E7424A6E862@bclabs.local' item is displayed to the user
	When User navigates to the 'Users' left menu item
	And User navigates to the 'Mailbox Permissions' left submenu item
	Then "100" rows found label displays on Details Page
	And Image item from "Name" column is displayed to the user
	And Links from "Name" column is displayed to the user on the Details Page
	And Links from "Display Name" column is displayed to the user on the Details Page

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17094
Scenario: EvergreenJnr_AllLists_CheckThatDataAboutUsersDevicesOnUsersMailboxObjectsWithSnrMatch
	When User navigates to the 'User' details page for 'AAD1011948' item
	Then Details page for 'AAD1011948' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Devices' left menu item
	Then '001BAQXT6JWFPI' content is displayed in the 'Hostname' column
	#=====================================================================================#
	When User navigates to the 'Mailbox' details page for '00A5B910A1004CF5AC4@bclabs.local' item
	Then Details page for '00A5B910A1004CF5AC4@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Users' left menu item
	Then '00A5B910A1004CF5AC4' content is displayed in the 'Username' column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16860 @DAS20468 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_ChecksThatLinksFromTheDeviceColumnInDeviceProjectSummaryOnDevicesPageGoingToSenior
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Projects Summary' left submenu item
	And User clicks "Computer Scheduled Test (Jo)" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Computer: 001BAQXT6JWFPI" object is displayed to the user
	And User click back button in the browser
	And Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User opens 'Project' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "33819" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Computer: 001BAQXT6JWFPI" object is displayed to the user
	And User click back button in the browser
	#=====================================================================================#
	And Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Owner Projects Summary' left submenu item
	And User clicks "Computer Scheduled Test (Jo)" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "User: QLL295118 (Nicole P. Braun)" object is displayed to the user
	And User click back button in the browser
	When User opens 'Project' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "34305" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "User: QLL295118 (Nicole P. Braun)" object is displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16860 @DAS20468 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_ChecksThatLinksFromTheDeviceColumnInDeviceProjectSummaryOnUsersPageGoingToSenior
	When User navigates to the 'User' details page for '000F977AC8824FE39B8' item
	Then Details page for '000F977AC8824FE39B8' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'User Projects' left submenu item
	And User clicks "*Project K-Computer Scheduled Project" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "User: 000F977AC8824FE39B8 (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	And Details page for '000F977AC8824FE39B8' item is displayed to the user
	When User opens 'Project' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "61097" link on the Details Page
	#waiting for the switching process to Senior page to be completed
	When User waits for '3' seconds
	Then "Project Object" page is displayed to the user
	And PMObject page for "User: 000F977AC8824FE39B8 (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	#=====================================================================================#
	And Details page for '000F977AC8824FE39B8' item is displayed to the user
	When User navigates to the 'Mailbox Project Summary' left submenu item
	And User clicks "Mailbox Evergreen Capacity Project" link on the Details Page
	#waiting for the switching process to Senior page to be completed
	When User waits for '3' seconds
	Then "Project Object" page is displayed to the user
	And PMObject page for "Mailbox: 000F977AC8824FE39B8@bclabs.local (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	And Details page for '000F977AC8824FE39B8' item is displayed to the user
	When User opens 'Project' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "66461" link on the Details Page
	#waiting for the switching process to Senior page to be completed
	When User waits for '3' seconds
	Then "Project Object" page is displayed to the user
	And PMObject page for "Mailbox: 000F977AC8824FE39B8@bclabs.local (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	#=====================================================================================#
	When User navigates to the 'User' details page for 'QLL295118' item
	Then Details page for 'QLL295118' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Device Project Summary' left submenu item
	And User clicks "Windows 7 Migration (Computer Scheduled Project)" link on the Details Page
	#waiting for the switching process to Senior page to be completed
	When User waits for '3' seconds
	Then "Project Object" page is displayed to the user
	And PMObject page for "Computer: 001BAQXT6JWFPI" object is displayed to the user
	And User click back button in the browser
	And Details page for 'QLL295118' item is displayed to the user
	When User opens 'Project' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "11176" link on the Details Page
	#waiting for the switching process to Senior page to be completed
	When User waits for '3' seconds
	Then "Project Object" page is displayed to the user
	And PMObject page for "Computer: 001BAQXT6JWFPI" object is displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16860 @DAS20468 @Zion_NewGrid
Scenario: EvergreenJnr_ApplicationsList_ChecksThatLinksFromTheDeviceColumnInDeviceProjectSummaryOnApplicationsPageGoingToSenior
	When User navigates to the 'Application' details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item
	Then Details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Projects' left submenu item
	And User clicks "Windows 7 Migration (Computer Scheduled Project)" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Application: "WPF/E" (codename) Community Technology Preview (Feb 2007) (A01)" object is displayed to the user
	And User click back button in the browser
	And Details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item is displayed to the user
	When User opens 'Project' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "17622" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Application: "WPF/E" (codename) Community Technology Preview (Feb 2007) (A01)" object is displayed to the user
	
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16860 @DAS20468 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_ChecksThatLinksFromTheDeviceColumnInDeviceProjectSummaryOnMailboxesPageGoingToSenior
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Mailbox Projects' left submenu item
	And User clicks "Mailbox Evergreen Capacity Project" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Mailbox: 000F977AC8824FE39B8@bclabs.local (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	And Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User opens 'Project' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "66461" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "Mailbox: 000F977AC8824FE39B8@bclabs.local (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	#=====================================================================================#
	And Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User navigates to the 'Mailbox User Projects' left submenu item
	And User clicks "*Project K-Computer Scheduled Project" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "User: 000F977AC8824FE39B8 (Spruill, Shea)" object is displayed to the user
	And User click back button in the browser
	And Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User opens 'Project' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Object ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Object ID  |
	When User clicks "61097" link on the Details Page
	Then "Project Object" page is displayed to the user
	And PMObject page for "User: 000F977AC8824FE39B8 (Spruill, Shea)" object is displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13849 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatNoDuplicatedRowsDisplayInDeviceProjectsGridOnProjectsTabOfParticularDevice
	When User clicks 'Devices' on the left-hand menu
	And User perform search by "00BDM1JUR8IF419"
	And User click content from "Hostname" column
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Projects Summary' left submenu item
	Then All data is unique in the 'Project' column

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17182 @DAS17219 @DAS17254 @DAS17255 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_CheckThatUsersTabIsDisplayedWithCorrectColumnsOnMailboxesDetailsPageForProjectMode
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User navigates to the 'Users' left menu item
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	Then following columns are displayed on the Item details page:
	| ColumnName            |
	| Username              |
	| Display Name          |
	| Readiness             |
	| Owner                 |
	| Domain                |
	| Path                  |
	| Category              |
	| Application Readiness |
	| Stage 1               |
	| Stage 2               |
	| Stage 3               |
	| Stage Z               |
	And "AMBER" content is displayed for "Stage 1" column
	And "RED" content is displayed for "Stage 2" column
	And "GREEN" content is displayed for "Stage 3" column
	And "BLUE" content is displayed for "Stage Z" column
	Then "1" rows found label displays on Details Page
	Then '[Default (User)]' checkbox is checked in the filter dropdown for the 'Path' column

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15039 @DAS18535 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatTheRelatedTabIsDisplayedCorrectlyWithTheCorrectElementsAndColumns
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User selects 'Devices Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Related' left menu item
	When User clicks following checkboxes from Column Settings panel for the 'Owner' column:
	| checkboxes            |
	| Application Readiness |
	Then following columns are displayed on the Item details page:
	| ColumnName            |
	| Device                |
	| Owner                 |
	| Owner Display Name    |
	| Linked By             |
	| Path                  |
	| Category              |
	| Status                |
	| Date                  |
	| Stage 1               |
	| Stage 2               |
	When User enters "03ME2G7TIR4GBN" text in the Search field for "Device" column
	Then Links from "Device" column is displayed to the user on the Details Page
	And Links from "Owner" column is displayed to the user on the Details Page
	And Links from "Owner Display Name" column is displayed to the user on the Details Page
	#link function is not ready yet
	#And Links from "Linked By" column is displayed to the user on the Details Page
	When User clicks "03ME2G7TIR4GBN" link on the Details Page
	Then Details page for '03ME2G7TIR4GBN' item is displayed to the user
	And User click back button in the browser
	And Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Related' left menu item
	And User enters "ACG370114" text in the Search field for "Owner" column
	And User clicks "ACG370114" link on the Details Page
	Then Details page for 'ACG370114 (James N. Snow)' item is displayed to the user
	And User click back button in the browser
	And Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Related' left menu item
	And User enters "James N. Snow" text in the Search field for "Owner Display Name" column
	And User clicks "James N. Snow" link on the Details Page
	Then Details page for 'ACG370114 (James N. Snow)' item is displayed to the user
	And User click back button in the browser
	And Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Related' left menu item
	#link function is not ready yet
	#When User enters "ACG370114" text in the Search field for "Linked By" column
	#When User clicks "ACG370114" link on the Details Page
	#Then Details page for "ACG370114" item is displayed correctly

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16472 @DAS15039 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatIconsForReadinessDdlOnRelatedTabAreDisplayed
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User selects 'Devices Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Related' left menu item
	When User enters "03ME2G7TIR4GBN" text in the Search field for "Device" column
	Then '31 May 2019' content is displayed in the 'Date' column

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17087 @Zion_NewGrid
Scenario: EvergreenJnr_MailboxesList_ChecksThatUsersAreReloadedAfterSelectingAProjectOnTheMailboxDetailsPage
	When User navigates to the 'Mailbox' details page for 'abel.y.hanson@dwlabs.local' item
	Then Details page for 'abel.y.hanson@dwlabs.local' item is displayed to the user
	When User navigates to the 'Users' left menu item
	Then "7" rows found label displays on Details Page
	And 'Administrator' content is displayed in the 'Username' column
	When User selects 'Email Migration' in the 'Item Details Project' dropdown with wait
	Then "1" rows found label displays on Details Page
	And 'hansonay' content is displayed in the 'Username' column

@Evergreen @Device @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17734 @DAS17733 @Zion_NewGrid
Scenario: EvergreenJnr_DeviceList_CheckThatUsersTabIsDisplayedWithCorrectStagesOnDevicesDetailsPageForProjectMode
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Users' left menu item
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	Then following columns are displayed on the Item details page:
	| ColumnName                  |
	| User                        |
	| Readiness                   |
	| Display Name                |
	| Domain                      |
	| Owner                       |
	| Path                        |
	| Category                    |
	| Application Readiness       |
	| Stage A                     |
	| Stage C                     |
	| Stage D                     |
	| Stage with (readiness) task |
	#if “stage WITHOUT readiness task” Stage is displayed here, please raise a bug.
	When User enters "AAC860150" text in the Search field for "User" column
	Then "GREEN" content is displayed for "Stage A" column
	And "RED" content is displayed for "Stage C" column
	And "AMBER" content is displayed for "Stage D" column

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18263 @Zion_NewGrid
Scenario: EvergreenJnr_ApplicationsList_CheckThatUnknownValuesAreEmptyOnObjectDetailsInDistributiontab
	When User navigates to the 'Application' details page for '7zip' item
	Then Details page for '7zip' item is displayed to the user
	When User navigates to the 'Distribution' left menu item
	And User navigates to the 'Devices' left submenu item
	Then "" content is displayed for "Owner" column
	Then "" content is displayed for "Owner Display Name" column