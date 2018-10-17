Feature: Capacity
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Units @DAS13720 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatDefaultCapacityUnitRenamedInUnassignedWithoutErrors
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "ProjectForCapacity13720" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "ProjectForCapacity13720" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	And User enters "Default Capacity Unit" text in the Search field for "Capacity Unit" column
	And User clicks content from "Capacity Unit" column
	And User changes Name to "Unassigned" in the "Capacity Unit Name" field on the Project details page 
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The capacity unit details have been updated" text

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Override_Dates @DAS13723 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUnlimitedValueIsDisplayedForCapacityColumn
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "ProjectForCapacity13723" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "ProjectForCapacity13723" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Override Dates" tab on the Project details page
	When User clicks the "ADD OVERRIDE DATE" Action button
	When User enters "4 Oct 2018" date in the "Override Start Date" field
	When User enters "7 Oct 2018" date in the "Override End Date" field
	When User clicks the "CREATE" Action button
	Then Success message is displayed and contains "Your override date has been created" text
	Then "Unlimited" content is displayed in "Capacity" column
	When User enters "1" text in the Search field for "Capacity" column
	Then Counter shows "0" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13171 @DAS13432 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatUnlimitedTextIsDisappearAfterClickingIntoTheCell
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "ProjectForCapacity13171" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "ProjectForCapacity13171" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Slots" tab on the Project details page
	When User clicks the "CREATE NEW SLOT" Action button
	When User clicks on the Unlimited field on the Capacity Slots page
	Then Unlimited text disappears from column
	When User clicks the "CANCEL" Action button
	When User clicks the "CREATE NEW SLOT" Action button
	And User type "CapacitySlot1" Name in the "Slot Name" field on the Project details page
	And User type "DAS13432" Name in the "Display Name" field on the Project details page
	When User selects "Capacity Units" in the "Capacity Type" dropdown
	When User clicks the "CREATE" Action button
	Then "All Capacity Units" content is displayed in "Capacity Units" column

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS13790 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectLinkIsDisplayedInTheGreenBannerForCreatedUnit
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "ProjectForCapacity13790" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "ProjectForCapacity13790" is displayed to user
	When User clicks "Capacity" tab
	And User selects "Units" tab on the Project details page
	When User clicks the "CREATE CAPACITY UNIT" Action button
	And User type "CapacityUnit13790" Name in the "Capacity Unit Name" field on the Project details page
	And User type "13720" Name in the "Description" field on the Project details page
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The capacity unit has been created" text
	And Success message is displayed and contains "Click here to view the CapacityUnit13790 capacity unit" link
	When User clicks newly created object link
	Then URL contains "evergreen/#/admin/project/"