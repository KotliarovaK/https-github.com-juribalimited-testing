Feature: CapacityPart2
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13790 @DAS13528 @DAS13165 @DAS13164 @DAS13154 @DAS14037 @DAS14236 @DAS13157 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectLinkIsDisplayedInTheGreenBannerForCreatedUnit
	When Project created via API and opened
	| ProjectName             | Scope       | ProjectTemplate | Mode               |
	| ProjectForCapacity13790 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit13790" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13720" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the CapacityUnit13790 capacity unit" link
	When User enters "13720" text in the Search field for "Description" column
	Then Rows counter shows "1" of "2" rows
	When User clicks newly created object link
	Then URL contains "evergreen/#/admin/project/"
	When User updates the "Default Unit" checkbox state
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text
	Then Success message is displayed correctly
	When User enters "13720" text in the Search field for "Description" column
	And User click content from "Capacity Unit" column
	Then "Default Unit" checkbox is checked and cannot be unchecked
	When User clicks the "CANCEL" Action button
	And User creates new Capacity Unit via api
	| Name              | Description | IsDefault | Project                 |
	| CapacityUnit13790 | DAS13528    | false     | ProjectForCapacity13790 |
	| CapacityUnit2     | DAS13528    | false     | ProjectForCapacity13790 |
	When User selects "Capacity Details" tab on the Project details page
	And User selects "Clone evergreen capacity units to project capacity units" in the "Capacity Units" dropdown
	And User clicks the "UPDATE" Action button
	Then Success message is displayed correctly
	Then Success message is displayed and contains "The project capacity details have been updated" text
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS12672 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatOneDefaultCapacityUnitCanBeCreated
	When Project created via API and opened
	| ProjectName           | Scope         | ProjectTemplate | Mode               |
	| ProjectForCapacity12672 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	Then User sees next Units on the Capacity Units page:
	| units             |
	| Unassigned        |
	And "TRUE" content is displayed in "Default" column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName |
	| Unassigned       |
	And User clicks on Actions button
	And User clicks Delete button in Actions
	And User clicks Delete button
	Then Warning message with "You cannot delete the default unit" text is displayed on the Admin page
	When User close message on the Admin page
	Then "Unassigned" content is displayed in the "Capacity Unit" column
	When User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type "CapacityUnit12672" Name in the "Capacity Unit Name" field on the Project details page
	And User type "12672" Name in the "Description" field on the Project details page
	And User updates the "Default Unit" checkbox state
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the CapacityUnit12672 capacity unit" link
	When User clicks newly created object link
	Then URL contains "capacity/units/unit/"
	And "Default Unit" checkbox is checked and cannot be unchecked
	#DAS-13151
	And "UPDATE" Action button is disabled
	And "CANCEL" Action button is enabled
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User enters "CapacityUnit12672" text in the Search field for "Capacity Unit" column
	Then "TRUE" content is displayed in "Default" column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "FALSE" content is displayed in "Default" column
	When User clicks content from "Capacity Unit" column
	And User updates the "Default Unit" checkbox state
	And User clicks the "UPDATE" Action button
	And User selects "Units" tab on the Project details page
	And User enters "CapacityUnit12672" text in the Search field for "Capacity Unit" column
	Then "FALSE" content is displayed in "Default" column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "TRUE" content is displayed in "Default" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14240 @DAS16372 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCapacityUnitsGridUpdatedAfterUnitUpdatingOrCreation
	When User creates new Capacity Unit via api
	| Name              | Description | IsDefault | Project         |
	| CapacityUnit14240 | 14240       | false     | Email Migration |
	And User navigates to "Email Migration" project details
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks content from "Capacity Unit" column
	When User clicks "Projects" navigation link on the Admin page
	Then Warning Pop-up is not displayed
	Then "Projects" page should be displayed to the user
	When User enters "Email Migration" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks content from "Capacity Unit" column
	When User clicks "Administration" navigation link on the Admin page
	Then Warning Pop-up is not displayed
	Then "Projects" page should be displayed to the user
	When User enters "Email Migration" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	Then User sees next Units on the Capacity Units page:
	| units             |
	| Unassigned        |
	| CapacityUnit14240 |
	When User enters "CapacityUnit14240" text in the Search field for "Capacity Unit" column
	And User click content from "Capacity Unit" column
	And User type "CapacityUnit14240NameUpdated" Name in the "Capacity Unit Name" field on the 'Email Migration' Project details page
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text
	And User sees next Units on the Capacity Units page:
	| units                        |
	| Unassigned                   |
	| CapacityUnit14240NameUpdated |
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName  |
	| CapacityUnit14240NameUpdated |
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	And User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected unit has been deleted" text
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13945 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitWithEmptyName
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13945 | All Devices | None            | Standalone Project |
	And User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User clicks the "CREATE PROJECT CAPACITY UNIT" Action button
	And User type " " Name in the "Capacity Unit Name" field on the Project details page
	And User type "13945" Name in the "Description" field on the Project details page
	Then "CREATE" Action button is disabled