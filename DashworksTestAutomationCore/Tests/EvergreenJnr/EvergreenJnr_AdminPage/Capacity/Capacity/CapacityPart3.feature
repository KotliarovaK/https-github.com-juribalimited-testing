Feature: CapacityPart3
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13166 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCapacityUnitCanBeCreatedWithNameAlreadyUsedInDifferentProject
	When Project created via API and opened
	| ProjectName        | Scope         | ProjectTemplate | Mode               |
	| ProjectForDAS13166 | All Mailboxes | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	And User clicks 'CREATE PROJECT CAPACITY UNIT' button 
	#next capacity name used in "2004 Rollout" project
	And User enters 'Manchester' text to 'Capacity Unit Name' textbox 
	And User enters 'Manchester Operations' text to 'Description' textbox
	And User clicks 'CREATE' button 
	Then 'The capacity unit has been created' text is displayed on inline success banner
	And Counter shows "2" found rows
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13945 @DAS12672 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitStartedWithSpace
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13945 | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	And User clicks 'CREATE PROJECT CAPACITY UNIT' button 
	And User enters ' test1' text to 'Capacity Unit Name' textbox
	And User enters '13945' text to 'Description' textbox
	And User clicks 'CREATE' button 
	Then 'The capacity unit has been created' text is displayed on inline success banner
	Then Content in the 'Capacity Unit' column is equal to
	| Content    |
	| Unassigned |
	| test1      |
	When User navigates to the 'Units' left menu item
	And User clicks 'CREATE PROJECT CAPACITY UNIT' button 
	And User enters ' test1' text to 'Capacity Unit Name' textbox
	And User enters '13945_2' text to 'Description' textbox
	And User clicks 'CREATE' button 
	Then 'A capacity unit already exists with this name' text is displayed on inline error banner
	Then Content in the 'Capacity Unit' column is equal to
	| Content    |
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
	And User navigates to the 'Units' left menu item
	Then Content in the 'Capacity Unit' column is equal to
	| Content           |
	| Unassigned        |
	| 13159             |
	| A13159Unit        |
	| CapacityUnit13790 |
	| NewUnit           |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Capacity @Senior_Projects @DAS14029 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultValueForCapacityModeFieldEqualsCapacityUnits
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName      | ShortName | Description | Type |
	| Project14029 Snr | 13498     |             |      |
	And User navigate to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	And User navigates to "Project14029 Snr" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Capacity Details' left menu item
	Then Capacity Units value is displayed for Capacity Mode field
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project14029 | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Capacity Details' left menu item
	Then Capacity Units value is displayed for Capacity Mode field
