﻿Feature: ActionsPanelPart5
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

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
	And User selects "Update path" Bulk Update Type on Action panel
	Then Projects are displayed in alphabetical order on Action panel
	When User selects "User Scheduled Test (Jo)" Project on Action panel
	And User selects "Request Type A" Path on Action panel
	When User clears Project field
	And User clicks on Action drop-down
	Then "User Scheduled Test (Jo)" Project is displayed on Action panel

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS13142 @DAS16826
Scenario: EvergreenJnr_MailboxesList_CheckThatProjectFieldIsDisplayedCorrectlyAfterClearingOnMailboxesPage
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 00A5B910A1004CF5AC4@bclabs.local |
	And User selects "Bulk update" in the Actions dropdown
	Then following values are displayed in "Bulk Update Type" drop-down on Action panel:
	| Options              |
	| Update bucket        |
	| Update capacity unit |
	| Update path          |
	| Update ring          |
	| Update task value    |
	When User selects "Update path" Bulk Update Type on Action panel
	And User selects "Email Migration" Project on Action panel
	And User selects "Personal Mailbox - VIP" Path on Action panel
	When User clears Project field
	And User clicks on Action drop-down
	Then "Email Migration" Project is displayed on Action panel

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13355 @DAS13260 @DAS13281
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

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS13264 @DAS13265 @DAS13278 @DAS14448 @Cleanup
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
	And the amber message is not displayed
	And "UPDATE" Action button is active
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
	| UserName              | PageName     | ColumnName    | RowName                                  | ProjectName                        | StageName             | TaskName                 | UpdateDate |
	| DAS13264_Devices      | Devices      | Hostname      | 00CWZRC4UK6W20                           | Babel (English, German and French) | Initiation            | Scheduled Date           | Remove     |
	| DAS13264_Users        | Users        | Username      | 0088FC8A50DD4344B92                      | Barry's User Project               | Project Dates         | Scheduled Date           | Remove     |
	| DAS13264_Applications | Applications | Application   | 0047 - Microsoft Access 97 SR-2 Francais | Barry's User Project               | Audit & Configuration | Package Delivery Date    | Remove     |
	| DAS13264_Mailboxes    | Mailboxes    | Email Address | 00C8BC63E7424A6E862@bclabs.local         | Email Migration                    | Pre-Migration         | Out Of Office Start Date | Remove     |