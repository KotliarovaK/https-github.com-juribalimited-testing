Feature: EndClient
	End Client related tests

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS18972 @DAS19885
Scenario: EvergreenJnr_AdminPage_CheckErrorMessageWhenSelfServiceIsNotAvailable
	When User navigates to 'selfservice/am-s4?uid=c56a4180-65aa-42ec-a945-5fd21dec053' url via address line
	Then self service error page with 'This is not a valid self service' text is displayed for end client

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19885
Scenario: EvergreenJnr_AdminPage_CheckNoErrorMessageWhenSelfServiceIsAvailable
	When User navigates to 'selfservice/AV1?ObjectId=C56A4180-65AA-42EC-A945-5FD21DEC0538' url via address line
	Then Self Service Tools Panel displayed for end client

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19653
Scenario: EvergreenJnr_AdminPage_CheckErrorMessageWhenSelfServiceObjectNotFound
	When User navigates to 'selfservice/amss1?ObjectId=c066458e-27da-4dc1-bbd6-1510f6ea7aa' url via address line
	Then self service error page with 'This application cannot be found' text is displayed for end client

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS19653
Scenario: EvergreenJnr_AdminPage_CheckThatNoErrorMessageWhenSelfServiceObjectWasFound
	When User navigates to 'selfservice/amss1?ObjectId=c066458e-27da-4dc1-bbd6-1510f6ea70dd' url via address line
	Then Self Service Tools Panel displayed for end client