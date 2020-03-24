Feature: ListDetailsFunctionalityPart8
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatRightClickMenuCopyCellOptionWorks
	When User clicks '<PageName>' on the left-hand menu
	When User right clicks on '<TargetCell>' cell from '<ColumnName>' column
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
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <SelectedRow>    |
	When User right clicks on '<TargetCell>' cell from '<ColumnName>' column
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
	| PageName     | ColumnName    | TargetCell                                 | SelectedRow                             |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                             | 001BAQXT6JWFPI                          |
	| Users        | Username      | $6BE000-SUDQ9614UVO8                       | 000F977AC8824FE39B8                     |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais | 0036 - Microsoft Access 97 SR-2 English |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local           | 002B5DC7D4D34D5C895@bclabs.local        |


#AnnI 3/19/20: This is fixed only for 'Wormhole' (DAS20346)
@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12968 @DAS20346 
Scenario Outline: EvergreenJnr_AllLists_CheckThatRightClickMenuCopyRowOptionWorks
	When User clicks '<PageName>' on the left-hand menu
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <SelectedRow>    |
	When User right clicks on '<TargetCell>' cell from '<ColumnName>' column
	And User selects 'Copy row' option in context menu
	Then Next data '<ExpectedData>' is copied

Examples: 
	| PageName     | ColumnName    | TargetCell                                 | SelectedRow                             | ExpectedData                                                                                                            |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                             | 001BAQXT6JWFPI                          | 00HA7MKAVVFDAV\tLaptop\tWindows 7\tKris C. Herman                                                                       |
	| Users        | Username      | $6BE000-SUDQ9614UVO8                       | 000F977AC8824FE39B8                     | $6BE000-SUDQ9614UVO8\tBCLABS\tExchange Online-ApplicationAccount\tExchange Online-ApplicationAccount.Users.bclabs.local |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais | 0036 - Microsoft Access 97 SR-2 English | 0004 - Adobe Acrobat Reader 5.0.5 Francais\tAdobe\t5.0.5                                                                |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local           | 002B5DC7D4D34D5C895@bclabs.local        | 000F977AC8824FE39B8@bclabs.local\tExchange 2007\tbc-exch07\tUserMailbox\tSpruill, Shea                                  |
	

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS12968
Scenario Outline: EvergreenJnr_AllLists_CheckThatRightClickMenuCopySelectedRowOptionWorks
	When User clicks '<PageName>' on the left-hand menu
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "<ColumnName>" rows in the grid
	| SelectedRowsName |
	| <SelectedRow1>   |
	| <SelectedRow2>   |
	When User right clicks on '<TargetCell>' cell from '<ColumnName>' column
	And User selects 'Copy selected rows' option in context menu
	Then Next data '<ExpectedData>' is copied

Examples: 
	| PageName     | ColumnName    | TargetCell                                 | SelectedRow1                            | SelectedRow2                     | ExpectedData                                                                                                                                                                                             |
	| Devices      | Hostname      | 00HA7MKAVVFDAV                             | 001BAQXT6JWFPI                          | 001PSUMZYOW581                   | 001BAQXT6JWFPI\tDesktop\tWindows 10\tNicole P. Braun \t001PSUMZYOW581\tLaptop\tWindows 10\tTricia G. Huang                                                                                                 |
	| Users        | Username      | $6BE000-SUDQ9614UVO8                       | 000F977AC8824FE39B8                     | 002B5DC7D4D34D5C895              | 000F977AC8824FE39B8\tBCLABS\tSpruill, Shea\tSpruill\\, Shea.Employees.Birmingham.UK.bclabs.local \t002B5DC7D4D34D5C895\tDWLABS\tCollor, Christopher\tCollor\\, Christopher.Users.Birmingham.dwlabs.local |
	| Applications | Application   | 0004 - Adobe Acrobat Reader 5.0.5 Francais | 0036 - Microsoft Access 97 SR-2 English | 20040610sqlserverck              | 0036 - Microsoft Access 97 SR-2 English\tMicrosoft\t8.0 \t20040610sqlserverck\tMicrosoft\t1.0.0                                                                                                          |
	| Mailboxes    | Email Address | 000F977AC8824FE39B8@bclabs.local           | 002B5DC7D4D34D5C895@bclabs.local        | 0072B088173449E3A93@bclabs.local | 002B5DC7D4D34D5C895@bclabs.local\tExchange 2013\tbc-exch13\tUserMailbox\tCollor, Christopher \t0072B088173449E3A93@bclabs.local\tExchange 2007\tbc-exch07\tUserMailbox\tRegister, Donna                  |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS16332 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatListNameUpdatesImmediatelyWhileTypingInDetailsPane
	When User clicks 'Devices' on the left-hand menu
	And User clicks the Filters button
	And User add "2004: In Scope" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	And User create dynamic list with "TestListName4682" name on "Devices" page
	Then "TestListName4682" list is displayed to user
	When User clicks 'Manage' option in cogmenu for 'TestListName4682' list
	And User adds "post" to list name
	Then "TestListName4682post" list is displayed to user

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS17632
Scenario: EvergreenJnr_DevicesLists_CheckThatArchivedEmptyNameCantBeClicked
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName |
	| Device Key |
	And User sets includes archived devices in 'true'
	And User clicks content from first row of Hostname column
	Then 'All Devices' list should be displayed to the user
	When User clicks content from first row of Device Key column
	Then 'All Devices' list should be displayed to the user