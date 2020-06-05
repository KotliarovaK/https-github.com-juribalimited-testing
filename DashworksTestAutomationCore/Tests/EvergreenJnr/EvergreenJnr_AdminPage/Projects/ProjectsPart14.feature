Feature: ProjectsPart14
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12949 @DAS12609 @DAS12108 @DAS12756 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatProjectNameWhichStartsWithLowerCaseLetterIsDisplayedInAlphabeticalOrder
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| project12949 | All Devices | None            | Standalone Project |
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Buckets' left menu item
	Then Page with 'Buckets' header is displayed to user
	Then options are sorted in alphabetical order in dropdown for 'Project' column
	Then options are sorted in alphabetical order in dropdown for 'Owned By Team' column
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "project12949" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User navigates to the 'Users' tab on Project Scope Changes page
	And User expands multiselect and selects following Objects
	| Objects                      |
	| ADD135461 (Luke W. Clark)    |
	| ADO048752 (Elena Z. Le)      |
	| ADX520696 (Bridgett E. Cobb) |
	| CKB423934 (Tracie N. Bright) |
	| CKB423934 (Tracie N. Bright) |
	And User clicks 'UPDATE ALL CHANGES' button 
	Then '3 users will be added' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button 
	Then '3 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Applications' tab on Project Scope Changes page
	And User expands multiselect and selects following Objects
	| Objects              |
	| Adobe Reader 5ver2.1 |
	| allCLEAR 6.0 Viewer  |
	| AnalogX TrackSeek    |
	And User clicks 'UPDATE ALL CHANGES' button 
	Then '3 applications will be added' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button 
	Then '3 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then following objects were not found
	| Objects                      |
	| ADD135461 (Luke W. Clark)    |
	| ADO048752 (Elena Z. Le)      |
	| ADX520696 (Bridgett E. Cobb) |
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then following objects were not found
	| Objects              |
	| Adobe Reader 5ver2.1 |
	| allCLEAR 6.0 Viewer  |
	| AnalogX TrackSeek    |
	When User navigates to the 'History' left menu item
	Then onboarded objects are displayed in the dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12755 @DAS12763 @DAS14604 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatRelatedBucketsAreUpdatedAfterCreatingOrDeletingProject
	When Project created via API and opened
	| ProjectName     | Scope       | ProjectTemplate | Mode               |
	| 1DevicesProject | All Devices | None            | Standalone Project |
	And User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Buckets' left menu item
	#Remove after Buckets loaded faster
	And User navigates to the 'Teams' left menu item
	And User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Buckets' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User clicks Reset Filters button on the Admin page
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "Select All" checkbox from String Filter with item list on the Admin page
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "1DevicesProject" checkbox from String Filter with item list on the Admin page
	Then 'Unassigned' content is displayed in the 'Bucket' column
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "1DevicesProject" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	And User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Buckets' left menu item
	Then Page with 'Buckets' header is displayed to user
	When User clicks String Filter button for "Project" column on the Admin page
	Then '1DevicesProject' is not displayed in the filter dropdown

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12496 @DAS12485 @DAS12108 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatOffboardedObjectsAreListedAfterSelectObjectToRemove
	When Project created via API and opened
	| ProjectName   | Scope     | ProjectTemplate | Mode               |
	| UsersProject2 | All Users | None            | Standalone Project |
	Then Page with 'UsersProject2' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Devices' tab on Project Scope Changes page
	And User expands multiselect to add objects
	And User selects following Objects from the expandable multiselect
	| Objects         |
	| 01HMZTRG6OQAOF  |
	| 02C80G8RFTPA9E  |
	| 04FPR090BNW80E  |
	| 05LG3HCJLEDEMTR |
	| 2QP6MWKI0BM87U  |
	| 2QP6MWKI0BM87U  |
	And User clicks 'UPDATE ALL CHANGES' button 
	Then '4 devices will be added' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button 
	Then '4 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Scope Details' left menu item
	And User navigates to the 'Device Scope' tab on Project Scope Changes page
	When User selects "Do not include owned devices" checkbox on the Project details page
	And User navigates to the 'Application Scope' tab on Project Scope Changes page
	And User selects "Do not include applications" checkbox on the Project details page
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Devices' tab on Project Scope Changes page
	And User expands 'Devices to remove' multiselect to the 'Devices' tab on Project Scope Changes page and selects following Objects
	| Objects         |
	| 01HMZTRG6OQAOF  |
	| 02C80G8RFTPA9E  |
	And User clicks 'UPDATE ALL CHANGES' button 
	Then '2 devices will be removed' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button 
	Then '0 objects queued for onboarding, 2 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'History' left menu item
	And User clicks String Filter button for "Action" column on the Admin page
	And User selects "Onboard Device Object" checkbox from String Filter with item list on the Admin page
	Then Rows counter shows "2" of "6" rows