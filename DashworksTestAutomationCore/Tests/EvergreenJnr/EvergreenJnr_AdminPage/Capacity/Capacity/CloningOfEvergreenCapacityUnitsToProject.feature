Feature: CloningOfEvergreenCapacityUnitsToProject
	Checks That Cloning Of Evergreen Capacity Units 
	To Project Capacity Units Is Worked Correctly 
	If The Capacity Mode Equals Capacity Units

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS14103 @DAS14172 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatCloningOfEvergreenCapacityUnitsToProjectCapacityUnitsIsWorkedCorrectlyIfTheCapacityModeEqualsCapacityUnits_Devices
	#Create Capacity Unit
	When User creates new Capacity Unit via api
	| Name                | Description | IsDefault |
	| Devices_CU_DAS14103 |             | false     |
	When User navigates to newly created Capacity Unit
	#Add Devices to Capacity Unit
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User perform search by "N7GXB25TPJY73EH"
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| N7GXB25TPJY73EH  |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update capacity unit' option from 'Bulk Update Type' autocomplete
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Devices_CU_DAS14103' option from 'Capacity Unit' autocomplete
	When User selects 'None' in the 'Also Move Users' dropdown
	When User clicks 'UPDATE' button
	When User clicks 'UPDATE' button
	#Setup project
	When Project created via API and opened
	| ProjectName    | Scope       | ProjectTemplate | Mode               |
	| Prj_D_DAS14103 | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	When User selects 'Teams and Paths' in the 'Capacity Mode' dropdown
	And User selects 'Clone Evergreen capacity units to project capacity units' in the 'Capacity Units' dropdown
	And User clicks 'UPDATE' button 
	Then 'The project capacity details have been updated' text is displayed on inline success banner
	#Add Devices to scope
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Devices' tab on Project Scope Changes page
	Then 'Devices' tab is opened on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects         |
	| N7GXB25TPJY73EH |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	#Test
	When User navigates to the 'Queue' left menu item
	Then following Items are displayed in the Queue table
	| Items           |
	| N7GXB25TPJY73EH |
	When User navigates to the 'History' left menu item
	Then following Items are displayed in the History table
	| Items           |
	| N7GXB25TPJY73EH |
	Then 'Devices_CU_DAS14103' content is displayed in the 'Capacity Unit' column
	When User navigates to the 'Capacity' left menu item
	When User navigates to the 'Units' left menu item
	When User enters "Devices_CU_DAS14103" text in the Search field for "Capacity Unit" column
	Then '1' content is displayed in the 'Devices' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS14103 @DAS14172 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatCloningOfEvergreenCapacityUnitsToProjectCapacityUnitsIsWorkedCorrectlyIfTheCapacityModeEqualsCapacityUnits_Users
	#Create Capacity Unit
	When User creates new Capacity Unit via api
	| Name              | Description | IsDefault |
	| Users_CU_DAS14103 |             | false     |
	When User navigates to newly created Capacity Unit
	#Add Devices to Capacity Unit
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User perform search by "B569F47FE6B1491CAEC"
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName    |
	| B569F47FE6B1491CAEC |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update capacity unit' option from 'Bulk Update Type' autocomplete
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Users_CU_DAS14103' option from 'Capacity Unit' autocomplete
	When User clicks 'UPDATE' button
	When User clicks 'UPDATE' button
	#Setup project
	When Project created via API and opened
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| Prj_U_DAS14103 | All Users | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	When User selects 'Teams and Paths' in the 'Capacity Mode' dropdown
	And User selects 'Clone Evergreen capacity units to project capacity units' in the 'Capacity Units' dropdown
	And User clicks 'UPDATE' button 
	Then 'The project capacity details have been updated' text is displayed on inline success banner
	#Add Devices to scope
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then 'Users' tab is opened on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects             |
	| B569F47FE6B1491CAEC |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	#Test
	When User navigates to the 'Queue' left menu item
	Then following Items are displayed in the Queue table
	| Items               |
	| B569F47FE6B1491CAEC |
	When User navigates to the 'History' left menu item
	Then following Items are displayed in the History table
	| Items               |
	| B569F47FE6B1491CAEC |
	Then 'Users_CU_DAS14103' content is displayed in the 'Capacity Unit' column
	When User navigates to the 'Capacity' left menu item
	When User navigates to the 'Units' left menu item
	When User enters "Users_CU_DAS14103" text in the Search field for "Capacity Unit" column
	Then '' content is displayed in the 'Devices' column
	Then '1' content is displayed in the 'Users' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS14103 @DAS14172 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatCloningOfEvergreenCapacityUnitsToProjectCapacityUnitsIsWorkedCorrectlyIfTheCapacityModeEqualsCapacityUnits_Applications
	#Create Capacity Unit
	When User creates new Capacity Unit via api
	| Name                     | Description | IsDefault |
	| Applications_CU_DAS14103 |             | false     |
	When User navigates to newly created Capacity Unit
	#Add Devices to Capacity Unit
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User perform search by "Windows Live Messenger (8.1.0178.00)"
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                     |
	| Windows Live Messenger (8.1.0178.00) |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update capacity unit' option from 'Bulk Update Type' autocomplete
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Applications_CU_DAS14103' option from 'Capacity Unit' autocomplete
	When User clicks 'UPDATE' button
	When User clicks 'UPDATE' button
	#Setup project
	When Project created via API and opened
	| ProjectName    | Scope     | ProjectTemplate | Mode               |
	| Prj_A_DAS14103 | All Users | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item
	When User selects 'Teams and Paths' in the 'Capacity Mode' dropdown
	And User selects 'Clone Evergreen capacity units to project capacity units' in the 'Capacity Units' dropdown
	And User clicks 'UPDATE' button 
	Then 'The project capacity details have been updated' text is displayed on inline success banner
	#Add Devices to scope
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then 'Applications' tab is opened on Project Scope Changes page
	When User expands multiselect and selects following Objects
	| Objects                              |
	| Windows Live Messenger (8.1.0178.00) |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	#Test
	#Ann.I. 11/15/19: Objects go to the history tab too quickly. We are waiting for Lisa's response.
	#When User navigates to the 'Queue' left menu item
	#Then following Items are displayed in the Queue table
	#| Items                                |
	#| Windows Live Messenger (8.1.0178.00) |
	When User navigates to the 'History' left menu item
	Then following Items are displayed in the History table
	| Items                                |
	| Windows Live Messenger (8.1.0178.00) |
	Then 'Applications_CU_DAS14103' content is displayed in the 'Capacity Unit' column
	When User navigates to the 'Capacity' left menu item
	When User navigates to the 'Units' left menu item
	When User enters "Applications_CU_DAS14103" text in the Search field for "Capacity Unit" column
	Then '' content is displayed in the 'Devices' column
	Then '' content is displayed in the 'Users' column
	Then '1' content is displayed in the 'Applications' column