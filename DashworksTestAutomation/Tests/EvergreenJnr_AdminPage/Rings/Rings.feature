Feature: Rings
	Runs Rings related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS14780 @DAS13530 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatRingsOptionMapsToEvergreenCanBeChanged
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode                            |
	| ProjectForDAS14780 | All Devices | None            | Clone from Evergreen to Project |
	Then Project "ProjectForDAS14780" is displayed to user
	When User clicks "Details" tab
	Then "Clone evergreen rings to project rings" text value is displayed in the "Rings" dropdown
	When User clicks "Rings" tab
	And User enters "Unassigned" text in the Search field for "Ring" column
	And User clicks content from "Ring" column
	Then Ring settings Maps to evergreen ring is displayed as "Unassigned"
	When User sets "None" value in Maps to evergreen ring field
	Then Ring settings Maps to evergreen ring is displayed as "None"
	When User clicks "Administration" navigation link on the Admin page
	And User clicks Yes button in Leave Page Warning
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Buckets" tab
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Select All" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "ProjectForDAS14780" checkbox from String Filter with item list on the Admin page
	Then "Unassigned" text is displayed in the table content

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS12452 @DAS14690 @DAS14691 @DAS15370 @DAS14692 @DAS14695 @DAS15415 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckProjectDetailFormAndRingDropdown
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 14690_Project | All Devices | None            | Standalone Project |
	When User clicks "Rings" tab
	When User clicks content from "Ring" column
	Then "Unassigned" content is displayed in "Ring name" field
	Then "Unassigned" content is displayed in "Description" field
	Then "UPDATE" Action button is disabled
	When User changes Name to "NewDescription" in the "Description" field on the Project details page
	Then "UPDATE" Action button is active
	Then "Default Ring" checkbox is checked and cannot be unchecked
	Then "Maps to Evergreen Ring" dropdown is not displayed on the Admin Settings screen
	When User clicks the "CANCEL" Action button
	Then "TRUE" content is displayed in "Default" column
	When User have opened Column Settings for "Ring" column in the Details Page table
	And User clicks Column button on the Column Settings panel
	And User select "Maps to Evergreen" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then Content is empty in the column
	| ColumnName        |
	| Maps to Evergreen |
	When User clicks "Details" tab
	And User changes Project Name to "New_14690_Project"
	Then "14690_Pro" content is displayed in "Project Short Name" field
	When User changes Project Short Name to "New_Short"
	Then "14690_Project" content is displayed in "Project Description" field
	When User changes Project Description to "New_14690_Description"
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	Then "Device scoped project" is displayed in the disabled Project Type field
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	Then "Use project rings" text value is displayed in the "Rings" dropdown
	When User selects "Clone evergreen rings to project rings" in the "Rings" dropdown
	When User clicks "Projects" navigation link on the Admin page
	When User enters "New_14690_Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "New_14690_Project" is displayed to user
	When User clicks "Details" tab
	Then "Clone evergreen buckets to project buckets" text value is displayed in the "Buckets" dropdown
	Then "Clone evergreen rings to project rings" text value is displayed in the "Rings" dropdown
	Then "New_Short" content is displayed in "Project Short Name" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS15906
Scenario: EvergreenJnr_AdminPage_CheckThatCogIconIsNotDisplayedOnLevelOfGroupedRows
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Rings" tab
	Then "Rings" page should be displayed to the user
	When User clicks Group By button on the Admin page and selects "Ring" value
	Then Cog menu is not displayed on the Admin page