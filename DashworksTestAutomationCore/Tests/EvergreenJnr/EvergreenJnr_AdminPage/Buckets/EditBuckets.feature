Feature: EditBuckets
	Edit Buckets

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11748 @Buckets @Set_Default_Bucket @Cleanup @Do_Not_Run_With_Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatNotificationMessageIsDisplayedAfterUpdatingBucketToDefaultType
	When User creates new Bucket via api
	| Name        | TeamName  | IsDefault |
	| TestBucket2 | Team 1045 | false     |
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User enters "TestBucket2" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then Page with 'TestBucket2' header is displayed to user
	When User checks 'Default Bucket' checkbox
	When User clicks 'UPDATE' button
	Then 'TestBucket2' text in 'The {0} bucket has been updated' message is displayed on inline success banner
	When User enters "TestBucket2" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then 'Default Bucket' checkbox is checked
	When User navigates to the 'Evergreen' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then 'FALSE' content is displayed in the 'Default' column
	When User clicks content from "Bucket" column
	When User checks 'Default Bucket' checkbox
	When User clicks 'UPDATE' button
	Then 'Unassigned' text in 'The {0} bucket has been updated' message is displayed on inline success banner