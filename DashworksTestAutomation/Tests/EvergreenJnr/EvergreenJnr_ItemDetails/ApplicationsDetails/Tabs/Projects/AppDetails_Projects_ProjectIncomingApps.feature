Feature: AppDetails_Projects_ProjectIncomingApps
	Runs related tests for Projects > Project Incoming Apps tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI 3/12/20 need gold data. will be ready by next week.
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectsTab @DAS20286 @DAS20362 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_ChecksThatEmptyValueIsDisplayedForAppWithoutANameOnProjectIncomingAppsTab
	When User navigates to the 'Application' details page for the item with '839' ID
	Then Details page for 'Access 95' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Incoming Apps' left submenu item
	When User enters "11.2.5058.0" text in the Search field for "Version" column
	Then 'Empty' content is displayed in the 'Application' column
	When User clicks following checkboxes from Column Settings panel for the 'Application' column:
	| checkboxes  |
	| Application |
	Then following checkboxes are displayed in the filter dropdown menu for the 'Path' column:
	| Values                  |
	| [Default (Application)] |

#AnnI 3/18/20: This functionality is implemented only for 'Wormhole'
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectsTab @DAS20356 @DAS20445 @Wormhole
Scenario: EvergreenJnr_ApplicationsList_CheckThatOpenedProjectIncomingAppsTabIsWorkedCorrectlyAfterSwitchingBetweenProjectsAndEvergreenModes
	When User navigates to the 'Application' details page for the item with '839' ID
	Then Details page for 'Access 95' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Incoming Apps' left submenu item
	Then 'Projects' left menu item is expanded
	Then 'Project Incoming Apps' left submenu item is active
	When User selects 'Evergreen' in the 'Item Details Project' dropdown with wait
	Then 'Details' left menu item is expanded
	Then 'Projects' left menu item is collapsed
	Then 'Application' left submenu item is active