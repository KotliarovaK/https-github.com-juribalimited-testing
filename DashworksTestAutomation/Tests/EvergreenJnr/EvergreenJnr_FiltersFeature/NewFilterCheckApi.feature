Feature: NewFilterCheckApi
	Runs New filters check related testss

Background: Pre-Conditions
	Given User is logged in to the Evergreen via API

@Evergreen @Users @Evergreen_FiltersFeature @NewFilterCheck @API @DAS14629 @DAS14663 @DAS14629
Scenario: EvergreenJnr_UsersList_CheckThatPrimaryDeviceFilterOptionsForUsersList
Then following operators are displayed in "User" category for "Primary Device" filter on "Users" page:
	| OperatorValues      |
	| Equals              |
	| Does not equal      |
	| Contains            |
	| Does not contain    |
	| Begins with         |
	| Does not begin with |
	| Ends with           |
	| Does not end with   |
	| Empty               |
	| Not empty           |
