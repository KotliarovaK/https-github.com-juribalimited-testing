Feature: CreateSelfServicePageViaApi
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @API @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUsderIsAbleToCreateSelfServicePageViaApi
	When User creates Self Service via API
	| ServiceId | Name              | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | SsTest_DAS19061_1 | id19061           | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name       | DisplayName       | ShowInSelfService |
	| id19061           | TestPageSs | TestPageSsDisplay | true              |
	Then Self Service Page with below data is created
	| ServiceIdentifier | Name       | DisplayName       | ShowInSelfService |
	| id19061           | TestPageSs | TestPageSsDisplay | true              |

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19061 @API @Cleanup @SelfServiceMVP
Scenario: EvergreenJnr_AdminPage_CheckThatUsderIsAbleToDeleteSelfServicePageViaApi
	When User creates Self Service via API
	| ServiceId | Name              | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | SsTest_DAS19061_2 | id19061_2         | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName       | ShowInSelfService |
	| id19061_2         | TestPageSs1 | TestPageSsDisplay | false             |
	Then Self Service Page with below data is created
	| ServiceIdentifier | Name        | DisplayName       | ShowInSelfService |
	| id19061_2         | TestPageSs1 | TestPageSsDisplay | false             |
	When User deletes 'TestPageSs1' Self Service Page with 'id19061_2' identifier via API
	Then 'id19061_2' Self Service does not contain 'TestPageSs2' page