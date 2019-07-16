Feature: CapacityPart5
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS13956 @DAS14068 @DAS14218 @Delete_Newly_Created_Project @Do_Not_Run_With_CapacityUnits @Set_Default_Capacity_Unit @Save_Default_Capacity_Unit
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultCapacityUnitInAProjectMappedToEvergreenDefaultCapacityUnit
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User updates Capacity Units via api
	| OldName    | Name     | Description | IsDefault |
	| Unassigned | New Name |             |           |
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13956 | All Devices | None            | Standalone Project |
	And User selects "Capacity" tab on the Project details page	
	Then User selects "Clone evergreen capacity units to project capacity units" option in "Capacity Units" dropdown
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text
	When User navigates to the "Units" sub-menu on the Details page
	Then Counter shows "1" found rows
	And "Unassigned" content is displayed for "Capacity Unit" column
	And "New Name" content is displayed for "Maps to Evergreen" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14218
Scenario: EvergreenJnr_AdminPage_CheckingMapsToEvergreenColumnDisplayedForDifferentProjectTypes
	When User navigates to "User Evergreen Capacity Project" project details
	Then Project "User Evergreen Capacity Project" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User enters "1" text in the Search field for "Capacity Unit" column
	Then "Evergreen Capacity Unit 1" content is displayed for "Maps to Evergreen" column
	When User enters "2" text in the Search field for "Capacity Unit" column
	Then "Evergreen Capacity Unit 2" content is displayed for "Maps to Evergreen" column
	When User enters "3" text in the Search field for "Capacity Unit" column
	Then "Evergreen Capacity Unit 3" content is displayed for "Maps to Evergreen" column
	When User navigates to "Devices Evergreen Capacity Project" project details
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User have opened Column Settings for "Capacity Unit" column
	And User clicks Column button on the Column Settings panel
	And User select "Maps to Evergreen" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User enters "1" text in the Search field for "Capacity Unit" column
	Then "" content is displayed for "Maps to Evergreen" column
	When User enters "2" text in the Search field for "Capacity Unit" column
	Then "" content is displayed for "Maps to Evergreen" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13156
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardedApplicationsAreDisplayedCapacityUnits
	When User navigates to "Email Migration" project details
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " 1Test" Name in the "Capacity Unit Name" field on the Project details page
	And User type "DAS13156" Name in the "Description" field on the Project details page
	And User updates the "Default Unit" checkbox state
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName         |
	| 7-Zip 16.04 (x64)        |
	| 7-Zip 9.20 (x64 edition) |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Project" Project or Evergreen on Action panel
	And User selects "Email Migration" Project on Action panel
	And User selects "1Test" value for "Capacity Unit" dropdown with search on Action panel
	And User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "2 of 2 objects were in the selected project and have been queued" text is displayed on Action panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Capacity Units" tab
	Then "Capacity Units" page should be displayed to the user
	When User clicks String Filter button for "Project" column
	When User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column
	When User selects "Email Migration" checkbox from String Filter with item list on the Admin page
	Then "2" content is displayed in "Applications" column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	And User click content from "Capacity Unit" column
	And User updates the "Default Unit" checkbox state
	And User clicks the "UPDATE" Action button
	When User clicks Reset Filters button on the Admin page
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName |
	| 1Test            |
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14967 @Not_Run
Scenario Outline: EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfDeviceProjectLeadToCorrectFilteredLists
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	And User remembers value in "<ListName>" column
	And User clicks content from "<ListName>" column
	Then "<ListName>" list should be displayed to the user
	And Rows counter number equals to remembered value
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Windows7Mi: Capacity Unit" filter is added to the list
	And Values is displayed in added filter info
	| Values     |
	| Unassigned |
	And Options is displayed in added filter info
	| Values |
	| is     |

Examples:
	| ListName     |
	| Devices      |
	| Users        |
	| Applications |
