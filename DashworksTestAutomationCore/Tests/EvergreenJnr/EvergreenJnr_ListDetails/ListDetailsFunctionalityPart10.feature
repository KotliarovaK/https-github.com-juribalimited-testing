Feature: ListDetailsFunctionalityPart10
	Runs List Details Panel related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18127 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForStaticList
	When User clicks '<Lists>' on the left-hand menu
	When User clicks the Actions button
	When User select "<Column>" rows in the grid
	| SelectedRowsName     |
	| <Row> |
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "<ListName>" name
	Then "<ListName>" list is displayed to user
	When User navigates to the "<ListName>" list
	When User clicks the List Details button
	Then Details panel is displayed to the user
	Then '<ListType>' label is displayed in List Details
	Then '<Data>' label is displayed in List Details

Examples: 
| Lists     | Column        | Row                              | ListName                 | ListType          | Data            |
| Users     | Username      | $231000-3AC04R8AR431             | AStaticUsers18127        | List Type: Static | Data: Users     |
| Mailboxes | Email Address | 000F977AC8824FE39B8@bclabs.local | AStaticApplications18127 | List Type: Static | Data: Mailboxes |

@Evergreen @Devices @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18127 @Cleanup
Scenario Outline: EvergreenJnr_AllLists_CheckThatListDataTypeIsDisplayedCorrectlyForPivot
	When User clicks '<Lists>' on the left-hand menu
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
	| RowGroups  |
	| <RowGroup> |
	When User selects the following Columns on Pivot:
	| Columns  |
	| <Column> |
	When User selects the following Values on Pivot:
	| Values  |
	| <Value> |
	When User clicks 'RUN PIVOT' button 
	Then Pivot run was completed
	When User creates Pivot list with "<PivotName>" name
	Then "<PivotName>" list is displayed to user
	When User navigates to the "<PivotName>" list
	When User clicks the List Details button
	Then Details panel is displayed to the user
	Then '<ListType>' label is displayed in List Details
	Then '<Data>' label is displayed in List Details

Examples: 
| Lists     | RowGroup | Column           | Value        | PivotName            | ListType                 | Data            |
| Devices   | Hostname | Owner Compliance | Owner City   | APivotDevices18127   | List Type: Dynamic Pivot | Data: Devices   |
| Mailboxes | Alias    | Owner City       | Created Date | APivotMailboxes18127 | List Type: Dynamic Pivot | Data: Mailboxes |

@Evergreen @AllLists @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS18376 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatNoRedBannerWithErrorIsDisplayedAfterSelectingListWithTheAppliedAdvancedFilterOn
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Actions button
	When User select "Hostname" rows in the grid
	| SelectedRowsName |
	| 001PSUMZYOW581   |
	| 00CWZRC4UK6W20   |
	When User selects 'Create static list' in the 'Action' dropdown
	When User create static list with "StaticDeviceList18376" name
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList          | Association    |
	| StaticDeviceList18376 | Used on device |
	When User create dynamic list with "ApplicationsDynamicList18376" name on "Applications" page
	When User navigates to "2004 Rollout" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	When User selects 'ApplicationsDynamicList18376' in the 'Application Scope' dropdown with wait
	When User navigates to the 'Scope Changes' left submenu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then inline error banner is not displayed

@Evergreen @Devices @EvergreenJnr_ListDetails @ListDetailsFunctionality @DAS20393 @Cleanup
Scenario: EvergreenJnr_DevicesList_CheckThatPermissionPanelContinuesToWorkAfterReselectingSharingOption
	When User clicks 'Devices' on the left-hand menu
	When User add following columns using URL to the "Devices" page:
	| ColumnName                 |
	| CPU Virtualisation Capable |
	When User create dynamic list with "List20393" name on "Devices" page
	Then "List20393" list is displayed to user
	When User clicks the Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User clicks 'group_add' icon
	When User selects 'Private' in the 'Sharing' dropdown
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User adds user to list of shared person
	| User               | Permission |
	| Automation Admin 1 | Admin      |