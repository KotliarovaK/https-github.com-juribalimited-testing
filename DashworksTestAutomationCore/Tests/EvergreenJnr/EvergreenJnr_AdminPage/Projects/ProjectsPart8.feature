Feature: ProjectsPart8
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Cleanup @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckProjectCreationWithProjectBucketsFromListPage
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	Then 'All <PageName>' content is displayed in 'Scope' autocomplete
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User create static list with "<StaticList>" name on "<PageName>" page with following items
	| ItemName |
	| <Item>   |
	Then "<StaticList>" list is displayed to user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	Then '<StaticList>' content is displayed in 'Scope' autocomplete
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	And User create dynamic list with "<DynamicList>" name on "<PageName>" page
	Then "<DynamicList>" list is displayed to user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	Then '<DynamicList>' content is displayed in 'Scope' autocomplete
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner

Examples:
	| ProjectName     | StaticList     | PageName  | Item                             | ColumnName    | DynamicList     |
	| TestProject9553 | StaticList8891 | Mailboxes | 00A5B910A1004CF5AC4@bclabs.local | Email Address | DynamicList9537 |
	| TestProject9554 | StaticList8892 | Users     | 003F5D8E1A844B1FAA5              | Username      | DynamicList9538 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @Cleanup @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckOnboardingObjectUsingUpdateAppropriateChangesButton
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	And User selects '<AllListName>' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	Then Page with '<ProjectName>' header is displayed to user
	Then Info message is displayed and contains "There are no objects in this project, use Scope Changes to add objects to your project" text
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the '<TabName>' tab on Project Scope Changes page
	And User expands multiselect and selects following Objects
	| Objects        |
	| <ObjectsToAdd> |
	And User clicks 'UPDATE ALL CHANGES' button 
	Then '<WarningMessageText>' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button 
	Then '<SuccessMessageText>' text is displayed on inline success banner

Examples:
	| ProjectName    | AllListName   | TabName   | ObjectsToAdd                                       | WarningMessageText      | SuccessMessageText                                   |
	| 13199Project_1 | All Mailboxes | Mailboxes | 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie) | 1 mailbox will be added | 1 object queued for onboarding, 0 objects offboarded |
	| 13199Project_2 | All Devices   | Users     | ADC714277 (Dina Q. Knight)                         | 1 user will be added    | 1 object queued for onboarding, 0 objects offboarded |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS12781 @DAS12903 @DAS12485 @DAS13803 @DAS13930 @DAS13973 @DAS13530 @Projects @Cleanup
Scenario: EvergreenJnr_AdminPage_ChangingBucketFromUseEvergreenBucketsToCloneEvergreenBuckets
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '1MailboxesProject' text to 'Project Name' textbox
	#And User selects "Evergreen" in the Mode Project dropdown
	When User selects 'All Mailboxes' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Buckets' left menu item
	When User clicks Reset Filters button on the Admin page
	When User unchecks following checkboxes in the filter dropdown menu for the 'Project' column:
	| checkboxes |
	| Select All |
	When User checks following checkboxes in the filter dropdown menu for the 'Project' column:
	| checkboxes        |
	| 1MailboxesProject |
	Then Rows counter contains "1" found row of all rows
	Then 'Unassigned' content is displayed in the 'Bucket' column
	When User navigates to the 'Projects' left menu item
	When User enters "1MailboxesProject" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Page with '1MailboxesProject' header is displayed to user
	When User navigates to the 'Details' left menu item
	Then "Mailbox scoped project" is displayed in the disabled Project Type field
	When User selects "Clone Evergreen buckets to project buckets" in the Buckets Project dropdown
	Then There are no errors in the browser console
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	Then 'Match to Evergreen Bucket' content is displayed in 'Bucket' dropdown
	When User clicks 'Administration' header breadcrumb
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Buckets' left menu item
	When User clicks Reset Filters button on the Admin page
	When User unchecks following checkboxes in the filter dropdown menu for the 'Project' column:
	| checkboxes |
	| Select All |
	When User checks following checkboxes in the filter dropdown menu for the 'Project' column:
	| checkboxes        |
	| 1MailboxesProject |
	Then Rows counter contains "1" found row of all rows
	Then 'Unassigned' content is displayed in the 'Bucket' column

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13530 @Projects @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatNoAdditionalCapacityUnitsAreCreatedWhenChangingCapacityUnitsMode
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '13530Project' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	When User unchecks following checkboxes in the filter dropdown menu for the 'Project' column:
	| checkboxes |
	| Evergreen  |
	When User checks following checkboxes in the filter dropdown menu for the 'Project' column:
	| checkboxes   |
	| 13530Project |
	Then Rows counter contains "1" found row of all rows
	And 'Unassigned' content is displayed in the 'Capacity Unit' column
	When User navigates to the 'Projects' left menu item
	And User enters "13530Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Page with '13530Project' header is displayed to user
	When User navigates to the 'Capacity' left menu item
	And User selects 'Clone Evergreen capacity units to project capacity units' in the 'Capacity Units' dropdown
	And User clicks 'UPDATE' button 
	Then 'The project capacity details have been updated' text is displayed on inline success banner
	When User clicks 'Administration' header breadcrumb
	And User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	When User unchecks following checkboxes in the filter dropdown menu for the 'Project' column:
	| checkboxes |
	| Evergreen  |
	When User checks following checkboxes in the filter dropdown menu for the 'Project' column:
	| checkboxes   |
	| 13530Project |
	Then Rows counter contains "1" found row of all rows
	Then 'Unassigned' content is displayed in the 'Capacity Unit' column