﻿Feature: SelfServiceGrid
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19392 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserSeesProperNotificationWhenGridIsEmpty
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	Then Page with 'Self Services' header is displayed to user
	Then 'Self Services' left menu item is expanded
	Then User sees AgGrid
	Then 'No self services found' message is displayed on empty greed

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
    Then data in table is sorted by "Self Service Name" column in ascending order on the Admin page
	
@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19392 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckSelfServiceAgGridSelcetion
    When User creates Self Service via API
	| ServiceId | Name                   | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | TestSelection_name1 | id193851          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 2         | TestSelection_name2 | id193852          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 3         | TestSelection_name3 | id193853          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 4         | TestSelection_name4 | id193854          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	| 5         | TestSelection_name5 | id193855          | true    | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
	Then select all rows checkbox is unchecked
    When User selects all rows on the grid
    Then all checkboxes are checked in the grid
	When User deselect all rows on the grid
	Then select all rows checkbox is unchecked
	When User enters "ATestSelfService_name1" text in the Search field for "Self Service Name" column
	When User selects all rows on the grid
	Then Select All checkbox have indeterminate checked state

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19392 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSelfServiceCogMenuDisplaysProperly
    When User creates Self Service via API
	| ServiceId | Name                   | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | TestSelfServiceCogMenu_name1 | id193851          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Self Services' left menu item
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