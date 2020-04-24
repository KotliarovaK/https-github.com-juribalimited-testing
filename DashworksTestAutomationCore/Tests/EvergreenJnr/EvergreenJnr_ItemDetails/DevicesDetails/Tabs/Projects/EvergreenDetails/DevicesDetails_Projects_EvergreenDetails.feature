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

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16360 @DAS20433 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksThatMoveEvergreenBucketFunctionalityIsDisplayedCorrectly
	When User creates new Bucket via api
	| Name             | TeamName | IsDefault |
	| BucketDAS16360_1 | My Team  | false     |
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
	When User selects 'BucketDAS16360_1' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	Then 'The selected objects will be moved to BucketDAS16360_1' text is displayed on inline tip banner
	When User clicks 'MOVE' button on popup
	Then 'The selected objects successfully moved to BucketDAS16360_1' text is displayed on inline success banner

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS16360 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatValueForEvergreenBucketIsChangingSuccessfully
	When User creates new Bucket via api
	| Name               | TeamName | IsDefault |
	| BucketDAS16360_2_1 | My Team  | false     |
	| BucketDAS16360_2_2 | My Team  | false     |
	When User navigates to the 'Device' details page for 'CDBR7TV3Y9T2ITS' item
	Then Details page for 'CDBR7TV3Y9T2ITS' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	When User selects 'BucketDAS16360_2_1' option from 'Move Bucket' autocomplete
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup
	Then 'The selected objects successfully moved to BucketDAS16360_2_1' text is displayed on inline success banner
	Then following content is displayed on the Details Page
	| Title            | Value              |
	| Evergreen Bucket | BucketDAS16360_2_1 |
	When User clicks on edit button for 'Evergreen Bucket' field
	When User selects 'BucketDAS16360_2_2' option from 'Move Bucket' autocomplete
	When User navigates to 'evergreen/#/admin/evergreen/buckets' URL in a new tab
	When User select "Bucket" rows in the grid
	| SelectedRowsName   |
	| BucketDAS16360_2_2 |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	Then 'The selected bucket has been deleted' text is displayed on inline success banner
	When User switches to previous tab
	When User clicks 'MOVE' button on popup
	When User clicks 'MOVE' button on popup
	Then 'The selected bucket has been deleted' text is displayed on inline tip banner

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS16360 @Cleanup
Scenario: EvergreenJnr_DevicesList_ChecksthatThePermissionIsWorkingCorrectlyForTheEvergreenBucket
	When User create new User via API
	| Username     | Email | FullName | Password  | Roles                          |
	| UserDAS16360 | Value | DAS16360 | m!gration | Project Computer Object Editor |
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username     | Password  |
 	| UserDAS16360 | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User navigates to the 'Device' details page for 'CDBR7TV3Y9T2ITS' item
	Then Details page for 'CDBR7TV3Y9T2ITS' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	Then button for editing the 'Evergreen Bucket' field is not displayed

@Evergreen @Devices @EvergreenJnr_ItemDetails @ProjectDetailsTab @DAS20336
Scenario: EvergreenJnr_DevicesList_CheckThatTheShowOnlySelectedItemsButtonAreNotDisplayedOnTheMoveBucketPopupIfDeviceDoesntHaveAnyAssociatedUsers
	When User navigates to the 'Device' details page for 'BNYXDHH4GUIIOM' item
	Then Details page for 'BNYXDHH4GUIIOM' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	Then 'Show only selected items' slide toggle is not displayed
	Then "13510TestProject" is not displayed in the filter dropdown
	Then 'Select the bucket to move this device to.' text is displayed on popup

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17091 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckPaginationDisplayingForBucketAutocomplete
	#DEVICE
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	Then shown items label is not displayed for 'Move Bucket' autocomplete
	#USER
	When User navigates to the 'User' details page for '$231000-3AC04R8AR431' item
	Then Details page for '$231000-3AC04R8AR431' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	Then shown items label is not displayed for 'Move Bucket' autocomplete
	#MAILBOX
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	Then shown items label is not displayed for 'Move Bucket' autocomplete
	
	When User creates new Bucket via api
	| Name                        | TeamName | IsDefault |
	| AutoTestBucket_DAS_17091_1  | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_2  | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_3  | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_4  | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_5  | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_6  | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_7  | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_8  | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_9  | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_10 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_11 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_12 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_13 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_14 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_15 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_16 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_17 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_18 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_19 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_20 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_21 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_22 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_23 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_24 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_25 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_26 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_27 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_28 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_29 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_30 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_31 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_32 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_33 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_34 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_35 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_36 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_37 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_38 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_39 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_40 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_41 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_42 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_43 | Admin IT | FALSE     |
	| AutoTestBucket_DAS_17091_44 | Admin IT | FALSE     |

	#DEVICE
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	When User expands 'Move Bucket' autocomplete
	Then "50" of all shown label displays in the Filter panel
	#USER
	When User navigates to the 'User' details page for '$231000-3AC04R8AR431' item
	Then Details page for '$231000-3AC04R8AR431' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	When User expands 'Move Bucket' autocomplete
	Then "50" of all shown label displays in the Filter panel
	#MAILBOX
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Bucket' field
	When User expands 'Move Bucket' autocomplete
	Then "50" of all shown label displays in the Filter panel

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17091 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckPaginationDisplayingForCapacityAutocomplete
	When User creates new Capacity Unit via api
	| Name                 | Description | IsDefault |
	| CapacityUnit17091_1  | 17091_1     | FALSE     |
	| CapacityUnit17091_2  | 17091_2     | FALSE     |
	| CapacityUnit17091_3  | 17091_3     | FALSE     |
	| CapacityUnit17091_4  | 17091_4     | FALSE     |
	| CapacityUnit17091_5  | 17091_5     | FALSE     |
	| CapacityUnit17091_6  | 17091_6     | FALSE     |
	| CapacityUnit17091_7  | 17091_7     | FALSE     |
	| CapacityUnit17091_8  | 17091_8     | FALSE     |
	| CapacityUnit17091_9  | 17091_9     | FALSE     |
	| CapacityUnit17091_10 | 17091_10    | FALSE     |
	| CapacityUnit17091_11 | 17091_11    | FALSE     |
	| CapacityUnit17091_12 | 17091_12    | FALSE     |
	| CapacityUnit17091_13 | 17091_13    | FALSE     |
	| CapacityUnit17091_14 | 17091_14    | FALSE     |
	| CapacityUnit17091_15 | 17091_15    | FALSE     |
	| CapacityUnit17091_16 | 17091_16    | FALSE     |
	| CapacityUnit17091_17 | 17091_17    | FALSE     |
	| CapacityUnit17091_18 | 17091_18    | FALSE     |
	| CapacityUnit17091_19 | 17091_19    | FALSE     |
	| CapacityUnit17091_20 | 17091_20    | FALSE     |
	| CapacityUnit17091_21 | 17091_21    | FALSE     |
	| CapacityUnit17091_22 | 17091_22    | FALSE     |
	| CapacityUnit17091_23 | 17091_23    | FALSE     |
	| CapacityUnit17091_24 | 17091_24    | FALSE     |
	| CapacityUnit17091_25 | 17091_25    | FALSE     |
	| CapacityUnit17091_26 | 17091_26    | FALSE     |
	| CapacityUnit17091_27 | 17091_27    | FALSE     |
	| CapacityUnit17091_28 | 17091_28    | FALSE     |
	| CapacityUnit17091_29 | 17091_29    | FALSE     |
	| CapacityUnit17091_30 | 17091_30    | FALSE     |
	| CapacityUnit17091_31 | 17091_31    | FALSE     |
	| CapacityUnit17091_32 | 17091_32    | FALSE     |
	| CapacityUnit17091_33 | 17091_33    | FALSE     |
	| CapacityUnit17091_34 | 17091_34    | FALSE     |
	| CapacityUnit17091_35 | 17091_35    | FALSE     |
	| CapacityUnit17091_36 | 17091_36    | FALSE     |
	| CapacityUnit17091_37 | 17091_37    | FALSE     |
	| CapacityUnit17091_38 | 17091_38    | FALSE     |
	| CapacityUnit17091_39 | 17091_39    | FALSE     |
	| CapacityUnit17091_40 | 17091_40    | FALSE     |
	| CapacityUnit17091_41 | 17091_41    | FALSE     |
	| CapacityUnit17091_42 | 17091_42    | FALSE     |
	| CapacityUnit17091_43 | 17091_43    | FALSE     |
	| CapacityUnit17091_44 | 17091_44    | FALSE     |

	#DEVICE
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Capacity Unit' field
	When User expands 'New Capacity Unit' autocomplete
	Then "50" of all shown label displays in the Filter panel
	#USER
	When User navigates to the 'User' details page for '$231000-3AC04R8AR431' item
	Then Details page for '$231000-3AC04R8AR431' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Capacity Unit' field
	When User expands 'New Capacity Unit' autocomplete
	Then "50" of all shown label displays in the Filter panel
	#MAILBOX
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Capacity Unit' field
	When User expands 'New Capacity Unit' autocomplete
	Then "50" of all shown label displays in the Filter panel

	#APPLICATION
	When User navigates to the 'Application' details page for '0004 - Adobe Acrobat Reader 5.0.5 Francais' item
	Then Details page for '0004 - Adobe Acrobat Reader 5.0.5 Francais' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Capacity Unit' field
	When User expands 'New Capacity Unit' autocomplete
	Then "50" of all shown label displays in the Filter panel

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17091 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckPaginationDisplayingForRingsAutocomplete
	When User creates new Ring via api
	| Name         | Description | IsDefault |
	| Ring17091_1  | 17091_1     | FALSE     |
	| Ring17091_2  | 17091_2     | FALSE     |
	| Ring17091_3  | 17091_3     | FALSE     |
	| Ring17091_4  | 17091_4     | FALSE     |
	| Ring17091_5  | 17091_5     | FALSE     |
	| Ring17091_6  | 17091_6     | FALSE     |
	| Ring17091_7  | 17091_7     | FALSE     |
	| Ring17091_8  | 17091_8     | FALSE     |
	| Ring17091_9  | 17091_9     | FALSE     |
	| Ring17091_10 | 17091_10    | FALSE     |
	| Ring17091_11 | 17091_11    | FALSE     |
	| Ring17091_12 | 17091_12    | FALSE     |
	| Ring17091_13 | 17091_13    | FALSE     |
	| Ring17091_14 | 17091_14    | FALSE     |
	| Ring17091_15 | 17091_15    | FALSE     |
	| Ring17091_16 | 17091_16    | FALSE     |
	| Ring17091_17 | 17091_17    | FALSE     |
	| Ring17091_18 | 17091_18    | FALSE     |
	| Ring17091_19 | 17091_19    | FALSE     |
	| Ring17091_20 | 17091_20    | FALSE     |
	| Ring17091_21 | 17091_21    | FALSE     |
	| Ring17091_22 | 17091_22    | FALSE     |
	| Ring17091_23 | 17091_23    | FALSE     |
	| Ring17091_24 | 17091_24    | FALSE     |
	| Ring17091_25 | 17091_25    | FALSE     |
	| Ring17091_26 | 17091_26    | FALSE     |
	| Ring17091_27 | 17091_27    | FALSE     |
	| Ring17091_28 | 17091_28    | FALSE     |
	| Ring17091_29 | 17091_29    | FALSE     |
	| Ring17091_30 | 17091_30    | FALSE     |
	| Ring17091_31 | 17091_31    | FALSE     |
	| Ring17091_32 | 17091_32    | FALSE     |
	| Ring17091_33 | 17091_33    | FALSE     |
	| Ring17091_34 | 17091_34    | FALSE     |
	| Ring17091_35 | 17091_35    | FALSE     |
	| Ring17091_36 | 17091_36    | FALSE     |
	| Ring17091_37 | 17091_37    | FALSE     |
	| Ring17091_38 | 17091_38    | FALSE     |
	| Ring17091_39 | 17091_39    | FALSE     |
	| Ring17091_40 | 17091_40    | FALSE     |
	| Ring17091_41 | 17091_41    | FALSE     |
	| Ring17091_42 | 17091_42    | FALSE     |
	| Ring17091_43 | 17091_43    | FALSE     |
	| Ring17091_44 | 17091_44    | FALSE     |

	#DEVICE
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Ring' field
	When User expands 'New Ring' autocomplete
	Then "50" of all shown label displays in the Filter panel
	#USER
	When User navigates to the 'User' details page for '$231000-3AC04R8AR431' item
	Then Details page for '$231000-3AC04R8AR431' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Ring' field
	When User expands 'New Ring' autocomplete
	Then "50" of all shown label displays in the Filter panel
	#MAILBOX
	When User navigates to the 'Mailbox' details page for '000F977AC8824FE39B8@bclabs.local' item
	Then Details page for '000F977AC8824FE39B8@bclabs.local' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User clicks on edit button for 'Evergreen Ring' field
	When User expands 'New Ring' autocomplete
	Then "50" of all shown label displays in the Filter panel
