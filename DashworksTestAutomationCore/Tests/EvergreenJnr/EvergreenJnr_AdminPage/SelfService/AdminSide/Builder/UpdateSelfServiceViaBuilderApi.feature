Feature: UpdateSelfServiceViaBuilderApi
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @API @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUsderIsAbleToUpdateSelfServicePageViaApi
	When User creates Self Service via API
	| ServiceId | Name              | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | SsTest_DAS19061_3 | id1906115         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName        | ShowInSelfService |
	| id1906115         | TestPageSs3 | TestPageSsDisplay3 | true              |
	When User updates 'TestPageSs3' Self Service Page via API
	| ServiceIdentifier | Name          | DisplayName            | ShowInSelfService |
	| id1906115         | UpdatedName_3 | TestPageSsDisplay_New4 | false             |
	Then Self Service Page with below data is created
	| ServiceIdentifier | Name          | DisplayName            | ShowInSelfService |
	| id1906115         | UpdatedName_3 | TestPageSsDisplay_New4 | false             |