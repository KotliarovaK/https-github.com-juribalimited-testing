Feature: FBU_UpdatePath
	Runs Favourite Bulk Update Update path related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20771 @Yellow_Dwarf
Scenario Outline: EvergreenJnr_AllLists_CheckFavouriteBulkUpdateUpdatePathForAllListsType
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	Then 'star' mat icon is disabled
	Then 'star' mat icon has tooltip with 'Some values are missing or not valid' text
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	When User selects '<ProjectName>' option from 'Project' autocomplete
	Then 'UPDATE' button is disabled
	Then 'star' mat icon is not disabled
	Then 'star' mat icon has tooltip with 'Save as Favourite Bulk Update' text
	When User selects '<PathName>' option from 'Path' autocomplete
	Then 'UPDATE' button is not disabled
	Then 'star' mat icon has tooltip with 'Save as Favourite Bulk Update' text

	Examples: 
	| PageName     | ColumnHeader  | RowName                          | ProjectName     | PathName                |
	| Devices      | Hostname      | 00BDM1JUR8IF419                  | 2004 Rollout    | Zero Touch              |
	| Users        | Username      | 002B5DC7D4D34D5C895              | 2004 Rollout    | VIP User                |
	| Applications | Application   | 20040610sqlserverck              | 2004 Rollout    | [Default (Application)] |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local | Email Migration | Public Folder           |

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20772 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckFavouriteBulkUpdatePopupWindow 
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' option from 'Bulk Update Type' autocomplete
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'VIP User' option from 'Path' autocomplete
	When User clicks 'star' mat icon
	Then popup with 'Create Favourite Bulk Update' title is displayed
	Then 'This Favourite Bulk Update will be created with the following parameters:' text is displayed on popup
	Then following data is displayed in the '0' column of the table
	| Fields           |
	| Bulk Update Type |
	| Project          |
	| Path             |
	Then User sees table with the following data
	| Field            | Data         |
	| Bulk Update Type | Update path  |
	| Project          | 2004 Rollout |
	| Path             | VIP User     |

	Then following data is displayed in the '0' column of the table
	| Fields           |
	| Bulk Update Type |
	| Project          |
	| Path             |
	Then User sees table with the following data
	| Field            | Data         |
	| Bulk Update Type | Update path  |
	| Project          | 2004 Rollout |
	| Path             | VIP User     |

	Then 'CANCEL' button is not disabled
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	When User enters '' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update name must be entered' error message is displayed for 'Favourite Bulk Update Name' field
	When User enters '20772_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters '20772_TestFBU' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update with this name already exists' error message is displayed for 'Favourite Bulk Update Name' field

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20773 @Cleanup @Yellow_Dwarf @Cleanup
Scenario: EvergreenJnr_AllUsers_CheckValueAndIconsForFavouriteBulkUpdateItems
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'VIP User' option from 'Path' autocomplete
	When User clicks 'star' mat icon
	When User enters '20773_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'TestFBU_20773' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'testFBU_207731' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'abc_20773' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	Then following items have 'star' icon in the 'Bulk Update Type' dropdown:
	| Items          |
	| 20773_TestFBU  |
	| TestFBU_20773  |
	| testFBU_207731 |
	| abc_20773      |
	Then items with 'star' icon for 'Bulk Update Type' dropdown are displayed in ascending order

@Evergreen @AllDevices @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20774 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckSelectedValueForCreatedFavouriteBulkUpdatePathType
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Desktop Upgrade' option from 'Path' autocomplete
	When User clicks 'star' mat icon
	When User enters '20774_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects '20774_TestFBU' in the 'Bulk Update Type' dropdown
	Then '2004 Rollout' content is displayed in 'Project' autocomplete
	Then 'Desktop Upgrade' content is displayed in 'Path' autocomplete
	Then 'UPDATE' button is not disabled
	Then 'CANCEL' button is not disabled
	Then 'star' mat icon is not disabled

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20774 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckSelectedValueForCreatedFavouriteBulkUpdateWithoutPath
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User clicks 'star' mat icon
	When User enters '20774_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects '20774_TestFBU' in the 'Bulk Update Type' dropdown
	Then '2004 Rollout' content is displayed in 'Project' autocomplete
	Then '' content is displayed in 'Path' autocomplete
	Then 'UPDATE' button is disabled
	Then 'CANCEL' button is not disabled
	Then 'star' mat icon is not disabled

#Add specific User with broken  FBU to check Error message when Path was deleted
@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20774 @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckErrorMessageForCreatedFavouriteBulkUpdate
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
	When User selects 'specific FBU' in the 'Bulk Update Type' dropdown
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	Then 'This Favourite Bulk Update is invalid' text is displayed on inline error banner
	Then 'UPDATE' button is disabled
	Then 'star' mat icon is not disabled

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20774 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckSelectedValueForCreatedFavouriteBulkUpdateForDeletedProject
	When Project created via API and opened
	| ProjectName   | Scope         | ProjectTemplate | Mode               |
	| 20774_Project | All Mailboxes | None            | Standalone Project |
	Then Page with '20774_Project' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User expands multiselect to add objects
	When User expands multiselect and selects following Objects
	| Objects             |
	| 000F977AC8824FE39B8 |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	When User selects '20774_Project' option from 'Project' autocomplete
	When User selects '[Default (Mailbox)]' option from 'Path' autocomplete
	When User clicks 'star' mat icon
	When User enters '20774_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	#Delete Project
	When User clicks 'Admin' on the left-hand menu
	When User enters "20774_Project" text in the Search field for "Project" column
	When User selects all rows on the grid
	When User removes selected item
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	Then following Values are not displayed in the 'Bulk Update Type' dropdown:
	| Options       |
	| 20774_TestFBU |

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20774 @DAS20955 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckFavouriteBulkUpdatesPopup
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User clicks 'star' mat icon
	When User enters '207741_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	When User selects 'Email Migration' option from 'Project' autocomplete
	When User clicks 'star' mat icon
	When User enters '207742_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects '207742_TestFBU' in the 'Bulk Update Type' dropdown
	When User selects 'Manage favourites' in the 'Bulk Update Type' dropdown
	Then popup with 'Favourite Bulk Updates' title is displayed
	Then 'star207742_TestFBU' content is displayed in 'Bulk Update Type' dropdown
	When User clicks Group By button and set checkboxes state
	| Checkboxes  | State |
	| Object Type | true  |
	Then Cog menu is not displayed on the Admin page
	And Grid is grouped
	When User expands 'Devices' row in the groped grid
	Then "207741_TestFBU" content is displayed for "Name" column

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20774 @DAS20955 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckFavouriteBulkUpdatesPopupColumns
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User clicks 'star' mat icon
	When User enters '207743_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Manage favourites' in the 'Bulk Update Type' dropdown
	Then popup with 'Favourite Bulk Updates' title is displayed
	Then grid headers are displayed in the following order on popup
	| ColumnName           |
	| Name                 |
	|                      |
	| Object Type          |
	| Type                 |
	| Project or Evergreen |
	| Task or Field        |
	| Update Type          |
	| Values               |

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20777 @DAS20955 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckFavouriteBulkUpdatesPopupDeletingAndEditing
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	When User selects 'Email Migration' option from 'Project' autocomplete
	When User clicks 'star' mat icon
	When User enters '20777_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters '20777_TestFBU1' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Manage favourites' in the 'Bulk Update Type' dropdown
	Then popup with 'Favourite Bulk Updates' title is displayed
	When User enters "20777_TestFBU1" text in the Search field for "Name" column
	When User clicks 'Rename' option in Cog-menu for '20777_TestFBU1' item from 'Name' column
	#Add step to rename fbu
	When User clicks 'Delete' option in Cog-menu for '20777_TestFBU1' item from 'Name' column
	Then 'This Favourite Bulk Update will be permanently deleted' text is displayed on inline tip banner
	When User clicks 'CANCEL' button on inline tip banner
	When User clicks 'Delete' option in Cog-menu for '20777_TestFBU1' item from 'Name' column
	Then 'This Favourite Bulk Update will be permanently deleted' text is displayed on inline tip banner
	When User clicks 'DELETE' button on inline tip banner
	Then 'The Favourite Bulk Update has been deleted' text is displayed on inline success banner

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21257 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_ChecThatFavoriteBulkUpdateNameFieldIsNotCaseSensitive
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'VIP User' option from 'Path' autocomplete
	When User clicks 'star' mat icon
	When User enters 'das21257_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'Das21257_TestFBU' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update with this name already exists' error message is displayed for 'Favourite Bulk Update Name' field