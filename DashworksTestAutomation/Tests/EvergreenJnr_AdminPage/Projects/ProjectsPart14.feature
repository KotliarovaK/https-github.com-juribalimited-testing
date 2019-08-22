Feature: ProjectsPart14
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12949 @DAS12609 @DAS12108 @DAS12756 @Cleanup @TEST
Scenario: EvergreenJnr_AdminPage_ChecksThatProjectNameWhichStartsWithLowerCaseLetterIsDisplayedInAlphabeticalOrder
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| project12949 | All Devices | None            | Standalone Project |
	When User clicks Admin on the left-hand menu
	And User clicks "Evergreen" link on the Admin page
	And User clicks "Buckets" tab
	Then "Buckets" page should be displayed to the user
	When User clicks String Filter button for "Project" column on the Admin page
	Then Projects in filter dropdown are displayed in alphabetical order
	When User clicks String Filter button for "Owned By Team" column on the Admin page
	Then Teams in filter dropdown are displayed in alphabetical order
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "project12949" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Users" tab in the Project Scope Changes section
	And User expands the object to add
	And User selects following Objects
	| Objects                      |
	| ADD135461 (Luke W. Clark)    |
	| ADO048752 (Elena Z. Le)      |
	| ADX520696 (Bridgett E. Cobb) |
	| CKB423934 (Tracie N. Bright) |
	| CKB423934 (Tracie N. Bright) |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "3 users will be added" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	When User clicks "Applications" tab in the Project Scope Changes section
	When User expands the object to add
	And User selects following Objects
	| Objects              |
	| Adobe Reader 5ver2.1 |
	| allCLEAR 6.0 Viewer  |
	| AnalogX TrackSeek    |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "3 applications will be added" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "3 objects queued for onboarding, 0 objects offboarded" text
	When User clicks "Users" tab in the Project Scope Changes section
	Then following objects were not found
	| Objects                      |
	| ADD135461 (Luke W. Clark)    |
	| ADO048752 (Elena Z. Le)      |
	| ADX520696 (Bridgett E. Cobb) |
	When User clicks "Applications" tab in the Project Scope Changes section
	Then following objects were not found
	| Objects              |
	| Adobe Reader 5ver2.1 |
	| allCLEAR 6.0 Viewer  |
	| AnalogX TrackSeek    |
	When User selects "History" tab on the Project details page
	Then onboarded objects are displayed in the dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12755 @DAS12763 @DAS14604 @Cleanup @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatRelatedBucketsAreUpdatedAfterCreatingOrDeletingProject
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| 1DevicesProject | All Devices | None            | Standalone Project |
	When User clicks Admin on the left-hand menu
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	#Remove after Buckets loaded faster
	When User clicks "Teams" link on the Admin page
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Select All" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "1DevicesProject" checkbox from String Filter with item list on the Admin page
	Then "Unassigned" text is displayed in the table content
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "1DevicesProject" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	Then "Buckets" page should be displayed to the user
	When User clicks String Filter button for "Project" column on the Admin page
	Then "1DevicesProject" is not displayed in the filter dropdown

@Evergreen @PMObject @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12965 @DAS12485 @DAS12825 @DASDAS14617 @Cleanup @Not_Run
Scenario: EvergreenJnr_AdminPage_ChecksThatColourOfOnboardedAppIsDisplayedCorrectly
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project12965 | All Devices | None            | Standalone Project |
	Then Project "Project12965" is displayed to user
	When User selects "Scope" tab on the Project details page
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "RED" color in the Application Scope tab on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following Objects
	| Objects                                                      |
	| ALS - Designing a Microsoft Windows 2000 Dir. Services eBook |
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "1 object queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items                                                        |
	| ALS - Designing a Microsoft Windows 2000 Dir. Services eBook |
	When User refreshes agGrid
	When User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items                                                        |
	| ALS - Designing a Microsoft Windows 2000 Dir. Services eBook |
	When User refreshes agGrid
	When User enters "ALS - Designing a Microsoft Windows 2000 Dir. Services eBook" text in the Search field for "Item" column
	And User clicks content from "Item" column
	Then "Project Object" page is displayed to the user
	And Colour of onboarded app is "Red"

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12496 @DAS12485 @DAS12108 @Cleanup @TEST
Scenario: EvergreenJnr_AdminPage_CheckThatOffboardedObjectsAreListedAfterSelectObjectToRemove
	When Project created via API and opened
	| ProjectName   | Scope     | ProjectTemplate | Mode               |
	| UsersProject2 | All Users | None            | Standalone Project |
	Then Project "UsersProject2" is displayed to user
	When User selects "Scope" tab on the Project details page
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	And User expands the object to add
	And User selects following Objects
	| Objects         |
	| 01HMZTRG6OQAOF  |
	| 02C80G8RFTPA9E  |
	| 04FPR090BNW80E  |
	| 05LG3HCJLEDEMTR |
	| 2QP6MWKI0BM87U  |
	| 2QP6MWKI0BM87U  |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "4 devices will be added" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "4 objects queued for onboarding, 0 objects offboarded" text
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Device Scope" tab in the Scope section on the Project details page
	When User selects "Do not include owned devices" checkbox on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	When User selects "Do not include applications" checkbox on the Project details page
	When User selects "Scope Changes" tab on the Project details page
	When User adds following Objects to the Project on "Devices" tab
	| Objects         |
	| 01HMZTRG6OQAOF  |
	| 02C80G8RFTPA9E  |
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message with "0 objects queued for onboarding, 2 objects offboarded" text is displayed on the Projects page
	When User selects "History" tab on the Project details page
	When User clicks String Filter button for "Action" column on the Admin page
	When User selects "Onboard Computer Object" checkbox from String Filter with item list on the Admin page
	Then Rows counter shows "2" of "6" rows