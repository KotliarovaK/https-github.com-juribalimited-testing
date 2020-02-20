Feature: Rings
	Runs Rings related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS14780 @DAS13530 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatRingsOptionMapsToEvergreenCanBeChanged
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode                            |
	| ProjectForDAS14780 | All Devices | None            | Clone from Evergreen to Project |
	Then Page with 'ProjectForDAS14780' header is displayed to user
	When User navigates to the 'Details' left menu item
	Then 'Clone Evergreen rings to project rings' content is displayed in 'Rings' dropdown
	When User navigates to the 'Rings' left menu item
	And User enters "Unassigned" text in the Search field for "Ring" column
	And User clicks content from "Ring" column
	Then Ring settings Maps to evergreen ring is displayed as "Unassigned"
	When User sets "None" value in Maps to evergreen ring field
	Then Ring settings Maps to evergreen ring is displayed as "None"
	When User clicks 'Administration' header breadcrumb
	When User clicks 'YES' button on popup
	And User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Buckets' left menu item
	And User clicks Reset Filters button on the Admin page
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "Select All" checkbox from String Filter with item list on the Admin page
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "ProjectForDAS14780" checkbox from String Filter with item list on the Admin page
	Then Content in the 'Bucket' column is equal to
	| Content    |
	| Unassigned |

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS12452 @DAS14690 @DAS14691 @DAS15370 @DAS14692 @DAS14695 @DAS15415 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckProjectDetailFormAndRingDropdown
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 14690_Project | All Devices | None            | Standalone Project |
	When User navigates to the 'Rings' left menu item
	When User clicks content from "Ring" column
	Then "Unassigned" content is displayed in "Ring name" field
	Then "Unassigned" content is displayed in "Description" field
	Then 'UPDATE' button is disabled
	When User enters 'NewDescription' text to 'Description' textbox
	Then 'UPDATE' button is not disabled
	Then "Default Ring" checkbox is checked and cannot be unchecked
	Then 'Maps to Evergreen Ring' dropdown is not displayed
	When User clicks 'CANCEL' button 
	Then 'TRUE' content is displayed in the 'Default' column
	When User opens 'Ring' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Maps to Evergreen" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then Content is empty in the column
	| ColumnName        |
	| Maps to Evergreen |
	When User navigates to the 'Details' left menu item
	And User changes Project Name to "New_14690_Project"
	Then "14690_Pro" content is displayed in "Project Short Name" field
	When User changes Project Short Name to "New_Short"
	Then "14690_Project" content is displayed in "Project Description" field
	When User changes Project Description to "New_14690_Description"
	When User selects "Clone Evergreen buckets to project buckets" in the Buckets Project dropdown
	Then "Device scoped project" is displayed in the disabled Project Type field
	When User selects "Clone Evergreen buckets to project buckets" in the Buckets Project dropdown
	Then 'Use project rings' content is displayed in 'Rings' dropdown
	When User selects 'Clone Evergreen rings to project rings' in the 'Rings' dropdown
	When User clicks 'Projects' header breadcrumb
	When User enters "New_14690_Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Page with 'New_14690_Project' header is displayed to user
	When User navigates to the 'Details' left menu item
	Then 'Clone Evergreen buckets to project buckets' content is displayed in 'Buckets' dropdown
	Then 'Clone Evergreen rings to project rings' content is displayed in 'Rings' dropdown
	Then "New_Short" content is displayed in "Project Short Name" field

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS15906
Scenario: EvergreenJnr_AdminPage_CheckThatCogIconIsNotDisplayedOnLevelOfGroupedRows
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	And User navigates to the 'Rings' left menu item
	Then Page with 'Rings' header is displayed to user
	When User clicks Group By button and set checkboxes state
	| Checkboxes | State |
	| Ring       | true  |
	Then Cog menu is not displayed on the Admin page