Feature: SelfServiceBuilderTest
	REname this feature!!!!!!!!!!!!!!!!!!

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @API @Cleanup
Scenario: EvergreenJnr_AdminPage_fIRSTtEST
	When User creates Self Service via API
	| ServiceId | Name              | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | SsTest_DAS19061_1 | id1906113         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	#
	When User creates new Self Service Page cia API
	| ServiceIdentifier | Name       | ObjectTypeId | DisplayName       | ShowInSelfService |
	| id1906113         | TestPageSs | 3            | TestPageSsDisplay | true              |
	Then Self Service Page with below data is created
	| ServiceIdentifier | Name       | DisplayName       | ShowInSelfService |
	| id1906113         | TestPageSs | TestPageSsDisplay | true              |
	#
	When User updates 'TestPageSs' Self Service Page via API
	| ServiceIdentifier | Name           | ObjectTypeId | DisplayName           | ShowInSelfService |
	| id1906113         | TestPageSs_New | 3            | TestPageSsDisplay_New | false             |
	Then Self Service Page with below data is created
	| ServiceIdentifier | Name           | DisplayName           | ShowInSelfService |
	| id1906113         | TestPageSs_New | TestPageSsDisplay_New | false             |
	#
	When User deletes 'TestPageSs_New' Self Service Page with 'id1906113' dentifier via API
	Then 'id1906113' Self Service does not contains any pages

