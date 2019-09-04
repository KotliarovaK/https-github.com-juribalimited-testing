Feature: AddObjectsToCapacityUnits
	Add Objects To Capacity Units on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @DAS13808 @DAS14200 @DAS14236 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatDevicesAreAddedCorrectly
	When User creates new Capacity Unit via api
	| Name                     | Description | IsDefault |
	| CapacityUnit12141Devices | Devices     | false     |
	And User clicks "Devices" on the left-hand menu
	Then "All Devices" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 00I0COBFWHOF27   |
	| 00K4CEEQ737BA4L  |
	| 00KLL9S8NRF0X6   |
	| 00KWQ4J3WKQM0G   |
	| 01ERDGD48UDQKE   |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Evergreen" Project or Evergreen on Action panel
	And User selects "CapacityUnit12141Devices" value for "Capacity Unit" dropdown with search on Action panel
	And User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "5 updates have been queued" text is displayed on Action panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Capacity Units" tab
	Then "Capacity Units" page should be displayed to the user
	When User enters "CapacityUnit12141Devices" text in the Search field for "Capacity Unit" column
	Then "5" content is displayed in "Devices" column

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @DAS13808 @DAS14200 @DAS14236 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatUsersAreAddedCorrectly
	When User creates new Capacity Unit via api
	| Name                   | Description | IsDefault |
	| CapacityUnit12141Users | Users       | false     |
	And User clicks "Users" on the left-hand menu
	Then "All Users" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Username" rows in the grid
	| SelectedRowsName     |
	| $231000-3AC04R8AR431 |
	| $6BE000-SUDQ9614UVO8 |
	| ___ ___              |
	| 002B5DC7D4D34D5C895  |
	| 00BDBAEA57334C7C8F4  |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Evergreen" Project or Evergreen on Action panel
	And User selects "CapacityUnit12141Users" value for "Capacity Unit" dropdown with search on Action panel
	And User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "5 updates have been queued" text is displayed on Action panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Capacity Units" tab
	Then "Capacity Units" page should be displayed to the user
	When User enters "CapacityUnit12141Users" text in the Search field for "Capacity Unit" column
	Then "5" content is displayed in "Users" column

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @DAS13808 @DAS14200 @DAS14236 @DAS14237 @DAS14757 @DAS16124 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatApplicationsAreAddedCorrectly
	When User creates new Capacity Unit via api
	| Name                          | Description  | IsDefault |
	| CapacityUnit12141Applications | Applications | false     |
	And User clicks "Applications" on the left-hand menu
	Then "All Applications" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                                                |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007)      |
	| %SQL_PRODUCT_SHORT_NAME% Data Tools - BI for Visual Studio 2013 |
	| %SQL_PRODUCT_SHORT_NAME% SSIS 64Bit For SSDTBI                  |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais                      |
	| ACD FotoCanvas 2.0 Trial                                        |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Evergreen" Project or Evergreen on Action panel
	And User selects "CapacityUnit12141Applications" value for "Capacity Unit" dropdown with search on Action panel
	And User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "5 updates have been queued" text is displayed on Action panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Capacity Units" tab
	Then "Capacity Units" page should be displayed to the user
	When User enters "CapacityUnit12141Applications" text in the Search field for "Capacity Unit" column
	Then "5" content is displayed in "Applications" column

@Evergreen @Admin @EvergreenJnr_AdminPage @CapacityUnits @DAS12141 @DAS13808 @DAS14200 @DAS14236 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatMailboxesAreAddedCorrectly
	When User creates new Capacity Unit via api
	| Name                       | Description | IsDefault |
	| CapacityUnit12141Mailboxes | Mailboxes   | false     |
	And User clicks "Mailboxes" on the left-hand menu
	Then "All Mailboxes" list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Email Address" rows in the grid
	| SelectedRowsName                 |
	| 000F977AC8824FE39B8@bclabs.local |
	| 002B5DC7D4D34D5C895@bclabs.local |
	| 003F5D8E1A844B1FAA5@bclabs.local |
	| 0072B088173449E3A93@bclabs.local |
	| 00A5B910A1004CF5AC4@bclabs.local |
	And User selects "Bulk update" in the Actions dropdown
	And User selects "Update capacity unit" Bulk Update Type on Action panel
	And User selects "Evergreen" Project or Evergreen on Action panel
	And User selects "CapacityUnit12141Mailboxes" value for "Capacity Unit" dropdown with search on Action panel
	And User clicks the "UPDATE" Action button
	Then User clicks "UPDATE" button on message box
	And Success message with "5 updates have been queued" text is displayed on Action panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	And User clicks "Capacity Units" tab
	Then "Capacity Units" page should be displayed to the user
	When User enters "CapacityUnit12141Mailboxes" text in the Search field for "Capacity Unit" column
	Then "5" content is displayed in "Mailboxes" column