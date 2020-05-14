Feature: FBU_UpdateTaskValue
	Runs Favourite Bulk Update Update Task Value related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20937 @Yellow_Dwarf
Scenario Outline: EvergreenJnr_AllLists_CheckFavouriteBulkUpdateUpdateTaskValueTypeValidations
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnHeader>" rows in the grid
	| SelectedRowsName |
	| <RowName>        |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	Then Star button is disabled
	Then Star button has tooltip with 'Some values are missing or not valid' text
	When User selects '<ProjectName>' option from 'Project' autocomplete
	Then Star button is disabled
	Then Star button has tooltip with 'Some values are missing or not valid' text
	When User selects '<Task>' option from 'Task' autocomplete
	Then Star button is not disabled
	Then Star button has tooltip with 'Save as Favourite Bulk Update Type' text
	Then 'UPDATE' button is disabled
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text

Examples: 
	| PageName     | ColumnHeader  | RowName                          | ProjectName     | Task                                  |
	| Devices      | Hostname      | 00BDM1JUR8IF419                  | 2004 Rollout    | Pre-Migration \ Device Priority       |
	| Users        | Username      | 002B5DC7D4D34D5C895              | 2004 Rollout    | Pre-Migration \ User Workflow         |
	| Applications | Application   | 20040610sqlserverck              | 2004 Rollout    | Pre-Migration \ App Workflow          |
	| Mailboxes    | Email Address | 002B5DC7D4D34D5C895@bclabs.local | Email Migration | Mobile Devices \ Mobile Device Status |

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20940 @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckCreateFavouriteBulkUpdatePopupWindowValidationsFotUsersList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 2 \ Weekdays Task' option from 'Task' autocomplete
	When User clicks Star button
	Then popup with 'Create Favourite Bulk Update' title is displayed
	Then 'This favourite bulk update will be created with the following parameters:' text is displayed on popup
	Then following fields are displayed in the popup:
	| Fields           |
	| Bulk Update Type |
	| Project          |
	| Task             |
	Then User compares data in the fields in the popup:
	| Field            | Data                              |
	| Bulk Update Type | Update task value                 |
	| Project          | zUser Sch for Automations Feature |
	| Task             | Stage 2 \ Weekdays Task           |
	Then 'CANCEL' button is not disabled
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	When User enters '' text to 'Favourite Bulk Update Name' textbox
	Then 'Favourite bulk update name must be entered' error message is displayed for 'Favourite Bulk Update Name' field
	When User enters '20940_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 2 \ Weekdays Task' option from 'Task' autocomplete
	When User clicks Star button
	When User enters '20940_TestFBU' text to 'Favourite Bulk Update Name' textbox
	Then 'Favourite Bulk Update Name should be unique' error message is displayed for 'Favourite Bulk Update Name' field

@Evergreen @AllDevices @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20950 @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckValueAndIconsForFavouriteBulkUpdateItemsUpdateTaskValueType
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 1 \ Dropdown Task' option from 'Task' autocomplete
	When User clicks Star button
	When User enters '20950_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks Star button
	When User enters 'TestFBU_20950' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks Star button
	When User enters 'testFBU_209501' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks Star button
	When User enters 'abc_20950' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	Then following items have star icon in the 'Bulk Update Type' dropdown:
	| Items          |
	| 20950_TestFBU  |
	| TestFBU_20950  |
	| testFBU_209501 |
	| abc_20950      |
	Then Favourite Bulk Update items are displayed in ascending order

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20940 @Yellow_Dwarf
Scenario: EvergreenJnr_AllApplications_CheckSelectedValueForCreatedFavouriteBulkUpdateUpdateTaskValueType
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 2 \ Radio Date Slot App' option from 'Task' autocomplete
	When User selects 'Started' in the 'Update Value' dropdown
	When User selects 'Update relative to a different task value' in the 'Update Date' dropdown
	When User selects 'Stage 1 \ Radiobutton Date App Task' option from 'Relative Task' autocomplete
	When User enters '5' text to 'Value' textbox
	When User selects 'weekdays after task value' in the 'DateUnit' dropdown
	When User clicks Star button
	When User clicks 'CANCEL' button on popup
	When User selects 'Failed' in the 'Update Value' dropdown
	When User selects 'weekdays before task value' in the 'DateUnit' dropdown
	When User clicks Star button
	Then following fields are displayed in the popup:
	| Fields           |
	| Bulk Update Type |
	| Project          |
	| Task             |
	| Update Value     |
	| Update Date      |
	| Relative Project |
	| Relative Task    |
	| Value            |
	Then User compares data in the fields in the popup:
	| Field            | Data                                      |
	| Bulk Update Type | Update task value                         |
	| Project          | zUser Sch for Automations Feature         |
	| Task             | Stage 2 \ Radio Date Slot App             |
	| Update Value     | Failed                                    |
	| Update Date      | Update relative to a different task value |
	| Relative Project | zUser Sch for Automations Feature       |
	| Relative Task    | Stage 1 \ Radiobutton Date App Task       |
	| Value            | 5 weekdays before task value              |
	When User enters 'DAS20940_FBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'DAS20940_FBU' in the 'Bulk Update Type' dropdown
	Then 'zUser Sch for Automations Feature' content is displayed in 'Project' autocomplete
	Then 'Stage 2 \ Radio Date Slot App' content is displayed in 'Task' autocomplete
	Then 'Failed' content is displayed in 'Update Value' dropdown
	Then 'Update relative to a different task value' value is displayed in the 'Update Date' dropdown
	Then 'zUser Sch for Automations Feature' content is displayed in 'Relative Project' autocomplete
	Then 'Stage 1 \ Radiobutton Date App Task' content is displayed in 'Relative Task' autocomplete
	Then '5' content is displayed in 'Value' textbox
	Then 'weekdays before task value' value is displayed in the 'DateUnit' dropdown
	Then 'UPDATE' button is not disabled
	Then 'CANCEL' button is not disabled
	Then Star button is not disabled

@Evergreen @AllDevices @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20950 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllDevices_CheckSelectedValueForUpdateTaskValueFbuForDeletedProject
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 2095t_Project | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "2095t_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName      |
	| Stage_DAS2095t |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	When User creates Task
	| Name          | Help     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| DAS2095t_Task | DAS2095t | Stage_DAS2095t   | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigates to "ProjectForDAS18025" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Devices' tab on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects        |
	| 00KLL9S8NRF0X6 |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects '20950_Project' option from 'Project' autocomplete
	When User selects 'Stage 1 \ DAS20950_Task' option from 'Task' autocomplete
	When User clicks Star button
	When User enters 'DAS20950_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	#Delete Project
	When User clicks 'Admin' on the left-hand menu
	When User enters "20950_Project" text in the Search field for "Project" column
	When User selects all rows on the grid
	When User removes selected item
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	Then following Values are not displayed in the 'Bulk Update Type' dropdown:
	| Options          |
	| DAS20950_TestFBU |
	#Add FBU is not displayed in Manage Favourite

@Evergreen @AllDevices @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20950 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllDevices_CheckSelectedValueForUpdateTaskValueFbuForDeletedTask
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 20950_Project | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "20950_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName      |
	| Stage_DAS20950 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	When User creates Task
	| Name          | Help     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| DAS20950_Task | DAS20950 | Stage_DAS17691   | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	When User clicks "Create Task" button
	When User creates Task
	| Name          | Help     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| DAS20951_Task | DAS20951 | Stage_DAS17691   | Normal         | Radiobutton     | Computer         | false                    |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigates to "ProjectForDAS18025" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Devices' tab on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects        |
	| 00KLL9S8NRF0X6 |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects '20950_Project' option from 'Project' autocomplete
	When User selects 'Stage 1 \ DAS20950_Task' option from 'Task' autocomplete
	When User clicks Star button
	When User enters 'DAS20950_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	#Delete Task
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "20950_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Tasks" tab
	When User removes "DAS20950_Task" Task
	When User navigate to Evergreen link
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	Then following Values are not displayed in the 'Bulk Update Type' dropdown:
	| Options          |
	| DAS20950_TestFBU |
	#Add FBU is not displayed in Manage Favourite