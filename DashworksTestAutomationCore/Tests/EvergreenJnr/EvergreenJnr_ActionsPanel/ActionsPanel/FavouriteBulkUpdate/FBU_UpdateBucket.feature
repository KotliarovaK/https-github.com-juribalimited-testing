﻿Feature: FBU_UpdateBucket
	Runs Favourite Bulk Update Update Bucket related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @FavouriteBulkUpdate @DAS20992 @Yellow_Dwarf
Scenario Outline: EvergreenJnr_AllLists_CheckFavouriteBulkUpdateValidationsUpdateBucketForAllListsType
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update bucket' option from 'Bulk Update Type' autocomplete
	Then 'star' mat icon is disabled
	Then 'star' mat icon has tooltip with 'Some values are missing or not valid' text
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	Then 'CANCEL' button is not disabled
	When User selects '<Project>' option from 'Project or Evergreen' autocomplete
	Then 'UPDATE' button is disabled
	Then 'star' mat icon is not disabled
	Then 'star' mat icon has tooltip with 'Save as Favourite Bulk Update' text
	When User selects '<Bucket>' option from 'Bucket' autocomplete
	Then 'UPDATE' button is not disabled
	Then 'star' mat icon is not disabled
	Then 'star' mat icon has tooltip with 'Save as Favourite Bulk Update' text

	Examples: 
	| PageName  | ColumnHeader  | RowName                          | Project      | Bucket        |
	| Devices   | Hostname      | 00BDM1JUR8IF419                  | 2004 Rollout | Birmingham    |
	| Users     | Username      | 002B5DC7D4D34D5C895              | Evergreen    | BucketforAuto |
	| Mailboxes | Email Address | 002B5DC7D4D34D5C895@bclabs.local | Evergreen    | Unassigned    |

@Evergreen @AllUsers @FavouriteBulkUpdate @DAS21000 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckFavouriteBulkUpdatePopupWindowForUpdateBucket
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update bucket' option from 'Bulk Update Type' autocomplete
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Unassigned' option from 'Bucket' autocomplete
	When User selects 'All linked devices' in the 'Also Move Devices' dropdown
	When User selects 'Owned mailboxes only' in the 'Also Move Mailboxes' dropdown
	When User clicks 'star' mat icon
	Then popup with 'Create Favourite Bulk Update' title is displayed
	Then 'This Favourite Bulk Update will be created with the following parameters:' text is displayed on popup
	Then following data is displayed in the '0' column of the table
	| Fields               |
	| Bulk Update Type     |
	| Project or Evergreen |
	| Bucket               |
	| Also Move Devices    |
	| Also Move Mailboxes  |
	Then User sees table with the following data
	| Field                | Data                 |
	| Bulk Update Type     | Update bucket        |
	| Project or Evergreen | Evergreen            |
	| Bucket               | Unassigned           |
	| Also Move Devices    | All linked devices   |
	| Also Move Mailboxes  | Owned mailboxes only |
	Then 'CANCEL' button is not disabled
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	When User enters '' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update name must be entered' error message is displayed for 'Favourite Bulk Update Name' field
	When User enters '21000_BulkFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters '21000_BulkFBU' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update with this name already exists' error message is displayed for 'Favourite Bulk Update Name' field

@Evergreen @AllMailboxes @FavouriteBulkUpdate @DAS21002 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllMailboxes_CheckValueAndIconsForFavouriteBulkUpdateItemsBuckets
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 003F5D8E1A844B1FAA5@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update bucket' option from 'Bulk Update Type' autocomplete
	When User selects 'Email Migration' option from 'Project or Evergreen' autocomplete
	When User selects 'Amsterdam' option from 'Bucket' autocomplete
	When User clicks 'star' mat icon
	Then following data is displayed in the '0' column of the table
	| Fields               |
	| Bulk Update Type     |
	| Project or Evergreen |
	| Bucket               |
	| Also Move Users      |
	Then User sees table with the following data
	| Field                | Data          |
	| Bulk Update Type     | Update bucket |
	| Project or Evergreen | Evergreen     |
	| Bucket               | Amsterdam     |
	| Also Move Users      | None          |
	When User enters '21002_BucketFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'Test21002_BucketFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'test21002_BucketFBU1' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'abc_21002_BucketFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	Then following items have 'star' mat icon from 'Bulk Update Type' autocomplete
	| Items                |
	| 21002_BucketFBU      |
	| abc_21002_BucketFBU  |
	| Test21002_BucketFBU  |
	| test21002_BucketFBU1 |
	Then items with 'star' mat icon for 'Bulk Update Type' autocomplete are displayed in ascending order

#Add specific User with broken FBU to check Error message when Bucket was deleted
#Will be added in the beginning of July
@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20774 @Zenith
Scenario: EvergreenJnr_AllUsers_CheckErrorMessageForCreatedFavouriteBulkUpdateWithBrokenBucket
	When User is logged in to the Evergreen as
 	| Username  | Password  |
 	| ********* | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User provides the Login and Password and clicks on the login button
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'specific FBU' option from 'Bulk Update Type' autocomplete
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	Then 'This Favourite Bulk Update is invalid' text is displayed on inline error banner
	Then 'The configuration for this Favourite Bulk Update is no longer valid' text is displayed on inline error banner
	Then 'UPDATE' button is disabled
	Then 'star' mat icon is not disabled