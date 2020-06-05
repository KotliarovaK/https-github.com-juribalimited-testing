Feature: UpdateCapacityUnit
	Upodate Capacity Unit

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @DAS14172 @DAS14236 @DAS13002 @DAS16803 @Cleanup @Do_Not_Run_With_CapacityUnits @Set_Default_Capacity_Unit
Scenario: EvergreenJnr_AdminPage_CheckThatTheUpdateCapacityUnitSettingsIsWorkingCorrectly
	When User creates new Capacity Unit via api
	| Name                   | Description | IsDefault |
	| Capacity Unit Settings |             |           |
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Capacity Units' left menu item
	Then Page with 'Capacity Units' header is displayed to user
	When User enters "Capacity Unit Settings" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	And User enters 'Capacity Unit Settings upd' text to 'Capacity Unit Name' textbox
	And User enters 'upd' text to 'Description' textbox
	When User checks 'Default unit' checkbox
	And User clicks 'UPDATE' button 
	Then 'The capacity unit details have been updated' text is displayed on inline success banner
	Then 'Capacity Unit Settings upd' content is displayed in the 'Capacity Unit' column
	When User enters "Capacity Unit Settings upd" text in the Search field for "Capacity Unit" column
	Then 'TRUE' content is displayed in the 'Default' column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	When User checks 'Default unit' checkbox
	And User clicks 'UPDATE' button 
	Then 'The capacity unit details have been updated' text is displayed on inline success banner
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then 'TRUE' content is displayed in the 'Default' column