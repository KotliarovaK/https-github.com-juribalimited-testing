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
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Capacity Units" tab
	Then "Capacity Units" page should be displayed to the user
	When User enters "Capacity Unit Settings" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	And User type "Capacity Unit Settings upd" Name in the "Capacity Unit Name" field on the Project details page
	And User type "upd" Name in the "Description" field on the Project details page
	And User updates the "Default Unit" checkbox state
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text
	Then "Capacity Unit Settings upd" text is displayed in the table content
	When User enters "Capacity Unit Settings upd" text in the Search field for "Capacity Unit" column
	Then "TRUE" value is displayed for Default column
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	And User updates the "Default Unit" checkbox state
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then "TRUE" value is displayed for Default column