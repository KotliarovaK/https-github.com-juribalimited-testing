Feature: CustomListDisplayPart10
	Runs Custom List Creation block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @CustomListDisplay @EvergreenJnr_ListPanel @DAS12917 
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterNameIsNotChangedAfterRenameWhileUpdateValuesOfFilter
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	| Amber              |
	And User create custom list with "Test_Application_Filter_DAS_12917" name
	And User clicks the List Details button
	And User changes list name to "EDITED_Application_Filter_DAS_12917"
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Compliance" filter
	And User change selected checkboxes:
	| Option | State |
	| Amber  | false |
	Then "EDITED_Application_Filter_DAS_12917" edited list is displayed to user

@Evergreen @Mailboxes @CustomListDisplay @EvergreenJnr_ListPanel @DAS12917 @Cleanup
Scenario: EvergreenJnr_MailboxesList_CheckThatFilterNameIsNotChangedAfterRenameWhileUpdateValuesOfFilter
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Created Date" filter where type is "Before" with added column and following value:
	| Values      |
	| 11 Dec 2017 |
	And User create custom list with "Test_Mailbox_Filter_DAS_12917" name
	And User clicks the List Details button
	And User changes list name to "EDITED_Mailbox_Filter_DAS_12917"
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "Created Date" filter
	And User changes filter date to "13 Dec 2017"
	Then "EDITED_Mailbox_Filter_DAS_12917" edited list is displayed to user

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS12891 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatCancelButtonIsDisplayedWithCorrectlyColorOnListPanel
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	Then data in table is sorted by 'Hostname' column in ascending order
	When User create dynamic list with "TestList12891" name on "Devices" page
	Then "TestList12891" list is displayed to user
	When User click Delete button for custom list with "TestList12891" name
	Then Cancel button is displayed with correctly color
	Then User confirm removed list

@Evergreen @Devices @EvergreenJnr_ListPanel @CustomListDisplay @DAS13637 @DAS13639 @DAS13643 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatListTypeFilterForCreatedListsIsWorkedCorrectly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User create static list with "StaticFilterList_1" name on "Devices" page with following items
	| ItemName       |
	| 001BAQXT6JWFPI |
	| 001PSUMZYOW581 |
	Then "StaticFilterList_1" list is displayed to user
	When User navigates to the "All Devices" list
	When User click on 'Hostname' column header
	When User create dynamic list with "DynamicFilterList_1" name on "Devices" page
	Then "DynamicFilterList_1" list is displayed to user
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups              |
	| Application Compliance |
	And User selects the following Columns on Pivot:
	| Columns          |
	| Operating System |  
	And User selects the following Values on Pivot:
	| Values               |
	| App Count (Entitled) |
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotDynamicFilterList_1" name
	Then "PivotDynamicFilterList_1" list is displayed to user
	When User navigates to the "All Devices" list
	And User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups  |
	| Build Date |
	And User selects the following Columns on Pivot:
	| Columns                |
	| Application Compliance | 
	And User selects the following Values on Pivot:
	| Values                            |
	| Owner General information field 1 |
	When User clicks the "RUN PIVOT" Action button
	Then Pivot run was completed
	When User creates Pivot list with "PivotFilterList_1" name
	Then "PivotFilterList_1" list is displayed to user
	When User navigates to the "All Devices" list
	When User apply "Dynamic" filter to lists panel
	Then "DynamicFilterList_1" list is displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_1" list is displayed in the bottom section of the List Panel
	And "PivotFilterList_1" list is displayed in the bottom section of the List Panel
	And "StaticFilterList_1" list is not displayed in the bottom section of the List Panel
	When User enters "1" text in Search field at List Panel
	Then "DynamicFilterList_1" list is displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_1" list is displayed in the bottom section of the List Panel
	And "PivotFilterList_1" list is displayed in the bottom section of the List Panel
	And "StaticFilterList_1" list is not displayed in the bottom section of the List Panel
	When User apply "Static" filter to lists panel
	Then "DynamicFilterList_1" list is not displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_1" list is not displayed in the bottom section of the List Panel
	And "PivotFilterList_1" list is not displayed in the bottom section of the List Panel
	And "StaticFilterList_1" list is displayed in the bottom section of the List Panel
	When User enters "1" text in Search field at List Panel
	Then "DynamicFilterList_1" list is not displayed in the bottom section of the List Panel
	And "PivotDynamicFilterList_1" list is not displayed in the bottom section of the List Panel
	And "PivotFilterList_1" list is not displayed in the bottom section of the List Panel
	And "StaticFilterList_1" list is displayed in the bottom section of the List Panel