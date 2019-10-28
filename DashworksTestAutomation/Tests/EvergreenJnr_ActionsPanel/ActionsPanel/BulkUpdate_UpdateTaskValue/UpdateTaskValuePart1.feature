Feature: UpdateTaskValuePart1
	Runs Bulk Update Update task value related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18245 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_UsersList_CheckUpdateTaskValueWithBeforeCurrentValueUpdateDate
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                          |
	| zDeviceAut: Relative BU \ DT BU Dev |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "Equals" with added column and following value:
	| Values         |
	| 00I0COBFWHOF27 |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Dev' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '1' text to 'Value' textbox
	When User selects 'Before current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "14 Oct 2019" content is displayed for "zDeviceAut: Relative BU \ DT BU Dev" column
	#Return value
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zDevice Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Dev' option from 'Task' autocomplete
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '1' text to 'Value' textbox
	And User clicks 'UPDATE' button
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "15 Oct 2019" content is displayed for "zDeviceAut: Relative BU \ DT BU Dev" column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18245 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_UsersList_CheckUpdateTaskValueWithNoChangeUpdateValue
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                |
	| zUserAutom: Relative BU \ DT BU Us (Date) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Username" filter where type is "Equals" with added column and following value:
	| Values              |
	| 2176236000044A2CA08 |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Us' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '2' text to 'Value' textbox
	When User selects 'Hours' in the 'Units' dropdown
	When User selects 'After current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	When User refreshes agGrid
	#Then '16 Oct 2019' content is displayed in the 'zUserAutom: Relative BU \ DT BU Us (Date)' column
	#Return value
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Us' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '2' text to 'Value' textbox
	When User selects 'Hours' in the 'Units' dropdown
	When User selects 'Before current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	#Then '16 Oct 2019' content is displayed in the 'zUserAutom: Relative BU \ DT BU Us (Date)' column

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS18245 @Not_Ready
#Waiting for 'Update relative to now' value
Scenario: EvergreenJnr_UsersList_CheckUpdateTaskValueWithAfterCurrentValueUpdate
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                                   |
	| zMailboxAu: Relative BU \ DT BU Users (Date) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Username" filter where type is "Equals" with added column and following value:
	| Values              |
	| 06C02CDC00044A7DB59 |
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zMailbox Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Relative BU' option from 'Stage' autocomplete
	When User selects 'DT BU Users' option from 'Task' autocomplete
	When User selects 'No change' in the 'Update Value' dropdown
	When User selects 'Update relative to current value' in the 'Update Date' dropdown
	When User enters '2' text to 'Value' textbox
	When User selects 'After current value' in the 'Before or After' dropdown
	And User clicks 'UPDATE' button
	Then the amber message is displayed correctly
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "" content is displayed for "zMailboxAu: Relative BU \ DT BU Users (Date)" column

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12946 @DAS12864 @DAS13258 @DAS13259 @DAS13260 @DAS13263 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_ChecksThatRemoveFromStaticListOptionIsNotShownInTheActionsPanelWhenAStaticListDoesNotExist
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks on '<ColumnHeader>' column header
	When User create dynamic list with "DynamicList12946" name on "<PageName>" page
	Then "DynamicList12946" list is displayed to user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	Then following Values are displayed in the 'Action' dropdown:
	| Value              |
	| Create static list |
	| Bulk update        |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	Then 'UPDATE' button is disabled
	And 'CANCEL' button is not disabled
	When User selects '<ProjectName>' option from 'Project' autocomplete
	And User selects '<StageName>' option from 'Stage' autocomplete
	And User selects '<TaskName>' option from 'Task' autocomplete
	And User selects '<Value>' in the 'Value' dropdown
	When User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "0 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	Then There are no errors in the browser console

Examples: 
	| PageName     | ColumnHeader  | RowName                          | ProjectName              | StageName      | TaskName                | Value                    |
	| Devices      | Hostname      | 001PSUMZYOW581                   | User Scheduled Test (Jo) | Two            | Radio Non Rag only Comp | Not Applicable           |
	| Users        | Username      | 003F5D8E1A844B1FAA5              | User Scheduled Test (Jo) | Two            | Radio Non Rag only User | Not Applicable           |
	| Applications | Application   | 7zip                             | User Scheduled Test (Jo) | Two            | Radio Non Rag only App  | Not Applicable           |
	| Mailboxes    | Email Address | 00BDBAEA57334C7C8F4@bclabs.local | Email Migration          | Mobile Devices | Mobile Device Status    | Identified & In Progress |

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13355 @DAS13260 @DAS13281
Scenario Outline: EvergreenJnr_AllLists_ChecksThatTextValueHaveOptionToRemoveExistingTextValue
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	And User selects 'One' option from 'Stage' autocomplete
	And User selects '<TaskName>' option from 'Task' autocomplete
	Then following Values are displayed in the 'Update Value' dropdown:
	| Value  |
	| Update |
	| Remove |

Examples:
	| PageName     | ColumnName  | RowName                          | TaskName                        |
	| Devices      | Hostname    | 01BQIYGGUW5PRP6                  | Text Computer                   |
	| Users        | Username    | 00DB4000EDD84951993              | Text User- Email Address        |
	| Applications | Application | 32VerSee v.231 en (C:\32VerSee\) | Text Application- Future Groups |

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13264 @DAS13265 @DAS13278 @DAS14448 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatUpdateAndCancelButtonsAreEnabledWhenUserLoggedWithProjectBulkUpdaterRole
	When User clicks 'Projects' on the left-hand menu
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
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update task value' in the 'Bulk Update Type' dropdown
	And User selects '<ProjectName>' option from 'Project' autocomplete
	And User selects '<StageName>' option from 'Stage' autocomplete
	And User selects '<TaskName>' option from 'Task' autocomplete
	And User selects '<UpdateDate>' in the 'Update Date' dropdown
	Then 'UPDATE' button is not disabled
	And 'CANCEL' button is not disabled
	When User clicks 'UPDATE' button 
	Then the amber message is displayed correctly
	When User clicks 'CANCEL' button
	Then the amber message is not displayed
	And 'UPDATE' button is not disabled
	And 'CANCEL' button is not disabled
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
	| UserName              | PageName     | ColumnName    | RowName                                  | ProjectName                        | StageName             | TaskName                 | UpdateDate |
	| DAS13264_Devices      | Devices      | Hostname      | 00CWZRC4UK6W20                           | Babel (English, German and French) | Initiation            | Scheduled Date           | Remove     |
	| DAS13264_Users        | Users        | Username      | 0088FC8A50DD4344B92                      | Barry's User Project               | Project Dates         | Scheduled Date           | Remove     |
	| DAS13264_Applications | Applications | Application   | 0047 - Microsoft Access 97 SR-2 Francais | Barry's User Project               | Audit & Configuration | Package Delivery Date    | Remove     |
	| DAS13264_Mailboxes    | Mailboxes    | Email Address | 00C8BC63E7424A6E862@bclabs.local         | Email Migration                    | Pre-Migration         | Out Of Office Start Date | Remove     |