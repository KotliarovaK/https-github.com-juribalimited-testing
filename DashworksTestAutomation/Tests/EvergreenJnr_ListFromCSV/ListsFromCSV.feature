Feature: ListsFromCSV
	Runs Lists From CSV related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListFromCSV @ListsFromCSV @DAS13221 @DAS13222 @DAS13223 @DAS13224 @DAS16585 @Not_Ready
Scenario Outline: EvergreenJnr_AllLists_CheckCreatingStaticListFromCSVFirstPage
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListName>' list should be displayed to the user
	When User selects "List from CSV" from the Create actions
	Then "<ImportPage>" Import page is displayed to the User
	When User selects "CSV-Upload-Devices - Hostname no header.csv" file to upload on Import Lists from CSV page
	Then "File has headers" checkbox is unchecked on the Base Dashboard Page
	When User selects "<FileContains>" in the "File Contains" dropdown
	Then "NEXT" Action button is active

Examples:
	| ListName     | ImportPage            | FileContains    |
	| Users        | Users from CSV        | User key        |
	| Applications | Applications from CSV | Application key |
	| Mailboxes    | Mailboxes from CSV    | Mailbox key     |

@Evergreen @EvergreenJnr_ListFromCSV @ListsFromCSV @DAS16616 @DAS16585 @Not_Ready
Scenario: EvergreenJnr_AllLists_CheckCancelButtonFunctionalityOnCreateListFromCSV
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects "List from CSV" from the Create actions
	Then "Devices from CSV" Import page is displayed to the User
	When User clicks 'CANCEL' button 
	Then 'All Devices' list should be displayed to the user
	When User selects "List from CSV" from the Create actions
	When User selects "CSV-Upload-Devices - Hostname no header.csv" file to upload on Import Lists from CSV page
	Then "File has headers" checkbox is unchecked on the Base Dashboard Page
	Then "Include archived applications" checkbox is unchecked on the Base Dashboard Page
	When User selects "Hostname" in the "File Contains" dropdown
	Then "NEXT" Action button is active
	When User clicks 'CANCEL' button 
	Then Warning Pop-up is displayed to the User
	When User clicks "NO" button in the Warning Pop-up message
	When User clicks 'CANCEL' button 
	Then Warning Pop-up is displayed to the User
	When User clicks "YES" button in the Warning Pop-up message
	Then 'All Devices' list should be displayed to the user
