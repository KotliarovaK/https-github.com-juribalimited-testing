Feature: Capacity
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13720
Scenario: EvergreenJnr_AdminPage_CheckThatDefaultCapacityUnitRenamedInUnassignedWithoutErrors
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "ProjectForCapacity13720" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "ProjectForCapacity13720" is displayed to user
	When User clicks "Capacity" tab
	When User selects "Units" tab on the Project details page
	When User enters "Default Capacity Unit" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	When User changes Name to "Unassigned" in the "Capacity Unit Name" field on the Project details page 
	When User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text