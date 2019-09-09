Feature: GridScreenBuckets
	Grid Screen Buckets

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11762 @DAS12009 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextFieldForBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	#Then Counter shows "558" found rows
	When User have opened Column Settings for "Bucket" column
	And User clicks Filter button on the Column Settings panel
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then There are no errors in the browser console
	When User have opened Column Settings for "Devices" column
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then Content is present in the table on the Admin page
	Then There are no errors in the browser console
	When User have opened Column Settings for "Default" column
	When User clicks "True" checkbox from boolean filter on the Admin page
	Then There are no errors in the browser console
	When User have opened Column Settings for "Project" column
	When User selects "Select All" checkbox from String Filter with item list on the Admin page
	Then There are no errors in the browser console
	When User clicks Reset Filters button on the Admin page
	#Add sorting check for "Bucket" column
	Then data in table is sorted by "Bucket" column in ascending order by default on the Admin page
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by "Project" column in ascending order on the Admin page
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by "Project" column in descending order on the Admin page
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by "Devices" column in descending order on the Admin page
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by "Devices" column in ascending order on the Admin page
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by "Users" column in descending order on the Admin page
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by "Users" column in ascending order on the Admin page
	When User click on "Default" column header on the Admin page
	Then boolean data is sorted by 'Default' column in ascending order
	When User click on "Default" column header on the Admin page
	Then boolean data is sorted by 'Default' column in descending order
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11944 @Buckets @archived
Scenario: EvergreenJnr_AdminPage_CheckSelectedRowsCountDisplayingOnBucketsGrids
	When User clicks Admin on the left-hand menu
	And User clicks "Evergreen" link on the Admin page
	And User selects all rows on the grid
	And User clicks Reset Filters button on the Admin page
	Then User sees "11" of "607" rows selected label
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Select All" checkbox from String Filter with item list on the Admin page
	When User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User selects all rows on the grid
	Then User sees "16937" of "16937" rows selected label
	When User navigates to the 'Users' tab on Scope Changes page
	And User selects all rows on the grid
	Then User sees "41339" of "41339" rows selected label
	When User navigates to the 'Mailboxes' left menu item
	And User selects all rows on the grid
	Then User sees "14538" of "14538" rows selected label

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12491 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbarforBucketsList
	When User clicks Admin on the left-hand menu
	And User clicks "Evergreen" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "birmingham" text in the Search field for "Bucket" column
	Then Rows counter contains "3" found row of all rows

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
	When User clicks Admin on the left-hand menu
	And User clicks "Evergreen" link on the Admin page
	Then data in table is sorted by "Bucket" column in ascending order by default on the Admin page
	When User enters "1ba" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User enters "a1ba" in the "Bucket Name" field
	And User clicks the "UPDATE" Action button
	Then data in table is sorted by "Bucket" column in ascending order by default on the Admin page
	When User deletes "aab" Bucket in the Administration
	And User clicks refresh button in the browser
	Then data in table is sorted by "Bucket" column in ascending order by default on the Admin page