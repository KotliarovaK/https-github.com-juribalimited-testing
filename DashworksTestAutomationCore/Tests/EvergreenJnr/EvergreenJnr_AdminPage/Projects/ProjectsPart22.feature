Feature: ProjectsPart22
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @DAS12768 @Cleanup @Project_Creation_and_Scope
Scenario Outline: EvergreenJnr_AdminPage_CheckThatMatchToEvergreenBucketDisplayedInTheBucketDropdown
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters '12768Project' text to 'Project Name' textbox
	And User selects '<ScopeList>' option from 'Scope' autocomplete
	When User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	And User navigates to the 'Scope Changes' left menu item
	Then 'Match to Evergreen Bucket' content is displayed in 'Bucket' dropdown

Examples:
	| ScopeList     |
	| All Devices   |
	| All Users     |
	| All Mailboxes |

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @UpdatingName @Senior_Projects @DAS13499 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatTasksRequestTypesAndCategoriesAreNotDeletedAfterChangingProjectName
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User clicks create Project button
	Then "Create Project" page is displayed to the user
	When User creates new Project on Senior
	| ProjectName     | ShortName | Description | Type |
	| DAS13499Project | 13499     |             |      |
	And User navigate to "Stages" tab
	Then "Manage Stages" page is displayed to the user
	When User clicks "Create Stage" button
	And User create Stage
	| StageName  |
	| Stage13499 |
	And User clicks "Create Stage" button
	And User navigate to "Tasks" tab
	Then "Manage Tasks" page is displayed to the user
	When User clicks "Create Task" button
	And User creates Task
	| Name      | Help  | StagesNameString | TaskTypeString | ValueTypeString | ObjectTypeString | TaskValuesTemplateString |
	| 13499Task | 13499 | Stage13499       | Normal         | Date            | Computer         |                          |
	Then Success message is displayed with "Task successfully created" text
	When User navigate to "Categories" tab
	Then "Manage Categories" page is displayed to the user
	When User clicks "Create Category" button
	And User create Category
	| Name           | Description              | ObjectTypeString |
	| 13499Categorie | ComputerScheduledProject | Computer         |
	Then Success message is displayed with "Category successfully created." text
	When User navigate to "Request Types" tab
	Then "Manage Request Types" page is displayed to the user
	When User clicks "Create Request Type" button
	And User create Request Type
	| Name             | Description     | ObjectTypeString |
	| 13499RequestType | DAS13499Project | Computer         |
	And User navigate to Evergreen link
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User enters "DAS13499Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User enters 'New_DAS13499_Project_Name' text to 'Project Name' textbox
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	#Update bottom step to "New_DAS13499_Project_Name" after Project renamed faster
	When User navigate to "New_DAS13499_Project_Name" Project
	Then Project with "New_DAS13499_Project_Name" name is displayed correctly
	When User navigate to "Request Types" tab
	Then "13499RequestType" displayed in the table on Senior
	When User navigate to "Categories" tab
	Then "13499Categorie" displayed in the table on Senior
	When User navigate to "Tasks" tab
	Then "13499Task" displayed in the table on Senior
	When User navigate to "Stages" tab
	Then "Stage13499" displayed in the table on Senior

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @Senior_Projects @DAS15262 @DAS13973 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultValuesStayTheSameAfterConvertingProjectToEvergreen
	When User clicks 'Projects' on the left-hand menu
	When User clicks create Project button
	When User creates new Project on Senior
	| ProjectName     | ShortName | Description | Type |
	| DAS15262Project | 15262     |             |      |
	And User clicks the Switch to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	And User enters "DAS15262Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then 'Use project buckets' content is displayed in 'Buckets' dropdown
	And 'Use project rings' content is displayed in 'Rings' dropdown
	When User navigates to the 'Capacity' left menu item
	Then 'Use project capacity units' content is displayed in 'Capacity Units' dropdown
	When User navigates to the 'Details' left menu item
	And User converts project to evergreen project
	Then 'Use project buckets' content is displayed in 'Buckets' dropdown
	And 'Use project rings' content is displayed in 'Rings' dropdown
	When User navigates to the 'Capacity' left menu item
	Then 'Use project capacity units' content is displayed in 'Capacity Units' dropdown
	When User clicks 'Admin' on the left-hand menu
	And User enters "DAS15262Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @Senior_Projects @DAS15262 @DAS16361 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatConvertToEvergreenButtonIsNotDisplayedForEvergreensProject
	When User clicks 'Admin' on the left-hand menu
	When User clicks 'CREATE PROJECT' button 
	When User selects 'Dependant List Filter - BROKEN LIST' option from 'Scope' autocomplete
	Then 'This list has errors' error message is displayed for 'Scope' field
	When User clicks 'CANCEL' button 
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'TestNegativeProject15262' text to 'Project Name' textbox
	When User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	And User navigates to the 'Details' left menu item
	Then Convert to Evergreen button is not displayed