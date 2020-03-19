Feature: CapacityUnit_DevicesPage
	Runs related tests for Capacity Unit fields

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @ProjectDetailsTab @DAS19538 @DAS19463 @Cleanup @Set_Default_Capacity_Unit @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatValueForCapacityUnitIsChangingSuccessfully
	When User creates new Capacity Unit via api
	| Name          | Description | IsDefault | Project          |
	| cu_DAS19538_1 | DAS19538    | false     | Havoc (Big Data) |
	When User navigates to the 'Device' details page for '011PLA470S0B9DJ' item
	Then Details page for '011PLA470S0B9DJ' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	Then 'MOVE' button is disabled on popup
	Then following columns are displayed on the Item details page:
	| ColumnName    |
	| Username      |
	| Display Name  |
	| Domain        |
	| Owner         |
	| Capacity Unit |
	| Bucket        |
	Then 'Move all' checkbox is not displayed
	When User selects 'cu_DAS19538_1' option from 'Capacity Unit' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup
	Then 'The selected objects successfully moved to cu_DAS19538_1' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title         | Value         |
	| Capacity Unit | cu_DAS19538_1 |
	When User navigates to the 'User' details page for the item with '2169' ID
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then following content is displayed on the Details Page
	| Title         | Value         |
	| Capacity Unit | cu_DAS19538_1 |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19538
Scenario: EvergreenJnr_AllLists_CheckThatThePenButtonIsNotDisplayedForCapacityFieldForUserWithSpecificAccess
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username       | Password |
 	| TestBucketAuto | 123456   |
	Then Evergreen Dashboards page should be displayed to the user
		#--Devices--#
	When User navigates to the 'Device' details page for '011PLA470S0B9DJ' item
	Then Details page for '011PLA470S0B9DJ' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Capacity Unit' field is not displayed
		#--Users--#
	When User navigates to the 'User' details page for 'IHA8903150' item
	Then Details page for 'IHA8903150' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Capacity Unit' field is not displayed
		#--Applications--#
	When User navigates to the 'Application' details page for '20040610sqlserverck' item
	Then Details page for '20040610sqlserverck' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Capacity Unit' field is not displayed
		#--Mailboxes--#
	When User navigates to the 'Mailbox' details page for '013DA2178AB4444CAF2@bclabs.local' item
	Then Details page for '013DA2178AB4444CAF2@bclabs.local' item is displayed to the user
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Capacity Unit' field is not displayed

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19538 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatValueForCapacityUnitIsChangingSuccessfullyForUserWithSpecificAccess
	When User creates new Capacity Unit via api
	| Name              | Description | IsDefault | Project                              |
	| cu_DAS19538_4645s | DAS19538    | false     | USE ME FOR AUTOMATION(DEVICE SCHDLD) |
	When User create new User via API
	| Username         | Email | FullName | Password  | Roles                                                                                                                                                                    |
	| UserDAS195381654 | Value | DAS19538 | m!gration | Project Application Object Editor, Project Computer Object Editor, Project Mailbox Object Editor, Project User Object Editor |
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username         | Password  |
 	| UserDAS195381654 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
		#--Devices--#
	When User navigates to the 'Device' details page for the item with '13292' ID
	Then Details page for 'CHAXTB7OLNX1W2' item is displayed to the user
	When User selects '2004 Rollout' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Capacity Unit' field is not displayed
		#--Users--#
	When User navigates to the 'User' details page for the item with '27418' ID
	Then Details page for 'REM635708' item is displayed to the user
	When User selects '2004 Rollout' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Capacity Unit' field is not displayed
		#--Mailboxes--#
	When User navigates to the 'Mailbox' details page for the item with '46886' ID
	Then Details page for '01DE1433D11E44E6A4A@bclabs.local' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(MAIL SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Capacity Unit' field is not displayed
		#--Applications--#
	When User navigates to the 'Application' details page for the item with '93' ID
	Then Details page for '20040610sqlserverck' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(DEVICE SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	Then 'MOVE' button is disabled on popup
	When User selects 'cu_DAS19538_4645s' option from 'Capacity Unit' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup
	Then following content is displayed on the Details Page
	| Title         | Value             |
	| Capacity Unit | cu_DAS19538_4645s |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19538 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatValueForCapacityUnitIsChangingSuccessfullyForUserWithSpecificAccessAndTeam
	When User create new User via API
	| Username         | Email | FullName | Password  | Roles                                                                                                                        |
	| UserDAS195385689 | Value | DAS19538 | m!gration | Project Application Object Editor, Project Computer Object Editor, Project Mailbox Object Editor, Project User Object Editor |
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "My team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User navigates to the 'Team Members' left menu item
	When User clicks 'ADD MEMBERS' button 
	And User selects following Objects from the expandable multiselect
	| Objects          |
	| UserDAS195385689 |
	And User clicks 'ADD USERS' button
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username         | Password  |
 	| UserDAS195385689 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
		#--Devices--#
	When User navigates to the 'Device' details page for the item with '13292' ID
	Then Details page for 'CHAXTB7OLNX1W2' item is displayed to the user
	When User selects '2004 Rollout' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	Then popup is displayed to User
	When User deselect all rows on the grid
	When User selects 'London - City' option from 'Capacity Unit' autocomplete
	And User clicks 'MOVE' button 
	Then following content is displayed on the Details Page
	| Title         | Value         |
	| Capacity Unit | London - City |
		#--Users--#
	When User navigates to the 'User' details page for the item with '27418' ID
	Then Details page for 'REM635708' item is displayed to the user
	When User selects '2004 Rollout' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	Then popup is displayed to User
	When User deselect all rows on the grid
	When User selects 'London - City' option from 'Capacity Unit' autocomplete
	And User clicks 'MOVE' button 
	Then following content is displayed on the Details Page
	| Title         | Value         |
	| Capacity Unit | London - City |
		#--Mailboxes--#
	When User navigates to the 'Mailbox' details page for the item with '46886' ID
	Then Details page for '01DE1433D11E44E6A4A@bclabs.local' item is displayed to the user
	When User selects 'Mailbox Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	Then popup is displayed to User
	When User deselect all rows on the grid
	When User selects 'Bb' option from 'Capacity Unit' autocomplete
	And User clicks 'MOVE' button 
	Then following content is displayed on the Details Page
	| Title         | Value |
	| Capacity Unit | Bb    |
		#--Applications--#
	When User navigates to the 'Application' details page for the item with '855' ID
	Then Details page for 'Adobe Reader 6.0 - Nederlands' item is displayed to the user
	When User selects 'Devices Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	Then popup is displayed to User
	When User selects 'Project Capacity Unit 1' option from 'Capacity Unit' autocomplete
	And User clicks 'MOVE' button 
	Then following content is displayed on the Details Page
	| Title         | Value                   |
	| Capacity Unit | Project Capacity Unit 1 |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectsTab @DAS19985 @DAS20088
Scenario: EvergreenJnr_DevicesList_CheckThatSlideToggleWorksCorrectlyForTheCapacityUnitPopUp
	When User navigates to the 'Device' details page for '32UIH1IBLQ050JY' item
	Then Details page for '32UIH1IBLQ050JY' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	When User deselect all rows on the grid
	Then 'FQT1418241' content is displayed in the 'Username' column
	When User checks 'Show only selected items' slide toggle
	Then 'FQT1418241' content is not displayed in the 'Username' column