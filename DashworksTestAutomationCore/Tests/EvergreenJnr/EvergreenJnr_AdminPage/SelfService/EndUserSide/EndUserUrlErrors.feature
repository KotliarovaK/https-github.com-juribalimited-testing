Feature: EndUserUrlErrors
	Positive and negative cases related to non-valid/valid SS URL

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS18972 @DAS19885 @DAS21385 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckErrorMessageWhenSelfServiceIsNotAvailable
	When User create static list with "DAS_18972_1" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_18972_SS_1 | 18972_1_SI        | true    | true                | DAS_18972_1 |
	When User navigates to End User landing page with '19653_1_SI' Self Service Identifier and inccorect SSID in URL '18972_1_X'
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

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19653 @DAS21385 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckErrorMessageWhenSelfServiceObjectNotFound
	When User create static list with "DAS_19653_1" name on "Applications" page with following items
	| ItemName   |
	| VSCmdShell |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_19653_SS_1 | 19653_1_SI        | true    | true                | DAS_19653_1 |
	When User navigates to End User landing page with '19653_1_SI' Self Service Identifier and inccorect GUID '4e6aea42-ed2f-4017-b7ad-4dde477e68d'
	Then self service error page with 'This application cannot be found' text is displayed for end client

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS21291 @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckDisabledSelfService
	When User creates Self Service via API and open it
	| Name     | ServiceIdentifier | Enabled  | AllowAnonymousUsers | Scope            |
	| 21291_SS | 21291_SI          | false    | true                | All Applications |
	When User navigates to End User landing page with '21291_SI' Self Service Identifier
	Then self service error page with 'Self service is not enabled' text is displayed for end client

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS21385 @Cleanup @SelfServiceMVP
Scenario Outline: EvergreenJnr_AdminPage_CheckEnduserErrorMessageHandling
	When User creates Self Service via API and open it
	| Name     | ServiceIdentifier   | Enabled   | AllowAnonymousUsers | Scope          |
	| <SSName> | <ServiceIdentifier> | <Enabled> | true                | <UserStatList> |
	When User creates new Self Service Page via API
	| ServiceIdentifier   | Name        | DisplayName       | ShowInSelfService |
	| <ServiceIdentifier> | TestPageSs1 | TestPageSsDisplay | false             |
	When User navigates to End User landing page with '<ServiceIdentifier>' Self Service Identifier via URL
	| SSID   | GUID   | PageID   |
	| <SSID> | <GUID> | <PageID> |
	Then self service error page with '<ErrorMessage>' text is displayed for end client

	Examples:
	| UserStatList | SSName               | ServiceIdentifier | Enabled | SSID  | GUID  | PageID | ErrorMessage                     |
	| All Users    | SSName_DAS_21385_1_A | 21385_1_SA        | true    | XXXXX | VALID | VALID  | This is not a valid self service |
	| All Users    | SSName_DAS_21385_1_B | 21385_1_SB        | true    | VALID | XXXXX | VALID  | This application cannot be found |
	| All Users    | SSName_DAS_21385_1_C | 21385_1_SC        | true    | VALID | VALID | XXXXX  | This is not a valid self service |
	| All Users    | SSName_DAS_21385_1_D | 21385_1_SD        | true    | XXXXX | XXXXX | VALID  | This is not a valid self service |
	| All Users    | SSName_DAS_21385_1_E | 21385_1_SE        | true    | XXXXX | VALID | XXXXX  | This is not a valid self service |
	| All Users    | SSName_DAS_21385_1_F | 21385_1_SF        | true    | VALID | XXXXX | XXXXX  | This application cannot be found |
	| All Users    | SSName_DAS_21385_1_G | 21385_1_SG        | true    | XXXXX | XXXXX | XXXXX  | This is not a valid self service |
	| All Users    | SSName_DAS_21385_1_H | 21385_1_SH        | false   | XXXXX | VALID | VALID  | This is not a valid self service |
	| All Users    | SSName_DAS_21385_1_I | 21385_1_SI        | false   | VALID | XXXXX | VALID  | Self service is not enabled      |
	| All Users    | SSName_DAS_21385_1_J | 21385_1_SJ        | false   | VALID | VALID | XXXXX  | Self service is not enabled      |
	| All Users    | SSName_DAS_21385_1_K | 21385_1_SK        | false   | XXXXX | XXXXX | VALID  | This is not a valid self service |
	| All Users    | SSName_DAS_21385_1_L | 21385_1_SL        | false   | XXXXX | VALID | XXXXX  | This is not a valid self service |
	| All Users    | SSName_DAS_21385_1_M | 21385_1_SM        | false   | VALID | XXXXX | XXXXX  | Self service is not enabled      |
	| All Users    | SSName_DAS_21385_1_N | 21385_1_SN        | false   | XXXXX | XXXXX | XXXXX  | This is not a valid self service |