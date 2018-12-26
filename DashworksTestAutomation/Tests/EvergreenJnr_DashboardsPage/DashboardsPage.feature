﻿Feature: DashboardsPage
	Runs Dashboards Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Dashboards @DAS13114 @DAS13721 @archived @Not_Run
Scenario: EvergreenJnr_DashboardsPage_CheckThatWindows10BranchChartUnknownLinkRedirectsToDevicesPageWithProperItems
	When User clicks "Unknown" section from "Windows 10 Branch" circle chart on Dashboards page
	Then "Devices" list should be displayed to the user
	And "16" rows are displayed in the agGrid

@Evergreen @Dashboards @Widgets @DAS14358
Scenario: EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForWidget
	When User clicks Edit mode trigger on Dashboards page
	And User clicks Ellipsis menu for "Top 10 App Vendors" Widget on Dashboards page
	Then User sees following Ellipsis menu items on Dashboards page:
	| items            |
	| Edit             |
	| Duplicate        |
	| Move to Start    |
	| Move to End      |
	| Move to position |
	| Delete           |

@Evergreen @Dashboards @Sections @DAS14358
Scenario: EvergreenJnr_DashboardsPage_CheckEllipsisMenuContentForSection
	When User clicks Edit mode trigger on Dashboards page
	And User clicks Ellipsis menu for Section having "Operating System" Widget on Dashboards page
	Then User sees following Ellipsis menu items on Dashboards page:
	| items            |
	| Hide             |
	| 1 Column         |
	| 3 Column         |
	| Duplicate        |
	| Move to Start    |
	| Move to End      |
	| Move to position |
	| Delete           |

@Evergreen @Dashboards @Widgets @DAS14358
Scenario: EvergreenJnr_DashboardsPage_CheckThatParticularWidgetCanBeDuplicated
	When User clicks Edit mode trigger on Dashboards page
	And User remembers number of Sections and Widgets on Dashboards page
	And User clicks Ellipsis menu for "Device Profile" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	Then User sees Widget with "Cloned - Device Profile" name on Dashboards page
	And User sees number of Widgets increased by "1" on Dashboards page
	When User deletes "Cloned - Device Profile" Widget on Dashboards page

@Evergreen @Dashboards @Sections @DAS14358
Scenario: EvergreenJnr_DashboardsPage_CheckThatParticularSectionWithWidgetsCanBeDuplicated
	When User clicks Edit mode trigger on Dashboards page
	And User remembers number of Sections and Widgets on Dashboards page
	And User clicks Ellipsis menu for Section having "Domain Profile" Widget on Dashboards page
	And User clicks "Duplicate" item from Ellipsis menu on Dashboards page
	Then User sees number of Sections increased by "1" on Dashboards page
	And User sees number of Widgets increased by "4" on Dashboards page
	When User deletes duplicated Section having "Domain Profile" Widget on Dashboards page