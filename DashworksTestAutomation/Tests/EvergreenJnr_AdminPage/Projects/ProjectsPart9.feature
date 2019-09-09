Feature: ProjectsPart9
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS13471 @DAS13803 @DAS13803 @DAS13930 @DAS13973 @Cleanup @Project_Creation_and_Scope @Projects
Scenario Outline: EvergreenJnr_AdminPage_ChangingBucketFromCloneEvergreenBucketsToUseDifferentBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the "Project Name" field
	And User selects '<ScopeValue>' option from 'Scope' autocomplete
	When User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User navigates to the 'Details' left menu item
	#Then 'Clone evergreen buckets to project buckets' content is displayed in 'Buckets' dropdown
	When User selects "Use project buckets" in the Buckets Project dropdown
	Then There are no errors in the browser console
	When User navigates to the 'Scope' left menu item
	And User selects "Scope Changes" tab on the Project details page
	Then "Unassigned" is displayed in the Bucket dropdown
	And There are no errors in the browser console

Examples:
	| ProjectName       | ScopeValue    |
	| UsersProject5     | All Users     |
	| MailboxesProject5 | All Mailboxes |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS12903 @DAS12485 @DAS13973 @Cleanup @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_ChangingDevicesScopeListToAnotherListUsingEvergreenBuckets
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Type" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Laptop         |
	Then "3,808" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList54" name on "Devices" page
	Then "DynamicList54" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject34" in the "Project Name" field
	Then Scope field is automatically populated
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 3808 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects "All Devices" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 17285 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Users' left menu item in the Project Scope Changes section
	When User navigates to the 'Applications' left menu item in the Project Scope Changes section
	Then Bucket dropdown is not displayed on the Project details page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_ChangingDevicesScopeListToAnotherListForDevicesProject
	When User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Operating System" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| OS X 10.10     |
	Then "1" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList56" name on "Devices" page
	Then "DynamicList56" list is displayed to user
	When User create static list with "StaticList6579" name on "Devices" page with following items
	| ItemName        |
	| 00SH8162NAS524  |
	| 011PLA470S0B9DJ |
	Then "StaticList6579" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject2" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 17285 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects "StaticList6579" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User selects "DynamicList56" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "Devices to add (0 of 1 selected)" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_ChangingUserScopeListToAnotherList
	When User create static list with "StaticList6179" name on "Users" page with following items
	| ItemName |
	| barbosaj |
	| clarkc   |
	Then "StaticList6179" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DevicesProject6" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User selects "Scope Changes" tab on the Project details page
	When User navigates to the 'Users' left menu item in the Project Scope Changes section
	Then "Users to add (0 of 14631 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	When User navigates to the "User Scope" tab in the Scope section on the Project details page
	And User selects "StaticList6179" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	When User navigates to the 'Users' left menu item in the Project Scope Changes section
	Then "Users to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console