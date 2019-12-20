﻿Feature: CreateSelfServiceViaApi
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19187 @API @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApi
	When User creates Self Service via API
	| ServiceId | Name                        | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | TestSelfService_name25_test | id193830          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	Then User checks the Self Service via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS18948 @API @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCreatedSelfServiceExistInTheGrid
	When User creates Self Service via API
	| ServiceId | Name                        | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | TestSelfService_name53_test | id193853          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	Then User checks the Self Services Grid via API