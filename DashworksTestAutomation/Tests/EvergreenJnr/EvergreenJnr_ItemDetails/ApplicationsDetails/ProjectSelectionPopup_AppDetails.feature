Feature: ProjectSelectionPopup_AppDetails
	Runs related tests for Project selection popup

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI 3/24/20: This functionality is implemented only for 'Wormhole'
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19704 @Wormhole
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectSelectionPopupForApplicationsDetailsPageIsWorkingCorrectly
	When User navigates to the 'Application' details page for 'Canon RAW Image Task for ZoomBrowser EX' item
	Then Details page for 'Canon RAW Image Task for ZoomBrowser EX' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then 'Select Project' text is displayed on popup
	Then 'GO' button is disabled
	Then 'CANCEL' button is not disabled
	Then options are sorted in alphabetical order in the 'Project' dropdown
	When User selects 'Havoc (Big Data)' in the 'Project' dropdown
	Then 'GO' button is not disabled
	When User clicks 'GO' button
	Then popup is not displayed to User
	Then 'Havoc (Big Data)' content is displayed in 'Item Details Project' dropdown
	Then 'Project Details' left submenu item is active

#AnnI 3/24/20: This functionality is implemented only for 'Wormhole'
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectsTab @DAS20432 @DAS19704 @Wormhole
Scenario: EvergreenJnr_ApplicationsList_CheckThatTabRedirectionIsWorkedCorrectlyAfterSwitchingFromProjectsToEvergreenModes
	When User navigates to the 'Application' details page for 'Canon RAW Image Task for ZoomBrowser EX' item
	Then Details page for 'Canon RAW Image Task for ZoomBrowser EX' item is displayed to the user
	When User selects 'Havoc (Big Data)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Project Details' left submenu item
	Then 'Projects' left menu item is expanded
	Then 'Project Details' left submenu item is active
	When User selects 'Evergreen' in the 'Item Details Project' dropdown with wait
	Then 'Details' left menu item is expanded
	Then 'Projects' left menu item is collapsed
	Then 'Application' left submenu item is active
	Then There are no errors in the browser console