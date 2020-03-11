Feature: DevicesDetails_Projects_EvergreenDetails
	Runs related tests for Projects > Evergreen Details tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS14941 @DAS12963 @DAS20166
Scenario: EvergreenJnr_DevicesList_CheckTheEvergreenRingProjectSetting
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User click content from "Hostname" column
	When User navigates to the 'Projects' left menu item
	Then following content is displayed on the Details Page
	| Title          | Value            |
	| Evergreen Ring | Evergreen Ring 2 |
	When User clicks on edit button for 'Evergreen Ring' field
	Then 'New Ring' autocomplete contains following options:
	| Options          |
	| Unassigned       |
	| Evergreen Ring 1 |
	| Evergreen Ring 3 |
	| TestBulkUpdate   |
	Then There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS13335 @DAS14923 @DAS12963 @DAS16233 @DAS16360 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckUpdatingDeviceBucketViaRelatedUserProjectSummaryWhenMailboxesSectionIsExpanded
	When User creates new Bucket via api
	| Name                     | TeamName | IsDefault |
	| AutoTestBucket_DAS_13335 | Admin IT | false     |
	#============================================================================#
	When User navigates to the 'User' details page for 'AAG081456' item
	Then Details page for 'AAG081456' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	When User selects 'AutoTestBucket_DAS_13335' option from 'Move Bucket' autocomplete
	When User selects all rows on the grid
	And User clicks 'MOVE' button
	And User clicks 'MOVE' button
	When User navigates to the 'Device' details page for 'I55HL8MSBYK0VG' item
	Then Details page for 'I55HL8MSBYK0VG' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then User sees "AutoTestBucket_DAS_13335" Evergreen Bucket in Project Summary section on the Details Page
	And There are no errors in the browser console

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12883 @DAS13208 @DAS13478 @DAS13971 @DAS13892 @DAS16824 @DAS17093 @DAS16360 @Cleanup
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
	When User selects 'Bucket12883' option from 'Move Bucket' autocomplete
	When User selects all rows on the grid
	And User clicks 'MOVE' button
	And User clicks 'MOVE' button
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on edit button for 'Evergreen Bucket' field
	Then popup is displayed to User
	When User selects all rows on the grid
	When User selects 'Unassigned' option from 'Move Bucket' autocomplete
	And User clicks 'MOVE' button
	And User clicks 'MOVE' button
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Users page
	When User navigates to the 'User' details page for '00DBB114BE1B41B0A38' item
	Then Details page for '00DBB114BE1B41B0A38' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	Then popup is displayed to User
	When User selects all rows on the grid
	When User selects 'Bucket12883' option from 'Move Bucket' autocomplete
	And User clicks 'MOVE' button
	And User clicks 'MOVE' button
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on edit button for 'Evergreen Bucket' field
	When User selects all rows on the grid
	When User selects 'Unassigned' option from 'Move Bucket' autocomplete
	And User clicks 'MOVE' button
	And User clicks 'MOVE' button
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console
	#============================================================================#
		#go to Mailboxes page
	When User navigates to the 'Mailbox' details page for '0845467C65E5438D83E@bclabs.local' item
	Then Details page for '0845467C65E5438D83E@bclabs.local' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	Then popup is displayed to User
	When User selects all rows on the grid
	When User selects 'Bucket12883' option from 'Move Bucket' autocomplete
	And User clicks 'MOVE' button
	And User clicks 'MOVE' button
	Then "Bucket12883" link is displayed on the Details Page
	And There are no errors in the browser console
		#backs the Evergreen Bucket and Capacity Unit to default value
	When User clicks on edit button for 'Evergreen Bucket' field
	Then popup is displayed to User
	When User selects all rows on the grid
	When User selects 'Unassigned' option from 'Move Bucket' autocomplete
	And User clicks 'MOVE' button
	And User clicks 'MOVE' button
	Then "Unassigned" link is displayed on the Details Page
	And There are no errors in the browser console

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16360 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatMoveBucketFunctionalityIsDisplayedCorrectly
	When User creates new Bucket via api
	| Name           | TeamName | IsDefault |
	| BucketDAS16360 | My Team  | false     |
	When User navigates to the 'Device' details page for '01ERDGD48UDQKE' item
	Then Details page for '01ERDGD48UDQKE' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	Then 'MOVE' button is disabled on popup
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Key                |
	| Directory Type     |
	| Username           |
	| Common Name        |
	| Distinguished Name |
	| Display Name       |
	Then 'Move all' checkbox is not displayed
	When User selects 'BucketDAS16360' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	Then 'The selected objects will be moved to Birmingham' text is displayed on inline tip banner
	When User clicks 'MOVE' button on popup
	Then 'The selected objects successfully moved to Birmingham' text is displayed on inline success banner