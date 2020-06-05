Feature: GridScreenForListScopedProject
	Check grid screen for Devices/Mailboxes Scoped Project

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS12452 @DAS14695 @DAS14697 @DAS15180 @DAS15826 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckGridScreenForDeviceScopedProject
	When Project created via API and opened
	| ProjectName   | Scope       | ProjectTemplate | Mode               |
	| 14695_Project | All Devices | None            | Standalone Project |
	When User navigates to the 'Rings' left menu item
	Then '' content is displayed in the 'Devices' column
	Then grid headers are displayed in the following order
	| ColumnName |
	| Ring       |
	|            |
	| Default    |
	| Devices    |
	When User clicks 'CREATE PROJECT RING' button 
	Then Page with 'Create Project Ring' subheader is displayed to user
	When User enters '14695_Ring' text to 'Ring name' textbox
	When User clicks 'CREATE' button
	Then 'The ring has been created' text is displayed on inline success banner
	When User clicks Cog-menu for 'Unassigned' item in the 'Ring' column and sees following cog-menu options
	| options          |
	| Edit             |
	| Duplicate        |
	| Move to bottom   |
	| Move to position |
	When User clicks 'CREATE PROJECT RING' button 
	Then Page with 'Create Project Ring' subheader is displayed to user
	When User enters 'Ring_Test' text to 'Ring name' textbox
	When User clicks Default Ring checkbox
	When User clicks 'CREATE' button
	When User opens 'Ring' column settings
	When User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Display Order" checkbox on the Column Settings panel
	When User clicks Column button on the Column Settings panel
	Then User sees following Display order on the Automation page
	| Values |
	| 1      |
	| 2      |
	| 3      |
	Then Content in the 'Ring' column is equal to
	| Content    |
	| Unassigned |
	| 14695_Ring |
	| Ring_Test  |
	When User clicks on 'Ring' column header
	Then data in table is sorted by 'Ring' column in ascending order
	When User clicks on 'Ring' column header
	Then data in table is sorted by 'Ring' column in descending order
	When User clicks Cog-menu for 'Unassigned' item in the 'Ring' column and sees following cog-menu options
	| options          |
	| Edit             |
	| Duplicate        |
	| Move to bottom   |
	| Move to position |
	| Set default      |
	| Delete           |
	When User select "Ring" rows in the grid
	| SelectedRowsName |
	| Unassigned       |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	Then 'This ring will be permanently deleted and any objects within it reassigned to the default ring' text is displayed on inline tip banner
	When User clicks 'DELETE' button on inline tip banner

@Evergreen @Admin @EvergreenJnr_AdminPage @Rings @DAS12452 @DAS14705 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckGridScreenForMailboxScopedProject
	When User navigates to "Email Migration" project details
	Then Page with 'Email Migration' header is displayed to user
	When User navigates to the 'Rings' left menu item
	Then '730' content is displayed in the 'Mailboxes' column
	Then grid headers are displayed in the following order
	| ColumnName |
	| Ring       |
	|            |
	| Default    |
	| Mailboxes  |
	When User clicks Cog-menu for 'Unassigned' item in the 'Ring' column and sees following cog-menu options
	| options          |
	| Edit             |
	| Duplicate        |
	When User clicks 'CREATE PROJECT RING' button 
	Then Page with 'Create Project Ring' subheader is displayed to user
	When User enters '14705_Ring' text to 'Ring name' textbox
	When User clicks 'CREATE' button
	Then 'The ring has been created' text is displayed on inline success banner
	When User clicks 'CREATE PROJECT RING' button 
	Then Page with 'Create Project Ring' subheader is displayed to user
	When User enters 'Ring_Test' text to 'Ring name' textbox
	When User clicks 'CREATE' button
	When User clicks on 'Ring' column header
	Then data in table is sorted by 'Ring' column in ascending order
	When User clicks Cog-menu for '14705_Ring' item in the 'Ring' column and sees following cog-menu options
	| options          |
	| Edit             |
	| Duplicate        |
	| Move to top      |
	| Move to bottom   |
	| Move to position |
	| Set default      |
	| Delete           |
	When User clicks on 'Ring' column header
	Then data in table is sorted by 'Ring' column in descending order
	When User select "Ring" rows in the grid
	| SelectedRowsName |
	| Ring_Test        |
	| 14705_Ring       |
	And User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button
	Then 'These rings will be permanently deleted and any objects within them reassigned to the default ring' text is displayed on inline tip banner
	When User clicks 'DELETE' button on inline tip banner
