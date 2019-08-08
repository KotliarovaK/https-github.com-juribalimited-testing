﻿Feature: GridScreenForListScopedProject
	Check grid screen for Devices/Mailboxes Scoped Project

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS12452 @DAS14695 @DAS14697 @DAS15180 @DAS15826 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckGridScreenForDeviceScopedProject
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 14695_Project | All Devices | None            | Standalone Project |
	When User clicks "Rings" tab
	Then "0" content is displayed in "Devices" column
	Then table with Setting menu column on Admin page is displayed in following order:
	| ColumnName |
	| Ring       |
	|            |
	| Default    |
	| Devices    |
	When User clicks Cog-menu on the Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	When User clicks the "CREATE PROJECT RING" Action button
	Then "Create Project Ring" page should be displayed to the user
	When User type "14695_Ring" Name in the "Ring name" field on the Project details page
	And User clicks Create button on the Create Ring page
	Then Success message is displayed and contains "The ring has been created" text
	When User clicks the "CREATE PROJECT RING" Action button
	Then "Create Project Ring" page should be displayed to the user
	When User type "Ring_Test" Name in the "Ring name" field on the Project details page
	When User clicks Default Ring checkbox
	And User clicks Create button on the Create Ring page
	When User have opened Column Settings for "Ring" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Display Order" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then User sees following Display order on the Automation page
	| Values |
	| 1      |
	| 2      |
	| 3      |
	Then "Ring" column content is displayed in the following order:
    | Items      |
    | Unassigned |
    | 14695_Ring |
    | Ring_Test  |
	When User click on 'Ring' column header
	Then data in table is sorted by "Ring" column in ascending order on the Admin page
	When User click on 'Ring' column header
	Then data in table is sorted by "Ring" column in descending order on the Admin page
	When User clicks Cog-menu on the Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Set default      |
	| Delete           |
	When User select "Ring" rows in the grid
	| SelectedRowsName |
	| Unassigned       |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "This ring will be permanently deleted and any objects within it reassigned to the default ring" text is displayed on the Admin page
	When User clicks Delete button in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS12452 @DAS14705 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckGridScreenForMailboxScopedProject
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "Email Migration" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "Email Migration" is displayed to user
	When User clicks "Rings" tab
	Then "729" content is displayed in "Mailboxes" column
	Then Columns on Admin page is displayed in following order:
	| ColumnName |
	|            |
	| Ring       |
	|            |
	| Default    |
	| Mailboxes  |
	When User clicks Cog-menu on the Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	When User clicks the "CREATE PROJECT RING" Action button
	Then "Create Project Ring" page should be displayed to the user
	When User type "14705_Ring" Name in the "Ring name" field on the 'Email Migration' Project details page
	And User clicks Create button on the Create Ring page
	Then Success message is displayed and contains "The ring has been created" text
	When User clicks the "CREATE PROJECT RING" Action button
	Then "Create Project Ring" page should be displayed to the user
	When User type "Ring_Test" Name in the "Ring name" field on the 'Email Migration' Project details page
	And User clicks Create button on the Create Ring page
	When User click on 'Ring' column header
	Then data in table is sorted by "Ring" column in ascending order on the Admin page
	When User clicks Cog-menu on the Admin page
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Set default      |
	| Delete           |
	When User click on 'Ring' column header
	Then data in table is sorted by "Ring" column in descending order on the Admin page
	When User select "Ring" rows in the grid
	| SelectedRowsName |
	| Ring_Test        |
	| 14705_Ring       |
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button
	Then Warning message with "These rings will be permanently deleted and any objects within them reassigned to the default ring" text is displayed on the Admin page
	When User clicks Delete button in the warning message