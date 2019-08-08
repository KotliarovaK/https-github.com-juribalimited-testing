﻿Feature: CreateBucket
	Create Bucket

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11770 @Buckets @Cleanup
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
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks the "CREATE EVERGREEN BUCKET" Action button
	Then "Create Evergreen Bucket" page should be displayed to the user
	When User enters " 11770" in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks the "CREATE" Action button
	Then Error message with "A bucket already exists with this name" text is displayed
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS16636 @Buckets @Set_Default_Bucket @Cleanup @Do_Not_Run_With_Buckets
Scenario: EvergreenJnr_AdminPage_CreatingDefaultBucket
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then "TRUE" value is displayed for Default column
	When User creates new Bucket via api
	| Name        | TeamName | IsDefault |
	| TestBucket5 | Admin IT | true      |
	And User navigates to newly created Bucket
	Then "TestBucket5" bucket details is displayed to the user
	When User enters "NewBucket5" in the "Bucket Name" field
	And User selects "I-Team" team in the Team dropdown on the Buckets page
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The NewBucket5 bucket has been updated" text
	When User enters "Unassigned" text in the Search field for "Bucket" column
	Then "FALSE" value is displayed for Default column

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726 @DAS11891 @DAS11747 @DAS13471 @Buckets
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyBucketName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	Then "Buckets" page should be displayed to the user
	Then Search fields for "Devices" column contain correctly value
	Then Search fields for "Users" column contain correctly value
	Then Search fields for "Mailboxes" column contain correctly value
	When User clicks the "CREATE EVERGREEN BUCKET" Action button
	Then "Create Evergreen Bucket" page should be displayed to the user
	When User enters " " in the "Bucket Name" field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	Then "CREATE" Action button is disabled