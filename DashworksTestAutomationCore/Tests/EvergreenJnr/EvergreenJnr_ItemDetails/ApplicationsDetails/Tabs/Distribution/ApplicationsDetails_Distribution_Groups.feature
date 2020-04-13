Feature: ApplicationsDetails_Distribution_Groups
	Runs related tests for Distribution > Groups sab tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17856
Scenario: EvergreenJnr_ApplicationsList_CheckThatGroupsCountIsCorrectOnEvergreenApplicationDetailsPage
	When User navigates to the 'Application' details page for 'Folder Size for Windows (2.3)' item
	When User navigates to the 'Distribution' left menu item
	Then 'Groups' left submenu item with '1' count is displayed
	When User navigates to the 'Groups' left submenu item
	Then 'GSMS-FolderSize-2.3' content is displayed in the 'Group' column
	And "1" rows found label displays on Details Page