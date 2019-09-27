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
	When User clicks "Evergreen" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "TestBucket2" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then "TestBucket2" bucket details is displayed to the user
	When User updates the "Default Bucket" checkbox state
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "TestBucket2" bucket has been updated is displayed on the Buckets page
	When User enters "TestBucket2" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then Default Bucket checkbox is selected
	When User clicks "Evergreen" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then 'FALSE' content is displayed in the 'Default' column
	When User clicks content from "Bucket" column
	And User updates the "Default Bucket" checkbox state
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "Unassigned" bucket has been updated is displayed on the Buckets page
