Feature: ListDetailsFunctionalityPart8
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks
	When User clicks "<PageName>" on the left-hand menu
	And User performs right-click on "<TargetCell>" cell in the grid
	Then User sees context menu with next options
	| OptionsName        |
	| Copy cell          |
	| Copy row           |
	| Open in new tab    |
	| Open in new window | 
	When User selects 'Copy cell' option in context menu
	Then Next data '<TargetCell>' is copied
	When User clicks refresh button in the browser
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<Columnname>" rows in the grid
	| SelectedRowsName |
	| <SelectedRow>    |
	And User performs right-click on "<TargetCell>" cell in the grid
	Then User sees context menu with next options
	| OptionsName        |
	| Copy cell          |
	| Copy row           |
	| Copy selected rows |
	| Open in new tab    |
	| Open in new window | 
	When User selects 'Copy cell' option in context menu
	Then Next data '<TargetCell>' is copied

Examples: 
	| PageName     | Columnname    | TargetCell                                 | SelectedRow                             |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                             | 001BAQXT6JWFPI                          |
	| Users        | Username      | $6BE000-SUDQ9614UVO8                       | 000F977AC8824FE39B8                     |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais | 0036 - Microsoft Access 97 SR-2 English |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local           | 002B5DC7D4D34D5C895@bclabs.local        |


@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks
	When User clicks "<PageName>" on the left-hand menu
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<Columnname>" rows in the grid
	| SelectedRowsName |
	| <SelectedRow>    |
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy row' option in context menu
	Then Next data '<ExpectedData>' is copied

Examples: 
	| PageName     | Columnname    | TargetCell                                 | SelectedRow                             | ExpectedData                                                                                                              |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                             | 001BAQXT6JWFPI                          | \t00HA7MKAVVFDAV\tLaptop\tWindows 7\tKris C. Herman                                                                       |
	| Users        | Username      | $6BE000-SUDQ9614UVO8                       | 000F977AC8824FE39B8                     | \t$6BE000-SUDQ9614UVO8\tBCLABS\tExchange Online-ApplicationAccount\tExchange Online-ApplicationAccount.Users.bclabs.local |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais | 0036 - Microsoft Access 97 SR-2 English | \t0004 - Adobe Acrobat Reader 5.0.5 Francais\tAdobe\t5.0.5                                                                |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local           | 002B5DC7D4D34D5C895@bclabs.local        | \t000F977AC8824FE39B8@bclabs.local\tExchange 2007\tbc-exch07\tUserMailbox\tSpruill, Shea                                  |
	

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks
	When User clicks "<PageName>" on the left-hand menu
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<Columnname>" rows in the grid
	| SelectedRowsName |
	| <SelectedRow1>   |
	| <SelectedRow2>   |
	And User performs right-click on "<TargetCell>" cell in the grid
	And User selects 'Copy selected rows' option in context menu
	Then Next data '<ExpectedData>' is copied

Examples: 
	| PageName     | Columnname    | TargetCell                                 | SelectedRow1                            | SelectedRow2                     | ExpectedData                                                                                                                                                                                               |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                             | 001BAQXT6JWFPI                          | 001PSUMZYOW581                   | \t001BAQXT6JWFPI\tDesktop\tWindows 7\tNicole P. Braun \t001PSUMZYOW581\tLaptop\tWindows 7\tTricia G. Huang                                                                                                 |
	| Users        | Username      | $6BE000-SUDQ9614UVO8                       | 000F977AC8824FE39B8                     | 002B5DC7D4D34D5C895              | \t000F977AC8824FE39B8\tBCLABS\tSpruill, Shea\tSpruill\\, Shea.Employees.Birmingham.UK.bclabs.local \t002B5DC7D4D34D5C895\tDWLABS\tCollor, Christopher\tCollor\\, Christopher.Users.Birmingham.dwlabs.local |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais | 0036 - Microsoft Access 97 SR-2 English | 20040610sqlserverck              | \t0036 - Microsoft Access 97 SR-2 English\tMicrosoft\t8.0 \t20040610sqlserverck\tMicrosoft\t1.0.0                                                                                                          |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local           | 002B5DC7D4D34D5C895@bclabs.local        | 0072B088173449E3A93@bclabs.local | \t002B5DC7D4D34D5C895@bclabs.local\tExchange 2013\tbc-exch13\tUserMailbox\tCollor, Christopher \t0072B088173449E3A93@bclabs.local\tExchange 2007\tbc-exch07\tUserMailbox\tRegister, Donna                  |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS16332 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatListNameUpdatesImmediatelyWhileTypingInDetailsPane
	When User clicks "Devices" on the left-hand menu
	And User clicks the Filters button
	And User add "1803: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	And User create dynamic list with "TestListName" name on "Devices" page
	Then "TestListName" list is displayed to user
	When User opens manage pane for list with "TestListName" name
	And User adds "post" to list name
	Then "TestListNamepost" list is displayed to user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS17632
Scenario: EvergreenJnr_DevicesLists_CheckThatArchivedEmptyNameCantBeClicked
	When User clicks "Devices" on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Device Key |
	And User sets includes archived devices in "true"
	And User clicks content from first row of Hostname column
	Then "All Devices" list should be displayed to the user
	When User clicks content from first row of Device Key column
	Then "All Devices" list should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS17651 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatArchivedItemStillRemainsInStaticList
	When User clicks "Devices" on the left-hand menu
	And User sets includes archived devices in "true"
	And User clicks the Actions button
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| Empty            |
	And User perform search by "00I0COBFWHOF27"
	And User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	And User selects "Create static list" in the Actions dropdown
	And User create static list with "StaticList17651" name
	Then "StaticList17651" list is displayed to user
	And "2" rows are displayed in the agGrid
	When User navigates to the "1803 Rollout" list
	Then "1803 Rollout" list is displayed to user
	When User navigates to the "StaticList17651" list
	Then "StaticList17651" list is displayed to user
	And "2" rows are displayed in the agGrid

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS17552
Scenario Outline: EvergreenJnr_DashboardsPage_CheckThatCustomFieldFiltersAndColumnsAreMultiValue
	When User clicks "<ListName>" on the left-hand menu
	And User clicks the Filters button
	And User add "<CustomColumn>" filter where type is "<Operator>" with added column and following value:
	| Values        |
	| <CustomValue> |
	Then '<ColumnData>' content is displayed in the '<CustomColumn>' column

Examples: 
	| ListName     | CustomValue | Operator | ColumnData                                | CustomColumn        |
	| Devices      | aaa         | Equals   | 0.665371384, 1kk, 2kk, 3kk, aaa, bbb, ccc | ComputerCustomField |
	| Mailboxes    | aaa         | Equals   | 1kk, 2kk, 3kk, aaa, bbb, ccc              | Mailbox Filter 1    |
	| Applications | aaa         | Equals   | 1kk, 2 kk, 3kk, abdc, aaa, bbb            | App field 1         |