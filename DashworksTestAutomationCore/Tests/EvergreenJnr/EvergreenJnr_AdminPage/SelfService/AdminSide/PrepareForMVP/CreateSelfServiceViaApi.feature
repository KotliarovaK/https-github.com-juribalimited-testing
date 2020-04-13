Feature: CreateSelfServiceViaApi
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19187 @API @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApi
	When User creates Self Service via API
	| ServiceId | Name                       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | TestSelfService_name3_test | id193803          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	Then User checks the Self Service via API
	Then User deletes the Self Services via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS18948 @API @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCreatedSelfServiceExistInTheGrid
	When User creates Self Service via API
	| ServiceId | Name                        | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | TestSelfService_name54_test | id193854          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	Then User checks the Self Services Grid via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19478 @API @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToEnableSelfServiceViaApi
	When User creates Self Service via API
	| ServiceId | Name                       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | TestSelfService_name3_test | id193806          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	Then User checks the Self Service via API
	Then User enables Self Service with 'id193806' identifier via API
	Then User checks the Self Service via API
	Then User deletes the Self Services via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19478 @API @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToDisableSelfServiceViaApi
	When User creates Self Service via API
	| ServiceId | Name                       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | TestSelfService_name3_test | id193808          | true    | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	Then User checks the Self Service via API
	Then User disables Self Service with 'id193808' identifier via API
	Then User checks the Self Service via API
	Then User deletes the Self Services via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19478 @API @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToDeleteSelfServiceViaApi
	When User creates Self Service via API
	| ServiceId | Name                       | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId | scopeName |
	| 1         | TestSelfService_name3_test | id193803          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 2       | bob       |
	Then User checks the Self Service via API
	Then User deletes the Self Services via API