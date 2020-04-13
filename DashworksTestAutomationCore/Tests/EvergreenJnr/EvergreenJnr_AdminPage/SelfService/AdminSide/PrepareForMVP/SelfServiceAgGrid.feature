Feature: SelfServiceGrid
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19392 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckGeneralViewOfSelfServiceAgGrid
    When User creates Self Service via API
	| ServiceId | Name                   | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
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
    Then data in table is sorted by 'Self Service Name' column in ascending order
	
@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19392 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckSelfServiceAgGridSelection
    When User creates Self Service via API
	| ServiceId | Name                   | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | A_TestSelection_name1  | id193851          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 2         | B_TestSelection_name2  | id193852          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 3         | C_TestSelection_name3  | id193853          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 4         | D_TestSelection_name4  | id193854          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 5         | F_TestSelection_name5  | id193855          | true    | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	Then select all rows checkbox is unchecked
    When User selects all rows on the grid
    Then all checkboxes are checked in the grid
	When User deselect all rows on the grid
	Then select all rows checkbox is unchecked
	When User enters "A_TestSelection_name1" text in the Search field for "Self Service Name" column
	When User selects all rows on the grid
	Then Select All checkbox have indeterminate checked state

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19392 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSelfServiceCogMenuDisplaysProperly
    When User creates Self Service via API
	| ServiceId | Name                         | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | TestSelfServiceCogMenu_name1 | id193851          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 5         | TestSelfServiceCogMenu_name5 | id193855          | true    | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	When User clicks Cog-menu for 'TestSelfServiceCogMenu_name1' item in the 'Self Service Name' column and sees following cog-menu options
	| options          |
	| Edit             |
	| Enable           | 
	| Delete           |
	When User clicks Cog-menu for 'TestSelfServiceCogMenu_name5' item in the 'Self Service Name' column and sees following cog-menu options
	| options          |
	| Edit             |
	| Disable          | 
	| Delete           |