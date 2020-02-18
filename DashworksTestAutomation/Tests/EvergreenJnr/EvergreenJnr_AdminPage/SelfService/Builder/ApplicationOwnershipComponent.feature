Feature: ApplicationOwnershipComponent
	Application Ownership component

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @Cleanup
Scenario: EvergreenJnr_AdminPage_EvergreenJnr_AdminPage_TEST
	When User create static list with "DAS_20019_1" name on "Applications" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_20019_SS_1 | 20019_1_SI        | true    | true                | DAS_20019_1 |