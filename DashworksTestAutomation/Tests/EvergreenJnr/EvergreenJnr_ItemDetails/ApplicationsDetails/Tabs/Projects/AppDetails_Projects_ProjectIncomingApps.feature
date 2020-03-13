Feature: AppDetails_Projects_ProjectIncomingApps
	Runs related tests for Projects > Project Incoming Apps tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI 3/12/20 need gold data. will be ready by next week.
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectsTab @DAS20286 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_ChecksThatEmptyValueIsDisplayedForAppWithoutANameOnProjectIncomingAppsTab
	When User navigates to the 'User' details page for the item with '839' ID
	Then Details page for 'Access 95' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Incoming Apps' left submenu item
	When User enters "11.2.5058.0" text in the Search field for "Version" column
	Then 'Empty' content is displayed in the 'Application' column