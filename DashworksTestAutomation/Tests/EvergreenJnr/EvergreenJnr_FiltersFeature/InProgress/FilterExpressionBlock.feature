Feature: FilterExpressionBlock
	Runs Filter Expression related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Evergreen_FiltersFeature @DAS17016
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

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS17252 @DAS16485
Scenario: EvergreenJnr_MailboxesList_CheckThatFilterExpressionSectionIsMovedToFilterPanel
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User navigates to the "Mailbox Pivot (Complex)" list
	And User clicks the Filters button
	Then Filter Expression icon displayed within Filter Panel
	When User clicks Filter Expression icon in Filter Panel
	Then Filter Expression displayed within Filter Panel

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11824
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

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS13831 @DAS15376
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
	When User add "MigrationP: Package Stage \ Date Task for Package Stage" filter where type is "Between" with added column and Date options
		| StartDateInclusive | EndDateInclusive |
		| 11 Nov 2012        | 22 Nov 2019      |
	Then "19" rows are displayed in the agGrid
	Then '12 Nov 2012' content is displayed in the 'MigrationP: Package Stage \ Date Task for Package Stage' column
	Then '22 Nov 2012' content is displayed in the 'MigrationP: Package Stage \ Date Task for Package Stage' column
	Then "(MigrationP: Package Stage \ Date Task for Package Stage between (2012-11-11, 2019-11-22))" text is displayed in filter container

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS13831 @DAS15376
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

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS15376 @DAS15331
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

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS11165
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

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11054 @DAS11578
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
	Then "(Compliance = Unknown, Red, Amber or Green) OR (Import != A01 SMS (Spoof))" text is displayed in filter container

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11054 @DAS11578
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

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11054 @DAS11578
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

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS11467 @Cleanup
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

@Evergreen @AllLists @Evergreen_FiltersFeature @FiltersDisplay @DAS12121 @DAS13376 @DAS14222 @Cleanup
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
	When User removes custom list with "ApplicationList1" name
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "DevicesList1" list
	#Then '(Application (Saved List) = {LIST_ID} ASSOCIATION = ("used on device"))' text is displayed in filter container for 'ApplicationList1' list
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Any Application in list [List not found] used on device" is displayed in added filter info
	When User click Edit button for " Application" filter
	Then "ApplicationList2" list is displayed for Saved List filter