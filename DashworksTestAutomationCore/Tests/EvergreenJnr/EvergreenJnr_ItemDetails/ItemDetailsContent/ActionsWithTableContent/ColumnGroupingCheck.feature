Feature: ColumnGroupingCheck
	Runs related tests for Column Grouping Check

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI 4/01/20: DAS20645 will be fixed only for 'Wormhole'
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20645 @DAS20614 @Zion_NewGrid @Wormhole
Scenario: EvergreenJnr_UsersList_CheckThatItIsPossibleToApplyTheGroupingToTheMigrationColumnInTheSelectedProjectOnDevicesTab
	When User navigates to the 'User' details page for 'TOM576324' item
	Then Details page for 'TOM576324' item is displayed to the user
	When User selects 'Project 000 M Computer Scheduled' in the 'Item Details Project' dropdown with wait
	And User navigates to the 'Devices' left menu item
	When User clicks following checkboxes from Column Settings panel for the 'Hostname' column:
	| checkboxes         |
	| Device Type        |
	| Owner Display Name |
	| Operating System   |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Migration' column:
	| Values |
	| RED    |
	When User clicks Group By button and set checkboxes state
	| Checkboxes | State |
	| Migration  | true  |
	Then Grid is grouped

#AnnI 4/01/20: DAS20672 will be fixed only for 'Wormhole'
@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20672 @Zion_NewGrid @Wormhole
Scenario: EvergreenJnr_GroupsList_CheckThatDataInTheGridIsCropedByKeyColumnOnDeviceMembersTabForGroupPage
	When User type "GSMS-ReportViewer" in Global Search Field
	Then User clicks on "GSMS-ReportViewer" search result
	And Details page for 'GSMS-ReportViewer' item is displayed to the user
	When User navigates to the 'Members' left menu item
	When User navigates to the 'User Members' left submenu item
	When User clicks following checkboxes from Column Settings panel for the 'Username' column:
	| checkboxes |
	| Key        |
	When User clicks Group By button and set checkboxes state
	| Checkboxes | State |
	| Key        | true  |
	Then Grid is grouped

#AnnI 4/01/20: DAS20671 will be fixed only for 'Wormhole'
@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20671 @Zion_NewGrid @Wormhole
Scenario: EvergreenJnr_GroupsList_CheckThatDataInTheGridIsCropedByAdvertisementColumnOnApplicationsTabForGroupPage
	When User type "GSMS-ReportViewer" in Global Search Field
	Then User clicks on "GSMS-ReportViewer" search result
	And Details page for 'GSMS-ReportViewer' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Applications' left submenu item
	When User clicks Group By button and set checkboxes state
	| Checkboxes    | State |
	| Advertisement | true  |
	Then Grid is grouped

#AnnI 4/01/20: DAS20643 will be fixed only for 'Wormhole'
@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20643 @Zion_NewGrid @Wormhole
Scenario: EvergreenJnr_DevicesList_CheckThatDataInTheGridIsCropedByRingColumnOnOwnerProjectsSummaryTabForDevicesPage
	When User navigates to the 'Device' details page for the item with '9114' ID
	Then Details page for 'RWAV0TLVTYON4G' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Owner Projects Summary' left submenu item
	When User clicks Group By button and set checkboxes state
	| Checkboxes | State |
	| Ring       | true  |
	Then Grid is grouped

#AnnI 4/14/20: DAS20672 will be fixed only for 'X_Ray'
@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20683 @Zion_NewGrid @X_Ray
Scenario: EvergreenJnr_GroupsList_CheckThatDataInTheGridIsCropedByKeyColumnOnApplicationsTabCollectionsSubTabForGroupPage
	When User type "GSMS-ReportViewer" in Global Search Field
	Then User clicks on "GSMS-ReportViewer" search result
	And Details page for 'GSMS-ReportViewer' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User navigates to the 'Collections' left submenu item
	When User clicks following checkboxes from Column Settings panel for the 'Collection' column:
	| checkboxes |
	| Key        |
	When User clicks Group By button and set checkboxes state
	| Checkboxes | State |
	| Key        | true  |
	Then Grid is grouped

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20866 @Zion_NewGrid @X_Ray
Scenario: EvergreenJnr_DevicesList_ChecksThatCheckboxIsNotDisappearsInTheGroupByDdlAfterRefreshingThePageInCaseTtheCheckboxRelatesToHiddenColumnByDefault
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User navigates to the 'Users' left menu item
	When User clicks following checkboxes from Column Settings panel for the 'Username' column:
	| checkboxes |
	| Key        |
	Then following Group By values ​​are displayed for User on menu panel
	| Values             |
	| Key                |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |
	When User refreshes agGrid
	Then following Group By values ​​are displayed for User on menu panel
	| Values             |
	| Key                |
	| Username           |
	| Domain             |
	| Display Name       |
	| Distinguished Name |