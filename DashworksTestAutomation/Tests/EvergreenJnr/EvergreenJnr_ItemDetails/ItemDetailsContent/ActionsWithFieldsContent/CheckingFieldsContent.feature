Feature: CheckingFieldsContent
	Runs Item Details Checking Fields Content related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @DevicesLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14973
Scenario: EvergreenJnr_DevicesList_CheckDeviceTabUIOnTheDeviceDetails
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the 'Details' left menu item
	Then User verifies data in the fields on details page
	| Field | Data |
	| Key   | 9141 |
	Then following content is displayed on the Details Page
	| Title                     | Value           |
	| Hostname                  | 001BAQXT6JWFPI  |
	| Source                    | A01 SMS (Spoof) |
	| Source Type               | SMS/SCCM 2007   |
	| Inventory Site            | A01             |
	Then empty value is displayed for "Dashworks First Seen Date" field on the Details Page

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17007 @DAS17768 @DAS17768
Scenario: EvergreenJnr_AllLists_CheckThatSelfServiceUrlIsNotDisplayedOnObjectDetailsPageEvenWhenItsDisabledInProjectManagement
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User selects 'Devices Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then 'Self Service URL' field is not displayed in the table
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for '0072B088173449E3A93' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then 'Self Service URL' field is displayed in the table
	Then following content is displayed on the Details Page
	| Title    | Value   |
	| Language | English |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12883 @DAS13208 @DAS13478 @DAS13971 @DAS13892 @DAS16824 @DAS17093 @Cleanup
Scenario: EvergreenJnr_AllLists_UpdatingTheEvergreenBucketFieldInTheProjectsResumeWorksCorrectly
	When User creates new Bucket via api
	| Name        | TeamName | IsDefault |
	| Bucket12883 | My Team  | false     |
	#============================================================================#
		#go to Devices page
	When User navigates to the 'Device' details page for '01ERDGD48UDQKE' item
	Then Details page for '01ERDGD48UDQKE' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Error message is not displayed
	When User clicks on edit button for 'Evergreen Bucket' field
	Then popup is displayed to User
	When User selects 'Bucket12883' option from 'New Bucket' autocomplete
	When User expands 'Related Users' category
	When User selects all rows on the grid
	And User clicks 'UPDATE' button 
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on edit button for 'Evergreen Bucket' field
	Then popup is displayed to User
	When User expands 'Related Users' category
	When User selects all rows on the grid
	When User selects 'Unassigned' option from 'New Bucket' autocomplete
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User navigates to the 'User' details page for '00DBB114BE1B41B0A38' item
	Then Details page for '00DBB114BE1B41B0A38' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	Then popup is displayed to User
	When User expands 'Related Mailboxes' category
	When User selects all rows on the grid
	When User selects 'Bucket12883' option from 'New Bucket' autocomplete
	And User clicks 'UPDATE' button 
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on edit button for 'Evergreen Bucket' field
	When User expands 'Related Mailboxes' category
	When User selects all rows on the grid
	When User selects 'Unassigned' option from 'New Bucket' autocomplete
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Mailboxes page
	When User navigates to the 'Mailbox' details page for '0845467C65E5438D83E@bclabs.local' item
	Then Details page for '0845467C65E5438D83E@bclabs.local' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	Then popup is displayed to User
	When User expands 'Related Users' category
	When User selects all rows on the grid
	When User selects 'Bucket12883' option from 'New Bucket' autocomplete
	And User clicks 'UPDATE' button 
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on edit button for 'Evergreen Bucket' field
	Then popup is displayed to User
	When User expands 'Related Users' category
	When User selects all rows on the grid
	When User selects 'Unassigned' option from 'New Bucket' autocomplete
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13208 @DAS13971 @DAS13892 @DAS13892 @Cleanup
Scenario: EvergreenJnr_AllLists_UpdatingTheEvergreenCapacityUnitFieldInTheProjectsResumeWorksCorrectly
	When User creates new Capacity Unit via api
	| Name              | Description | IsDefault |
	| CapacityUnit12883 | Devices     | false     |
	#============================================================================#
		#go to Devices page
	When User navigates to the 'Device' details page for 'ZZNKKYW97AL4VS' item
	Then Details page for 'ZZNKKYW97AL4VS' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Capacity Unit' field
	Then popup is displayed to User
	When User expands 'Related Users' category
	When User selects all rows on the grid
	When User selects 'CapacityUnit12883' option from 'New Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	Then "CapacityUnit12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on edit button for 'Evergreen Capacity Unit' field
	Then popup is displayed to User
	When User expands 'Related Users' category
	When User selects all rows on the grid
	When User selects 'Unassigned' option from 'New Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User navigates to the 'User' details page for '00DBB114BE1B41B0A38' item
	Then Details page for '00DBB114BE1B41B0A38' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Capacity Unit' field
	Then popup is displayed to User
	When User expands 'Related Mailboxes' category
	When User selects all rows on the grid
	When User selects 'CapacityUnit12883' option from 'New Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	Then "CapacityUnit12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on edit button for 'Evergreen Capacity Unit' field
	Then popup is displayed to User
	When User expands 'Related Mailboxes' category
	When User selects all rows on the grid
	When User selects 'Unassigned' option from 'New Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Mailboxes page
	When User navigates to the 'Mailbox' details page for '0845467C65E5438D83E@bclabs.local' item
	Then Details page for '0845467C65E5438D83E@bclabs.local' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Capacity Unit' field
	Then popup is displayed to User
	When User expands 'Related Users' category
	When User selects all rows on the grid
	When User selects 'CapacityUnit12883' option from 'New Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	Then "CapacityUnit12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on edit button for 'Evergreen Capacity Unit' field
	Then popup is displayed to User
	When User expands 'Related Users' category
	When User selects all rows on the grid
	When User selects 'Unassigned' option from 'New Capacity Unit' autocomplete
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18607
Scenario: EvergreenJnr_ApplicationsList_CheckThatInCatalogFieldsAreDisplayedAndWorkingCorrectly
	When User navigates to the 'Application' details page for 'GogoTools version 2.1.0.9' item
	Then Details page for 'GogoTools version 2.1.0.9' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then following content is displayed on the Details Page
	| Title       | Value         |
	| In Catalog  | FALSE         |
	When User selects 'TRUE' in the dropdown for the 'In Catalog' field
	Then 'In catalog successfully changed' text is displayed on inline success banner
	When User clicks refresh button in the browser
	Then following content is displayed on the Details Page
	| Title      | Value |
	| In Catalog | TRUE  |
	When User selects 'FALSE' in the dropdown for the 'In Catalog' field
	Then following content is displayed on the Details Page
	| Title      | Value |
	| In Catalog | FALSE |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18607
Scenario: EvergreenJnr_ApplicationsList_CheckThatCriticalityFieldsAreDisplayedAndWorkingCorrectly
	When User navigates to the 'Application' details page for 'GogoTools version 2.1.0.9' item
	Then Details page for 'GogoTools version 2.1.0.9' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then following content is displayed on the Details Page
	| Title       | Value         |
	| Criticality | Uncategorised |
	Then following Values are displayed in the dropdown for the 'Criticality' field:
	| Value         |
	| Core          |
	| Critical      |
	| Important     |
	| Not Important |
	| Uncategorised |
	When User selects 'Important' in the dropdown for the 'Criticality' field
	Then 'Criticality successfully changed' text is displayed on inline success banner
	When User clicks refresh button in the browser
	Then following content is displayed on the Details Page
	| Title       | Value     |
	| Criticality | Important |
	When User selects 'Uncategorised' in the dropdown for the 'Criticality' field
	Then following content is displayed on the Details Page
	| Title       | Value         |
	| Criticality | Uncategorised |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18865
Scenario: EvergreenJnr_ApplicationsList_CheckThatAppropriateValuesAreDisplayedCorrectlyForStickyComplianceFieldOnTheApplicationDetailsTab 
	When User navigates to the 'Application' details page for 'Axosoft OnTime 2005 Enterprise Server' item
	Then Details page for 'Axosoft OnTime 2005 Enterprise Server' item is displayed to the user
	Then User verifies data in the fields on details page
	| Field             | Data |
	| Sticky Compliance |      |
	When User navigates to the 'Application' details page for 'Standard SDK for Windows CE .NET 4.2' item
	Then Details page for 'Standard SDK for Windows CE .NET 4.2' item is displayed to the user
	Then User verifies data in the fields on details page
	| Field             | Data |
	| Sticky Compliance |      |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18849
Scenario: EvergreenJnr_ApplicationsList_CheckThatHideFromEndUserFieldsAreDisplayedAndWorkingCorrectly
	When User navigates to the 'Application' details page for 'ACDSee for Windows 95' item
	Then Details page for 'ACDSee for Windows 95' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then following content is displayed on the Details Page
	| Title              | Value |
	| Hide From End User | FALSE |
	When User selects 'TRUE' in the dropdown for the 'Hide From End User' field
	Then 'Hide from end user successfully changed' text is displayed on inline success banner
	When User clicks refresh button in the browser
	Then following content is displayed on the Details Page
	| Title              | Value |
	| Hide From End User | TRUE  |
	When User selects 'FALSE' in the dropdown for the 'Hide From End User' field
	Then 'Hide from end user successfully changed' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title              | Value |
	| Hide From End User | FALSE |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18852
Scenario: EvergreenJnr_ApplicationsList_CheckThatAllFieldsAreAensitiveToSecurityRequirementsForAnalysisEditorRole
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username       | Password |
 	| TestBucketAuto | 123456   |
	Then Evergreen Dashboards page should be displayed to the user
	When User navigates to the 'Application' details page for 'ACDSee for Windows 95' item
	Then Details page for 'ACDSee for Windows 95' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then following Values are displayed in the dropdown for the 'In Catalog' field:
	| Value |
	| TRUE  |
	| FALSE |
	Then following Values are displayed in the dropdown for the 'Criticality' field:
	| Value         |
	| Core          |
	| Critical      |
	| Important     |
	| Not Important |
	| Uncategorised |
	Then following Values are displayed in the dropdown for the 'Hide From End User' field:
	| Value |
	| TRUE  |
	| FALSE |
	When User clicks on edit button for 'Evergreen Capacity Unit' field
	Then popup is displayed to User
	When User clicks 'CANCEL' button
	#AnnI 1/8/20: 'Rationalisation' field hidden for 'terminator' (DAS-19609)
	#When User clicks on edit button for 'Rationalisation' field
	#Then popup is displayed to User
	#When User clicks 'CANCEL' button

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
	When User navigates to the 'User' details page for '0088FC8A50DD4344B92' item
	Then Details page for '0088FC8A50DD4344B92' item is displayed to the user
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Capacity Unit' field is not displayed
		#--Applications--#
	When User navigates to the 'Application' details page for '20040610sqlserverck' item
	Then Details page for '20040610sqlserverck' item is displayed to the user
	When User selects 'I-Computer Scheduled Project' in the 'Item Details Project' dropdown with wait
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
	| Name              | Description | IsDefault | Project                      |
	| cu_DAS19538_4645s | DAS19538    | false     | I-Computer Scheduled Project |
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
	When User selects '1803 Rollout' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Capacity Unit' field is not displayed
		#--Users--#
	When User navigates to the 'User' details page for the item with '27418' ID
	Then Details page for 'REM635708' item is displayed to the user
	When User selects '1803 Rollout' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Capacity Unit' field is not displayed
		#--Mailboxes--#
	When User navigates to the 'Mailbox' details page for the item with '46886' ID
	Then Details page for '01DE1433D11E44E6A4A@bclabs.local' item is displayed to the user
	When User selects 'TSTPROJ' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then button for editing the 'Capacity Unit' field is not displayed
		#--Applications--#
	When User navigates to the 'Application' details page for the item with '93' ID
	Then Details page for '20040610sqlserverck' item is displayed to the user
	When User selects 'I-Computer Scheduled Project' in the 'Item Details Project' dropdown with wait
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

	#AnnI 1/9/20: 'nor ready' because I need more details from Elena.
@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19538 @Cleanup @Not_Run
Scenario: EvergreenJnr_AllLists_CheckThatValueForCapacityUnitIsChangingSuccessfullyForUserWithSpecificAccessAndTeam
	When User creates new Capacity Unit via api
	| Name              | Description | IsDefault |
	| cu_DAS19538_5689d | Devices     | false     |
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
	When User selects '1803 Rollout' in the 'Item Details Project' dropdown with wait
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
	When User selects '1803 Rollout' in the 'Item Details Project' dropdown with wait
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
	When User selects 'cu_DAS19538_5689d' option from 'Capacity Unit' autocomplete
	And User clicks 'MOVE' button 
	Then following content is displayed on the Details Page
	| Title         | Value             |
	| Capacity Unit | cu_DAS19538_5689d |
		#--Applications--#
	When User navigates to the 'Application' details page for the item with '93' ID
	Then Details page for '20040610sqlserverck' item is displayed to the user
	When User selects 'I-Computer Scheduled Project' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks on edit button for 'Capacity Unit' field
	Then popup is displayed to User
	When User deselect all rows on the grid
	When User selects 'cu_DAS19538_5689d' option from 'Capacity Unit' autocomplete
	And User clicks 'MOVE' button 
	Then following content is displayed on the Details Page
	| Title         | Value             |
	| Capacity Unit | cu_DAS19538_5689d |