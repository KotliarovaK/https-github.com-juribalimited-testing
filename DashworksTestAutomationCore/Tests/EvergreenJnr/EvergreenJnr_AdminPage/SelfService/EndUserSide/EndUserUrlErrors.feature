Feature: EndUserUrlErrors
	Positive and negative cases related to non-valid/valid SS URL

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS18972 @DAS19885 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckErrorMessageWhenSelfServiceIsNotAvailable
	When User create static list with "DAS_18972_1" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_18972_SS_1 | 19653_1_SI        | true    | true                | DAS_18972_1 |
	When User navigates to End User landing page with '19653_1_SI' Self Service Identifier with inccorect SSID in URL '19653_1_X'
	Then self service error page with 'This is not a valid self service' text is displayed for end client

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19885 @DAS19653 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckNoErrorMessageWhenSelfServiceIsAvailableAndSelfServiceObjectWasFound
When User create static list with "DAS_19885_1" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_19885_SS_1 | 19885_1_SI        | true    | true                | DAS_19885_1 |
	When User navigates to End User landing page with '19885_1_SI' Self Service Identifier
	Then Self Service Tools Panel displayed for end client

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19653 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckErrorMessageWhenSelfServiceObjectNotFound
	When User create static list with "DAS_19653_1" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_19653_SS_1 | 19653_1_SI        | true    | true                | DAS_19653_1 |
	When User navigates to End User landing page with '19653_1_SI' Self Service Identifier and inccorect GUID '4e6aea42-ed2f-4017-b7ad-4dde477e68d'
	Then self service error page with 'This application cannot be found' text is displayed for end client