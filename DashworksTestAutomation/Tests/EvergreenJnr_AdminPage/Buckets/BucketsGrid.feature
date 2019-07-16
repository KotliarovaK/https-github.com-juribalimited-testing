Feature: BucketsGrid
	Buckets grid

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12491 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbarforBucketsList
	When User clicks Admin on the left-hand menu
	And User clicks "Evergreen" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "birmingham" text in the Search field for "Bucket" column
	Then Rows counter contains "3" found row of all rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12760 @DAS13254 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckMessageThatDisplayedWhenDeletingBucket
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Amsterdam" text in the Search field for "Bucket" column
	Then Actions dropdown is displayed correctly
	When User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks Select All checkbox on the grid
	And User clicks Select All checkbox on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	When User clicks Delete button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	When User clicks the "CREATE EVERGREEN BUCKET" Action button
	Then "Create Evergreen Bucket" page should be displayed to the user
	When User enters "TestBucket4" in the "Bucket Name" field
	And User selects "Team 1045" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User enters "TestBucket4" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page
	When User clicks Cancel button in the warning message on the Admin page
	Then Warning message is not displayed on the Admin page
	When User clicks Delete button 
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page
	When User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected bucket has been deleted" text

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12939 @Buckets @Delete_Newly_Created_Bucket
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