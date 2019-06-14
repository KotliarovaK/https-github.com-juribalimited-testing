Feature: ListsFromCSV
	Runs Lists From CSV related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListFromCSV @ListsFromCSV @DAS13221 @DAS13222 @DAS16585 @Not_Ready
Scenario Outline: EvergreenJnr_AllLists_Check
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User selects "LIST FROM CSV" from the Create actions
	Then "<ImportPage>" Import page is displayed to the User
	When User navigates to Pivot
	And User selects the following Row Groups on Pivot:
	| RowGroups   |

Examples:
	| ListName     | ImportPage            |
	| Devices      | Devices from CSV      |
	| Users        | Users from CSV        |
	| Applications | Applications from CSV |
	| Mailboxes    | Mailboxes from CSV    |