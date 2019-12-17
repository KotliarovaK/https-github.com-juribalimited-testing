﻿Feature: EvergreenDetails
	Runs Evergreen Details related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19189 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatTheTargetAppForForwardPathRationalisationIsChangedAfterChangingTheTargetAppWhenForwardPathRationalisationAlreadySelected
	When User navigates to the 'Application' details page for '"WPF/E" (codename) Community Technology Preview (Feb 2007)' item
	Then Details page for ""WPF/E" (codename) Community Technology Preview (Feb 2007)" item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	When User clicks on edit button for 'Rationalisation' field
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'Corel WordPerfect' in the 'Application' autocomplete field and selects 'Corel WordPerfect 8 (327)' value
	When User clicks 'UPDATE' button on popup
	Then following content is displayed on the Details Page
	| Title      | Value               |
	| Target App | Corel WordPerfect 8 |
	When User clicks on edit button for 'Rationalisation' field
	When User enters 'Rosoft MP3 Encoder, Limited Edition' in the 'Application' autocomplete field and selects 'Rosoft Engineering Rosoft MP3 Encoder, Limited Edition (495)' value
	When User clicks 'UPDATE' button on popup
	Then following content is displayed on the Details Page
	| Title      | Value                                                  |
	| Target App | Rosoft Engineering Rosoft MP3 Encoder, Limited Edition |
	When User clicks on edit button for 'Rationalisation' field
	When User selects 'UNCATEGORISED' in the 'Rationalisation' dropdown
	When User clicks 'UPDATE' button on popup

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19026
Scenario: EvergreenJnr_ApplicationsList_CheckThatTheRationalisationDropdownIsDisplayedCorrectly
	When User navigates to the 'Application' details page for 'Mozilla Sunbird (0.2a.)' item
	Then Details page for "Mozilla Sunbird (0.2a.)" item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	When User clicks on edit button for 'Rationalisation' field
	Then 'UPDATE' button is displayed
	Then 'CANCEL' button is displayed
	Then following Values are displayed in the 'Rationalisation' dropdown:
	| Values        |
	| FORWARD PATH  |
	| KEEP          |
	| RETIRE        |
	| UNCATEGORISED |

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19026 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatTheRationalisationValuesAreAppliedSuccessfully
	When User navigates to the 'Application' details page for the item with '675' ID
	Then Details page for "Music Visualizer Library 1.0" item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	When User clicks on edit button for 'Rationalisation' field
	When User selects 'RETIRE' in the 'Rationalisation' dropdown
	When User clicks 'UPDATE' button on popup
	Then following content is displayed on the Details Page
	| Title           | Value  |
	| Rationalisation | RETIRE |
	When User navigates to the 'Application' details page for the item with '676' ID
	Then Details page for "Microsoft Internet Explorer 5.5 SP2 MUI Pack" item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	When User clicks on edit button for 'Rationalisation' field
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	When User enters 'Corel WordPerfect' in the 'Application' autocomplete field and selects 'Corel WordPerfect 8 (327)' value
	When User clicks 'UPDATE' button on popup
	Then following content is displayed on the Details Page
	| Title           | Value        |
	| Rationalisation | FORWARD PATH |
	When User navigates to the 'Application' details page for the item with '983' ID
	Then Details page for "Mozilla Sunbird (0.2a.)" item is displayed to the user
	When User navigates to the 'Projects' parent left menu item
	And User navigates to the 'Evergreen Details' left submenu item
	When User clicks on edit button for 'Rationalisation' field
	When User selects 'FORWARD PATH' in the 'Rationalisation' dropdown
	Then 'Music Visualizer Library 1.0' content is not displayed in 'Application' autocomplete after search
	#When User clears 'Application' autocomplete
	#Then 'Microsoft Internet Explorer 5.5 SP2 MUI Pack (Czech) - Menus and Dialogs' content is not displayed in 'Application' autocomplete after search
	When User enters 'Microsoft Office Simplified Chinese Support' in the 'Application' autocomplete field and selects 'Microsoft Office Simplified Chinese Support' value
	When User clicks 'UPDATE' button on popup
	Then following content is displayed on the Details Page
	| Title           | Value        |
	| Rationalisation | FORWARD PATH |
	When User clicks on edit button for 'Rationalisation' field
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User clicks 'UPDATE' button on popup
	Then following content is displayed on the Details Page
	| Title           | Value |
	| Rationalisation | KEEP  |