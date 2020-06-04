Feature: ProjectsPart3
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12332 @DAS13199 @DAS12485 @DAS12645 @DAS11877 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckingThatRedBannerWithOkMessageIsNotDisplayedAfterAddingItemsToCreatedProject
	When Project created via API and opened
	| ProjectName      | Scope       | ProjectTemplate | Mode               |
	| TestProject12332 | All Devices | None            | Standalone Project |
	Then Page with 'TestProject12332' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User expands multiselect to add objects
	Then Objects are displayed in alphabetical order on the Admin page
	When User expands multiselect and selects following Objects
	| Objects        |
	| 1DPQO52HJQZJ0H |
	And User navigates to the 'Applications' tab on Project Scope Changes page
	And User expands multiselect to add objects
	Then Objects are displayed in alphabetical order on the Admin page
	When User expands multiselect and selects following Objects
	| Objects                                    |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais |
	And User navigates to the 'Users' tab on Project Scope Changes page
	And User expands multiselect to add objects
	Then Objects are displayed in alphabetical order on the Admin page
	When User expands multiselect and selects following Objects
	| Objects                    |
	| AAC860150 (Kerrie D. Ruiz) |
	And User clicks 'UPDATE ALL CHANGES' button 
	Then '1 device will be added, 1 user will be added, 1 application will be added' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button 
	Then '3 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12796 @DAS12872 @DAS13401 @DAS-14877 @Cleanup @Cleanup @Project_Creation_and_Scope @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckThatNumberOfObjectIsUpdatedInTheScopeChangesOfProjectAfterTheChangeCustomList
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	And User create dynamic list with "<DynamicListName>" name on "<ListName>" page
	Then "<DynamicListName>" list is displayed to user
	And "<RowsCount>" rows are displayed in the agGrid
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	Then Page with '<ProjectName>' header is displayed to user
	When User navigates to the 'Scope Changes' left menu item
	Then "<ObjectsCount>" is displayed to the user in the Project Scope Changes section
	When User clicks '<ListName>' on the left-hand menu
	And User navigates to the "<DynamicListName>" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| <Checkbox>     |
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	Then "<NewRowsCount>" rows are displayed in the agGrid
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Page with '<ProjectName>' header is displayed to user
	When User navigates to the 'Scope Changes' left menu item
	Then "<NewCount>" is displayed to the user in the Project Scope Changes section

Examples:
	| ListName  | ColumnName    | DynamicListName | RowsCount | ProjectName     | ObjectsCount | FilterName  | Checkbox | NewRowsCount | NewCount | DeleteProject   |
	| Devices   | Hostname      | ProjectList4587 | 17,279    | TestProject4511 | 17279        | Device Type | Desktop  | 8,100        | 8100     | TestProject4511 |
	| Users     | Username      | ProjectList4511 | 41,339    | TestProject4512 | 41339        | Domain      | CORP     | 103          | 103      | TestProject4512 |
	| Mailboxes | Email Address | ProjectList4548 | 14,884    | TestProject4513 | 14884        | Owner City  | London   | 3,294        | 3294     | TestProject4513 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12816 @DAS12873 @DAS13007 @DAS13199 @DAS13973 @DAS21397 @Project_Creation_and_Scope @Projects @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatObjectsIsOnboardedToTheProjectWithCloneEvergreenBucketsToProjectBuckets
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'TestProject19' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	When User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	And There are no errors in the browser console
	When User clicks newly created object link
	Then Page with 'TestProject19' header is displayed to user
	When User navigates to the 'Scope Changes' left menu item
	And User expands multiselect and selects following Objects
	| Objects         |
	| 01BQIYGGUW5PRP6 |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
	Then There are no errors in the browser console
	Then inline error banner is not displayed
	Then following Items are displayed in the Queue table
	| Items           |
	| 01BQIYGGUW5PRP6 |
	When User navigates to the 'History' left menu item
	Then There are no errors in the browser console
	Then inline error banner is not displayed
	Then following Items are displayed in the History table
	| Items           |
	| 01BQIYGGUW5PRP6 |
	When User click on Back button
	And User enters "TestProject19" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12490 @DAS13007 @DAS12999 @DAS13199 @DAS12680 @DAS12485 @DAS13949 @DAS14180 @DAS18337 @Project_Creation_and_Scope @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckingThatProjectDetailsForOnboardedObjectsIsDisplayedCorrectly
	When Project created via API and opened
	| ProjectName      | Scope       | ProjectTemplate | Mode               |
	| TestProject12490 | All Devices | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Devices' tab on Project Scope Changes page
	Then "[Default (Computer)]" Path is displayed to the user
	And "[None]" Category is displayed to the user
	And 'Unassigned' content is displayed in 'Bucket' dropdown
	When User expands multiselect and selects following Objects
	| Objects        |
	| 0IJB93JZPG72PX |
	| 04I01QSFL1AWKM |
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "[Default (Application)]" Path is displayed to the user
	And "[None]" Category is displayed to the user
	When User expands multiselect and selects following Objects
	| Objects                        |
	| ACDSee 4.0.1 Std Trial Version |
	| ACDSee 8 (8.0.39)              |
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "[Default (User)]" Path is displayed to the user
	And "[None]" Category is displayed to the user
	And 'Unassigned' content is displayed in 'Bucket' dropdown
	When User expands multiselect and selects following Objects
	| Objects                        |
	| ABQ575757 (Salvador K. Waller) |
	| ADG685492 (Eugene N. Stanton)  |
	Then 'Devices 2/0' tab is displayed on Project Scope Changes page
	And 'Users 2/0' tab is displayed on Project Scope Changes page
	And 'Applications 2/0' tab is displayed on Project Scope Changes page
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then 'Devices 0/0' tab is displayed on Project Scope Changes page
	And 'Users 0/0' tab is displayed on Project Scope Changes page
	And 'Applications 0/0' tab is displayed on Project Scope Changes page
	When User navigates to the 'Queue' left menu item
	Then There are no errors in the browser console
	Then inline error banner is not displayed
	Then following Items are displayed in the Queue table
	| Items                          |
	| 0IJB93JZPG72PX                 |
	| 04I01QSFL1AWKM                 |
	| ABQ575757                      |
	| ADG685492                      |
	| ACDSee 4.0.1 Std Trial Version |
	| ACDSee 8                       |
	Then Counter shows "6" found rows
	When User click on "Date" column header on the Admin page
	Then date in table is sorted by 'Date' column in descending order
	When User click on "Date" column header on the Admin page
	Then date in table is sorted by 'Date' column in ascending order
	When User click on "Item" column header on the Admin page
	Then data in table is sorted by 'Item' column in ascending order
	When User click on "Item" column header on the Admin page
	Then data in table is sorted by 'Item' column in descending order
	When User click on "Object Type" column header on the Admin page
	Then data in table is sorted by 'Object Type' column in ascending order
	When User click on "Object Type" column header on the Admin page
	Then data in table is sorted by 'Object Type' column in descending order
	When User click on "Action" column header on the Admin page
	Then data in table is sorted by 'Action' column in ascending order
	When User click on "Action" column header on the Admin page
	Then data in table is sorted by 'Action' column in descending order
	When User click on "Bucket" column header on the Admin page
	Then data in table is sorted by 'Bucket' column in ascending order
	When User click on "Bucket" column header on the Admin page
	Then data in table is sorted by 'Bucket' column in descending order
	When User selects following date filter on the Projects page
	| FilterData  |
	| 30 Jul 2017 |
	Then Rows counter shows "0" of "6" rows
	When User clicks Reset Filters button on the Admin page
	Then field for Date column is empty
	When User enters "0IJB93JZPG72PX" text in the Search field for "Item" column
	Then Rows counter shows "1" of "6" rows
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Object Type" column on the Admin page
	And User selects "User" checkbox from String Filter on the Admin page
	Then Rows counter shows "4" of "6" rows
	When User clicks Reset Filters button on the Admin page
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then Rows counter shows "4" of "6" rows
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "Onboard Device Object" checkbox from String Filter with item list on the Admin page
	Then Rows counter shows "4" of "6" rows
	When User waits until Queue disappears
	And User navigates to the 'History' left menu item
	Then There are no errors in the browser console
	Then inline error banner is not displayed
	Then Following items displayed in the History table
	| Items                          |
	| 0IJB93JZPG72PX                 |
	| 04I01QSFL1AWKM                 |
	| ABQ575757                      |
	| ADG685492                      |
	| ACDSee 4.0.1 Std Trial Version |
	| ACDSee 8                       |
	Then Counter shows "6" found rows
	Then data in table is sorted by 'Item' column in ascending order by default
	Then data in table is sorted by 'Date' column in descending order by default
	When User click on "Date" column header on the Admin page
	Then date in table is sorted by 'Date' column in descending order
	When User click on "Date" column header on the Admin page
	Then date in table is sorted by 'Date' column in ascending order
	When User click on "Item" column header on the Admin page
	Then data in table is sorted by 'Item' column in ascending order
	When User click on "Item" column header on the Admin page
	Then data in table is sorted by 'Item' column in descending order
	When User click on "Object Type" column header on the Admin page
	Then data in table is sorted by 'Object Type' column in ascending order
	When User click on "Object Type" column header on the Admin page
	Then data in table is sorted by 'Object Type' column in descending order
	When User click on "Action" column header on the Admin page
	Then data in table is sorted by 'Action' column in ascending order
	When User click on "Action" column header on the Admin page
	Then data in table is sorted by 'Action' column in descending order
	When User click on "Status" column header on the Admin page
	Then data in table is sorted by 'Status' column in ascending order
	When User click on "Status" column header on the Admin page
	Then data in table is sorted by 'Status' column in descending order
	When User selects following date filter on the Projects page
	| FilterData  |
	| 30 Jul 2017 |
	Then Rows counter shows "0" of "6" rows
	When User clicks Reset Filters button on the Admin page
	Then field for Date column is empty
	When User enters "0IJB93JZPG72PX" text in the Search field for "Item" column
	Then Rows counter shows "1" of "6" rows
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Object Type" column on the Admin page
	When User selects "Device" checkbox from String Filter on the Admin page
	Then Rows counter shows "4" of "6" rows
	When User clicks Reset Filters button on the Admin page
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then Rows counter shows "4" of "6" rows
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "Onboard Device Object" checkbox from String Filter with item list on the Admin page
	Then Rows counter shows "4" of "6" rows
	When User clicks String Filter button for "Status" column on the Admin page
	When User selects "Succeeded" checkbox from String Filter on the Admin page
	Then Rows counter shows "0" of "6" rows