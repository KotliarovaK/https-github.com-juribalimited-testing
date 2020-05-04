@retry:1
Feature: PermissionsSettings02
	Runs Dynamic List permissions setting related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_DynamicLists @DAS18880 @Cleanup
Scenario Outline: EvergreenJnr_DevicesList_CheckThatTaskOwnerValuesCanBeSelectedForExistingFilters
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username | Password |
	| User(Me) | 111111   |
	When User clicks 'Devices' on the left-hand menu
	When User clicks the Filters button
	When User add "<FilterName>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| <FilterValue>  |
	Then table content is present
	When User create dynamic list with "<ListName>" name on "Devices" page
	Then "<ListName>" list is displayed to user
	Then "<NumberOfValues>" rows are displayed in the agGrid
	When User clicks the Permissions button
	When User selects 'Specific users / teams' in the 'Sharing' dropdown
	When User adds user to list of shared person
	| User      | Permission |
	| User(Me)2 | Admin      |
	When User clicks the Logout button
	When User is logged in to the Evergreen as
	| Username  | Password |
	| User(Me)2 | 111111   |
	When User clicks 'Devices' on the left-hand menu
	When User navigates to the "<ListName>" list
	Then "<ListName>" list is displayed to user
	When User clicks the Filters button
	Then message 'No devices found' is displayed to the user

Examples: 
| FilterName                        | FilterValue | ListName                   | NumberOfValues |
| s.Me/MyPr: Stg1 \ S.task1 (Owner) | Me          | aMyDeviceListForDAS18880   | 5              |
| s.Me/MyPr: Stg1 \ S.task1 (Team)  | My Team     | aTeamDeviceListForDAS18880 | 8              |