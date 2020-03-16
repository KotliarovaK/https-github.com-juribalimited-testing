Feature: AppDetails_Projects_EvergreenIncomingApps.feature
	Runs related tests for Projects > Evergreen Incoming Apps tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI. 2/14/20: need to wait for gold data in March
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectsTab @DAS19242 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatTableOnEvergreenIncomingAppsTabIsDisplayedCorrectly
	When User navigates to the 'Application' details page for the item with '1' ID
	Then Details page for 'Python 2.2a4' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Evergreen Incoming Apps' left submenu item
	Then 'Evergreen Incoming Apps' left submenu item with '4' count is displayed
	Then Counter shows "4" found rows
	Then following columns are displayed on the Item details page:
	| ColumnName          |
	| Application         |
	| Vendor              |
	| Version             |
	| Compliance          |
	| In Catalog          |
	| Criticality         |
	| Hide From End Users |

#AnnI. 2/19/20: need to wait for gold data in March
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectsTab @DAS20026 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersValueIsAdjustedOnTheEvergreenIncomingAppsTabAccordingToTheChangesMadeOnTheAppropriateApplicationDetailsPage
	When User navigates to the 'Application' details page for the item with '1' ID
	Then Details page for 'Python 2.2a4' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User selects 'TRUE' in the dropdown for the 'In Catalog' field
	When User selects 'TRUE' in the dropdown for the 'Hide From End Users' field
	When User navigates to the 'Evergreen Incoming Apps' left submenu item
	#TODO: Add the value that we will check.
	When User enters "(.*)" text in the Search field for "Application" column
	Then 'TRUE' content is displayed in the 'In Catalog' column
	Then 'TRUE' content is displayed in the 'Hide From End Users' column

#AnnI. 2/27/20: need to wait for gold data in March
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectsTab @DAS20071 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_ChecksThatIncomingAppCounterIsDynamicallyUpdatedAfterChangingTheRationalisationOfTheTargetAppToTheForwardPathValue
	When User navigates to the 'Application' details page for the item with '1' ID
	Then Details page for 'Python 2.2a4' item is displayed to the user
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Evergreen Incoming Apps' left submenu item
	Then 'Evergreen Incoming Apps' left submenu item with '4' count is displayed
	Then Counter shows "4" found rows
	When User navigates to the 'Evergreen Details' left submenu item
	When User clicks on edit button for 'Rationalisation' field
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'Corel WordPerfect' in the 'Application' autocomplete field and selects 'Corel WordPerfect 8 (327)' value
	When User clicks 'UPDATE' button on popup
	When User clicks 'UPDATE' button on popup
	When User navigates to the 'Evergreen Incoming Apps' left submenu item
	Then 'Evergreen Incoming Apps' left submenu item with '0' count is displayed
	Then 'No Evergreen incoming apps found for this application' message is displayed on empty greed

#AnnI 3/12/20 need gold data. will be ready by next week.
@Evergreen @Applications @EvergreenJnr_ItemDetails @ProjectsTab @DAS20286 @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_ChecksThatEmptyValueIsDisplayedForAppWithoutANameOnEvergreenIncomingAppsTab
	When User navigates to the 'Application' details page for the item with '839' ID
	Then Details page for 'Access 95' item is displayed to the user
	When User selects 'USE ME FOR AUTOMATION(USR SCHDLD)' in the 'Item Details Project' dropdown with wait
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Evergreen Incoming Apps' left submenu item
	When User enters "11.2.5058.0" text in the Search field for "Version" column
	Then 'Empty' content is displayed in the 'Application' column