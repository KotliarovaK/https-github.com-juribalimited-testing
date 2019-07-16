Feature: OnboarBuckets
	Onboard 

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12806 @DAS12999 @DAS13199 @DAS12680 @DAS12485 @DAS13803 @DAS13930 @DAS13973 @DAS12768 @Project_Creation_and_Scope @Buckets @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardedObjectsAreDisplayedAfterChangingProjectBucketsSetting
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| TestProject20 | All Devices | None            | Standalone Project |
	Then Project "TestProject20" is displayed to user
	When User clicks "Details" tab
	And User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	When User clicks "Scope" tab
	And User selects "Scope Changes" tab on the Project details page
	Then "Match to Evergreen Bucket" is displayed in the Bucket dropdown
	When User expands the object to add
	And User selects following Objects
	| Objects         |
	| 0281Z793OLLLDU6 |
	| 03U75EKEMUQMUS  |
	Then "Devices 2/0" is displayed in the tab header on the Admin page
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "2 objects queued for onboarding, 0 objects offboarded" text
	Then "Devices 0/0" is displayed in the tab header on the Admin page
	When User click on Back button
	And User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "My Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	And User clicks "Buckets" tab
	And User enters "Unassigned2" text in the Search field for "Bucket" column
	Then "2" Onboarded objects are displayed
	When User clicks Admin on the left-hand menu
