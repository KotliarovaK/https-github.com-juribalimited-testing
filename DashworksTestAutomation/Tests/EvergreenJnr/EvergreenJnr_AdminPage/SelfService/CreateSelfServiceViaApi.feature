Feature: CreateSelfServiceViaApi
	Self Service

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19187 @API @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToCreateAndGetSelfServiceViaApi
	When User creates Self Service via API
	| ServiceId | Name                   | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId |
	| 1         | TestSelfService_name33 | id191839          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 0       |
	Then User checks the Self Service via API

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19187 @API @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatUserIsAbleToUpdateSelfServiceViaApiAndGet
    When User creates Self Service via API	
	| ServiceId | Name                   | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate              | EndDate                | SelfServiceURL | AllowAnonymousUsers | ScopeId |
	| 1         | TestSelfService_name28 | id191828          | false   | Devimdmdmm | 3            | 2019-12-10T21:34:47.24 | 2019-12-31T21:34:47.24 | URL            | true                | 0       |
	When User updates Self Service via API
	| OldName                | Name         | ServiceIdentifier | Enabled | ScopeId |
	| TestSelfService_name28 | Updated_name1 | id19187          | true    | 1       |
	Then User checks the Self Service via API