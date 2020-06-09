Feature: GridScreenBuckets
	Grid Screen Buckets

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11762 @DAS12009 @DAS18098 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextFieldForBuckets
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User clicks Reset Filters button on the Admin page
	#Then Counter shows "558" found rows
	When User opens 'Bucket' column settings
	When User clicks Filter button on the Column Settings panel
	When User enters "123455465" text in the Filter field
	When User clears Filter field
	Then There are no errors in the browser console
	When User opens 'Devices' column settings
	When User enters "123455465" text in the Filter field
	When User clears Filter field
	Then Content is present in the table on the Admin page
	Then There are no errors in the browser console
	When User checks following checkboxes in the filter dropdown menu for the 'Default' column:
	| checkboxes |
	| True       |
	Then There are no errors in the browser console
	When User unchecks following checkboxes in the filter dropdown menu for the 'Project' column:
	| checkboxes |
	| Select All |
	Then There are no errors in the browser console
	When User clicks Reset Filters button on the Admin page
	#Add sorting check for "Bucket" column
	Then data in table is sorted by 'Bucket' column in ascending order by default
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by 'Project' column in ascending order
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by 'Project' column in descending order
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by 'Devices' column in descending order
	When User click on "Devices" column header on the Admin page
	Then all cells in the 'Devices' column are empty
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by 'Users' column in descending order
	When User click on "Users" column header on the Admin page
	Then all cells in the 'Users' column are empty
	When User click on "Default" column header on the Admin page
	Then boolean data is sorted by 'Default' column in ascending order
	When User click on "Default" column header on the Admin page
	Then boolean data is sorted by 'Default' column in descending order
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12491 @DAS16389 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbarforBucketsList
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User clicks Reset Filters button on the Admin page
	When User enters "birmingham" text in the Search field for "Bucket" column
	Then Rows counter contains "3" found row of all rows
	#DAS16389
	When User enters "144" text in the Search field for "Users" column
	When User clicks content from "Users" column
	Then "144" rows are displayed in the agGrid

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12939 @Buckets @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckDefaultSortOrderOfBucketsAfterCreateOrUpdateOrDeleteAction
	When User creates new Bucket via api
	| Name | TeamName |
	| 1ba  | Admin IT |
	| 2ab  | K-Team   |
	| aaa  | Admin IT |
	| aab  | I-Team   |
	| aba  | Admin IT |
	| waa  | IB Team  |
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Evergreen' left menu item
	Then data in table is sorted by 'Bucket' column in ascending order by default
	When User enters "1ba" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User enters 'a1ba' text to 'Bucket Name' textbox
	And User clicks 'UPDATE' button 
	Then data in table is sorted by 'Bucket' column in ascending order by default
	When User deletes "aab" Bucket in the Administration
	And User clicks refresh button in the browser
	Then data in table is sorted by 'Bucket' column in ascending order by default
