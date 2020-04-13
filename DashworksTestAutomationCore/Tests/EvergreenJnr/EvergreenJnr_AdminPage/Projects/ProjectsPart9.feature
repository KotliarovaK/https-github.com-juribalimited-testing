Feature: ProjectsPart9
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS13471 @DAS13803 @DAS13803 @DAS13930 @DAS13973 @Cleanup @Project_Creation_and_Scope @Projects
Scenario Outline: EvergreenJnr_AdminPage_ChangingBucketFromCloneEvergreenBucketsToUseDifferentBuckets
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '<ProjectName>' text to 'Project Name' textbox
	And User selects '<ScopeValue>' option from 'Scope' autocomplete
	When User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	And User navigates to the 'Details' left menu item
	#Then 'Clone Evergreen buckets to project buckets' content is displayed in 'Buckets' dropdown
	When User selects "Use project buckets" in the Buckets Project dropdown
	Then There are no errors in the browser console
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	Then 'Unassigned' content is displayed in 'Bucket' dropdown
	And There are no errors in the browser console

Examples:
	| ProjectName       | ScopeValue    |
	| UsersProject5     | All Users     |
	| MailboxesProject5 | All Mailboxes |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12999 @DAS12903 @DAS12485 @DAS13973 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChangingDevicesScopeListToAnotherListUsingEvergreenBuckets
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Type" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Laptop         |
	Then "3,806" rows are displayed in the agGrid
	When User create dynamic list with "DynamicList54" name on "Devices" page
	Then "DynamicList54" list is displayed to user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'DevicesProject34' text to 'Project Name' textbox
	Then 'DynamicList54' content is displayed in 'Scope' autocomplete
	When User selects "Standalone Project" in the Mode Project dropdown
	And User clicks 'CREATE' button 
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	And User navigates to the 'Scope Changes' left menu item
	Then "Devices to add (0 of 3806 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	And User selects 'All Devices' in the 'Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	Then "Devices to add (0 of 17279 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Users' tab on Project Scope Changes page
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then 'Buckets' dropdown is not displayed
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_ChangingDevicesScopeListToAnotherListForDevicesProject
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
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
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'DevicesProject2' text to 'Project Name' textbox
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks 'CREATE' button 
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	And User navigates to the 'Scope Changes' left menu item
	Then "Devices to add (0 of 17279 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	And User selects 'StaticList6579' in the 'Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	Then "Devices to add (0 of 2 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	And User selects 'DynamicList56' in the 'Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	Then "Devices to add (0 of 1 selected)" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Cleanup @Projects
Scenario: EvergreenJnr_AdminPage_ChangingUserScopeListToAnotherList
	#Adding one user having devices and one that doesn't have devices so in Project having
	#'All Devices' scope when selecting custom list for Users tab we should see only one
	#user having devices
	When User create static list with "StaticList6179" name on "Users" page with following items
	| ItemName   |
	| barbosaj   |
	| AAH0343264 |
	Then "StaticList6179" list is displayed to user
	Then "2" rows are displayed in the agGrid
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| DevicesProject6 | All Devices | None            | Standalone Project |
	And User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14629 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'User Scope' tab on Project Scope Changes page
	And User selects 'StaticList6179' in the 'User Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Users' tab on Project Scope Changes page
	#here we should see only users that have devices
	Then "Users to add (0 of 51 selected)" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console