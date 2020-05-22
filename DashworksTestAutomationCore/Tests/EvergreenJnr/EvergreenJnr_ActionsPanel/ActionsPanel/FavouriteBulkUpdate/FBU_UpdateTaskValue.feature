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
	Then 'star' mat-icon is disabled
	Then 'star' mat-icon has tooltip with 'Some values are missing or not valid' text
	When User selects '<ProjectName>' option from 'Project' autocomplete
	Then 'star' mat-icon is disabled
	Then 'star' mat-icon has tooltip with 'Some values are missing or not valid' text
	When User selects '<Task>' option from 'Task' autocomplete
	Then 'star' mat-icon is not disabled
	Then 'star' mat-icon has tooltip with 'Save as Favourite Bulk Update' text
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
	When User clicks 'star' mat-icon
	Then popup with 'Create Favourite Bulk Update' title is displayed
	Then 'This Favourite Bulk Update will be created with the following parameters:' text is displayed on popup
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
	Then 'A Favourite Bulk Update name must be entered' error message is displayed for 'Favourite Bulk Update Name' field
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
	When User clicks 'star' mat-icon
	When User enters '20940_TestFBU' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update with this name already exists' error message is displayed for 'Favourite Bulk Update Name' field

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
	When User clicks 'star' mat-icon
	When User enters '20950_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat-icon
	When User enters 'TestFBU_20950' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat-icon
	When User enters 'testFBU_209501' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat-icon
	When User enters 'abc_20950' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks refresh button in the browser
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	Then following items have 'star' icon in the 'Bulk Update Type' dropdown:
	| Items          |
	| 20950_TestFBU  |
	| TestFBU_20950  |
	| testFBU_209501 |
	| abc_20950      |
	Then created items for 'Bulk Update Type' dropdown are displayed in ascending order

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20940 @DAS21318 @Yellow_Dwarf
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
	#DAS21318
	Then 'days after task value' value is displayed in the 'DateUnit' dropdown
	When User selects '2004 Rollout' option from 'Relative Project' autocomplete
	When User selects 'Information \ App Delivery Date' option from 'Relative Task' autocomplete
	Then 'days after task value' value is displayed in the 'DateUnit' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Relative Project' autocomplete
	When User selects 'Stage 1 \ Radiobutton Date App Task' option from 'Relative Task' autocomplete
	Then 'days after task value' value is displayed in the 'DateUnit' dropdown
	#DAS21318
	When User enters '5' text to 'Value' textbox
	When User selects 'weekdays after task value' in the 'DateUnit' dropdown
	When User clicks 'star' mat-icon
	When User clicks 'CANCEL' button on popup
	When User selects 'Failed' in the 'Update Value' dropdown
	When User selects 'weekdays before task value' in the 'DateUnit' dropdown
	When User clicks 'star' mat-icon
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
	Then 'star' mat-icon is not disabled

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
	When User clicks 'star' mat-icon
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

@Evergreen @AllDevices @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS20950 @DAS21253 @Cleanup @Yellow_Dwarf
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
	| DAS20950_Task | DAS20950 | Stage_DAS20950   | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User clicks "Cancel" button
	When User clicks "Create Task" button
	When User creates Task
	| Name          | Help     | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| DAS20951_Task | DAS20951 | Stage_DAS20950   | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User publishes the task
	Then selected task was published
	When User navigates to "20950_Project" project details
	When User navigates to the 'Scope' left menu item
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
	| 00KLL9S8NRF0X6   |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects '20950_Project' option from 'Project' autocomplete
	When User selects 'Stage_DAS20950 \ DAS20950_Task' option from 'Task' autocomplete
	When User clicks 'star' mat-icon
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
	When User selects 'DAS20950_TestFBU' in the 'Bulk Update Type' dropdown
	Then 'The configuration for this Favourite Bulk Update is no longer valid' text is displayed on inline error banner
	Then '' content is displayed in 'Project' autocomplete
	Then 'Task' autocomplete is not displayed

@Evergreen @AllDevices @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21249 @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckTaskDropdownAfterRestoringFbuAndCreatingNew
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
	When User clicks 'star' mat-icon
	When User enters '21249_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User selects '21249_TestFBU' in the 'Bulk Update Type' dropdown
	Then 'zUser Sch for Automations Feature' content is displayed in 'Project' autocomplete
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'zUser Sch for Automations Feature' option from 'Project' autocomplete
	When User selects 'Stage 1 \ Dropdown Task' option from 'Task' autocomplete

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21250 @Yellow_Dwarf
Scenario: EvergreenJnr_AllUsers_CheckThatBulkUpdateTypeDropdownIsNotEmptyAfterRestoring
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
	When User selects 'Stage 3 \ DDL Slot Task' option from 'Task' autocomplete
	When User clicks 'star' mat-icon
	When User enters 'DAS21250_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat-icon
	When User enters '21250_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	Then 'Update task value' content is displayed in 'Bulk Update Type' dropdown

@Evergreen @AllDevices @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21248 @Yellow_Dwarf
Scenario: EvergreenJnr_AllDevices_CheckThatCapacitySlotDropdownIsNotEmptyForNoneValue
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00K4CEEQ737BA4L  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects '2004 Rollout' option from 'Project' autocomplete
	When User selects 'Pre-Migration \ Scheduled Date' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Date' dropdown
	When User enters '28 May 2020' text to 'Date' textbox
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'None' in the 'Slot' dropdown
	When User clicks 'star' mat-icon
	When User enters 'DAS21248_FBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User selects 'DAS21248_FBU' in the 'Bulk Update Type' dropdown
	Then 'None' content is displayed in 'Slot' dropdown

@Evergreen @EvergreenJnr_AdminPage @Automations @FavouriteBulkUpdate @DAS21252 @Yellow_Dwarf @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatOwnerDropdownsAreNotEmptyAfterChangingTask
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 21252_Project | All Devices | None            | Standalone Project |
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "21252_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName   |
	| 21252_Stage |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name       | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString | ApplyToAllCheckbox |
	| 21252_Task | 21252 | 21252_Stage      | Normal         | Radiobutton     | Computer         |                          | false              |
	Then Success message is displayed with "Task successfully created" text
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| false          | DateOnly       | None                  | false          | true                 | false       | false         | false      | false       |
	When User publishes the task
	Then selected task was published
	When User navigate to Evergreen link
	#Create FBU
	When User navigates to "21252_Project" project details
	When User navigates to the 'Scope' left menu item
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
	| 00KLL9S8NRF0X6   |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects '21252_Project' option from 'Project' autocomplete
	When User selects '21252_Stage \ 21252_Task' option from 'Task' autocomplete
	When User clicks 'star' mat-icon
	When User enters '21252_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	#Change Task
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "21252_Project" Project
	Then "Manage Project Details" page is displayed to the user
	When User navigate to "Tasks" tab
	When User navigate to "21252_Task" Task
	When User updates the Task page
	| TaskHaADueDate | DateModeString | TaskProjectRoleString | TaskHasAnOwner | TaskImpactsReadiness | ShowDetails | ProjectObject | BulkUpdate | SelfService |
	| true           | DateOnly       | None                  | true           | true                 | false       | false         | false      | false       |
	When User navigate to Evergreen link
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00KLL9S8NRF0X6   |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects '21252_TestFBU' in the 'Bulk Update Type' dropdown
	Then 'The configuration for this Favourite Bulk Update is no longer valid' text is displayed on inline error banner
	Then '' content is displayed in 'Project' autocomplete

@Evergreen @AllUsers @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21319
Scenario: EvergreenJnr_AllUsers_CheckOwnerFieldCreateFavouriteBulkUpdatePopUp
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| 002B5DC7D4D34D5C895 |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One \ Radio Date Owner User' option from 'Task' autocomplete
	When User selects 'Update' in the 'Update Owner' dropdown
	When User selects 'Admin IT' option from 'Team' autocomplete
	When User selects 'Lisa Bailey' option from 'Owner' autocomplete
	When User selects 'D-Team' option from 'Team' autocomplete
	When User clicks 'star' mat-icon
	Then following fields are displayed in the popup:
	| Fields           |
	| Bulk Update Type |
	| Project          |
	| Task             |
	| Update Owner     |
	| Team             |
	Then User compares data in the fields in the popup:
	| Field            | Data                         |
	| Bulk Update Type | Update task value            |
	| Project          | Computer Scheduled Test (Jo) |
	| Task             | One \ Radio Date Owner User  |
	| Update Owner     | Update                       |
	| Team             | D-Team                       |

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21317 @Yellow_Dwarf
Scenario: EvergreenJnr_AllApplications_CheckValueFieldForUpdateRelativeToADifferentTask
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update task value' in the 'Bulk Update Type' dropdown
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project' autocomplete
	When User selects 'One \ Date App- Application Delivery Date' option from 'Task' autocomplete
	When User selects 'Update relative to a different task value' in the 'Update Date' dropdown
	When User selects 'One \ Radio Rag Date Owner App Req A' option from 'Relative Task' autocomplete
	When User enters '12' text to 'Value' textbox
	When User selects 'weekdays after task value' in the 'DateUnit' dropdown
	When User clicks 'star' mat-icon
	When User enters 'DAS21317_FBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User selects 'DAS21317_FBU' in the 'Bulk Update Type' dropdown
	Then '12' content is displayed in 'Value' textbox