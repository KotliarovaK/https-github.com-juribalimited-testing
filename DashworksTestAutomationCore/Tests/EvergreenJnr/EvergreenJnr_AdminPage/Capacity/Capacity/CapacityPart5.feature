Feature: CapacityPart5
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @DAS13956 @DAS14068 @DAS14218 @Cleanup @Do_Not_Run_With_Capacity @Do_Not_Run_With_CapacityUnits @Set_Default_Capacity_Unit
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultCapacityUnitInAProjectMappedToEvergreenDefaultCapacityUnit
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User updates Capacity Units via api
	| OldName    | Name     | Description | IsDefault |
	| Unassigned | New Name |             |           |
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS13956 | All Devices | None            | Standalone Project |
	And User navigates to the 'Capacity' left menu item	
	And User selects 'Clone Evergreen capacity units to project capacity units' in the 'Capacity Units' dropdown
	And User clicks 'UPDATE' button 
	Then 'The project capacity details have been updated' text is displayed on inline success banner
	When User navigates to the 'Units' left submenu item
	Then Counter shows "1" found rows
	And "Unassigned" content is displayed for "Capacity Unit" column
	And "New Name" content is displayed for "Maps to Evergreen" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14218
Scenario: EvergreenJnr_AdminPage_CheckingMapsToEvergreenColumnDisplayedForDifferentProjectTypes
	When User navigates to "User Evergreen Capacity Project" project details
	Then Page with 'User Evergreen Capacity Project' header is displayed to user
	When User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	When User enters "1" text in the Search field for "Capacity Unit" column
	Then "Evergreen Capacity Unit 1" content is displayed for "Maps to Evergreen" column
	When User enters "2" text in the Search field for "Capacity Unit" column
	Then "Evergreen Capacity Unit 2" content is displayed for "Maps to Evergreen" column
	When User enters "3" text in the Search field for "Capacity Unit" column
	Then "Evergreen Capacity Unit 3" content is displayed for "Maps to Evergreen" column
	When User navigates to "Devices Evergreen Capacity Project" project details
	When User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	When User opens 'Capacity Unit' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Maps to Evergreen" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	When User enters "1" text in the Search field for "Capacity Unit" column
	Then "" content is displayed for "Maps to Evergreen" column
	When User enters "2" text in the Search field for "Capacity Unit" column
	Then "" content is displayed for "Maps to Evergreen" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13156 @Cleanup @Set_Default_Capacity_Unit @Do_Not_Run_With_CapacityUnits @Do_Not_Run_With_Units @Do_Not_Run_With_Capacity
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardedApplicationsAreDisplayedCapacityUnits
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project13156 | All Devices | None            | Standalone Project |
	When User creates new Capacity Unit via api
	| Name  | Description | IsDefault | Project      |
	| 1Test | DAS13156    | true      | Project13156 |
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left submenu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	When User expands 'Applications to add' multiselect to the 'Applications' tab on Project Scope Changes page and selects following Objects
	| Objects                                                                       |
	| ACDSee 4.0.2 PowerPack Trial Version (4.00.0002)                              |
	| 0036 - Microsoft Access 97 SR-2 English (8.0)                                 |
	When User clicks 'UPDATE ALL CHANGES' button 
	When User clicks 'UPDATE PROJECT' button 
	Then Blue banner with "Object updates being queued, please wait" text is displayed
	Then '2 objects queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
	When User waits until Queue disappears
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Capacity Units' left menu item
	Then Page with 'Capacity Units' header is displayed to user
	When User clicks String Filter button for "Project" column
	When User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column
	When User selects "Project13156" checkbox from String Filter with item list on the Admin page
	Then '2' content is displayed in the 'Applications' column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS14967
Scenario Outline: EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCountersOfDeviceProjectLeadToCorrectFilteredLists
	When User navigates to "Windows 7 Migration (Computer Scheduled Project)" project details
	And User navigates to the 'Capacity' left menu item
	And User navigates to the 'Units' left menu item
	And User enters "Unassigned" text in the Search field for "Capacity Unit" column
	And User remembers value in "<ColumnName>" column
	And User clicks content from "<ColumnName>" column
	Then '<ListName>' list should be displayed to the user
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
	| ColumnName   | ListName         |
	| Devices      | All Devices      |
	| Users        | All Users        |
	| Applications | All Applications |