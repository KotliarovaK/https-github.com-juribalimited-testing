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
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Devices Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then field with "Self Service URL" text is not displayed in expanded tab on the Details Page
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	And User navigates to the 'Projects' left menu item
	And User navigates to the 'Project Details' left submenu item
	Then field with "Self Service URL" text is displayed in expanded tab on the Details Page
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
	Then Details page for "01ERDGD48UDQKE" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Error message is not displayed
	When User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	And User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	And User opens "Related Users" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Users"
	And User clicks 'UPDATE' button 
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "Unassigned" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User navigates to the 'User' details page for '00DBB114BE1B41B0A38' item
	Then Details page for "00DBB114BE1B41B0A38" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	When User opens "Related Mailboxes" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Bucket" dropdown
	When User select "Unassigned" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Mailboxes page
	When User navigates to the 'Mailbox' details page for '0845467C65E5438D83E@bclabs.local' item
	Then Details page for "0845467C65E5438D83E@bclabs.local" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User clicks on "Unassigned" link for Evergreen Bucket field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "Bucket12883" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "Bucket12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Bucket" dropdown
	When User select "Unassigned" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	
	#Ann.Ilchenko 8/30/19: Question about link change speed (for "Capacity Unit")
@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13208 @DAS13971 @DAS13892 @DAS13892 @Cleanup @Not_Run
Scenario: EvergreenJnr_AllLists_UpdatingTheEvergreenCapacityUnitFieldInTheProjectsResumeWorksCorrectly
	When User creates new Capacity Unit via api
	| Name              | Description | IsDefault |
	| CapacityUnit12883 | Devices     | false     |
	#============================================================================#
		#go to Devices page
	When User navigates to the 'Device' details page for 'ZZNKKYW97AL4VS' item
	Then Details page for "ZZNKKYW97AL4VS" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "CapacityUnit12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "Unassigned" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User navigates to the 'User' details page for 'ZZNKKYW97AL4VS' item
	Then Details page for "ZZNKKYW97AL4VS" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Mailboxes" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "CapacityUnit12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Mailboxes"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "Unassigned" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Mailboxes page
	When User navigates to the 'Mailbox' details page for '0845467C65E5438D83E@bclabs.local' item
	Then Details page for "0845467C65E5438D83E@bclabs.local" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User clicks on "Unassigned" link for Evergreen Capacity Unit field
	Then popup changes window opened
	When User opens "Related Users" section on the Details Page
	And User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "CapacityUnit12883" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "CapacityUnit12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on "CapacityUnit12883" link on the Details Page
	Then popup changes window opened
	When User selects all rows on the grid on the Details Page for "Related Users"
	Then User clicks on "New Capacity Unit" dropdown
	When User select "Unassigned" value on the Details Page
	And User clicks 'UPDATE' button 
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console

	#Ann.I. 11/6/19: ready only for the 'spectrum'
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18607 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatInCatalogAndCriticalityFieldsAreDisplayedAndWorkingCorrectly
	When User navigates to the 'Application' details page for 'GogoTools version 2.1.0.9' item
	Then Details page for "GogoTools version 2.1.0.9" item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then following content is displayed on the Details Page
	| Title       | Value         |
	| In Catalog  | FALSE         |
	| Criticality | Uncategorised |
	#===In Catalog===#
	When User selects 'TRUE' in the dropdown for the 'In Catalog' field
	Then Success message is displayed and contains "In catalog successfully changed" text
	When User clicks refresh button in the browser
	Then following content is displayed on the Details Page
	| Title      | Value |
	| In Catalog | TRUE  |
	When User selects 'FALSE' in the dropdown for the 'In Catalog' field
	Then following content is displayed on the Details Page
	| Title      | Value |
	| In Catalog | FALSE |
	#===Criticality===#
	Then following Values are displayed in the dropdown for the 'Criticality' field:
	| Value         |
	| Core          |
	| Critical      |
	| Important     |
	| Not Important |
	| Uncategorised |
	When User selects 'Important' in the dropdown for the 'Criticality' field
	Then Success message is displayed and contains "Criticality successfully changed" text
	When User clicks refresh button in the browser
	Then following content is displayed on the Details Page
	| Title       | Value     |
	| Criticality | Important |
	When User selects 'Uncategorised' in the dropdown for the 'Criticality' field
	Then following content is displayed on the Details Page
	| Title       | Value         |
	| Criticality | Uncategorised |