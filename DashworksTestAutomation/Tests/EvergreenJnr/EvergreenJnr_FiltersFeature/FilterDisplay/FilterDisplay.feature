Feature: FilterDisplay
	Runs Dynamic Filters Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11678
Scenario: EvergreenJnr_DevicesList_CheckThatTheSaveButtonIsNotAvailableWhenEnteringInvalidData
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Build Date" filter
	And User enters '111' text to 'Date' textbox
	Then 'ADD' button is disabled

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11738 @DAS12194 @DAS12199 @DAS12220
Scenario: EvergreenJnr_UsersList_CheckThatToolTipShownWithEditFilterTextWhenEditingAFilterDisplayed 
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User navigate to Edit button for "Compliance" filter
	Then tooltip is displayed with "Edit Filter" text for edit filter button

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS13182
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddNewOptionAvailableAfterClickOnAllOptionInListsPanelWhileFiltersSectionExpanded
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	When User navigates to the "<LinkName>" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And Add New button is displayed on the Filter panel

	Examples:
		| ListName     | LinkName         |
		| Devices      | All Devices      |
		| Users        | All Users        |
		| Applications | All Applications |
		| Mailboxes    | All Mailboxes    |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS17943
Scenario Outline: EvergreenJnr_AdminPage_CheckThaSearchfieldHasProperPlaceholderForFiltersAndColumns
	When User clicks '<PageName>' on the left-hand menu
	Then '<ListName>' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then Filter Searchfield placeholder is 'Search filters'
	When User clicks the Columns button
	Then Columns Searchfield placeholder is 'Search columns'

	Examples:
		| PageName     | ListName         |
		| Devices      | All Devices      |
		| Users        | All Users        |
		| Applications | All Applications |
		| Mailboxes    | All Mailboxes    |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS12819 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatTheUserDescriptionFieldIsNotDisplayedForEmptyNotEmptyOptions
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Description" filter where type is "Contains" with following Value and Association:
		| Values | Association     |
		| Aw     | Entitled to app |
	Then "3" rows are displayed in the agGrid
	When User create dynamic list with "UsersDescriptionFilterList" name on "Applications" page
	Then "UsersDescriptionFilterList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "User " filter
	And User select "Empty" Operator value
	Then User Description field is not displayed
	When User select "Not empty" Operator value
	Then User Description field is not displayed 

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11760 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatTheSaveButtonIsNotAvailableWithoutTheFilterValue
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application Name" filter
	And User enters "testText" text in Search field at selected Filter
	And User clicks Add button for input filter value
	And User select "Not entitled to device" Association for Application filter with Lookup value
	When User clicks 'ADD' button 
	Then "Application whose Name is testText not entitled to device" is displayed in added filter info
	When User create dynamic list with "TestListF58LY5" name on "Devices" page
	Then Edit List menu is not displayed
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Application " filter
	Then Search field in selected Filter is empty

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS12543 @DAS13001 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckThatEditFilterElementsBlockIsDisplayedCorrectlyOnTheFiltersPanel
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "EmailMigra: Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Light Blue     |
	Then Content is present in the newly added column
	| ColumnName            |
	| EmailMigra: Readiness |
	When User create dynamic list with "TestListF544Y5" name on "Mailboxes" page
	Then "TestListF544Y5" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
	| Values     |
	| Light Blue |
	When User click Edit button for "EmailMigra: Readiness" filter
	Then "Add column" checkbox is checked
	And "EmailMigra: Readiness" filter is displayed in the Filters panel

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11009
Scenario: EvergreenJnr_DevicesList_CheckThatResetIsUpdatingRowCount
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Unknown            |
	Then "Compliance" filter is added to the list
	And "75" rows are displayed in the agGrid
	And table data is filtered correctly
	And "Compliance" filter with "Unknown" values is added to URL on "Devices" page
	And "Compliance" column is added to URL on "Devices" page
	When User have reset all filters
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	And "17,279" rows are displayed in the agGrid
	Then "Compliance" filter is removed from filters

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11506
Scenario: EvergreenJnr_DevicesList_CheckThatDeleteByUrlIsUpdatingRowCount
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Unknown            |
	Then "Compliance" filter is added to the list
	And "75" rows are displayed in the agGrid
	And table data is filtered correctly
	And "Compliance" filter with "Unknown" values is added to URL on "Devices" page
	And "Compliance" column is added to URL on "Devices" page
	When User is remove filter by URL
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	And "17,279" rows are displayed in the agGrid
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Compliance" filter is removed from filters

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11009 @DAS11044 @DAS12199 @DAS14603
Scenario: EvergreenJnr_UsersList_CheckThatDeletePartOfFilterFromUrlIsUpdatingRowCount
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName |
	| Compliance |
	| Username   |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	| Amber              |
	| Green              |
	Then "Compliance" filter is added to the list
	And "41,164" rows are displayed in the agGrid
	And table data is filtered correctly
	And "Compliance" filter with "Red, Amber, Green" values is added to URL on "Users" page
	And "Compliance" column is added to URL on "Users" page
	When User is remove part of filter URL
	Then ColumnName is added to the list
	| ColumnName |
	| Compliance |
	And "41,339" rows are displayed in the agGrid
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Compliance" filter is removed from filters

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10996 @DAS12207
Scenario: EvergreenJnr_MailboxesList_CheckThatFiltersIsResetAndDataOnTheGridUpdatedBackToTheFullDataSet
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "City" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| London             |
	Then "City" filter is added to the list
	And "3,294" rows are displayed in the agGrid
	And table data is filtered correctly
	When User have reset all filters
	Then "14,884" rows are displayed in the agGrid
	And "City" filter is removed from filters

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS12635 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatCancelingUnsavedFilterDoesNotReloadList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: In Scope" filter
	When User deletes filter and agGrid does not reload
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Owner Enabled" filter
	When User cancels filter and agGrid does not reload
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "App Count (Entitled to Owned Device)" filter where type is "Equals" without added column and following value:
	| Values |
	| 0      |
	When User create dynamic list with "TestList12635" name on "Users" page
	Then "TestList12635" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add And button on the Filter panel
	When user select "Device Count" filter
	When User deletes filter and agGrid does not reload
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Count (Entitled)" filter where type is "Equals" without added column and following value:
	| Values |
	| 100    |
	When User create dynamic list with "TestList12635" name on "Applications" page
	Then "TestList12635" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	When user select "Compliance" filter
	When User deletes filter and agGrid does not reload

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS17436 @DAS18561 @Cleanup
Scenario: EvergreenJnr_DevicesLists_CheckBrokenListDisplayingAfterFilterRemoving
	When User creates broken list with 'Broken list DAS17436' name on 'Devices' page
	And User clicks 'Devices' on the left-hand menu
	And User navigates to the "Broken list DAS17436" list
	Then "Broken list DAS17436" list is displayed to user
	And "This list has errors" message is displayed on the Admin Page
	When User clicks the Filters button
	And User have reset all filters
	Then "17,279" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10795 @DAS10781 @DAS11573
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnOptionIsAvailableForFilters
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then checkboxes are displayed to the User:
		| SelectedCheckboxes   |
		| <SelectedCheckboxes> |

	Examples:
		| PageName     | FilterName            | SelectedCheckboxes               |
		| Devices      | Operating System      | Add Operating System column      |
		| Devices      | City                  | Add City column                  |
		| Users        | Zip Code              | Add Zip Code column              |
		| Applications | Application Owner     | Add Application Owner column     |
		| Mailboxes    | Mailbox Filter 1      | Add Mailbox Filter 1 column      |
		| Devices      | Compliance            | Add Compliance column            |
		| Mailboxes    | Owner Department Code | Add Owner Department Code column |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10795 @DAS11187 @DAS13376
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnOptionIsNotAvailableForApplicationCustomFieldsFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User selects "Application Owner" filter from "Application Custom Fields" category
	Then "Add column" checkbox is not displayed

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11351
Scenario Outline: EvergreenJnr_AllLists_DevicesList_CheckThatAddColumnOptionIsAvailableForOwnerDepartmentFilter
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Owner Department" filter
	Then checkboxes are displayed to the User:
		| SelectedCheckboxes                    |
		| Add Owner Department Name column      |
		| Add Owner Department Full Path column |

	Examples:
		| PageName  |
		| Mailboxes |
		| Devices   |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11619
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckboxIsDisabledForAlreadySelectedColumn
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then "Add column"checkbox is checked and cannot be unchecked

	Examples:
		| ListName     | FilterName              |
		| Devices      | Hostname                |
		| Devices      | Device Type             |
		| Devices      | Operating System        |
		| Devices      | Owner Display Name      |
		| Users        | Username                |
		| Users        | Domain                  |
		| Users        | Display Name            |
		| Users        | Distinguished Name      |
		| Applications | Application             |
		| Applications | Vendor                  |
		| Applications | Version                 |
		| Mailboxes    | Email Address (Primary) |
		| Mailboxes    | Mailbox Platform        |
		| Mailboxes    | Mail Server             |
		| Mailboxes    | Mailbox Type            |
		| Mailboxes    | Owner Display Name      |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11829
Scenario Outline: EvergreenJnr_AllLists_CheckThatAddColumnCheckboxIsDisplayedForOrganisationCategoryFilters
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then checkboxes are displayed to the User:
		| SelectedCheckboxes   |
		| <SelectedCheckboxes> |

	Examples:
		| ListName  | FilterName                 | SelectedCheckboxes                    |
		| Devices   | Department Name            | Add Department Name column            |
		| Devices   | Department Full Path       | Add Department Full Path column       |
		| Devices   | Owner Department Name      | Add Owner Department Name column      |
		| Devices   | Owner Department Full Path | Add Owner Department Full Path column |
		| Mailboxes | Department Name            | Add Department Name column            |
		| Mailboxes | Department Full Path       | Add Department Full Path column       |
		| Mailboxes | Owner Department Name      | Add Owner Department Name column      |
		| Mailboxes | Owner Department Full Path | Add Owner Department Full Path column |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11042 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnCheckboxIsCheckedAfterSavingFilterInANewList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User create dynamic list with "TestList4A5CD6" name on "Devices" page
	Then "TestList4A5CD6" list is displayed to user
	When User navigates to the "All Devices" list
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "TestList4A5CD6" list
	Then "TestList4A5CD6" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is checked
	And "Add Column" checkbox is disabled

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11042
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnCheckboxIsUncheckedAfterSavingAFilterAndRemovingAColumn
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is checked
	When User clicks the Columns button
	When User removes "Compliance" column by Column panel
	When User clicks the Filters button
	#When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is unchecked
	And "Add column" checkbox is not disabled

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10734 @DAS11507 @DAS12351 @DAS12512
Scenario: EvergreenJnr_ApplicationsList_CheckThatAddColumnCheckboxWorksCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Category" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes  |
	| A Star Packages     |
	Then "Windows7Mi: Category" filter is added to the list
	Then table data is filtered correctly
	When User clicks refresh button in the browser
	Then User sees "3" rows in grid

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11042
Scenario: EvergreenJnr_DevicesList_CheckThatAddColumnCheckboxIsCheckedAfterSavingAFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User click Edit button for "Compliance" filter
	Then "Add column" checkbox is checked
	And "Add Column" checkbox is disabled

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS17016
Scenario: EvergreenJnr_DevicesPage_CheckThatFilterExpressionCanBeSelected
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "Equals" with added column and following value:
	| Values         |
	| 00I0COBFWHOF27 |
	When User clicks Filter Expression icon in Filter Panel
	Then Filter Expression displayed within Filter Panel
	When User double clicks Filter Expression text
	Then '00I0COBFWHOF27' text is highlighted

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS17252 @DAS16485
Scenario: EvergreenJnr_MailboxesList_CheckThatFilterExpressionSectionIsMovedToFilterPanel
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User navigates to the "Mailbox Pivot (Complex)" list
	And User clicks the Filters button
	Then Filter Expression icon displayed within Filter Panel
	When User clicks Filter Expression icon in Filter Panel
	Then Filter Expression displayed within Filter Panel

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11824
Scenario: EvergreenJnr_DevicesList_CheckingThatError500IsNotDisplayedAfterUsingSpecialCharactersIntoTheApplicationNameFilterAndRefreshingThePage
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Name" filter where type is "Equals" with following Value and Association:
	| Values | Association            |
	| __     | Entitled to device     |
	Then "Application whose Name" filter is added to the list
	When User clicks refresh button in the browser
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Filter Expression icon in Filter Panel
	Then "(Application Name = __ ASSOCIATION = (entitled to device))" text is displayed in filter container

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS13831 @DAS15376
Scenario: EvergreenJnr_AllLists_CheckThatBetweenOperatorIsDisplayedInTheDateFilters
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Build Date" filter where type is "Between" with added column and Date options
		| StartDateInclusive | EndDateInclusive |
		| 17 Feb 2017        | 08 Aug 2017      |
	Then "27" rows are displayed in the agGrid
	Then '17 Feb 2017' content is displayed in the 'Build Date' column
	Then '8 Aug 2017' content is displayed in the 'Build Date' column
	Then "(Build Date between (2017-02-17, 2017-08-08))" text is displayed in filter container
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Last Logon Date" filter where type is "Between" with added column and Date options
		| StartDateInclusive | EndDateInclusive |
		| 25 Apr 2018        | 02 May 2018      |
	Then "22" rows are displayed in the agGrid
	Then '25 Apr 2018' content is displayed in the 'Last Logon Date' column
	Then '2 May 2018' content is displayed in the 'Last Logon Date' column
	Then "(Last Logon Date between (2018-04-25, 2018-05-02))" text is displayed in filter container
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Created Date" filter where type is "Between" with added column and Date options
		| StartDateInclusive | EndDateInclusive |
		| 14 Sep 2016        | 22 Jun 2017      |
	Then "7" rows are displayed in the agGrid
	Then '14 Sep 2016' content is displayed in the 'Created Date' column
	Then '22 Jun 2017' content is displayed in the 'Created Date' column
	Then "(Created Date between (2016-09-14, 2017-06-22))" text is displayed in filter container
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "UserEvergr: Stage 2 \ Application Delivery Date" filter where type is "Between" with added column and Date options
		| StartDateInclusive | EndDateInclusive |
		| 11 Nov 2012        | 22 Nov 2019      |
	Then "18" rows are displayed in the agGrid
	Then '8 Feb 2019' content is displayed in the 'UserEvergr: Stage 2 \ Application Delivery Date' column
	Then "(UserEvergr: Stage 2 \ Application Delivery Date between (2012-11-11, 2019-11-22))" text is displayed in filter container

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS13831 @DAS15376
Scenario: EvergreenJnr_ApplicationsList_CheckThatBetweenOperatorIsDisplayedInTheUserLastLogonDateFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Between" with following Date options and Associations:
		| StartDateInclusive | EndDateInclusive | Association                             |
		| 11 Nov 2012        | 22 Nov 2019      | Has used app                            |
		|                    |                  | Entitled to app                         |
		|                    |                  | Owns a device which app was used on     |
		|                    |                  | Owns a device which app is entitled to  |
		|                    |                  | Owns a device which app is installed on |
	Then "979" rows are displayed in the agGrid
	Then "(User Last Logon Date between (2012-11-11, 2019-11-22) ASSOCIATION = (has used app, entitled to app, owns a device which app was used on, owns a device which app is entitled to, owns a device which app is installed on))" text is displayed in filter container

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS15376 @DAS15331
Scenario Outline: EvergreenJnr_AllList_CheckFilterTextInThePopOutPanelForBetweenOperator
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Last Logon Date" filter where type is "Between" with added column and Date options
		| StartDateInclusive | EndDateInclusive |
		| 25 Apr 2018        | 02 May 2018      |
	Then "(Last Logon Date between (2018-04-25, 2018-05-02))" text is displayed in filter container

	Examples:
		| ListName  |
		| Mailboxes |
		| Users     |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11165
Scenario: EvergreenJnr_ApplicationsList_CheckThat500ErrorIsNotDisplayedForFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
		| Values                             |
		| DirectX SDK (Version 8.1) (3663.0) |
	Then "Application" filter is added to the list
	When User add "Application" filter where type is "Equals" with added column and following value:
		| Values                                                     |
		| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	Then "Application" filter is added to the list
	And "(Application = DirectX SDK (Version 8.1) (3663.0)) OR (Application = "WPF/E" (codename) Community Technology Preview (Feb 2007))" text is displayed in filter container

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11054 @DAS11578
Scenario: EvergreenJnr_DevicesList_CheckThatSpaceAfterCommasInTheComplianceAndImportFiltersContainerIsDisplayed
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
		| SelectedCheckboxes |
		| Unknown            |
		| Red                |
		| Amber              |
		| Green              |
	Then "Compliance" filter is added to the list
	When User add "Import" filter where type is "Does not equal" with added column and "A01 SMS (Spoof)" Lookup option
	Then "Import" filter is added to the list
	Then "(Compliance = Amber, Green, Red or Unknown) OR (Import != A01 SMS (Spoof))" text is displayed in filter container

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11054 @DAS11578
Scenario: EvergreenJnr_DevicesList_CheckThatSpaceAfterCommasInTheDepartmentCodeFilterContainerIsDisplayed
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Department Code" filter where type is "Contains" with added column and following value:
		| Values |
		| ABC    |
	Then "Department Code" filter is added to the list
	When User add "Department Code" filter where type is "Does not contain" with added column and following value:
		| Values |
		| ACV    |
	Then "Department Code" filter is added to the list
	When User add "Department Code" filter where type is "Begins with" with added column and following value:
		| Values |
		| AXZ    |
	Then "Department Code" filter is added to the list
	When User add "Department Code" filter where type is "Ends with" with added column and following value:
		| Values |
		| YQA    |
	Then "Department Code" filter is added to the list
	When User add "Department Code" filter where type is "Empty" without added column and following value:
		| Values |
		|        |
	Then "Department Code" filter is added to the list
	When User add "Department Code" filter where type is "Not empty" without added column and following value:
		| Values |
		|        |
	Then "Department Code" filter is added to the list
	Then "(Department Code ~ ABC) OR (Department Code !~ ACV) OR (Department Code BEGINS WITH AXZ) OR (Department Code ENDS WITH YQA) OR (Department Code = EMPTY) OR (Department Code != EMPTY)" text is displayed in filter container

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11054 @DAS11578
Scenario: EvergreenJnr_DevicesList_CheckThatSpaceAfterCommasInTheBootUpDateAndCpuCountFiltersContainerIsDisplayed
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Boot Up Date" filter where type is "Before" with added column and "14 Dec 2017" Date filter
	Then "Boot Up Date" filter is added to the list
	When User add "Boot Up Date" filter where type is "After" with added column and "3 Dec 2017" Date filter
	Then "Boot Up Date" filter is added to the list
	When User add "CPU Count" filter where type is "Greater than" with added column and following value:
		| Values |
		| 66     |
	Then "CPU Count" filter is added to the list
	When User add "CPU Count" filter where type is "Greater than or equal to" with added column and following value:
		| Values |
		| 12     |
	Then "CPU Count" filter is added to the list
	When User add "CPU Count" filter where type is "Less than" with added column and following value:
		| Values |
		| 31     |
	Then "CPU Count" filter is added to the list
	When User add "CPU Count" filter where type is "Less than or equal to" with added column and following value:
		| Values |
		| 13     |
	Then "CPU Count" filter is added to the list
	Then "(Boot Up Date < 2017-12-14) OR (Boot Up Date > 2017-12-03) OR (CPU Count > 66) OR (CPU Count >= 12) OR (CPU Count < 31) OR (CPU Count <= 13)" text is displayed in filter container

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11467 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatMultipleFilterCriteriaToApplicationNameDisplayedCorrectlyWhenUsingTheContainsOperator
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Name" filter where type is "Contains" with following Value and Association:
		| Values    | Association         |
		| adobe     | Installed on device |
		| microsoft |                     |
	Then "Application whose Name" filter is added to the list
	And "Application whose Name contains adobe or microsoft installed on device" is displayed in added filter info
	When User create dynamic list with "TestListF9A187" name on "Devices" page
	Then "TestListF9A187" list is displayed to user
	And "10,257" rows are displayed in the agGrid
	And Edit List menu is not displayed
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "(Application Name ~ (adobe, microsoft) ASSOCIATION = (installed on device))" text is displayed in filter container

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS12121 @DAS13376 @DAS14222 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatTextInTheFilterPanelDisplaysTheCurrentListName
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Application' column header
	And User create dynamic list with "ApplicationList1" name on "Applications" page
	And User navigates to the "All Applications" list
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Vendor' column header
	And User create dynamic list with "ApplicationList2" name on "Applications" page
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
		| SelectedList     | Association    |
		| ApplicationList1 | Used on device |
	When User create dynamic list with "DevicesList1" name on "Devices" page
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "(Application (Saved List) = ApplicationList1 ASSOCIATION = ("used on device"))" text is displayed in filter container
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks 'Delete' option in cogmenu for 'ApplicationList1' list
	When User confirms list removing
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "DevicesList1" list
	#Then '(Application (Saved List) = {LIST_ID} ASSOCIATION = ("used on device"))' text is displayed in filter container for 'ApplicationList1' list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Any Application in list [List not found] used on device" is displayed in added filter info
	When User click Edit button for " Application" filter
	Then "ApplicationList2" list is displayed for Saved List filter

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11142 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatApostrophesAreDisplayedCorrectlyInFilterInfo
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Owner Display Name" filter where type is "Contains" with added column and following value:
		| Values |
		| '      |
	Then "Owner Display Name" filter is added to the list
	And "129" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS15374 @Cleanup
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatDatesDisplayIsRegionSpecific
	When User language is changed to "<Language>" via API
	And User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Pre-Migration \ Scheduled Date" filter where type is "<Option>" with added column and following value:
		| Values         |
		| <ExpectedDate> |
	Then "2004: Pre-Migration \ Scheduled Date" filter is added to the list
	And Values is displayed in added filter info
		| Values         |
		| <ExpectedDate> |

	Examples:
		| Language   | Option | ExpectedDate  |
		| english us | Equals | Jul 10, 2019  |
		| english uk | Equals | 10 Jul 2019   |
		| deutsch    | Gleich | 10. Juli 2019 |
		| français   | Avant  | 10 juil. 2019 |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10651
Scenario: EvergreenJnr_ApplicationsList_CheckTrueFalseOptionsAndImagesInFilterInfo
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Hide From End Users" filter
	Then correct true and false options are displayed in filter settings
	When User have created "Equals" filter without column and following options:
		| SelectedCheckboxes |
		| TRUE               |
		| FALSE              |
		| Empty              |
	Then "Windows7Mi: Hide From End Users" filter is added to the list
	Then Values is displayed in added filter info
		| Values |
		| Empty  |
		| False  |
		| True   |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10754 @DAS11142 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckSpecialCharactersDisplayInFilterInfo
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Display Name" filter where type is "Equals" with added column and following value:
		| Values           |
		| O'Conn"/\or#@!() |
	Then "Display Name" filter is added to the list
	And Values is displayed in added filter info
		| Values           |
		| O'Conn"/\or#@!() |
	When User create dynamic list with "TestList66E313" name on "Users" page
	Then "TestList66E313" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
		| Values           |
		| O'Conn"/\or#@!() |
	When User navigates to the "All Users" list
	When User navigates to the "TestList66E313" list
	Then "TestList66E313" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
		| Values           |
		| O'Conn"/\or#@!() |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatFilterDataIsDisplayedCorrectlyWhenNavigatingBetweenLists
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Hostname" filter
	And User have create "Equals" Values filter with column and following options:
		| Values          |
		| 00BDM1JUR8IF419 |
	Then "Hostname" filter is added to the list
	Then Values is displayed in added filter info
		| Values          |
		| 00BDM1JUR8IF419 |
	When User create dynamic list with "TestList5256A5" name on "Devices" page
	Then "TestList5256A5" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
		| Values          |
		| 00BDM1JUR8IF419 |
	When User navigates to the "All Devices" list
	When User navigates to the "TestList5256A5" list
	Then "TestList5256A5" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
		| Values          |
		| 00BDM1JUR8IF419 |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS12199 @DAS12220 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatFilterDataIsDisplayedCorrectlyWhenNavigatingBetweenLists
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Does not equal" with added column and following checkboxes:
		| SelectedCheckboxes |
		| Red                |
		| Amber              |
		| Green              |
	Then "Compliance" filter is added to the list
	Then Values is displayed in added filter info
		| Values |
		| Amber  |
		| Green  |
		| Red    |
	When User create dynamic list with "Users - Nav between lists" name on "Users" page
	Then "Users - Nav between lists" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
		| Values |
		| Amber  |
		| Green  |
		| Red    |
	When User navigates to the "All Users" list
	When User navigates to the "Users - Nav between lists" list
	Then "Users - Nav between lists" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
		| Values |
		| Amber  |
		| Green  |
		| Red    |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterDataIsDisplayedCorrectlyWhenNavigatingBetweenLists
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Count (Entitled)" filter where type is "Greater than or equal to" with added column and following value:
		| Values |
		| 1      |
	Then "Device Count (Entitled)" filter is added to the list
	And Values is displayed in added filter info
		| Values |
		| 1      |
	When User create dynamic list with "Apps - Nav between lists" name on "Applications" page
	Then "Apps - Nav between lists" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
		| Values |
		| 1      |
	When User navigates to the "All Applications" list
	When User navigates to the "Apps - Nav between lists" list
	Then "Apps - Nav between lists" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
		| Values |
		| 1      |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS12114 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckThatFilterDataIsDisplayedCorrectlyWhenNavigatingBetweenLists
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Created Date" filter where type is "Before" with added column and following value:
		| Values      |
		| 17 Nov 2017 |
	Then "Created Date" filter is added to the list
	And Values is displayed in added filter info
		| Values      |
		| 17 Nov 2017 |
	When User create dynamic list with "Mailboxes - Nav between lists" name on "Mailboxes" page
	Then "Mailboxes - Nav between lists" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
		| Values      |
		| 17 Nov 2017 |
	When User navigates to the "All Mailboxes" list
	When User navigates to the "Mailboxes - Nav between lists" list
	Then "Mailboxes - Nav between lists" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And Values is displayed in added filter info
		| Values      |
		| 17 Nov 2017 |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10696
Scenario Outline: EvergreenJnr_DevicesList_CheckThatFilterOperatorsIsCorrectInFilterInfo
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Hostname" filter where type is "<operatorValue>" with added column and following value:
		| Values         |
		| <filterOption> |
	Then "Hostname" filter is added to the list
	And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
		| Values                |
		| <operatorValueInInfo> |

	Examples:
		| operatorValue    | filterOption    | rowsCount | operatorValueInInfo |
		| Equals           | 00BDM1JUR8IF419 | 1         | is                  |
		| Does not equal   | 00BDM1JUR8IF419 | 17,278    | is not              |
		| Contains         | 00B             | 6         | contains            |
		| Does not contain | 00BDM1J         | 17,278    | does not contain    |
		| Begins with      | 00              | 14        | begins with         |
		| Ends with        | 41              | 7         | ends with           |
		| Empty            |                 |           | is empty            |
		| Not empty        |                 | 17,279    | is not empty        |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS12199 @DAS12220
Scenario Outline: EvergreenJnr_UsersList_CheckThatFilterOperatorsIsCorrectInFilterInfo
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "<operatorValue>" with added column and following checkboxes:
		| SelectedCheckboxes |
		| <filterOption>     |
	Then "Compliance" filter is added to the list
	#And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
		| Values                |
		| <operatorValueInInfo> |

	Examples:
		| operatorValue  | filterOption | rowsCount | operatorValueInInfo |
		| Equals         | Red          | 9,438     | is                  |
		| Does not equal | Red          | 31,901    | is not              |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10696
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatFilterOperatorsIsCorrectInFilterInfo
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Count (Entitled)" filter where type is "<operatorValue>" with added column and following value:
		| Values         |
		| <filterOption> |
	Then "Device Count (Entitled)" filter is added to the list
	And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
		| Values                |
		| <operatorValueInInfo> |

	Examples:
		| operatorValue            | filterOption | rowsCount | operatorValueInInfo         |
		| Equals                   | 1            | 2         | is                          |
		| Does not equal           | 1            | 2,221     | is not                      |
		| Greater than             | 1            | 1,057     | is greater than             |
		| Greater than or equal to | 1            | 1,059     | is greater than or equal to |
		| Less than                | 1            | 1,164     | is less than                |
		| Less than or equal to    | 1            | 1,166     | is less than or equal to    |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS12114
Scenario Outline: EvergreenJnr_MailboxesList_CheckThatFilterOperatorsIsCorrectInFilterInfo
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Created Date" filter where type is "<operatorValue>" with added column and following value:
		| Values         |
		| <filterOption> |
	Then "Created Date" filter is added to the list
	And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
		| Values                |
		| <operatorValueInInfo> |

	Examples:
		| operatorValue  | filterOption | rowsCount | operatorValueInInfo |
		| Not empty      |              | 14,878    | is not empty        |
		| Does not equal | 8 Mar 2016   | 14,881    | is not              |
		| Equals         | 8 Mar 2016   | 3         | is                  |
		| Empty          |              | 6         | is empty            |
		| Before         | 8 Mar 2016   | 4,799     | is before           |
		| After          | 8 Mar 2016   | 10,076    | is after            |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS11090 @DAS12114 @DAS12698
Scenario Outline: EvergreenJnr_DevicesList_CheckThatFilterOperatorsIsCorrectInFilterInfoDatetime
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Computer Information ---- Text fill; Text fill; \ Date & Time Task" filter where type is "<operatorValue>" with added column and following value:
		| Values         |
		| <filterOption> |
	Then "Windows7Mi: Computer Information ---- Text fill; Text fill; \ Date & Time Task" filter is added to the list
	And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
		| Values                |
		| <operatorValueInInfo> |

	Examples:
		| operatorValue  | filterOption | rowsCount | operatorValueInInfo |
		| Equals         | 22 Nov 2012  | 16        | is                  |
		| Does not equal | 22 Nov 2012  | 17,263    | is not              |
		| Before         | 22 Nov 2012  | 1         | is before           |
		| After          | 14 May 2012  | 16        | is after            |
		| Empty          |              | 17,262    | is empty            |
		| Not empty      |              | 17        | is not empty        |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10696
Scenario Outline: EvergreenJnr_UsersList_CheckThatFilterOperatorsIsCorrectInFilterInfoEnabled
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Enabled" filter where type is "<operatorValue>" with added column and following checkboxes:
		| SelectedCheckboxes |
		| <filterOption>     |
	Then "Enabled" filter is added to the list
	And "<rowsCount>" rows are displayed in the agGrid
	And Options is displayed in added filter info
		| Values                |
		| <operatorValueInInfo> |

	Examples:
		| operatorValue  | filterOption | rowsCount | operatorValueInInfo |
		| Equals         | TRUE         | 41,231    | is                  |
		| Does not equal | TRUE         | 108       | is not              |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10696 @DAS11512 @DAS13376 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatApplicationSavedListFilterIsWorkingCorrect
	When User add following columns using URL to the "Applications" page:
		| ColumnName      |
		| Application Key |
	When User create dynamic list with "TestList2854B3" name on "Applications" page
	Then "TestList2854B3" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
		| SelectedList   | Association        |
		| TestList2854B3 | Not used on device |
	Then "Any Application" filter is added to the list
	And "17,185" rows are displayed in the agGrid
	And Options is displayed in added filter info
		| Values  |
		| in list |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11142 @DAS11665 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatBracketsAreDisplayedCorrectlyInFilterInfo
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
		| Values                                    |
		| wxPython 2.5.3.1 (unicode) for Python 2.3 |
	Then "Application" filter is added to the list
	When User add "Application" filter where type is "Equals" with added column and following value:
		| Values                                               |
		| NI LabVIEW PID Control Toolset 6.0 (for LabVIEW 7.1) |
		| Windows Installer SDK (Version 2.0) (3718.1)         |
		| Janus Systems Controls for Microsoft .NET (TRIAL)    |
	Then "Application" filter is added to the list
	When User add "Application" filter where type is "Contains" with added column and following value:
		| Values                 |
		| (Version 6.0) (3672.1) |
	Then "Application" filter is added to the list
	When User add "Application" filter where type is "Ends With" with added column and following value:
		| Values            |
		| (self-installing) |
	Then "Application" filter is added to the list
	When User create dynamic list with "TestList3065CC" name on "Applications" page
	Then "TestList3065CC" list is displayed to user
	And "6" rows are displayed in the agGrid
	When User navigates to the "All Applications" list
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "TestList3065CC" list
	And User clicks the Filters button
	Then "TestList3065CC" list is displayed to user
	And "6" rows are displayed in the agGrid
	And Edit List menu is not displayed
	And Values is displayed in added filter info
		| Values                                               |
		| wxPython 2.5.3.1 (unicode) for Python 2.3            |
		| NI LabVIEW PID Control Toolset 6.0 (for LabVIEW 7.1) |
		| Windows Installer SDK (Version 2.0) (3718.1)         |
		| Janus Systems Controls for Microsoft .NET (TRIAL)    |
		| (Version 6.0) (3672.1)                               |
		| (self-installing)                                    |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS10790 @DAS13206 @DAS13178 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatApplicationFiltersBeingAppliedAgainstTheDevicesListAreRestoredCorrectlyAndAreShownInTheFiltersPanel
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "Application" filter where type is "Equals" with following Lookup Value and Association:
		| SelectedValues | Association        |
		| 7zip (2015)    | Entitled to device |
	Then "Application" filter is added to the list
	Then "11" rows are displayed in the agGrid
	Then "(Application = 7zip (2015) ASSOCIATION = ("entitled to device"))" text is displayed in filter container
	Then "Application 7zip (2015) entitled to device" is displayed in added filter info
	When User create dynamic list with "TestList44C8B6" name on "Devices" page
	Then "TestList44C8B6" list is displayed to user
	When User navigates to the "All Devices" list
	When User navigates to the "TestList44C8B6" list
	Then "TestList44C8B6" list is displayed to user
	Then "11" rows are displayed in the agGrid
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "(Application = 7zip (2015) ASSOCIATION = ("entitled to device"))" text is displayed in filter container
	And "Application 7zip (2015) entitled to device" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS18833
Scenario: EvergreenJnr_DevicesList_CheckDisplayingListAfterAppliyingFilter
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	And User selects "2004: Owner (Saved List)" filter from "Saved List" category
	And User checks 'Users with Device Count' checkbox
	And User clicks 'ADD' button
	Then "2004: Owner in list Users with Device Count" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS12812 @DAS12056
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTextInTheAdvancedFilterWithCheckboxesIsDisplayedCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with selected Checkboxes and following Association:
		| SelectedCheckboxes | Association  |
		| <Checkbox>         | Has used app |
	Then "<FilterInfo>" is displayed in added filter info
	And Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info

	Examples:
		| FilterName      | Checkbox | FilterInfo                                |
		| User Enabled    | FALSE    | User whose Enabled is False has used app  |
		| User Compliance | Red      | User whose Compliance is Red has used app |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS12812 @DAS12056
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTextInTheAdvancedFilterInfoIsDisplayedCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "<FilterType>" with following Value and Association:
		| Values        | Association  |
		| <FilterValue> | Has used app |
	Then "<FilterInfo>" is displayed in added filter info
	And Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info

	Examples:
		| FilterName    | FilterType  | FilterValue   | FilterInfo                                             |
		| User SID      | Begins with | S-1-5-99      | User whose SID begins with S-1-5-99 has used app       |
		| User GUID     | Begins with | 180a2898-9ab2 | User whose GUID begins with 180a2898-9ab2 has used app |
		| User Username | Contains    | ZDP           | User whose Username contains ZDP has used app          |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS12854 @DAS12812 @DAS12056
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectValuesAreDisplayedforUserKeyFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Key" filter where type is "Less than" with following Number and Association:
		| Number | Association     |
		| 2      | Entitled to app |
	Then Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info
	When User Add And "User Key" filter where type is "Greater than" with following Number and Association:
		| Number | Association     |
		| 8      | Entitled to app |
	Then Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info
	Then "User whose Key is less than 2 entitled to app" is displayed in added filter info
	And "User whose Key is greater than 8 entitled to app" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS12520 @DAS12785 @Cleanup
Scenario: EvergreenJnr_UsersList_CheckThatFloorFilterEqualsEmptyValueIsDisplayedCorrectlyInTheFilterPanel
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Floor" filter
	When User select "Equals" Operator value
	When User enters "Empty" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	When User clicks Save filter button
	When User creates 'TestList5434' dynamic list
	And User navigates to the "All Users" list
	And User navigates to the "TestList5434" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Floor is Empty" is displayed in added filter info
	When User click Edit button for "Floor" filter
	Then "Empty" value is displayed in the filter info

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS12520 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatUserRegionFilterEqualsEmptyValueIsDisplayedCorrectlyInTheFilterPanel
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Region" filter where type is "Equals" with Selected Value and following Association:
		| SelectedList | Association  |
		| Empty        | Has used app |
	And User creates 'TestList5435' dynamic list
	And User navigates to the "All Applications" list
	And User navigates to the "TestList5435" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "User whose Region is Empty has used app" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS12205 @DAS12624 @DAS13376 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThatFilterTextDisplaysActualListName
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks on 'Application' column header
	And User create dynamic list with "ApplicationList" name on "Applications" page
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
		| SelectedList    | Association        |
		| ApplicationList | Entitled to device |
	When User create dynamic list with "DevicesList" name on "Devices" page
	When User clicks the Permissions button
	When User selects 'Everyone can edit' in the 'Sharing' dropdown
	Then 'Everyone can edit' content is displayed in 'Sharing' dropdown
	When User clicks the Logout button
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "DevicesList" list
	Then "DevicesList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Any Application in list [List not found] entitled to device" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS12520 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatFilterEqualsEmptyValueIsDisplayedCorrectlyInTheFilterPanel
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
		| SelectedCheckboxes |
		| Empty              |
	And User creates '<CustomList>' dynamic list
	And User navigates to the "<AllList>" list
	And User navigates to the "<CustomList>" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	And "<FilterInfo>" is displayed in added filter info

	Examples:
		| ListName  | FilterName | CustomList   | AllList       | FilterInfo         |
		| Devices   | OS Branch  | TestList5433 | All Devices   | OS Branch is Empty |
		| Mailboxes | Country    | TestList5436 | All Mailboxes | Country is Empty   |


@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11468 @DAS12152 @DAS12602 @DAS13376 @DAS14222 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThat500ErrorIsNotDisplayedForStaticListAfterRemovingAssociationsList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticListTestName" name
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
		| SelectedList       | Association        |
		| StaticListTestName | Not used on device |
	Then "Any Application in list StaticListTestName not used on device" is displayed in added filter info
	When User create dynamic list with "TestList8D5C03" name on "Devices" page
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	Then User remove list with "StaticListTestName" name on "Applications" page
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "TestList8D5C03" list
	Then "TestList8D5C03" list is displayed to user

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11468 @DAS13376 @DAS14222 @Cleanup
Scenario: EvergreenJnr_AllLists_CheckThat500ErrorIsNotDisplayedForDynamicListAfterRemovingAssociationsList
	When User add following columns using URL to the "Applications" page:
		| ColumnName      |
		| Application Key |
	When User create dynamic list with "TestList5E021D" name on "Applications" page
	Then "TestList5E021D" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
		| SelectedList   | Association        |
		| TestList5E021D | Not used on device |
	Then "Any Application in list TestList5E021D not used on device" is displayed in added filter info
	When User create dynamic list with "TestList5E021D" name on "Devices" page
	Then "TestList5E021D" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	Then User remove list with "TestList5E021D" name on "Applications" page
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "TestList5E021D" list
	Then "TestList5E021D" list is displayed to user

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS18065
Scenario: EvergreenJnr_DevicesList_CheckThatThereIsNoTooltipsForChipsInFilterPanel
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When user select "Hostname" filter
	When User select "Equals" Operator value
	When User enters "Text1" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then following chips value displayed for 'Hostname' textbox
		| ChipValue |
		| Text1     |
	Then tooltip is not displayed for 'Text1' chip of 'Hostname' textbox
	When User enters "Text2" text in Search field at selected Filter
	When User clicks Add button for input filter value
	When User enters "Text3" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then following chips value displayed for 'Hostname' textbox
		| ChipValue |
		| Text1     |
		| Text2     |
		| 1 more    |
	Then tooltip is not displayed for '1 more' chip of 'Hostname' textbox

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS13391 @DAS15776
Scenario Outline: EvergreenJnr_AllLists_CheckThatSelectedColumnsSectionIsExpandedByDefaultInFiltersPanel
	When User clicks '<ListName>' on the left-hand menu
	And User clicks the Filters button
	And User clicks Add New button on the Filter panel
	Then User sees "Suggested" section expanded by default in Filters panel

	Examples:
		| ListName     |
		| Devices      |
		| Users        |
		| Applications |
		| Mailboxes    |

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11466
Scenario: EvergreenJnr_DevicesList_CheckingThatVendorFilterIsDisplayedInApplicationCategory
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User selects "Application Vendor" filter from "Application" category
	Then setting section for "Application Vendor" filter is loaded

@Evergreen @Evergreen_FiltersFeature @FiltersDisplay @DAS11539
Scenario: EvergreenJnr_DevicesList_CheckThatFilterCategoriesAreClosedAfterClearingAFilterSearchValue
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User clicks Add New button on the Filter panel
	And User enters "date" text in Search field at Filters Panel
	Then Minimize buttons are displayed for all category in Filters panel
	When User clears search textbox in Filters panel
	Then Maximize buttons are displayed for all category in Filters panel