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
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	When User clicks 'CREATE PROJECT CAPACITY UNIT' button 
	And User enters 'CapacityUnit13790' text to 'Capacity Unit Name' textbox
	And User enters '13720' text to 'Description' textbox
	And User clicks 'CREATE' button 
	Then 'The capacity unit has been created' text is displayed on inline success banner
	And 'Click here to view the CapacityUnit13790 capacity unit' link is displayed
	When User enters "13720" text in the Search field for "Description" column
	Then Rows counter shows "1" of "2" rows
	When User clicks newly created object link
	Then URL contains 'evergreen/#/admin/project/'
	When User updates the "Default Unit" checkbox state
	And User clicks 'UPDATE' button 
	Then 'The capacity unit details have been updated' text is displayed on inline success banner
	Then inline success banner is displayed
	When User enters "13720" text in the Search field for "Description" column
	And User click content from "Capacity Unit" column
	Then "Default Unit" checkbox is checked and cannot be unchecked
	When User clicks 'CANCEL' button 
	And User creates new Capacity Unit via api
	| Name              | Description | IsDefault | Project                 |
	| CapacityUnit13790 | DAS13528    | false     | ProjectForCapacity13790 |
	| CapacityUnit2     | DAS13528    | false     | ProjectForCapacity13790 |
	When User navigates to the 'Capacity Details' left menu item
	And User selects 'Clone Evergreen capacity units to project capacity units' in the 'Capacity Units' dropdown
	And User clicks 'UPDATE' button 
	Then inline success banner is displayed
	Then 'The project capacity details have been updated' text is displayed on inline success banner
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS12672 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatOneDefaultCapacityUnitCanBeCreated
	When Project created via API and opened
	| ProjectName           | Scope         | ProjectTemplate | Mode               |
	| ProjectForCapacity12672 | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	Then User sees next Units on the Capacity Units page:
	| units             |
	| Unassigned        |
	And 'TRUE' content is displayed in the 'Default' column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName |
	| Unassigned       |
	And User selects 'Delete' in the 'Actions' dropdown
	And User clicks 'DELETE' button
	Then 'You cannot delete the default unit' text is displayed on inline tip banner
	When User close message on the Admin page
	Then 'Unassigned' content is displayed in the 'Capacity Unit' column
	When User clicks 'CREATE PROJECT CAPACITY UNIT' button 
	And User enters 'CapacityUnit12672' text to 'Capacity Unit Name' textbox
	And User enters '12672' text to 'Description' textbox
	And User updates the "Default Unit" checkbox state
	And User clicks 'CREATE' button 
	Then 'The capacity unit has been created' text is displayed on inline success banner
	And 'Click here to view the CapacityUnit12672 capacity unit' link is displayed
	When User clicks newly created object link
	Then URL contains 'capacity/units/unit/'
	And "Default Unit" checkbox is checked and cannot be unchecked
	#DAS-13151
	And 'UPDATE' button is disabled
	And 'CANCEL' button is not disabled
	When User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	And User enters "CapacityUnit12672" text in the Search field for "Capacity Unit" column
	Then 'TRUE' content is displayed in the 'Default' column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then 'FALSE' content is displayed in the 'Default' column
	When User clicks content from "Capacity Unit" column
	And User updates the "Default Unit" checkbox state
	And User clicks 'UPDATE' button 
	And User navigates to the 'Units' left menu item
	And User enters "CapacityUnit12672" text in the Search field for "Capacity Unit" column
	Then 'FALSE' content is displayed in the 'Default' column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then 'TRUE' content is displayed in the 'Default' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14240 @DAS16372 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCapacityUnitsGridUpdatedAfterUnitUpdatingOrCreation
	When User creates new Capacity Unit via api
	| Name              | Description | IsDefault | Project         |
	| CapacityUnit14240 | 14240       | false     | Email Migration |
	And User navigates to "Email Migration" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	And User clicks content from "Capacity Unit" column
	When User clicks 'Projects' header breadcrumb
	Then Warning Pop-up is not displayed
	Then Page with 'Projects' header is displayed to user
	When User enters "Email Migration" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	And User clicks content from "Capacity Unit" column
	When User clicks 'Administration' header breadcrumb
	Then Warning Pop-up is not displayed
	Then Page with 'Projects' header is displayed to user
	When User enters "Email Migration" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	Then User sees next Units on the Capacity Units page:
	| units             |
	| Unassigned        |
	| CapacityUnit14240 |
	When User enters "CapacityUnit14240" text in the Search field for "Capacity Unit" column
	And User click content from "Capacity Unit" column
	When User enters 'CapacityUnit14240NameUpdated' text to 'Capacity Unit Name' textbox
	And User clicks 'UPDATE' button 
	Then 'The capacity unit details have been updated' text is displayed on inline success banner
	And User sees next Units on the Capacity Units page:
	| units                        |
	| Unassigned                   |
	| CapacityUnit14240NameUpdated |
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName  |
	| CapacityUnit14240NameUpdated |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	And User clicks 'DELETE' button on inline tip banner
	Then 'The selected unit has been deleted' text is displayed on inline success banner
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13945 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserCantCreateCapacityUnitWithEmptyName
	When Project created via API and opened
	| ProjectName          | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13945_2 | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	And User clicks 'CREATE PROJECT CAPACITY UNIT' button 
	And User enters ' ' text to 'Capacity Unit Name' textbox
	And User enters '13945_2' text to 'Description' textbox
	Then 'CREATE' button is disabled
