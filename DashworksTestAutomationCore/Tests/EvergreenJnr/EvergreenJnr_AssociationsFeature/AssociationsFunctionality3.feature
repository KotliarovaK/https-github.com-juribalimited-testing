Feature: AssociationsFunctionality3
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Associations @DAS18426 @Cleanup
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatApplicationsItemIsDisplayedAfterApplyingEntitledToDeviceFilter
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects '<operator1>' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects '<operator2>' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add And button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects '<operator3>' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	When User clicks content from "Hostname" column
	Then Details page for '<hostname>' item is displayed to the user
	When User navigates to the 'Applications' left menu item
	When User enters "<application>" text in the Search field for "Application" column
	Then '<installed>' content is displayed in the 'Installed' column
	Then '<used>' content is displayed in the 'Used' column
	Then '<entitled>' content is displayed in the 'Entitled' column

Examples: 
	| operator1           | operator2               | operator3               | hostname        | application                   | installed | used    | entitled |
	| Used on device      | Not entitled to device  | Not installed on device | 00BDM1JUR8IF419 | 20040610sqlserverck           | UNKNOWN   | TRUE    | FALSE    |
	| Entitled to device  | Installed on device     | Not used on device      | 001BAQXT6JWFPI  | AddressGrabber Standard       | TRUE      | UNKNOWN | TRUE     |
	| Entitled to device  | Not installed on device | Not used on device      | 00BDM1JUR8IF419 | cdparanoia-libs               | UNKNOWN   | FALSE   | TRUE     |
	| Installed on device | Not entitled to device  | Not used on device      | 00KWQ4J3WKQM0G  | Adobe Reader 6.0.1 - Fran?ais | TRUE      | UNKNOWN | FALSE    |

@Evergreen @Associations @DAS18804
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorDisplayedWhenUsingFilterWithNegativeValue
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	When User add "<filter>" filter where type is "Equals" with added column and following value:
	| Values |
	| -1     |
	When User clicks the Associations button
	When User clicks 'RUN LIST' button
	Then There are no errors in the browser console

Examples: 
	| filter                       |
	| Device Key                   |
	| Application Key              |
	| CPU Count                    |
	| CPU Count                    |
	| CPU Speed (GHz)              |
	| HDD Count                    |
	| HDD Total Size (GB)          |
	| Memory (GB)                  |
	| Monitor Count                |
	| Network Card Count           |
	| Sound Card Count             |
	| Target Drive Free Space (GB) |
	| Video Card Count             |

@Evergreen @Associations @DAS18454 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatAddedColumnIsDisplayedInGridAfterSortingAndRunninList
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	Then table content is present
	When User clicks on 'Hostname' column header
	When User clicks the Columns button
	When User removes "App Vendor" column by Column panel
	When User clicks 'RUN LIST' button
	Then table content is present

@Evergreen @Associations @DAS18897 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatSomeColumnsAreNotDuplicatedAfterRunningList
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Entitled to device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	Then table content is present
	Then All column headers are unique

@Evergreen @Associations @DAS18447 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatAssociationsMenuIsHighlightedAfterGoingToAllDeviceApplicationsPageFromSavedList
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'Used on device' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	When User creates 'AssociationList18447' dynamic list
	Then table content is present
	When User navigates to the "All Device Applications" list
	Then table content is present
	Then Associations Button is highlighted
	Then Associations panel is displayed to the user