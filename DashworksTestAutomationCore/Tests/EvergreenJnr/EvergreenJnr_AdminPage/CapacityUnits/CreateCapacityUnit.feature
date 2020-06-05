Feature: CreateCapacityUnit
	Create Capacity Unit

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12632 @DAS13626 @DAS14236 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatCapacityUnitsCreatedCorrectly
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	Then Page with 'Capacity Units' header is displayed to user
	When User clicks 'CREATE EVERGREEN CAPACITY UNIT' button 
	And User enters 'NotDefaultCapacityUnit13720' text to 'Capacity Unit Name' textbox
	And User enters '13720' text to 'Description' textbox
	And User clicks 'CREATE' button 
	Then 'The capacity unit has been created' text is displayed on inline success banner
	And 'Click here to view the NotDefaultCapacityUnit13720 capacity unit' link is displayed
	And There are no errors in the browser console
	And 'NotDefaultCapacityUnit13720' content is displayed in the 'Capacity Unit' column
	When User enters "NotDefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	Then 'FALSE' content is displayed in the 'Default' column
	And '' content is displayed in the 'Devices' column
	And '' content is displayed in the 'Users' column
	And '' content is displayed in the 'Mailboxes' column
	And '' content is displayed in the 'Applications' column
	When User select "Capacity Unit" rows in the grid
	| SelectedRowsName            |
	| NotDefaultCapacityUnit13720 |
	And User selects 'Delete' in the 'Actions' dropdown
	And User clicks 'DELETE' button
	Then 'This unit will be permanently deleted and any objects within it reassigned to the default unit' text is displayed on inline tip banner
	And Delete and Cancel buttons are available in the warning message
	When User clicks 'DELETE' button on inline tip banner
	Then 'The selected unit has been deleted' text is displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12632 @Cleanup @Set_Default_Capacity_Unit @Do_Not_Run_With_CapacityUnits
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultCapacityUnitsCreatedCorrectly
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User creates new Capacity Unit via api
	| Name                     | Description | IsDefault |
	| DefaultCapacityUnit13720 | 13720       | true      |
	And User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	Then 'DefaultCapacityUnit13720' content is displayed in the 'Capacity Unit' column
	When User enters "DefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	Then 'TRUE' content is displayed in the 'Default' column
	And '' content is displayed in the 'Devices' column
	And '' content is displayed in the 'Users' column
	And '' content is displayed in the 'Mailboxes' column
	And '' content is displayed in the 'Applications' column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then 'FALSE' content is displayed in the 'Default' column
	When User enters "DefaultCapacityUnit13720" text in the Search field for "Capacity Unit" column
	And User select "Capacity Unit" rows in the grid
	| SelectedRowsName         |
	| DefaultCapacityUnit13720 |
	And User selects 'Delete' in the 'Actions' dropdown
	And User clicks 'DELETE' button
	Then 'You cannot delete the default unit' text is displayed on inline tip banner
	When User close message on the Admin page
	Then 'DefaultCapacityUnit13720' content is displayed in the 'Capacity Unit' column
	When User clicks content from "Capacity Unit" column
	Then "Default unit" checkbox is checked and cannot be unchecked

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS13013 @DAS12926 @DAS18351 @DAS18920 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatMessageAppearsWhenUserCreatesUnitWithTheSameNameInDifferentCase
	When User clicks 'Admin' on the left-hand menu
	And User creates new Capacity Unit via api
	| Name                  | Description           | IsDefault |
	| SameNameCaseSensative | SameNameCaseSensative | false     |
	And User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	When User clicks 'CREATE EVERGREEN CAPACITY UNIT' button 
	And User enters 'samenamecaseSensative' text to 'Capacity Unit Name' textbox
	And User enters 'SameNameCaseSensative' text to 'Description' textbox
	Then 'A capacity unit already exists with this name' error message is displayed for 'Capacity Unit Name' field
	And There are no errors in the browser console