Feature: SelfService
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19392 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatb
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	Then Page with 'Create Self Service' header is displayed to user
	Then 'Self Services' left menu item is expanded
	Then User sees Ag-Grid
	Then 'No self services found' message is displayed on empty greed

		@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19392 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatGredWorksProperly
    When User creates Self Service via API
	| ServiceId | Name                       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | ATestSelfService_name1 | id193851          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 2         | BTestSelfService_name2 | id193852          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 3         | CTestSelfService_name3 | id193853          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 4         | DTestSelfService_name4 | id193854          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 5         | FTestSelfService_name5 | id193855          | true    | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	Then grid headers are displayed in the following order
	| ColumnName          |
	| Self Service Name   |
	|                     |
	| Enabled             |
	| Scope               |
	| Primary Object Type |
	| Self Service URL    |
	| Created By          |
	| Created Date        |
	When User clicks on 'Self Service Name' column header
    Then data in table is sorted by "Self Service Name" column in ascending order on the Admin page
	Then select all rows checkbox is unchecked
    When User selects all rows on the grid
    Then all checkboxes are checked in the grid
	When User deselect all rows on the grid
	Then select all rows checkbox is unchecked
	When User clicks Cog-menu for 'TestSelfService_name1' item in the 'Self Service Name' column
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Enable           | 
	| Delete           |
	When User clicks Cog-menu for 'TestSelfService_name5' item in the 'Self Service Name' column
	Then User sees following cog-menu items on Admin page:
	| items            |
	| Edit             |
	| Disable          | 
	| Delete           |
#	Then following Values are displayed in the 'Actions' dropdown:
#	| Values |
#	| Enable |
#	| Delete |
