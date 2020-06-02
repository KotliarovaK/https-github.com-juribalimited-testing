Feature: UpdatePathPart1
	Runs Bulk Update Update path related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS12932 @DAS13261 @DAS20438 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNewlyCreatedNonTeamUserCanNotUpdatePath
	When User create new User via API
	| Username   | Email | FullName             | Password  | Roles                |
	| 000WithPBU | Value | Project Bulk Updater | m!gration | Project Bulk Updater |
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username   | Password  |
 	| 000WithPBU | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Windows7Mi: Path |
	And User perform search by "0DTXL41673EW7O"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 0DTXL41673EW7O   |
	Then '[This is the Default Request Type for Computer)]' content is displayed in the 'Windows7Mi: Path' column
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update path' in the 'Bulk Update Type' dropdown
	When User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	When User selects 'Computer: Laptop Replacement' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then '[This is the Default Request Type for Computer)]' content is displayed in the 'Windows7Mi: Path' column
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "000WithPBU" User

	#AnnI 6/2/20: DAS21304 fixed only for 'Yellow_Dwarf'
@Evergreen @Applications @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS12932 @DAS13261 @DAS16826 @DAS18267 @DAS21304 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_ApplicationsList_CheckThatUserWithoutJustTheProjectBulkUpdaterRoleCanStillBulkUpdateObjects
	When User create new User via API
	| Username  | Email | FullName              | Password  | Roles                 |
	| 000WithPA | Value | Project Administrator | m!gration | Project Administrator |
	When User clicks the Logout button
 	When User is logged in to the Evergreen as
 	| Username  | Password  |
 	| 000WithPA | m!gration |
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| EmailMigra: Path |
	And User perform search by "0047 - Microsoft Access 97 SR-2 Francais"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Email Migration' option from 'Project' autocomplete
	And User selects 'Sharepoint Application' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User refreshes agGrid
	Then "Sharepoint Application" content is displayed for "EmailMigra: Path" column
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User removes "000WithPA" User
	
@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12863 @DAS13266 @DAS13284 @DAS16826
Scenario: EvergreenJnr_DevicesList_ChecksThatRequestTypeIsUpdatedCorrectlyOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "Windows7Mi: In Scope" filter is added to the list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Windows7Mi: Path |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001PSUMZYOW581   |
	| 00BDM1JUR8IF419  |
	| 00RUUMAH9OZN9A   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	Then 'UPDATE' button is disabled
	When User selects 'Computer: PC Rebuild' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "3 of 3 objects were in the selected project and have been queued" text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "001PSUMZYOW581"
	Then 'Computer: PC Rebuild' content is displayed in the 'Windows7Mi: Path' column
	When User perform search by "00BDM1JUR8IF419"
	Then 'Computer: PC Rebuild' content is displayed in the 'Windows7Mi: Path' column
	When User perform search by "00RUUMAH9OZN9A"
	Then 'Computer: PC Rebuild' content is displayed in the 'Windows7Mi: Path' column
	When User closes Tools panel
	And User clicks Close panel button
		#returns default object state
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001PSUMZYOW581   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Computer: Virtual Machine' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00BDM1JUR8IF419  |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects '[This is the Default Request Type for Computer)]' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00RUUMAH9OZN9A   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Computer: Laptop Replacement' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel

@Evergreen @Users @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12863 @DAS13266 @DAS13284
Scenario: EvergreenJnr_UsersList_ChecksThatRequestTypeIsUpdatedCorrectlyOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "Windows7Mi: In Scope" filter is added to the list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Windows7Mi: Path |
	And User clicks on 'Windows7Mi: Path' column header
	And User clicks on 'Windows7Mi: Path' column header
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| FMN5805290       |
	| AKX995383        |
	| AAD1011948       |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	Then 'UPDATE' button is disabled
	When User selects 'User; Maternity' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "3 of 3 objects were in the selected project and have been queued" text is displayed on Action panel
	When User refreshes agGrid
	When User clicks Search button and opens Search panel for agGrid
	And User perform search by "FMN5805290"
	Then 'User; Maternity' content is displayed in the 'Windows7Mi: Path' column
	When User perform search by "AKX995383"
	Then 'User; Maternity' content is displayed in the 'Windows7Mi: Path' column
	When User perform search by "AAD1011948"
	Then 'User; Maternity' content is displayed in the 'Windows7Mi: Path' column
	When User closes Tools panel
	And User clicks Close panel button
	When User refreshes agGrid
		#returns default object state
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| FMN5805290       |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'User: VIP' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| AKX995383        |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'User: No Agent' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName |
	| AAD1011948       |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects '[Default (User)]' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel

@Evergreen @Applications @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12863 @DAS13266 @DAS13284 @DAS16826
Scenario: EvergreenJnr_ApplicationsList_ChecksThatRequestTypeIsUpdatedCorrectlyOnApplicationsPage
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "Windows7Mi: In Scope" filter is added to the list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Windows7Mi: Path |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                                           |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                 |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	Then 'UPDATE' button is disabled
	When User selects 'Application: Request Type B' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "2 of 2 objects were in the selected project and have been queued" text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by ""WPF/E" (codename) Community Technology Preview (Feb 2007)"
	Then 'Application: Request Type B' content is displayed in the 'Windows7Mi: Path' column
	When User perform search by "0004 - Adobe Acrobat Reader 5.0.5 Francais"
	Then 'Application: Request Type B' content is displayed in the 'Windows7Mi: Path' column
	When User closes Tools panel
	And User clicks Close panel button
	When User refreshes agGrid
#returns default object state
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                                           |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects '[Default (Application)]' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                           |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Application: Request Type A' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel

@Evergreen @Mailboxes @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12863 @DAS13266 @DAS13284 @DAS13708
Scenario: EvergreenJnr_MailboxesList_ChecksThatRequestTypeIsUpdatedCorrectlyOnMailboxesPage
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "EmailMigra: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	Then "EmailMigra: In Scope" filter is added to the list
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| EmailMigra: Path |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 0F1ED67386AD4FA7BF4@bclabs.local |
	| 10A919CA1E7641E08E7@bclabs.local |
	| 229DCF8E575243E9928@bclabs.local |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Email Migration' option from 'Project' autocomplete
	Then 'UPDATE' button is disabled
	When User selects 'Personal Mailbox - VIP' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "3 of 3 objects were in the selected project and have been queued" text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "0F1ED67386AD4FA7BF4@bclabs.local"
	Then 'Personal Mailbox - VIP' content is displayed in the 'EmailMigra: Path' column
	When User perform search by "10A919CA1E7641E08E7@bclabs.local"
	Then 'Personal Mailbox - VIP' content is displayed in the 'EmailMigra: Path' column
	When User perform search by "229DCF8E575243E9928@bclabs.local"
	Then 'Personal Mailbox - VIP' content is displayed in the 'EmailMigra: Path' column
	When User closes Tools panel
	And User clicks Close panel button
	When User refreshes agGrid
#returns default object state
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 0F1ED67386AD4FA7BF4@bclabs.local |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Email Migration' option from 'Project' autocomplete
	And User selects 'Shared Mailbox' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 10A919CA1E7641E08E7@bclabs.local |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Email Migration' option from 'Project' autocomplete
	And User selects 'Personal Mailbox - EA' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 229DCF8E575243E9928@bclabs.local |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Email Migration' option from 'Project' autocomplete
	And User selects 'Personal Mailbox' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel

@Evergreen @Devices @EvergreenJnr_ActionsPanel @BulkUpdate @DAS12864 @DAS12863 @DAS13266 @DAS13284
Scenario: EvergreenJnr_DevicesList_ChecksThatRequestTypeIsUpdatedCorrectlyWhereSomeObjectsAreValidAndSomeAreInvalidForTheSelectedProject
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName       |
	| Windows7Mi: Path |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| 001BAQXT6JWFPI   |
	| 001PSUMZYOW581   |
	| 00RUUMAH9OZN9A   |
	| 1B1CJ31RV9ZPYD   |
	| 018UQ6KL9TF4YF   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Computer: Workstation Replacement' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "5 of 5 objects were in the selected project and have been queued" text is displayed on Action panel
	When User refreshes agGrid
	And User perform search by "001BAQXT6JWFPI"
	Then "Computer: Workstation Replacement" content is displayed for "Windows7Mi: Path" column
	When User perform search by "001PSUMZYOW581"
	Then "Computer: Workstation Replacement" content is displayed for "Windows7Mi: Path" column
	When User perform search by "00RUUMAH9OZN9A"
	Then "Computer: Workstation Replacement" content is displayed for "Windows7Mi: Path" column
	When User perform search by "1B1CJ31RV9ZPYD"
	Then "Computer: Workstation Replacement" content is displayed for "Windows7Mi: Path" column
	When User perform search by "018UQ6KL9TF4YF"
	Then "Computer: Workstation Replacement" content is displayed for "Windows7Mi: Path" column
	When User closes Tools panel
	And User clicks Close panel button
	When User refreshes agGrid
#returns default object state
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| 1B1CJ31RV9ZPYD   |
	| 018UQ6KL9TF4YF   |
	| 001BAQXT6JWFPI   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects '[This is the Default Request Type for Computer)]' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "3 of 3 objects were in the selected project and have been queued" text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| 001PSUMZYOW581   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Computer: Virtual Machine' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel
	When User clicks Close panel button
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User searches and selects following rows in the grid on Details page:
	| SelectedRowsName |
	| 00RUUMAH9OZN9A   |
	And User selects 'Bulk update' in the 'Action' dropdown
	And User selects 'Update path' in the 'Bulk Update Type' dropdown
	And User selects 'Windows 7 Migration (Computer Scheduled Project)' option from 'Project' autocomplete
	And User selects 'Computer: Laptop Replacement' option from 'Path' autocomplete
	And User clicks 'UPDATE' button 
	Then Warning message with "This operation cannot be undone" text is displayed on Action panel
	When User clicks 'UPDATE' button
	Then Success message with "1 of 1 object was in the selected project and has been queued" text is displayed on Action panel