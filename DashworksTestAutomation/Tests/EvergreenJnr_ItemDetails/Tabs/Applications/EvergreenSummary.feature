Feature: EvergreenSummary
	Runs Evergreen Summary related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#ready only on 'Spectrum'
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18618 @Not_Ready
Scenario: EvergreenJnr_UsersList_CheckThatApplicationsWhichAreOwnedAreAppearInApplicationsEvergreenDetailsForUser
	When User navigates to the 'User' details page for 'AAQ9911340' item
	Then Details page for "AAQ9911340" item is displayed to the user
	When User navigates to the 'Applications' left menu item
	And User navigates to the 'Evergreen Summary' left submenu item
	Then 'Infragistics Expense Reference Site 2004 Vol. 1' content is not displayed in the 'Application' column
	When User navigates to the 'Evergreen Owned' left submenu item
	Then 'Infragistics Expense Reference Site 2004 Vol. 1' content is displayed in the 'Application' column