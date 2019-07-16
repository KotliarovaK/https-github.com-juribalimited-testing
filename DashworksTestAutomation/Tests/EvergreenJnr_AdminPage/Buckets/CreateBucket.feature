Feature: CreateBucket
	Create Bucket

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11770 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatImpossibleToCreateSameNamedBucketUsingTheSpaceAsAFirstSymbol
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks the "CREATE EVERGREEN BUCKET" Action button
	Then "Create Evergreen Bucket" page should be displayed to the user
	When User enters "11770" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created, Click here to view the 11770 bucket" text
	When User clicks the "CREATE EVERGREEN BUCKET" Action button
	Then "Create Evergreen Bucket" page should be displayed to the user
	When User enters " 11770" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Error message with "A bucket already exists with this name" text is displayed
	And Delete "11770" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS16636 @Buckets
Scenario: EvergreenJnr_AdminPage_CreatingDefaultBucket
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then "TRUE" value is displayed for Default column
	When User clicks the "CREATE EVERGREEN BUCKET" Action button
	Then "Create Evergreen Bucket" page should be displayed to the user
	When User enters "TestBucket5" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User updates the "Default Bucket" checkbox state
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks newly created object link
	Then "TestBucket5" bucket details is displayed to the user
	When User enters "NewBucket5" in the "Bucket Name" field
	And User selects "I-Team" team in the Team dropdown on the Buckets page
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The NewBucket5 bucket has been updated" text
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then "FALSE" value is displayed for Default column
	When User clicks content from "Bucket" column
	And User updates the "Default Bucket" checkbox state
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "Unassigned" bucket has been updated is displayed on the Buckets page
	And Delete "NewBucket5" Bucket in the Administration
