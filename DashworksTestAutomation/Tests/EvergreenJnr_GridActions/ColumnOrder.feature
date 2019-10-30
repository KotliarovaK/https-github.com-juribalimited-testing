﻿@retry:1
Feature: ColumnOrder
	Runs Column Order related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_GridActions @ColumnOrder @DAS10836 @DAS11666 @DAS12325
Scenario: EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterSearch
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User have opened column settings for "Owner Display Name" column
	When User have select "Pin Left" option from column settings
	Then "Owner Display Name" column is "Left" Pinned
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	Then "Owner Display Name" column is "Left" Pinned

@Evergreen @Users @EvergreenJnr_GridActions @ColumnOrder @DAS10836 @DAS11664 @DAS12325 @DAS14183
Scenario: EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterSearch
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName          |
	| Compliance          |
	When User have opened column settings for "Compliance" column
	When User have select "Pin Right" option from column settings
	Then "Compliance" column is "Right" Pinned
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 59           |
	Then "Compliance" column is "Right" Pinned

@Evergreen @Devices @EvergreenJnr_GridActions @ColumnOrder @DAS10621 @DAS11666 @DAS12156 @DAS12351
Scenario: EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterAddingAFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| Compliance   |
	| Boot Up Date |
	When User move 'Boot Up Date' column to 'Hostname' column
	Then Column is displayed in following order:
	| ColumnName         |
	| Hostname           |
	| Boot Up Date       |
	| Device Type        |
	| Operating System   |
	| Owner Display Name |
	| Compliance         |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| None               |
	Then Column is displayed in following order:
	| ColumnName           |
	| Hostname             |
	| Boot Up Date         |
	| Device Type          |
	| Operating System     |
	| Owner Display Name   |
	| Compliance           |
	| Windows7Mi: Category |

@Evergreen @Users @EvergreenJnr_GridActions @ColumnOrder @DAS11666 @DAS12156
Scenario: EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterAddingAnotherColumn
	When User add following columns using URL to the "Users" page:
	| ColumnName    |
	| Compliance    |
	| Email Address |
	And User move 'Email Address' column to 'Username' column
	And User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Distinguished Name" column by Column panel
	Then Column is displayed in following order:
	| ColumnName         |
	| Username           |
	| Email Address      |
	| Domain             |
	| Display Name       |
	| Compliance         |
	When User add following columns using current URL on "Users" page:
	| ColumnName |
	| User Key   |
	Then Column is displayed in following order:
	| ColumnName         |
	| Username           |
	| Email Address      |
	| Domain             |
	| Display Name       |
	| Compliance         |
	| User Key           |

@Evergreen @Mailboxes @EvergreenJnr_GridActions @ColumnOrder @DAS11666 @DAS12156
Scenario: EvergreenJnr_MailboxesList_CheckThatColumnsOrderSavedAfterUsingTheAgGridSearch
	When User add following columns using URL to the "Mailboxes" page:
	| ColumnName  |
	| Email Count |
	| Import Type |
	When User move 'Email Count' column to 'Email Address' column
	Then Column is displayed in following order:
	| ColumnName         |
	| Email Address      |
	| Email Count        |
	| Mailbox Platform   |
	| Mail Server        |
	| Mailbox Type       |
	| Owner Display Name |
	| Import Type        |
	When User perform search by "Smith"
	Then Column is displayed in following order:
	| ColumnName         |
	| Email Address      |
	| Email Count        |
	| Mailbox Platform   |
	| Mail Server        |
	| Mailbox Type       |
	| Owner Display Name |
	| Import Type        |

@Evergreen @Applications @EvergreenJnr_Columns @RemoveColumn @DAS11625
Scenario: EvergreenJnr_ApplicationsList_CheckThatAfterDeletingFirstColumnTheColumnsOrderIsDisplayedCorrectly 
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Application" column by Column panel
	Then 'All Applications' list should be displayed to the user
	And ColumnName is removed from the list
	| ColumnName  |
	| Application |
	Then Column is displayed in following order:
	| ColumnName         |
	| Vendor             |
	| Version            |

@Evergreen @AllLists @EvergreenJnr_Columns @ColumnOrder @DAS12345 @DAS12823 @DAS13668
Scenario Outline: EvergreenJnr_AllLists_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasReturnedToDefaultPositionWhenActionsPanelWasOpen
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User move '<FirstColumnName>' column to '<ToColumnName>' column
	And User move '<SecondColumnName>' column to '<ToColumnName>' column
	And User clicks Close panel button
	Then Actions panel is not displayed to the user
	And Save to New Custom List element is NOT displayed

Examples: 
	| PageName     | FirstColumnName | SecondColumnName | ToColumnName     |
	| Devices      | Hostname        | Device Type      | Operating System |
	| Users        | Username        | Domain           | Display Name     |
	| Applications | Application     | Vendor           | Version          |
	| Mailboxes    | Email Address   | Mailbox Platform | Mail Server      |

@Evergreen @AllLists @EvergreenJnr_Columns @ColumnOrder @DAS11836
Scenario Outline: EvergreenJnr_AllLists_CheckThatSaveButtonIsNotDisplayedIfTheGridColumnsWasRemovedAndReturnedToDefaultPosition 
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "<ColumnName>" column by Column panel
	Then ColumnName is removed from the list
	| ColumnName   |
	| <ColumnName> |
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	Then ColumnName is added to the list
	| ColumnName   |
	| <ColumnName> |
	And Save to New Custom List element is NOT displayed

Examples: 
	| PageName     | ColumnName         | 
	| Devices      | Owner Display Name | 
	| Users        | Distinguished Name | 
	| Applications | Version            | 
	| Mailboxes    | Owner Display Name |