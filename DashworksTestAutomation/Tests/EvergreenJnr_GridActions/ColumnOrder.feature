@retry:1
Feature: ColumnOrder
	Runs Column Order related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_GridActions @ColumnOrder @DAS10836 @DAS11666 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterSearch
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User have opened column settings for "Owner Display Name" column
	When User have select "Pin Left" option from column settings
	Then "Owner Display Name" column is "Left" Pinned
	Then User enters SearchCriteria into the agGrid Search Box and the correct NumberOfRows are returned
	| SearchCriteria | NumberOfRows |
	| Smith          | 11           |
	Then "Owner Display Name" column is "Left" Pinned

@Evergreen @Users @EvergreenJnr_GridActions @ColumnOrder @DAS10836 @DAS11664 @Not_Run
Scenario: EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterSearch
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
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
	| Smith          | 51           |
	Then "Compliance" column is "Right" Pinned

@Evergreen @Devices @EvergreenJnr_GridActions @ColumnOrder @DAS10621 @DAS11666 @Not_Run
Scenario: EvergreenJnr_DevicesList_CheckThatColumnsOrderSavedAfterAddingAFilter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
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

@Evergreen @Users @EvergreenJnr_GridActions @ColumnOrder @DAS11666
Scenario: EvergreenJnr_UsersList_CheckThatColumnsOrderSavedAfterAddingAnotherColumn
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName    |
	| Compliance    |
	| Email Address |
	When User move 'Email Address' column to 'Username' column
	Then Column is displayed in following order:
	| ColumnName         |
	| Username           |
	| Email Address      |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	| Compliance         |
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| User Key   |
	Then Column is displayed in following order:
	| ColumnName         |
	| Username           |
	| Email Address      |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	| Compliance         |
	| User Key           |

@Evergreen @Mailboxes @EvergreenJnr_GridActions @ColumnOrder @DAS11666
Scenario: EvergreenJnr_MailboxesList_CheckThatColumnsOrderSavedAfterUsingTheAgGridSearch
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
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
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When User removes "Application" column by Column panel
	Then "Applications" list should be displayed to the user
	And ColumnName is removed from the list
	| ColumnName  |
	| Application |
	Then Column is displayed in following order:
	| ColumnName |
	| Vendor     |
	| Version    |