Feature: ProjectsPart7
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS12680 @Cleanup @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatUsersToAddAndRemoveAreChangingAppropriate
	When User create static list with "StaticList6529" name on "Users" page with following items
	| ItemName            |
	| 000F977AC8824FE39B8 |
	| 002B5DC7D4D34D5C895 |
	Then "StaticList6529" list is displayed to user
	When User create static list with "StaticList6530" name on "Users" page with following items
	| ItemName            |
	| 02642091E2484C9C989 |
	| 02769746B44A414593E |
	Then "StaticList6530" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'UsersProject' text to 'Project Name' textbox
	And User selects 'StaticList6529' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	Then Page with 'UsersProject' header is displayed to user
	Then Info message is displayed and contains "There are no objects in this project, use Scope Changes to add objects to your project" text
	When User navigates to the 'Scope Changes' left menu item
	Then "Users to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User expands multiselect and selects following Objects
	| Objects                                   |
	| 000F977AC8824FE39B8 (Spruill, Shea)       |
	| 002B5DC7D4D34D5C895 (Collor, Christopher) |
	Then "Users to add (2 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Scope Details' left menu item
	And User selects 'StaticList6530' in the 'Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	Then "Users to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	#And "Users to remove (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	And Add Objects panel is collapsed

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS12903 @DAS13973 @Cleanup @Cleanup @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckProjectCreationFromListPageWithUseEvergreenBucket
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	Then 'All <ListName>' content is displayed in 'Scope' autocomplete
	When User selects "Standalone Project" in the Mode Project dropdown
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User create static list with "<StaticList>" name on "<ListName>" page with following items
	| ItemName |
	| <Item>   |
	Then "<StaticList>" list is displayed to user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	Then '<StaticList>' content is displayed in 'Scope' autocomplete
	When User selects "Standalone Project" in the Mode Project dropdown
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	And User create dynamic list with "<DynamicList>" name on "<ListName>" page
	Then "<DynamicList>" list is displayed to user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	Then '<DynamicList>' content is displayed in 'Scope' autocomplete
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner

Examples:
	| ListName  | ProjectName   | StaticList     | Item                   | ColumnName    | DynamicList  |
	| Devices   | Project2587_1 | StaticList6521 | 00KLL9S8NRF0X6         | Hostname      | TestList6584 |
	| Mailboxes | Project2587_2 | StaticList6522 | ZVI880605@bclabs.local | Email Address | TestList6583 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS12799 @DAS13973 @Project_Creation_and_Scope @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_CheckMailboxProjectCreationWithCloneEvergreenBuckets
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'MailboxesProject25' text to 'Project Name' textbox
	When User selects "Standalone Project" in the Mode Project dropdown
	And User selects 'All Mailboxes' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "MailboxesProject25" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	Then 'The selected project has been deleted' text is displayed on inline success banner
	And There are no errors in the browser console
	When User create static list with "StaticList5846" name on "Mailboxes" page with following items
	| ItemName                         |
	| 000F977AC8824FE39B8@bclabs.local |
	Then "StaticList5846" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'MailboxesProject26' text to 'Project Name' textbox
	And User selects 'StaticList5846' option from 'Scope' autocomplete
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User enters "MailboxesProject26" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks on 'Email Address' column header
	And User create dynamic list with "DynamicList9513" name on "Mailboxes" page
	Then "DynamicList9513" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'MailboxesProject27' text to 'Project Name' textbox
	And User selects 'DynamicList9513' option from 'Scope' autocomplete
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User enters "MailboxesProject27" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13973 @Cleanup @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckProjectCreationWithCloneEvergreenBucketsFromListPage
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	Then 'All <PageName>' content is displayed in 'Scope' autocomplete
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks 'CREATE' button
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
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks 'CREATE' button
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
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner

Examples:
	| ProjectName     | StaticList     | PageName | Item                | ColumnName | DynamicList     |
	| TestProject9543 | StaticList8851 | Devices  | 00KWQ4J3WKQM0G      | Hostname   | DynamicList9527 |
	| TestProject9544 | StaticList8852 | Users    | 003F5D8E1A844B1FAA5 | Username   | DynamicList9528 |