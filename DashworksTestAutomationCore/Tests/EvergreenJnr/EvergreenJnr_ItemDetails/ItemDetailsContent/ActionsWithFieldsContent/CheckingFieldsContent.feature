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

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17007 @DAS17768 @DAS17768 @Void
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

#upd AnnI 5/18/20: archived to 'Yellow_Dwarf'? in development, will be redesigned.
@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13208 @DAS13971 @DAS13892 @DAS13892 @Cleanup @Yellow_Dwarf
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

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20454 @DAS20669
Scenario: EvergreenJnr_UsersList_CheckThatAppropriateValuesAreDisplayedCorrectlyForEnabledFieldOnTheUsersDetailsPage
	When User navigates to the 'User' details page for 'NPS8676905' item
	Then Details page for 'NPS8676905' item is displayed to the user
	Then User verifies data in the fields on details page
	| Field   | Data  |
	| Enabled | FALSE |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19977
Scenario Outline: EvergreenJnr_AllLists_CheckThatTheOwnerLinkOnDetailsPageRedirectsToTheCorrectPage
	When User navigates to the '<PageName>' details page for '<ItemName>' item
	Then Details page for '<ItemName>' item is displayed to the user
	When User selects '<ProjectName>' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	When User clicks "<OwnerLinkName>" link on the Details Page
	Then Details page for '<OwnerPage>' item is displayed to the user

Examples: 
	| PageName    | ItemName                                  | ProjectName                        | OwnerLinkName    | OwnerPage                            |
	| Device      | 00OMQQXWA1DRI6                            | Computer Scheduled Test (Jo)       | Sandra R. Castro | YRD045946 (Sandra R. Castro)         |
	| Application | ABBYY FineReader 8.0 Professional Edition | Barry's User Project               | Sherry M. Berger | NOK673558 (Sherry M. Berger)         |
	| Mailbox     | 00B5CCB89AD0404B965@bclabs.local          | Mailbox Evergreen Capacity Project | Smith, Delores   | 00B5CCB89AD0404B965 (Smith, Delores) |