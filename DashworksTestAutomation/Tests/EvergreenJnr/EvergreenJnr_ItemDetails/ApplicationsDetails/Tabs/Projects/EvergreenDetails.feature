Feature: EvergreenDetails
	Runs Evergreen Details related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS19189
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