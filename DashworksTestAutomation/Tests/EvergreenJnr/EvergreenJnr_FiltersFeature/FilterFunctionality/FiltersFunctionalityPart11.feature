Feature: FiltersFunctionalityPart11
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13384 @Cleanup
Scenario: EvergreenJnr_UsersList_ChecksThatEditButtonIsDisplayedOnFiltersSectionIfEditFormOpenWhenYouSaveList
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "MigrationP: Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Light Blue     |
	| Out Of Scope   |
	| Blue           |
	Then "MigrationP: Readiness" filter is added to the list
	When User click Edit button for "MigrationP: Readiness" filter
	And User creates 'DynamicList13384' dynamic list
	Then "DynamicList13384" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Edit button is displayed correctly for "MigrationP: Readiness" filter

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13588
Scenario: EvergreenJnr_ApplicationsList_CheckThatUsingUserLDAPFilterDoesNotProduceServerError
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "badpasswordtime" filter where type is "Equals" with following Value and Association:
	| Values | Association     |
	| test   | Has used app    |
	|        | Entitled to app |
	Then There are no errors in the browser console
	And 'All Applications' list should be displayed to the user
	And message 'No applications found' is displayed to the user 

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13331
Scenario: EvergreenJnr_DevicesList_ChecksThatUsedByDevicesOwnerApplicationToDeviceAssociationReturnCorrectData
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Key" filter where type is "Equals" with following Number and Association:
	| Number | Association            |
	| 86     | Used by device's owner |
	Then "Application whose Key" filter is added to the list
	And "Application whose Key is 86 used by device's owner" is displayed in added filter info
	And "154" rows are displayed in the agGrid

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS9820 @DAS13296
Scenario Outline: EvergreenJnr_UsersList_ChecksThatDeviceAndGroupAndMailboxFiltersCanBeUsedOnUsersPage
	When User clicks 'Users' on the left-hand menu
	And User clicks the Filters button
	And User add "<FilterName>" filter where type is "Equals" with added column and following value:
	| Values   |
	| <Values> |
	Then "<RowsCount>" rows are displayed in the agGrid
	And There are no errors in the browser console

Examples: 
	| FilterName             | Values | RowsCount        |
	| Device Count           | 6      | 1                |
	| Group Count            | 13     | 32               |
	| Mailbox Count (Access) | 3      | 6                |
	#| Mailbox Count (Owned)  | 4      | to_be_determined |

@Evergreen @AllLists @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13145
Scenario Outline: EvergreenJnr_AllLists_ChecksThatApplicationFilterIsNotExcludedApplicationsWhichAreNotLinkedToAnyDevices
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application" filter
	And User clicks in search field for selected Association filter
	Then "50 of 2223 shown" results are displayed in the Filter panel
	And the following values are displayed for "Application" filter on "<PageName>" page:
	| Value                               |
	| Acrobat Reader 6.0.1 (500)          |
	| ACT Data Collection Packages (1104) |
	Then "ACT Data Collection Packages (1104)" is displayed after "Acrobat Reader 6.0.1 (500)" in Application list filter
	When User enters "1104" text in Search field at selected Lookup Filter
	Then "1 shown" results are displayed in the Filter panel
	And "ACT Data Collection Packages (1104)" value is displayed for selected Lookup Filter

Examples:
	| PageName |
	| Devices  |
	#| Users    |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS13473 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_ChecksThatIfListWithAnAdvancedUserDescriptionIsEmptyFilterIsSavedAndOpenedNotInEditMode
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User Description" filter where type is "Empty" with following Lookup Value and Association:
	| SelectedValues | Association     |
	|                | Has used app    |
	|                | Entitled to app |
	Then "User whose Description" filter is added to the list
	And "User whose Description is empty has used app; or entitled to app" is displayed in added filter info
	When User creates 'DAS13473' dynamic list
	Then "DAS13473" list is displayed to user
	And "113" rows are displayed in the agGrid
	And URL contains 'evergreen/#/applications?$listid='
	And Edit List menu is not displayed
	When User navigates to the "All Applications" list
	And User navigates to the "DAS13473" list
	Then "113" rows are displayed in the agGrid
	Then URL contains 'evergreen/#/applications?$listid='
	And Edit List menu is not displayed