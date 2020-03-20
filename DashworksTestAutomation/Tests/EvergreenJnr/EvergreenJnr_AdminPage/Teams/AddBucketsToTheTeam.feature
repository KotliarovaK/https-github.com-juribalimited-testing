Feature: AddBucketsToTheTeam
	Add Buckets To The Team

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13421 @DAS12788 @Teams @Cleanup
Scenario: EvergreenJnr_AdminPage_AddingBucketsToTheTeam
	When User creates new Team via api
	| TeamName  | Description | IsDefault |
	| TestTeam5 | test        | false     |
	And User creates new Bucket via api
	| Name        | TeamName  | IsDefault |
	| TestBucket6 | Team 1045 | false     |
	| TestBucket7 | Team 1045 | false     |
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "TestTeam5" text in the Search field for "Team" column
	And User clicks content from "Team" column
	And User navigates to the 'Buckets' left menu item
	And User clicks 'ADD BUCKETS' button 
	Then Page with 'Add Buckets' subheader is displayed to user
	When User expands 'Evergreen' multiselect and selects following Objects
	| Objects     |
	| TestBucket6 |
	| TestBucket7 |
	When User clicks 'ADD BUCKETS' button
	Then 'The selected buckets have been added' text is displayed on inline success banner
	When User enters "TestBucket" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User selects 'Change Team' in the 'Actions' dropdown
	And User clicks 'CONTINUE' button 
	Then 'Change Team' page subheader is displayed to user
	When User selects 'Team 10' option from 'Team' autocomplete without search
	And User clicks 'CHANGE' button 
	Then 'The selected buckets have been reassigned to the selected team' text is displayed on inline success banner
	And There are no errors in the browser console
	When User click on Back button

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13421 @DAS12788 @Teams
Scenario: EvergreenJnr_AdminPage_CheckBucketsSortingAndFiltersForTeams
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "2004 Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	And User navigates to the 'Buckets' left menu item
	When User click on "Bucket" column header on the Admin page
	Then data in table is sorted by 'Bucket' column in ascending order
	When User click on "Bucket" column header on the Admin page
	Then data in table is sorted by 'Bucket' column in descending order
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by 'Project' column in ascending order
	When User click on "Project" column header on the Admin page
	Then data in table is sorted by 'Project' column in descending order
	When User click on "Default" column header on the Admin page
	Then boolean data is sorted by 'Default' column in ascending order
	When User click on "Default" column header on the Admin page
	Then boolean data is sorted by 'Default' column in descending order
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by 'Devices' column in descending order
	When User click on "Devices" column header on the Admin page
	Then numeric data in table is sorted by 'Devices' column in ascending order
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by 'Users' column in descending order
	When User click on "Users" column header on the Admin page
	Then numeric data in table is sorted by 'Mailboxes' column in ascending order
	When User click on "Mailboxes" column header on the Admin page
	Then numeric data in table is sorted by 'Mailboxes' column in descending order
	When User click on "Mailboxes" column header on the Admin page
	Then numeric data in table is sorted by 'Mailboxes' column in ascending order
	#Filters
	When User unchecks following checkboxes in the filter dropdown menu for the 'Default' column:
	| checkboxes |
	| False      |
	Then Rows counter shows "0" of "9" rows
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	Then Rows counter shows "6" of "9" rows
	When User clicks Reset Filters button on the Admin page
	When User enters "Birmingham" text in the Search field for "Bucket" column
	Then Rows counter shows "2" of "9" rows
	When User clicks Reset Filters button on the Admin page
	And User enters "14" text in the Search field for "Devices" column
	Then Rows counter shows "1" of "9" rows
	When User clicks Reset Filters button on the Admin page
	And User enters ">10" text in the Search field for "Users" column
	Then Rows counter shows "4" of "9" rows
	When User clicks Reset Filters button on the Admin page
	And User enters "100" text in the Search field for "Mailboxes" column
	Then Rows counter shows "0" of "9" rows
	When User clicks Reset Filters button on the Admin page
	Then There are no errors in the browser console