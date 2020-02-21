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