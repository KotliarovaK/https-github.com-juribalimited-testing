Feature: ActionsPanel
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @DAS10859 @DAS12602 @Not_Run
Scenario: EvergreenJnr_UsersList_CheckThatAfterInterruptingProcessSelectingAllRowsAtActionsPanelProgressIndicatorDoesNotContinueToRun
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	When User click on 'Username' column header
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	When User click content from "Username" column
	Then User click back button in the browser
	And "Users" list should be displayed to the user
	Then Actions panel is displayed to the user
	Then Actions message container is displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @DAS10860
Scenario: EvergreenJnr_UsersList_CheckThatAfterClosingActionsPanelTheActionsButtonIsNotShownInRed
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions button is active
	When User clicks the Actions button
	Then Actions button is not active

@Evergreen @Users @EvergreenJnr_ActionsPanel @DAS12932 @DAS13262
Scenario: EvergreenJnr_UsersList_CheckThatUserWithoutRelevantRolesCannotSeeBulkUpdateOptionInActionsPanel
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username        | FullName     | Password | ConfirmPassword | Roles |
	| 000WithoutRoles | WithoutRoles | 1234qwer | 1234qwer        |       |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username        | Password |
	| 000WithoutRoles | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	| 0088FC8A50DD4344B92 |
	And User clicks on Action drop-down
	Then following Values are displayed in Action drop-down:
	| Value              |
	| Create static list |
	When User clicks Profile in Account Dropdown
	Then Profile page is displayed to user
	And following Roles are available for User:
	| Roles                     |
	| Dashworks Users           |
	| Dashworks Evergreen Users |
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "000WithoutRoles" User

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12932 @DAS13261
Scenario: EvergreenJnr_DevicesList_CheckThatUserWithoutJustTheProjectAdministratorRoleCanStillBulkUpdateObjects
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username   | FullName             | Password | ConfirmPassword | Roles                |
	| 000WithPBU | Project Bulk Updater | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username   | Password |
	| 000WithPBU | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName               |
	| Windows7Mi: Request Type |
	And User perform search by "0DTXL41673EW7O"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 0DTXL41673EW7O   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "Computer: Laptop Replacement" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User refreshes agGrid
	Then "Computer: Laptop Replacement" text is displayed in the table content
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "000WithPBU" User

@Evergreen @Applications @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12932 @DAS13261
Scenario: EvergreenJnr_ApplicationsList_CheckThatUserWithoutJustTheProjectBulkUpdaterRoleCanStillBulkUpdateObjects
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username  | FullName              | Password | ConfirmPassword | Roles                 |
	| 000WithPA | Project Administrator | 1234qwer | 1234qwer        | Project Administrator |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username  | Password |
	| 000WithPA | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName               |
	| EmailMigra: Request Type |
	And User perform search by "0047 - Microsoft Access 97 SR-2 Francais"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Email Migration" Project on Action panel
	And User selects "Sharepoint Application" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User refreshes agGrid
	Then "Sharepoint Application" text is displayed in the table content
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "000WithPA" User

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12946 @DAS12864 @DAS13258 @DAS13259 @DAS13260 @DAS13263 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_ChecksThatRemoveFromStaticListOptionIsNotShownInTheActionsPanelWhenAStaticListDoesNotExist
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User click on '<ColumnHeader>' column header
	When User create dynamic list with "DynamicList12946" name on "<PageName>" page
	Then "DynamicList12946" list is displayed to user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User clicks on Action drop-down
	Then following Values are displayed in Action drop-down:
	| Value              |
	| Create static list |
	| Bulk update        |
	When User selects "Bulk update" in the Actions dropdown
	Then Bulk Update Type dropdown is displayed on Action panel
	When User selects "Update task value" Bulk Update Type on Action panel
	Then "UPDATE" Action button is disabled
	And "CANCEL" Action button is active
	When User selects "<ProjectName>" Project on Action panel
	And User selects "<StageName>" Stage on Action panel
	And User selects "<TaskName>" Task on Action panel
	And User selects "<Value>" Value on Action panel
	When User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "0 of 1 objects were valid for the update." text is displayed on Action panel
	Then There are no errors in the browser console

Examples: 
	| PageName     | ColumnHeader  | RowName                          | ProjectName                  | StageName      | TaskName                | Value                    |
	| Devices      | Hostname      | 001PSUMZYOW581                   | User Scheduled Test (Jo)     | Two            | Radio Non Rag only Comp | Not Applicable           |
	| Users        | Username      | 003F5D8E1A844B1FAA5              | Computer Scheduled Test (Jo) | Two            | Radio Non Rag User      | Not Applicable           |
	| Applications | Application   | 7zip                             | Computer Scheduled Test (Jo) | Two            | Radio Non Rag App       | Not Applicable           |
	| Mailboxes    | Email Address | 00BDBAEA57334C7C8F4@bclabs.local | Email Migration              | Mobile Devices | Mobile Device Status    | Identified & In Progress |

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12946 @DAS12864 @DAS13258 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_ChecksThatAddToStaticListOptionIsNotShownInTheActionsPanelWhenOnlOneStaticListExists 
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "StaticList12946" name
	Then "StaticList12946" list is displayed to user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User clicks on Action drop-down
	Then following Values are displayed in Action drop-down:
	| Value                   |
	| Create static list      |
	| Remove from static list |
	| Bulk update             |

Examples: 
	| PageName     | ColumnHeader  | RowName                          |
	| Devices      | Hostname      | 001PSUMZYOW581                   |
	| Users        | Username      | 002B5DC7D4D34D5C895              |
	| Applications | Application   | 20040610sqlserverck              |
	| Mailboxes    | Email Address | 00C8BC63E7424A6E862@bclabs.local |

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12946 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AllLists_ChecksThatStaticListsCreatedFromAFilterOriginallyLoadsAnyDataOnceTheStaticListHasBeenCreated  
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| <Checkboxes>       |
	Then "<FilterName>" filter is added to the list
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	When User selects "Create static list" in the Actions dropdown
	When User create static list with "StaticList12946" name
	Then "StaticList12946" list is displayed to user
	And table content is present
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select all rows
	Then "<SelectedRowsCount>" selected rows are displayed in the Actions panel
	When User clicks on Action drop-down

Examples: 
	| PageName     | FilterName       | Checkboxes | SelectedRowsCount |
	| Devices      | Compliance       | Red        | 9174              |
	| Users        | Compliance       | Red        | 9438              |
	| Applications | Compliance       | Red        | 181               |
	| Mailboxes    | Owner Compliance | Green      | 14701             |

@Evergreen @Devices @EvergreenJnr_ActionsPanel @DAS12863 @DAS13266 @DAS13284
Scenario: EvergreenJnr_DevicesList_ChecksThatRequestTypeIsUpdatedCorrectlyOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "Windows7Mi: In Scope" filter is added to the list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName               |
	| Windows7Mi: Request Type |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001PSUMZYOW581   |
	| 00BDM1JUR8IF419  |
	| 00RUUMAH9OZN9A   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	Then "UPDATE" Action button is disabled
	When User selects "Computer: PC Rebuild" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "3 of 3 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "001PSUMZYOW581"
	Then "Computer: PC Rebuild" content is displayed in "Windows7Mi: Request Type" column
	When User perform search by "00BDM1JUR8IF419"
	Then "Computer: PC Rebuild" content is displayed in "Windows7Mi: Request Type" column
	When User perform search by "00RUUMAH9OZN9A"
	Then "Computer: PC Rebuild" content is displayed in "Windows7Mi: Request Type" column
	When User closes Tools panel
	And User clicks Close panel button
		#returns default object state
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001PSUMZYOW581   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "Computer: Virtual Machine" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "[This is the Default Request Type for Computer)] " Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00RUUMAH9OZN9A   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "Computer: Laptop Replacement" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12863 @DAS13266 @DAS13284
Scenario: EvergreenJnr_UsersList_ChecksThatRequestTypeIsUpdatedCorrectlyOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "Windows7Mi: In Scope" filter is added to the list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName               |
	| Windows7Mi: Request Type |
	And User click on 'Windows7Mi: Request Type' column header
	And User click on 'Windows7Mi: Request Type' column header
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects "Username" rows in the grid
	| SelectedRowsName |
	| FMN5805290       |
	| AKX995383        |
	| AAD1011948       |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	Then "UPDATE" Action button is disabled
	When User selects "User; Maternity" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "3 of 3 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "FMN5805290"
	Then "User; Maternity" content is displayed in "Windows7Mi: Request Type" column
	When User perform search by "AKX995383"
	Then "User; Maternity" content is displayed in "Windows7Mi: Request Type" column
	When User perform search by "AAD1011948"
	Then "User; Maternity" content is displayed in "Windows7Mi: Request Type" column
	When User closes Tools panel
	And User clicks Close panel button
		#returns default object state
	And User perform search by "FMN5805290"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| FMN5805290       |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "User: VIP" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User clicks Close panel button
	And User perform search by "AKX995383"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| AKX995383        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "User: No Agent" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User clicks Close panel button
	And User perform search by "AAD1011948"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| AAD1011948       |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "[Default (User)]" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel

@Evergreen @Applications @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12863 @DAS13266 @DAS13284
Scenario: EvergreenJnr_ApplicationsList_ChecksThatRequestTypeIsUpdatedCorrectlyOnApplicationsPage
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "Windows7Mi: In Scope" filter is added to the list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName               |
	| Windows7Mi: Request Type |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                                           |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                 |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	Then "UPDATE" Action button is disabled
	When User selects "Application: Request Type B" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "2 of 2 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by ""WPF/E" (codename) Community Technology Preview (Feb 2007)"
	Then "Application: Request Type B" content is displayed in "Windows7Mi: Request Type" column
	When User perform search by "0004 - Adobe Acrobat Reader 5.0.5 Francais"
	Then "Application: Request Type B" content is displayed in "Windows7Mi: Request Type" column
	When User closes Tools panel
	And User clicks Close panel button
		#returns default object state
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                                           |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "[Default (Application)]" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                           |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "Application: Request Type A" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12863 @DAS13266 @DAS13284
Scenario: EvergreenJnr_MailboxesList_ChecksThatRequestTypeIsUpdatedCorrectlyOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "EmailMigra: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "EmailMigra: In Scope" filter is added to the list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName               |
	| EmailMigra: Request Type |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 0F1ED67386AD4FA7BF4@bclabs.local |
	| 10A919CA1E7641E08E7@bclabs.local |
	| 229DCF8E575243E9928@bclabs.local |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Email Migration" Project on Action panel
	Then "UPDATE" Action button is disabled
	When User selects "Personal Mailbox - VIP" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "3 of 3 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "0F1ED67386AD4FA7BF4@bclabs.local"
	Then "Personal Mailbox - VIP" content is displayed in "EmailMigra: Request Type" column
	When User perform search by "10A919CA1E7641E08E7@bclabs.local"
	Then "Personal Mailbox - VIP" content is displayed in "EmailMigra: Request Type" column
	When User perform search by "229DCF8E575243E9928@bclabs.local"
	Then "Personal Mailbox - VIP" content is displayed in "EmailMigra: Request Type" column
	When User closes Tools panel
	And User clicks Close panel button
		#returns default object state
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 0F1ED67386AD4FA7BF4@bclabs.local |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Email Migration" Project on Action panel
	And User selects "Shared Mailbox" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 10A919CA1E7641E08E7@bclabs.local |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Email Migration" Project on Action panel
	And User selects "Personal Mailbox - EA" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 229DCF8E575243E9928@bclabs.local |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Email Migration" Project on Action panel
	And User selects "Personal Mailbox" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12863 @DAS13266 @DAS13284
Scenario: EvergreenJnr_DevicesList_ChecksThatRequestTypeIsUpdatedCorrectlyWhereSomeObjectsAreValidAndSomeAreInvalidForTheSelectedProject
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName               |
	| Windows7Mi: Request Type |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00HA7MKAVVFDAV   |
	| 00I0COBFWHOF27   |
	| 018UQ6KL9TF4YF   |
	| 019BFPQGKK5QT8N  |
	| 01DRMO46G58SXK   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "Computer: Workstation Replacement" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "2 of 5 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "00HA7MKAVVFDAV"
	Then "Computer: Workstation Replacement" content is displayed in "Windows7Mi: Request Type" column
	When User perform search by "018UQ6KL9TF4YF"
	Then "Computer: Workstation Replacement" content is displayed in "Windows7Mi: Request Type" column
	When User perform search by "00I0COBFWHOF27"
	Then "" content is displayed in "Windows7Mi: Request Type" column
	When User perform search by "019BFPQGKK5QT8N"
	Then "" content is displayed in "Windows7Mi: Request Type" column
	When User perform search by "01DRMO46G58SXK"
	Then "" content is displayed in "Windows7Mi: Request Type" column
	When User closes Tools panel
	And User clicks Close panel button
		#returns default object state
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00HA7MKAVVFDAV   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "[This is the Default Request Type for Computer)] " Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 018UQ6KL9TF4YF   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	And User selects "Computer: Virtual Machine" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12863 @DAS13277
Scenario: EvergreenJnr_DevicesList_ChecksThatActionsPanelWorkedCorrectlyAfterCickOnCancelButton
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00OMQQXWA1DRI6   |
	| 00RUUMAH9OZN9A   |
	| 00SH8162NAS524   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Babel (English, German and French)" Project on Action panel
	And User selects "Machines" Request Type on Action panel
	And User clicks the "CANCEL" Action button
	Then Actions panel is not displayed to the user
	And Checkboxes are not displayed

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13074
Scenario: EvergreenJnr_DevicesList_ChecksThatProjectNamesAreDisplayedCorrectlyInTheActionsDllAndInSelectedSection
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00OMQQXWA1DRI6   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	Then the following Projects are displayed in opened DLL on Action panel:
	| Projects                                         |
	| Babel (English, German and French)               |
	| Barry's User Project                             |
	| Computer Scheduled Test (Jo)                     |
	| Havoc (Big Data)                                 |
	| I-Computer Scheduled Project                     |
	| Migration Project Phase 2 (User Project)         |
	| Project K-Computer Scheduled Project             |
	| User Scheduled Test (Jo)                         |
	| Windows 7 Migration (Computer Scheduled Project) |
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	And User closed "Selected Columns" columns category
	And User is expand "Project Stages: Windows7Mi" columns category
	And the following Column subcategories are displayed for open category:
	| Subcategories                                               |
	| Windows7Mi: Command & Control                               |
	| Windows7Mi: Communication                                   |
	| Windows7Mi: Computer Information ---- Text fill; Text fill; |
	| Windows7Mi: Migration                                       |
	| Windows7Mi: Portal Self Service                             |
	| Windows7Mi: Post Migration                                  |
	| Windows7Mi: Pre-Migration                                   |

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13142
Scenario: EvergreenJnr_DevicesList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnDevicesPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00KLL9S8NRF0X6   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Barry's User Project" Project on Action panel
	And User selects "Desktop Replacement" Request Type on Action panel
	When User clears Project field
	And User clicks on Action drop-down
	Then "Barry's User Project" Project is displayed on Action panel

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13142
Scenario: EvergreenJnr_UsersList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnUsersPage
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Havoc (Big Data)" Project on Action panel
	And User selects "User Request Type 2" Request Type on Action panel
	When User clears Project field
	And User clicks on Action drop-down
	Then "Havoc (Big Data)" Project is displayed on Action panel

@Evergreen @Applications @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13142 @DAS12864 @DAS13270
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnApplicationsPage
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	Then Projects are displayed in alphabetical order on Action panel
	When User selects "User Scheduled Test (Jo)" Project on Action panel
	And User selects "Request Type A" Request Type on Action panel
	When User clears Project field
	And User clicks on Action drop-down
	Then "User Scheduled Test (Jo)" Project is displayed on Action panel

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13142
Scenario: EvergreenJnr_MailboxesList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 00A5B910A1004CF5AC4@bclabs.local |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Email Migration" Project on Action panel
	And User selects "Personal Mailbox - VIP" Request Type on Action panel
	When User clears Project field
	And User clicks on Action drop-down
	Then "Email Migration" Project is displayed on Action panel

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13355 @DAS13260 @DAS13281
Scenario Outline: EvergreenJnr_AllLists_ChecksThatTextValueHaveOptionToRemoveExistingTextValue
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Computer Scheduled Test (Jo)" Project on Action panel
	And User selects "One" Stage on Action panel
	And User selects "<TaskName>" Task on Action panel
	Then the following Update Value are displayed in opened DLL on Action panel:
	| Value  |
	| Update |
	| Remove |

Examples: 
	| PageName     | ColumnName  | RowName                          | TaskName                        |
	| Devices      | Hostname    | 01BQIYGGUW5PRP6                  | Text Computer                   |
	| Users        | Username    | 00DB4000EDD84951993              | Text User- Email Address        |
	| Applications | Application | 32VerSee v.231 en (C:\32VerSee\) | Text Application- Future Groups |

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13264 @DAS13265 @DAS13278
Scenario Outline: EvergreenJnr_AllLists_CheckThatUpdateAndCancelButtonsAreEnabledWhenUserLoggedWithProjectBulkUpdaterRole
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username   | FullName | Password | ConfirmPassword | Roles                |
	| <UserName> | DAS13264 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username   | Password |
	| <UserName> | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "<PageName>" on the left-hand menu
	Then "<PageName>" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "<ProjectName>" Project on Action panel
	And User selects "<StageName>" Stage on Action panel
	And User selects "<TaskName>" Task on Action panel
	And User selects "<UpdateDate>" Update Date on Action panel
	Then "UPDATE" Action button is active
	And "CANCEL" Action button is active
	When User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	And User clicks "CANCEL" button on message box
	Then the amber message is not displayed
	Then "UPDATE" Action button is active
	And "CANCEL" Action button is active
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "<UserName>" User

Examples: 
	| UserName          | PageName     | ColumnName    | RowName                                  | ProjectName                          | StageName             | TaskName                            | UpdateDate |
	| Devices13264      | Devices      | Hostname      | 00CWZRC4UK6W20                           | Babel (English, German and French)   | Initiation            | Scheduled Date                      | Remove     |
	| Users13264        | Users        | Username      | 0088FC8A50DD4344B92                      | Project K-Computer Scheduled Project | email                 | Email to be sent - All Placeholders | Remove     |
	| Applications13264 | Applications | Application   | 0047 - Microsoft Access 97 SR-2 Francais | Barry's User Project                 | Audit & Configuration | Package Delivery Date               | Remove     |
	| Mailboxes13264    | Mailboxes    | Email Address | 00C8BC63E7424A6E862@bclabs.local         | Email Migration                      | Pre-Migration         | Out Of Office Start Date            | Remove     |

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13268 @DAS13269 @DAS13272 @DAS13273 @DAS13276 @DAS13275
Scenario: EvergreenJnr_DevicesList_ChecksThatActionsPanelIsWorkingCorrectlyWhenSelectedTaskThatHasAnTeamOrOwner
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| DAS13268 | DAS13268 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13268 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 018UQ6KL9TF4YF   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Barry's User Project" Project on Action panel
	Then Stages are displayed in alphabetical order on Action panel
	When User selects "Audit & Configuration" Stage on Action panel
	Then Tasks are displayed in alphabetical order on Action panel
	When User selects "Validate User Device Ownership" Task on Action panel
	Then the Update Value options are displayed in following order:
	| Options               |
	| Update                |
	| No change             |
	When User selects "No change" Update Value on Action panel
	Then the Update Date options are displayed in following order:
	| Options   |
	| Update    |
	| Remove    |
	| No change |
	When User selects "No change" Update Date on Action panel
	Then the Update Owner options are displayed in following order:
	| Options               |
	| Update                |
	| Remove owner and team |
	| No change             |
	When User selects "Update" Update Owner on Action panel
	Then Teams are displayed in alphabetical order on Action panel
	When User selects "Admin IT" Team on Action panel
	Then Owner field is not displayed on Action panel
	When User selects "IB Team" Team on Action panel
	Then Owner field is displayed on Action panel
	When User selects "IB User" Owner on Action panel
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13268" User

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13280
Scenario: EvergreenJnr_DevicesList_CheckThatClearingAValueResetsSubsequentValuesr
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| DAS13280 | DAS13280 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13280 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 018UQ6KL9TF4YF   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "User Scheduled Test (Jo)" Project on Action panel
	When User selects "One" Stage on Action panel
	When User selects "Radio Rag Only Comp" Task on Action panel
	And User selects "Started" Value on Action panel
	When User selects "Computer Scheduled Test (Jo)" Project on Action panel
	Then Value field is not displayed on Action panel
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13280" User

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13281 @DAS13284 @DAS13285
Scenario Outline: EvergreenJnr_DevicesList_ChecksThatDllOptionsAreDisplayedCorrectly
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| DAS13281 | DAS13281 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13281 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	When User selects "Computer Information ---- Text fill; Text fill;" Stage on Action panel
	When User selects "Computer Read Only Task in Self Service" Task on Action panel
	Then the Update Value options are displayed in following order:
	| Options               |
	| Update                |
	| No change             |
	Then the Update Date options are displayed in following order:
	| Options   |
	| Update    |
	| Remove    |
	| No change |
	Then the Update Owner options are displayed in following order:
	| Options               |
	| Update                |
	| Remove owner and team |
	| No change             |
	When User selects "Workstation Text Task" Task on Action panel
	Then the Update Value options are displayed in following order:
	| Options   |
	| Update    |
	| Remove    |
	#| No change |
	When User selects "Computer Read Only Task in Self Service" Task on Action panel
	Then the Update Value options are displayed in following order:
	| Options               |
	| Update                |
	| No change             |
	When User selects "Update" Update Value on Action panel
	When User selects "Started" Value on Action panel
	When User selects "No change" Update Date on Action panel
	When User selects "No change" Update Owner on Action panel
	When User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	And User clicks "CANCEL" button on message box
	Then the amber message is not displayed
	When User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	Then User clicks "UPDATE" button on message box
	And Success message with "<MessageText>" text is displayed on Action panel
	Then Success message is hidden after five seconds
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13281" User

Examples: 
	| RowName        | MessageText                                                                           |
	| 00HA7MKAVVFDAV | 1 of 1 objects were valid for the update. Your changes have successfully been queued. |
	| 00I0COBFWHOF27 | 0 of 1 objects were valid for the update.                                             |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13288 @DAS13289 @DAS13287
Scenario Outline: EvergreenJnr_UsersList_ChecksThatTheNoChangeOptionIsWorkedCorrectlyForValueField
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| DAS13288 | Value    | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13288 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                               |
	| Windows7Mi: Perform User Acceptance Test |
	When User perform search by "<RowName>"
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	When User selects "User Acceptance Test" Stage on Action panel
	When User selects "Perform User Acceptance Test" Task on Action panel
	When User selects "Update" Update Value on Action panel
	When User selects "<NewValue>" Value on Action panel
	When User selects "No change" Update Date on Action panel
	When User selects "Update" Update Owner on Action panel
	When User selects "<NewTeam>" Team on Action panel
	When User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	Then User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	Then Success message is hidden after five seconds
	When User refreshes agGrid
	Then "<NewValue>" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
		#returns default object state
	When User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	When User selects "User Acceptance Test" Stage on Action panel
	When User selects "Perform User Acceptance Test" Task on Action panel
	When User selects "Update" Update Value on Action panel
	When User selects "<DefaultValue>" Value on Action panel
	When User selects "No change" Update Date on Action panel
	When User selects "Update" Update Owner on Action panel
	When User selects "<DefaultTeam>" Team on Action panel
	When User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User refreshes agGrid
	Then "<DefaultValue>" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13288" User

Examples: 
	| RowName    | NewValue       | NewTeam  | DefaultValue   | DefaultTeam         |
	| CQV0623434 | Complete       | Admin IT | Started        | Administrative Team |
	| BBZ877343  | Failed         | Admin IT | Not Applicable | Retail Team         |
	| DLL972653  | Complete       | Admin IT | Not Started    | K-Team              |
	| LZI970280  | Not Applicable | Admin IT | Failed         | IB Team             |
	| ZQX656408  | Not Applicable | Admin IT | Complete       | Migration Phase 2   |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13288 @DAS13289 @DAS13287
Scenario Outline: EvergreenJnr_UsersList_ChecksThatTheNoChangeOptionIsWorkedCorrectlyForDateField
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| DAS13288 | DAS13288 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13288 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                               |
	| Windows7Mi: Perform User Acceptance Test |
	When User perform search by "<RowName>"
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	When User selects "User Acceptance Test" Stage on Action panel
	When User selects "Perform User Acceptance Test" Task on Action panel
	When User selects "No change" Update Value on Action panel
	When User selects "Update" Update Date on Action panel
	When User selects "<NewDate>" Date on Action panel
	When User selects "Update" Update Owner on Action panel
	When User selects "<NewTeam>" Team on Action panel
	When User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	Then User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	Then Success message is hidden after five seconds
	When User refreshes agGrid
	Then "<DefaultValue>" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
		#returns default object state
	When User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	When User selects "User Acceptance Test" Stage on Action panel
	When User selects "Perform User Acceptance Test" Task on Action panel
	When User selects "No change" Update Value on Action panel
	When User selects "Update" Update Date on Action panel
	When User selects "<DefaultDate>" Date on Action panel
	When User selects "Update" Update Owner on Action panel
	When User selects "<DefaultTeam>" Team on Action panel
	When User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User refreshes agGrid
	Then "<DefaultValue>" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13288" User

Examples: 
	| RowName    | NewDate      | NewTeam  | DefaultDate  | DefaultTeam         | DefaultValue   |
	| CQV0623434 | May 19, 2018 | Admin IT | May 08, 2015 | Administrative Team | Complete       |
	| BBZ877343  | Aug 28, 2001 | Admin IT | Sep 07, 2018 | Retail Team         | Failed         |
	| DLL972653  | Aug 30, 2018 | Admin IT | Sep 05, 2018 | K-Team              | Complete       |
	| LZI970280  | May 09, 2018 | Admin IT | Sep 03, 2018 | IB Team             | Not Applicable |
	| ZQX656408  | Aug 15, 2018 | Admin IT | Aug 30, 2018 | Migration Phase 2   | Not Applicable |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13288 @DAS13289 @DAS13287
Scenario Outline: EvergreenJnr_UsersList_ChecksThatTheNoChangeOptionIsWorkedCorrectlyForOwnerField
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| DAS13288 | DAS13288 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13288 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                               |
	| Windows7Mi: Perform User Acceptance Test |
	When User perform search by "<RowName>"
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	When User selects "User Acceptance Test" Stage on Action panel
	When User selects "Perform User Acceptance Test" Task on Action panel
	When User selects "Update" Update Value on Action panel
	When User selects "<NewValue>" Value on Action panel
	When User selects "Update" Update Date on Action panel
	When User selects "<NewDate>" Date on Action panel
	When User selects "No change" Update Owner on Action panel
	When User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	Then User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	Then Success message is hidden after five seconds
	When User refreshes agGrid
	Then "<NewValue>" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
		#returns default object state
	When User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	When User selects "User Acceptance Test" Stage on Action panel
	When User selects "Perform User Acceptance Test" Task on Action panel
	When User selects "Update" Update Value on Action panel
	When User selects "<DefaultValue>" Value on Action panel
	When User selects "Update" Update Date on Action panel
	When User selects "<DefaultDate>" Date on Action panel
	When User selects "No change" Update Owner on Action panel
	When User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User refreshes agGrid
	Then "<DefaultValue>" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13288" User

Examples: 
	| RowName    | NewValue       | NewDate      | DefaultValue   | DefaultDate  |
	| CQV0623434 | Complete       | Sep 01, 2009 | Started        | May 08, 2015 |
	| BBZ877343  | Failed         | Aug 28, 2001 | Not Applicable | Sep 07, 2018 |
	| DLL972653  | Complete       | Aug 30, 2018 | Not Started    | Sep 05, 2018 |
	| LZI970280  | Not Applicable | May 09, 2018 | Failed         | Sep 03, 2018 |
	| ZQX656408  | Not Applicable | Aug 15, 2018 | Complete       | Aug 30, 2018 |

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13290
Scenario: EvergreenJnr_UsersList_ChecksThatDateRemovingIsWorksCorrectly
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username | FullName | Password | ConfirmPassword | Roles                |
	| DAS13290 | DAS13290 | 1234qwer | 1234qwer        | Project Bulk Updater |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username | Password |
	| DAS13290 | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                               |
	| Windows7Mi: Perform User Acceptance Test |
	When User perform search by "LZI970280"
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| LZI970280        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	When User selects "User Acceptance Test" Stage on Action panel
	When User selects "Perform User Acceptance Test" Task on Action panel
	When User selects "Update" Update Value on Action panel
	When User selects "Complete" Value on Action panel
	When User selects "Remove" Update Date on Action panel
	When User selects "No change" Update Owner on Action panel
	When User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	Then User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	Then Success message is hidden after five seconds
	When User refreshes agGrid
	Then "Complete" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
		#returns default object state
	When User selects "Bulk update" in the Actions dropdown
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "Windows 7 Migration (Computer Scheduled Project)" Project on Action panel
	When User selects "User Acceptance Test" Stage on Action panel
	When User selects "Perform User Acceptance Test" Task on Action panel
	When User selects "Update" Update Value on Action panel
	When User selects "Failed" Value on Action panel
	When User selects "Update" Update Date on Action panel
	When User selects "Sep 03, 2018" Date on Action panel
	When User selects "No change" Update Owner on Action panel
	When User clicks the "UPDATE" Action button
	Then the amber message is displayed correctly
	Then User clicks "UPDATE" button on message box
	And Success message with "1 of 1 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User refreshes agGrid
	Then "Failed" content is displayed in "Windows7Mi: Perform User Acceptance Test" column
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "DAS13290" User