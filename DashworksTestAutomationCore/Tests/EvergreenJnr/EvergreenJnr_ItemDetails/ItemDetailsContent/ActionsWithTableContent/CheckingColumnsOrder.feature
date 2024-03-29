﻿Feature: CheckingColumnsOrder
	Runs Item Details Checking Columns Order related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17182 @DAS17218 @DAS11053 @DAS14923 @Zion_NewGrid
Scenario: EvergreenJnr_UsersList_CheckThatDevicesTabIsDisplayedWithCorrectColumnsOnUsersDetailsPageForProjectMode
	When User navigates to the 'User' details page for 'ZZP911429' item
	Then Details page for 'ZZP911429' item is displayed to the user
	When User navigates to the 'Devices' left menu item
	Then following columns are displayed on the Item details page:
	| ColumnName         |
	| Hostname           |
	| Device Type        |
	| Owner Display Name |
	| Operating System   |
	| Compliance         |
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	When User clicks following checkboxes from Column Settings panel for the 'Hostname' column:
	| checkboxes       |
	| Operating System |
	Then following columns are displayed on the Item details page:
	| ColumnName            |
	| Hostname              |
	| Device Type           |
	| Owner                 |
	| Owner Display Name    |
	| Readiness             |
	| Path                  |
	| Category              |
	| Application Readiness |
	| Stage 1               |

	#AnnI 5/29/20: fixed only for 'Yellow_Dwarf'
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectsTab @DAS21286 @Zion_NewGrid @Yellow_Dwarf
Scenario: EvergreenJnr_ApplicationsList_CheckThatBucketColumnIsRenamedToTheGroupValueOnTheApplicationDetailsPageProjectsTab
	When User navigates to the 'Application' details page for the item with '882' ID
	Then Details page for 'Access' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	And User navigates to the 'Projects' left submenu item
	Then following columns are displayed on the Item details page:
	| ColumnName    |
	| Project       |
	| Project Type  |
	| Group         |
	| Path          |
	| Workflow      |
	| Category      |
	| Delivery Date |
	| Slot          |
	| Readiness     |