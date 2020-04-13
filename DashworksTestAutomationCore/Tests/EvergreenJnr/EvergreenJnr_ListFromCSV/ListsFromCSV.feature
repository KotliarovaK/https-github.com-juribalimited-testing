Feature: ListsFromCSV
	Runs Lists From CSV related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ListFromCSV @ListsFromCSV @DAS13221 @DAS13222 @DAS13223 @DAS13224 @DAS16585 @DAS18336 @Not_Ready
#Waiting for 'List from CSV' on the automation
Scenario Outline: EvergreenJnr_AllLists_CheckCreatingStaticListFromCSVFirstPage
	When User clicks '<ListName>' on the left-hand menu
	Then '<ListName1>' list should be displayed to the user
	When User selects 'List from CSV' in the 'Create' dropdown
	Then "<ImportPage>" Import page is displayed to the User
	When User selects "CSV-Upload-Devices - Hostname no header.csv" file to upload on Import Lists from CSV page
	Then 'File has headers' checkbox is unchecked
	When User selects '<FileContains>' in the 'File Contains' dropdown
	Then 'NEXT' button is not disabled

Examples:
	| ListName     | ListName1        | ImportPage                   | FileContains    |
	| Users        | All Users        | Import Users from CSV        | User key        |
	| Applications | All Applications | Import Applications from CSV | Application key |
	| Mailboxes    | All Mailboxes    | Import Mailboxes from CSV    | Mailbox key     |

#Yurii T. 17Mar2020: added not_ready tag because DAS-20329 and current releas is void
@Evergreen @EvergreenJnr_ListFromCSV @ListsFromCSV @DAS16616 @DAS16585 @DAS18336 @Not_Ready
Scenario: EvergreenJnr_AllLists_CheckCancelButtonFunctionalityOnCreateListFromCSV
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'List from CSV' in the 'Create' dropdown
	Then "Import Devices from CSV" Import page is displayed to the User
	When User clicks 'CANCEL' button 
	Then 'All Devices' list should be displayed to the user
	When User selects 'List from CSV' in the 'Create' dropdown
	When User selects "IncorrectFile.zip" file to upload on Import Lists from CSV page
	When User selects "CSV-Upload-Devices - Hostname no header.csv" file to upload on Import Lists from CSV page
	Then 'File has headers' checkbox is unchecked
	Then 'Include archived devices' checkbox is unchecked
	When User selects 'Hostname' in the 'File Contains' dropdown
	Then 'NEXT' button is not disabled
	When User clicks 'CANCEL' button 
	Then popup is displayed to User
	When User clicks 'NO' button on popup
	When User clicks 'CANCEL' button 
	Then popup is displayed to User
	When User clicks 'YES' button on popup
	Then 'All Devices' list should be displayed to the user

#Yurii T. 17Mar2020: added not_ready tag because DAS-20329 and current releas is void
@Evergreen @EvergreenJnr_ListFromCSV @ListsFromCSV @DAS18451 @Not_Ready
Scenario: EvergreenJnr_AllLists_CheckErrorBannerWhenTryingUploadIncorrectFileOnCreateListFromCSV
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User selects 'List from CSV' in the 'Create' dropdown
	Then "Import Devices from CSV" Import page is displayed to the User
	When User clicks 'CANCEL' button 
	Then 'All Devices' list should be displayed to the user
	When User selects 'List from CSV' in the 'Create' dropdown
	When User selects "IncorrectFile.zip" file to upload on Import Lists from CSV page
	When User selects state 'true' for 'File has headers' checkbox
	When User selects state 'true' for 'Include archived devices' checkbox
	When User selects 'Hostname' in the 'File Contains' dropdown
	Then 'NEXT' button is not disabled
	When User clicks 'NEXT' button 
	Then 'Selected file is not in a valid format' text is displayed on inline error banner