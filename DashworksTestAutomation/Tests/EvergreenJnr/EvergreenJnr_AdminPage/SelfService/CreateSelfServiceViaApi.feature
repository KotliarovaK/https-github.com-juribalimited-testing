﻿Feature: CreateSelfServiceViaApi
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19187 @API
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApi
	When User creates Self Service via API
	| ServiceId | Name                      | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId |
	| 1         | TestSelfService_name11_v1 | id191811          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       |
	Then User checks the created Self Service via API