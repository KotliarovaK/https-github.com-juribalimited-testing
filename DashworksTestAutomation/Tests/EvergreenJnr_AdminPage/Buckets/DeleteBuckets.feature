﻿Feature: DeleteBuckets
	Delete Buckets

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12760 @DAS13254 @Buckets @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckMessageThatDisplayedWhenDeletingBucket
	When User creates new Bucket via api
	| Name        | TeamName  | IsDefault |
	| TestBucket4 | Team 1045 | false     |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User clicks Reset Filters button on the Admin page
	And User enters "Amsterdam" text in the Search field for "Bucket" column
	Then Actions dropdown is displayed correctly
	When User selects all rows on the grid
	And User selects 'Delete' in the 'Actions' dropdown
	And User clicks 'DELETE' button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	When User clicks Select All checkbox on the grid
	And User enters "Unassigned" text in the Search field for "Bucket" column
	And User clicks Select All checkbox on the grid
	And User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	When User clicks Select All checkbox on the grid
	And User enters "TestBucket4" text in the Search field for "Bucket" column
	And User clicks Select All checkbox on the grid
	And User selects 'Delete' in the 'Actions' dropdown
	And User clicks 'DELETE' button 
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page
	When User clicks Cancel button in the warning message on the Admin page
	Then Warning message is not displayed on the Admin page
	When User clicks 'DELETE' button 
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page
	When User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected bucket has been deleted" text

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12921 @Buckets
Scenario: EvergreenJnr_AdminPage_ChecksThatSpellingIsCorrectInBucketDeletionMessages
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User select "Bucket" rows in the grid
	| SelectedRowsName   |
	| Evergreen Bucket 3 |
	And User selects 'Delete' in the 'Actions' dropdown
	And User clicks 'DELETE' button
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page
	When User select "Bucket" rows in the grid
	| SelectedRowsName   |
	| Evergreen Bucket 4 |
	And User clicks 'DELETE' button
	Then Warning message with "These buckets will be permanently deleted and any objects within them reassigned to the default bucket" text is displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11879 @DAS12742 @DAS12752 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatSpecificWarningMessageIsNotDisplayedAfterTryingToDeleteNonDefaultBucket
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User clicks Reset Filters button on the Admin page
	When User enters "Administration" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then Default Bucket checkbox is selected
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User clicks Reset Filters button on the Admin page
	And User enters "Chicago" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	Then Warning message with "You can not delete the default bucket" text is not displayed on the Admin page
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page


@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12331 @Buckets @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatWarningNotificationIsDisappearedAfterSwitchingFocusToAnotherBucket 
	When User creates new Bucket via api
	| Name         | TeamName | IsDefault |
	| 1Bucket12331 | K-Team   | false     |
	| 2Bucket12331 | K-Team   | false     |
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User select "Bucket" rows in the grid
	| SelectedRowsName |
	| 1Bucket12331     |
	And User selects 'Delete' in the 'Actions' dropdown
	And User clicks 'DELETE' button
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is displayed on the Admin page
	When User select "Bucket" rows in the grid
	| SelectedRowsName |
	| 1Bucket12331     |
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is not displayed on the Admin page
	When User select "Bucket" rows in the grid
	| SelectedRowsName |
	| 2Bucket12331     |
	Then Warning message with "This bucket will be permanently deleted and any objects within it reassigned to the default bucket" text is not displayed on the Admin page