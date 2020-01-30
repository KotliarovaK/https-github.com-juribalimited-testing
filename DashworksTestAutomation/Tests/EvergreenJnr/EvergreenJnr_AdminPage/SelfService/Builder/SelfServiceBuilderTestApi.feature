Feature: SelfServiceBuilderTest
	REname this feature!!!!!!!!!!!!!!!!!!

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @API @Cleanup
Scenario: EvergreenJnr_AdminPage_fIRSTtEST
	When User creates Self Service via API
	| ServiceId | Name              | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | SsTest_DAS19061_1 | id1906113         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	When User creates new Self Service Page cia API
	| ServiceIdentifier | Name       | ObjectTypeId | DisplayName       | ShowInSelfService |
	| id1906113         | TestPageSs | 3            | TestPageSsDisplay | true              |
	When User updates 'TestPageSs' Self Service Page via API
	| ServiceIdentifier | Name           | ObjectTypeId | DisplayName           | ShowInSelfService |
	| id1906113         | TestPageSs_New | 3            | TestPageSsDisplay_New | true              |
	When User deletes 'TestPageSs_New' Self Service Page with 'id1906113' dentifier via API
