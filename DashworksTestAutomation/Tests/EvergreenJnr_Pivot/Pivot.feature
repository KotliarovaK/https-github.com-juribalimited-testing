Feature: Pivot
	Runs Pivot block related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_Pivot @Pivot @DAS14224
Scenario: EvergreenJnr_ApplicationsList_TestPivot
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User navigates to Pivot
	When User adds the following Row Groups:
	| RowGroups   |
	| Import      |
	| Application |
	When User adds the following Columns:
	| Columns           |
	| Application Owner |
	When User adds the following Values:
	| Values |
	| Vendor |

