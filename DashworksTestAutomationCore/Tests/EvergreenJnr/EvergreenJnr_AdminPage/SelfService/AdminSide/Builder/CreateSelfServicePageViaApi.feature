Feature: CreateSelfServicePageViaApi
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @API @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUsderIsAbleToCreateSelfServicePageViaApi
	When User creates Self Service via API
	| ServiceId | Name              | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | SsTest_DAS19061_1 | id1906113         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name       | DisplayName       | ShowInSelfService |
	| id1906113         | TestPageSs | TestPageSsDisplay | true              |
	Then Self Service Page with below data is created
	| ServiceIdentifier | Name       | DisplayName       | ShowInSelfService |
	| id1906113         | TestPageSs | TestPageSsDisplay | true              |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @API @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUsderIsAbleToDeleteSelfServicePageViaApi
	When User creates Self Service via API
	| ServiceId | Name              | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | SsTest_DAS19061_2 | id1906114         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName       | ShowInSelfService |
	| id1906114         | TestPageSs2 | TestPageSsDisplay | false             |
	Then Self Service Page with below data is created
	| ServiceIdentifier | Name        | DisplayName       | ShowInSelfService |
	| id1906114         | TestPageSs2 | TestPageSsDisplay | false             |
	When User deletes 'TestPageSs2' Self Service Page with 'id1906114' identifier via API
	Then 'id1906114' Self Service does not contain 'TestPageSs2' page