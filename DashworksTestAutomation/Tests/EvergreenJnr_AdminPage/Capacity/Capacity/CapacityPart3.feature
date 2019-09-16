Feature: CapacityPart3
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13166 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCapacityUnitCanBeCreatedWithNameAlreadyUsedInDifferentProject
	When Project created via API and opened
	| ProjectName        | Scope         | ProjectTemplate | Mode               |
	| ProjectForDAS13945 | All Mailboxes | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	#next capacity name used in "1803 Rollout" project
	And User type "Manchester" Name in the "Capacity Unit Name" field on the Project details page 
	And User type "Manchester Operations" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Counter shows "2" found rows
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13945 @DAS12672 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitStartedWithSpace
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13945 | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " test1" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13945" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Error message is not displayed on the Capacity Units page
	And User sees next Units on the Capacity Units page:
	| units      |
	| Unassigned |
	| test1      |
	When User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " test1" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13945_2" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Error message with "A capacity unit already exists with this name" text is displayed
	And User sees next Units on the Capacity Units page:
	| units      |
	| Unassigned |
	| test1      |

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS13159 @DAS13754 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckingSortOrderForCapacityUnits
	When Project created via API and opened
	| ProjectName             | Scope       | ProjectTemplate | Mode               |
	| 13159ProjectForCapacity | All Devices | None            | Standalone Project |
	And User creates new Capacity Unit via api
	| Name              | Description | IsDefault | Project                 |
	| CapacityUnit13790 |             | false     | 13159ProjectForCapacity |
	| NewUnit           |             | false     | 13159ProjectForCapacity |
	| 13159             |             | false     | 13159ProjectForCapacity |
	| A13159Unit        |             | false     | 13159ProjectForCapacity |
	And User navigates to the 'Capacity' left menu item
	And User selects "Units" tab on the Project details page
	Then "Capacity Unit" column content is displayed in the following order:
	| Items             |
	| Unassigned        |
	| 13159             |
	| A13159Unit        |
	| CapacityUnit13790 |
	| NewUnit           |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Capacity @Senior_Projects @DAS14029 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultValueForCapacityModeFieldEqualsCapacityUnits
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName      | ShortName | Description | Type |
	| Project14029 Snr | 13498     |             |      |
	And User navigate to Evergreen link
	And User clicks "Admin" on the left-hand menu
	And User navigates to "Project14029 Snr" project details
	And User navigates to the 'Capacity' left menu item
	And User selects "Capacity Details" tab on the Project details page
	Then Capacity Units value is displayed for Capacity Mode field
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project14029 | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User selects "Capacity Details" tab on the Project details page
	Then Capacity Units value is displayed for Capacity Mode field
