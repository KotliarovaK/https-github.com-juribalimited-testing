﻿Feature: NewFilterCheck
	Runs New filters check related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10828
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTargetAppFilterIsAddedToTheList
	When User add following columns using URL to the "Applications" page:
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" Lookup filter with column and "<FilterOption>" option
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order 

Examples:
	| ColumnName             | Operators                         | FilterOption      | Text                                        | RowsCount |
	| Windows7Mi: Target App | Equals, Does not equal, Not empty | WebZIP (A01)      | Windows7Mi: Target App is WebZIP (A01)      | 3         |
	| Babel(Engl: Target App | Equals, Does not equal, Not empty | sndconfig         | Babel(Engl: Target App is sndconfig         | 1         |
	| Barry'sUse: Target App | Equals, Does not equal, Not empty | World Watch (A01) | Barry'sUse: Target App is World Watch (A01) | 1         |
	| ComputerSc: Target App | Equals, Does not equal, Not empty | World Watch (A01) | ComputerSc: Target App is World Watch (A01) | 1         |
	| Havoc(BigD: Target App | Equals, Does not equal, Not empty | WebZIP (A01)      | Havoc(BigD: Target App is WebZIP (A01)      | 1         |
	| MigrationP: Target App | Equals, Does not equal, Not empty | Zune (A01)        | MigrationP: Target App is Zune (A01)        | 1         |
	| UserSchedu: Target App | Equals, Does not equal, Not empty | Zune (A01)        | UserSchedu: Target App is Zune (A01)        | 1         |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10828 @DAS14287
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTargetAppKeyFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have create "Equals" Values filter with column and following options:
	| Values         |
	| <FilterOption> |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order 

Examples:
	| ColumnName                 | Operators                                                                                        | FilterOption | Text                               | RowsCount |
	| Windows7Mi: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1051         | Windows7Mi: Target App Key is 1051 | 4         |
	| Babel(Engl: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 15           | Babel(Engl: Target App Key is 15   | 1         |
	| Barry'sUse: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 115          | Barry'sUse: Target App Key is 115  | 1         |
	| ComputerSc: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1060         | ComputerSc: Target App Key is 1060 | 1         |
	| Havoc(BigD: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1050         | Havoc(BigD: Target App Key is 1050 | 1         |
	| MigrationP: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 960          | MigrationP: Target App Key is 960  | 1         |
	| UserSchedu: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1            | UserSchedu: Target App Key is 1    | 1         |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10828 @DAS13001
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTargetAppReadinessFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" Lookup filter with column and "<FilterOption>" option
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples:
	| ColumnName                       | Operators                         | FilterOption | Text                                      | RowsCount |
	| Windows7Mi: Target App Readiness | Equals, Does not equal, Not empty | Red          | Windows7Mi: Target App Readiness is Red   | 28        |
	| Babel(Engl: Target App Readiness | Equals, Does not equal, Not empty | Empty        | Babel(Engl: Target App Readiness is Empty | 1,921     |
	| Barry'sUse: Target App Readiness | Equals, Does not equal, Not empty | Empty        | Barry'sUse: Target App Readiness is Empty | 1,145     |
	| ComputerSc: Target App Readiness | Equals, Does not equal, Not empty | Green        | ComputerSc: Target App Readiness is Green | 913       |
	| Havoc(BigD: Target App Readiness | Equals, Does not equal, Not empty | Empty        | Havoc(BigD: Target App Readiness is Empty | 1,155     |
	| MigrationP: Target App Readiness | Equals, Does not equal, Not empty | Blue         | MigrationP: Target App Readiness is Blue  | 189       |
	| UserSchedu: Target App Readiness | Equals, Does not equal, Not empty | Grey         | UserSchedu: Target App Readiness is Grey  | 981       |

	@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS12388
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatAddColumnCheckboxIsDisplayedForTargetAppKeyFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes        |
	| Add Target App Key column |

Examples:
	| FilterName                 |
	| Windows7Mi: Target App Key |
	| Babel(Engl: Target App Key |
	| Barry'sUse: Target App Key |
	| ComputerSc: Target App Key |
	| Havoc(BigD: Target App Key |
	| MigrationP: Target App Key |
	| UserSchedu: Target App Key |
	| prK: Target App Key        |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS12388
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatAddColumnCheckboxIsDisplayedForTargetAppIDFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes        |
	| Add Target App ID column |

Examples:
	| FilterName                |
	| Windows7Mi: Target App ID |
	| Babel(Engl: Target App ID |
	| Barry'sUse: Target App ID |
	| ComputerSc: Target App ID |
	| EmailMigra: Target App ID |
	| Havoc(BigD: Target App ID |
	| MigrationP: Target App ID |
	| UserSchedu: Target App ID |
	| prK: Target App ID        |

@Evergreen @AllLists @Evergreen_FiltersFeature @NewFilterCheck @DAS10578 @DAS14159
Scenario Outline: EvergreenJnr_AllLists_CheckThatDashworksFirstSeenFilterIsAddedToTheFilterList
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName           |
	| Dashworks First Seen |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Dashworks First Seen" filter
	Then "Equals, Equals (relative), Does not equal, Between, Does not equal (relative), Before, Before (relative), On or before, On or before (relative), After, After (relative), On or after, On or after (relative), Empty, Not empty" option is available for this filter
	When User have created "Empty" Date filter with column and "" option
	Then "Dashworks First Seen is empty" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on 'Dashworks First Seen' column header
	Then data in table is sorted by 'Dashworks First Seen' column in descending order 

Examples:
	| ListName     | RowsCount |
	| Devices      | 17,219    |
	| Users        | 41,335    |
	| Applications | 2,223     |
	| Mailboxes    | 14,784    |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10512 @DAS13001
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatApplicationReadinessFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" Lookup filter with column and "<FilterOption>" option
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples:
	| ColumnName                        | Operators                         | FilterOption | Text                                       | RowsCount |
	| Windows7Mi: Application Readiness | Equals, Does not equal, Not empty | Red          | Windows7Mi: Application Readiness is Red   | 27        |
	| Babel(Engl: Application Readiness | Equals, Does not equal, Not empty | Empty        | Babel(Engl: Application Readiness is Empty | 1,921     |
	| Barry'sUse: Application Readiness | Equals, Does not equal, Not empty | Empty        | Barry'sUse: Application Readiness is Empty | 1,145     |
	| ComputerSc: Application Readiness | Equals, Does not equal, Not empty | Green        | ComputerSc: Application Readiness is Green | 911       |
	| Havoc(BigD: Application Readiness | Equals, Does not equal, Not empty | Empty        | Havoc(BigD: Application Readiness is Empty | 1,155     |
	| MigrationP: Application Readiness | Equals, Does not equal, Not empty | Blue         | MigrationP: Application Readiness is Blue  | 189       |
	| UserSchedu: Application Readiness | Equals, Does not equal, Not empty | Empty        | UserSchedu: Application Readiness is Empty | 1,242     |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10512 @DAS11509 @DAS11507 @DAS11509 @DAS12026
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatApplicationRationalisationFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" filter with column and following options:
	| SelectedCheckboxes |
	| <FilterOption>     |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order 

Examples: 
	| ColumnName                              | Operators                         | FilterOption  | Text                                                     | RowsCount |
	| Windows7Mi: Application Rationalisation | Equals, Does not equal, Not empty | RETIRE        | Windows7Mi: Application Rationalisation is Retire        | 85        |
	#| Babel(Engl: Application Rationalisation | Equals, Does not equal | UNCATEGORISED | Babel(Engl: Application Rationalisation is Uncategorised | 302       |
	| Barry'sUse: Application Rationalisation | Equals, Does not equal, Not empty | KEEP          | Barry'sUse: Application Rationalisation is Keep          | 2         |
	| ComputerSc: Application Rationalisation | Equals, Does not equal, Not empty | FORWARD PATH  | ComputerSc: Application Rationalisation is Forward Path  | 15        |
	| Havoc(BigD: Application Rationalisation | Equals, Does not equal, Not empty | UNCATEGORISED | Havoc(BigD: Application Rationalisation is Uncategorised | 1,068     |
	| MigrationP: Application Rationalisation | Equals, Does not equal, Not empty | RETIRE        | MigrationP: Application Rationalisation is Retire        | 1         |
	| UserSchedu: Application Rationalisation | Equals, Does not equal, Not empty | UNCATEGORISED | UserSchedu: Application Rationalisation is Uncategorised | 981       |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10512 @DAS11507
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatCoreApplicationFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" filter with column and following options:
	| SelectedCheckboxes |
	| <FilterOption>     |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName                   | Operators                         | FilterOption | Text                                  | RowsCount |
	| Windows7Mi: Core Application | Equals, Does not equal, Not empty | TRUE         | Windows7Mi: Core Application is True  | 11        |
	| Babel(Engl: Core Application | Equals, Does not equal, Not empty | FALSE        | Babel(Engl: Core Application is False | 302       |
	| Barry'sUse: Core Application | Equals, Does not equal, Not empty | Empty        | Barry'sUse: Core Application is Empty | 1,145     |
	| ComputerSc: Core Application | Equals, Does not equal, Not empty | FALSE        | ComputerSc: Core Application is False | 1,043     |
	| Havoc(BigD: Core Application | Equals, Does not equal, Not empty | Empty        | Havoc(BigD: Core Application is Empty | 1,155     |
	| MigrationP: Core Application | Equals, Does not equal, Not empty | FALSE        | MigrationP: Core Application is False | 220       |
	| UserSchedu: Core Application | Equals, Does not equal, Not empty | Empty        | UserSchedu: Core Application is Empty | 1,242     |

@Evergreen @Applications @Evergreen_FiltersFeature @NewFilterCheck @DAS10512 @DAS11509 @DAS11507 @DAS11509
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" filter with column and following options:
	| SelectedCheckboxes |
	| <FilterOption>     |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName                      | Operators                         | FilterOption | Text                                     | RowsCount |
	| Windows7Mi: Hide from End Users | Equals, Does not equal, Not empty | FALSE        | Windows7Mi: Hide from End Users is False | 1,067     |
	| Babel(Engl: Hide from End Users | Equals, Does not equal, Not empty | Empty        | Babel(Engl: Hide from End Users is Empty | 1,921     |
	| Barry'sUse: Hide from End Users | Equals, Does not equal, Not empty | FALSE        | Barry'sUse: Hide from End Users is False | 1,078     |
	| ComputerSc: Hide from End Users | Equals, Does not equal, Not empty | FALSE        | ComputerSc: Hide from End Users is False | 1,043     |
	| Havoc(BigD: Hide from End Users | Equals, Does not equal, Not empty | Empty        | Havoc(BigD: Hide from End Users is Empty | 1,155     |
	| MigrationP: Hide from End Users | Equals, Does not equal, Not empty | FALSE        | MigrationP: Hide from End Users is False | 220       |
	| UserSchedu: Hide from End Users | Equals, Does not equal, Not empty | Empty        | UserSchedu: Hide from End Users is Empty | 1,242     |

@Evergreen @Devices @Evergreen_FiltersFeature @NewFilterCheck @DAS12232 @DAS12351 @DAS12639 @DAS14288
Scenario: EvergreenJnr_DevicesList_CheckThatMultiSelectProjectTaskFiltersAreDisplayedCorrectlyOnDevicesPage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Migration \ Values but no RAG" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| One                |
	| Three              |
	And User Add And "UserSchedu: One \ Radio Rag Date Comp" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Not Applicable     |
	| Started            |
	| Failed             |
	| Complete           |
	Then "233" rows are displayed in the agGrid
	When User create dynamic list with "Devices_ProjectTaskFilters_AND" name on "Devices" page
	Then "Devices_ProjectTaskFilters_AND" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "Devices_ProjectTaskFilters_AND" list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Migration \ Values but no RAG is One or Three" is displayed in added filter info
	And "UserSchedu: One \ Radio Rag Date Comp is Not Applicable, Started, Failed or Complete" is displayed in added filter info
	When User click Edit button for "Windows7Mi: Migration \ Values but no RAG" filter
	And User change selected checkboxes:
	| Option | State |
	| One    | false |
	| Two    | false |
	| Three  | true  |
	And User click Edit button for "UserSchedu: One \ Radio Rag Date Comp" filter
	And User select "Does not equal" Operator value
	And User change selected checkboxes:
	| Option         | State |
	| Not Applicable | true  |
	| Not Started    | false |
	| Started        | false |
	| Failed         | false |
	| Complete       | false |
	Then "1" rows are displayed in the agGrid
	When User update current custom list

@Evergreen @Users @Evergreen_FiltersFeature @NewFilterCheck @DAS12232 @DAS12351 @DAS14288
Scenario: EvergreenJnr_UsersList_CheckThatMultiSelectProjectTaskFiltersAreDisplayedCorrectlyOnUsersPage
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Stage for User Tasks \ Read Only on Bulk Update Page" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Not Applicable     |
	| Started            |
	| Failed             |
	| Complete           |
	And User Add And "Windows7Mi: User Acceptance Test \ T-60 SMS Message Sent" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Not Applicable     |
	Then "4,641" rows are displayed in the agGrid
	When User create dynamic list with "Users_ProjectTaskFilters_AND" name on "Users" page
	Then "Users_ProjectTaskFilters_AND" list is displayed to user
	When User navigates to the "All Users" list
	Then 'All Users' list should be displayed to the user
	When User navigates to the "Users_ProjectTaskFilters_AND" list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Stage for User Tasks \ Read Only on Bulk Update Page is Not Applicable, Started, Failed or Complete" is displayed in added filter info
	And "Windows7Mi: User Acceptance Test \ T-60 SMS Message Sent is Not Applicable" is displayed in added filter info
	When User click Edit button for "Windows7Mi: Stage for User Tasks \ Read Only on Bulk Update Page" filter
	And User select "Does not equal" Operator value
	And User change selected checkboxes:
	| Option         | State |
	| Not Applicable | false |
	| Not Started    | true  |
	| Started        | true  |
	| Failed         | true  |
	| Complete       | true  |
	And User click Edit button for "Windows7Mi: User Acceptance Test \ T-60 SMS Message Sent" filter
	And User change selected checkboxes:
	| Option         | State |
	| Not Applicable | true  |
	| Not Sent       | false |
	| Sent           | true  |
	Then "4,642" rows are displayed in the agGrid
	When User update current custom list

@Evergreen @AllLists @Evergreen_FiltersFeature @NewFilterCheck @DAS11830 @DAS14288
Scenario Outline: EvergreenJnr_AllLists_CheckThatOptionsIsAvailableForFiltersOfProjectTaskCategories
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then "Empty, Off, On" checkbox is available for this filter

Examples:
	| PageName     | FilterName                           |
	| Users        | ComputerSc: One \ User Off/On        |
	| Devices      | ComputerSc: One \ Computer Off/On    |
	| Applications | ComputerSc: One \ Application Off/On |

@Evergreen @Devices @Evergreen_FiltersFeature @NewFilterCheck @DAS16726 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNewCurrentAndLastSeenFiltersAreAvailableForSelection
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Columns button
	And ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Current             |
	| Dashworks Last Seen |
	And User clicks the Filters button
	And User add "Current" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	And User add "Dashworks Last Seen" filter where type is "Equals" with added column and "25 Jul 2019" Date filter
	And User create custom list with "TestNewColumnsAndFilters" name
	Then "TestNewColumnsAndFilters" list is displayed to user