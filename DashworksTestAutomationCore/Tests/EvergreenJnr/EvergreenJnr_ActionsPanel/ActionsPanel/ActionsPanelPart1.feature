Feature: ActionsPanelPart1
	Runs Actions Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @DAS10860
Scenario: EvergreenJnr_UsersList_CheckThatAfterClosingActionsPanelTheActionsButtonIsNotShownInRed
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User clicks the Actions button
	Then Actions panel is not displayed to the user

@Evergreen @Users @EvergreenJnr_ActionsPanel @DAS12864 @DAS12932 @DAS13262 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatUserWithoutRelevantRolesCannotSeeBulkUpdateOptionInActionsPanel
	When User clicks 'Projects' on the left-hand menu
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
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	| 0088FC8A50DD4344B92 |
	Then following Values are displayed in the 'Action' dropdown:
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

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14161
Scenario: EvergreenJnr_MailboxesList_CheckBucketBulkUpdateOptionsOnMailboxesListForMailboxScopedProjectAreDisplayedCorrectly
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 00BDBAEA57334C7C8F4@bclabs.local |
	| 016E1B57C2DD4FCC986@bclabs.local |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update bucket' option from 'Bulk Update Type' autocomplete
	And User selects 'Mailbox Evergreen Capacity Project' option from 'Project or Evergreen' autocomplete
	And User selects 'Unassigned' option from 'Bucket' autocomplete
	Then following Values are displayed in the 'Also Move Users' dropdown:
	| Options          |
	| None             |
	| Owners only      |
	| All linked users |
	When User selects 'Owners only' in the 'Also Move Users' dropdown
	Then 'UPDATE' button is not disabled

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14162
Scenario: EvergreenJnr_MailboxesList_CheckThatOnMailboxesListForBucketBulkUpdateOptionsOnlyDisplayedEvergreenOrMailboxScopedProjects
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 00BDBAEA57334C7C8F4@bclabs.local |
	| 016E1B57C2DD4FCC986@bclabs.local |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update bucket' option from 'Bulk Update Type' autocomplete
	Then 'Project or Evergreen' autocomplete contains following options:
	| Options                            |
	| Email Migration                    |
	| Mailbox Evergreen Capacity Project |

@Evergreen @Applications @EvergreenJnr_ActionsPanel @BulkUpdate @DAS14563 @DAS13960 @DAS14164 @DAS16826
Scenario: EvergreenJnr_ApplicationsList_CheckThatBucketBulkUpdateOptionNotAvailableOnApplicationsList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                                           |
	| %SQL_PRODUCT_SHORT_NAME% SSIS 64Bit For SSDTBI             |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	And User selects 'Bulk update' in the 'Action' dropdown
	#Add step to check defoult value for 'Bulk Update Type'autocomplete 4/06/2020 Kate
	#Then following Values are displayed in the 'Bulk Update Type' dropdown:
	#| Options                       |
	#| Update application attributes |
	#| Update capacity unit          |
	#| Update custom field           |
	#| Update path                   |
	#| Update task value             |
	#| Manage favourites             |

@Evergreen @Applications @EvergreenJnr_ActionsPanel @DAS197462 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckActionPanelAfterAddingObjectsToStaticListViaListPanel
	When User create static list with "FirstList197462" name on "Applications" page with following items
	| ItemName |
	|          |
	Then "FirstList197462" list is displayed to user
	When User create static list with "SecondList197462" name on "Applications" page with following items
	| ItemName |
	|          |
	Then "SecondList197462" list is displayed to user
	When User clicks on 'Vendor' column header
	Then data in table is sorted by 'Vendor' column in ascending order
	When User clicks 'SAVE' button and select 'ADD TO STATIC LIST' menu button
	And User selects 'FirstList197462' in the 'Add to static list' dropdown
	And User clicks 'SAVE' button
	Then "FirstList197462" list is displayed to user
	When User clicks the Actions button
	Then 'Select at least one row' message is displayed on Actions panel to the user