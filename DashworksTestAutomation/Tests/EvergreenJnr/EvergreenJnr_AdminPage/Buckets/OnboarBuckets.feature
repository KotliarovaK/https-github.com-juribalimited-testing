Feature: OnboarBuckets
	Onboard 

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12806 @DAS12999 @DAS13199 @DAS12680 @DAS12485 @DAS13803 @DAS13930 @DAS13973 @DAS12768 @Project_Creation_and_Scope @Buckets @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardedObjectsAreDisplayedAfterChangingProjectBucketsSetting
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| TestProject20 | All Devices | None            | Standalone Project |
	Then Page with 'TestProject20' header is displayed to user
	When User navigates to the 'Details' left menu item
	And User selects "Clone Evergreen buckets to project buckets" in the Buckets Project dropdown
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'Scope Changes' left menu item
	Then 'Match to Evergreen Bucket' content is displayed in 'Bucket' dropdown
	When User expands multiselect and selects following Objects
	| Objects         |
	| 0281Z793OLLLDU6 |
	| 03U75EKEMUQMUS  |
	Then 'Devices 2/0' tab is displayed on Project Scope Changes page
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	Then 'Devices 0/0' tab is displayed on Project Scope Changes page
	When User click on Back button
	And User navigates to the 'Teams' left menu item
	Then Page with 'Teams' header is displayed to user
	When User enters "My Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	And User navigates to the 'Buckets' left menu item
	And User enters "Unassigned2" text in the Search field for "Bucket" column
	Then "2" Onboarded objects are displayed
	When User clicks 'Admin' on the left-hand menu
