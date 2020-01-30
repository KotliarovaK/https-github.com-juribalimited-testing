﻿Feature: EndClient
	End Client related tests

@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS18972
Scenario: EvergreenJnr_AdminPage_CheckErrorMessageWhenSelfServiceIsNotAvailable
	When User navigates to 'selfservice/am-s4?uid=c56a4180-65aa-42ec-a945-5fd21dec053' url via address line
	Then self service error page with 'This is not a valid self service' text is displayed for end client 