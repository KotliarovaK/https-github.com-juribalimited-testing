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

@Evergreen @Users @EvergreenJnr_ActionsPanel @DAS12932
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

@Evergreen @Devices @EvergreenJnr_ActionsPanel @DAS12932
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

@Evergreen @Applications @EvergreenJnr_ActionsPanel @DAS12932
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

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @DAS12946 @Delete_Newly_Created_List
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
	And User selects "Update task value" Bulk Update Type on Action panel
	And User selects "<ProjectName>" Project on Action panel
	And User selects "<StageName>" Stage on Action panel
	And User selects "<TaskName>" Task on Action panel
	And User selects "<Value>" Value on Action panel
	And User clicks the "UPDATE" Action button
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

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @DAS12946 @Delete_Newly_Created_List
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

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @DAS12946 @Delete_Newly_Created_List
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

@Evergreen @Devices @EvergreenJnr_ActionsPanel @DAS12863
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
	| 00K4CEEQ737BA4L  |
	| 00YTY8U3ZYP2WT   |
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
	When User perform search by "00K4CEEQ737BA4L"
	Then "Computer: PC Rebuild" content is displayed in "Windows7Mi: Request Type" column
	When User perform search by "00YTY8U3ZYP2WT"
	Then "Computer: PC Rebuild" content is displayed in "Windows7Mi: Request Type" column

@Evergreen @Users @EvergreenJnr_ActionsPanel @DAS12863
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
	When User click on 'Windows7Mi: Request Type' column header
	When User click on 'Windows7Mi: Request Type' column header
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| FMN5805290       |
	| AKX995383        |
	| ADC714277       |
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
	When User perform search by "ADC714277"
	Then "User; Maternity" content is displayed in "Windows7Mi: Request Type" column

@Evergreen @Applications @EvergreenJnr_ActionsPanel @DAS12863
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
	| SelectedRowsName                           |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	| 0036 - Microsoft Access 97 SR-2 English    |
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
	And User perform search by "0004 - Adobe Acrobat Reader 5.0.5 Francais"
	Then "Application: Request Type B" content is displayed in "Windows7Mi: Request Type" column
	When User perform search by "0036 - Microsoft Access 97 SR-2 English"
	Then "Application: Request Type B" content is displayed in "Windows7Mi: Request Type" column

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @DAS12863
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
	| 06C02CDC00044A7DB59@bclabs.local |
	| 10A919CA1E7641E08E7@bclabs.local |
	| 0C1785B7E6954139AC5@bclabs.local |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update request type" Bulk Update Type on Action panel
	And User selects "Email Migration" Project on Action panel
	Then "UPDATE" Action button is disabled
	When User selects "Personal Mailbox - EA" Request Type on Action panel
	And User clicks the "UPDATE" Action button
	Then Warning message with "Are you sure you want to proceed, this operation cannot be undone." text is displayed on Action panel
	And User clicks "UPDATE" button on message box
	And Success message with "3 of 3 objects were valid for the update. Your changes have successfully been queued." text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "06C02CDC00044A7DB59@bclabs.local"
	Then "Personal Mailbox - EA" content is displayed in "EmailMigra: Request Type" column
	When User perform search by "10A919CA1E7641E08E7@bclabs.local"
	Then "Personal Mailbox - EA" content is displayed in "EmailMigra: Request Type" column
	When User perform search by "0C1785B7E6954139AC5@bclabs.local"
	Then "Personal Mailbox - EA" content is displayed in "EmailMigra: Request Type" column

@Evergreen @Devices @EvergreenJnr_ActionsPanel @DAS12863
Scenario: EvergreenJnr_DevicesList_ChecksThatRequestTypeIsUpdatedCorrectlyWhereSomeObjectsAreValidAndSomeAreInvalidForTheSelectedProject
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Actions button
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
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName               |
	| Windows7Mi: Request Type |
	And User refreshes agGrid
	And User perform search by "00HA7MKAVVFDAV"
	Then "Computer: Workstation Replacement" content is displayed in "Windows7Mi: Request Type" column
	When User perform search by "018UQ6KL9TF4YF"
	Then "Computer: Workstation Replacement" content is displayed in "Windows7Mi: Request Type" column

@Evergreen @Devices @EvergreenJnr_ActionsPanel @DAS12863
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

@Evergreen @Devices @EvergreenJnr_ActionsPanel @DAS13074
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
	Then User closed "Selected Columns" columns category
	Then User is expand "Project Stages: Windows7Mi" columns category
	Then the following Column subcategories are displayed for open category:
	| Subcategories                                               |
	| Windows7Mi: Command & Control                               |
	| Windows7Mi: Communication                                   |
	| Windows7Mi: Computer Information ---- Text fill; Text fill; |
	| Windows7Mi: Migration                                       |
	| Windows7Mi: Portal Self Service                             |
	| Windows7Mi: Post Migration                                  |
	| Windows7Mi: Pre-Migration                                   |