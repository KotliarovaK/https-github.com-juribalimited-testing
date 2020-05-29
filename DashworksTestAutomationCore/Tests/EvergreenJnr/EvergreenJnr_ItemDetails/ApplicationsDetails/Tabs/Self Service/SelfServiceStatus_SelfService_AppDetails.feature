Feature: SelfServiceStatus_SelfService_AppDetails
	Runs related tests for Self Service Status tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI 5/26/20: This functionality is implemented only for 'Yellow_Dwarf'
@Evergreen @Applications @EvergreenJnr_ItemDetails @SelfServicesTab @DAS21182 @DAS21202 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_ApplicationsList_CheckThatSelfServiceStatusTabIsDisplayedCorrectly
	#precondition
	When User create static list with "DAS_21202_SS_List" name on "Applications" page with following items
	| ItemName                        |
	| Microsoft Office 97 Starts Here |
	When User creates Self Service via API and open it
	| Name          | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope             |
	| DAS21202_SS_2 | 21202_SS_2        | true    | true                | DAS_21202_SS_List |
	#scenario1
	When User navigates to the 'Application' details page for the item with '645' ID
	Then Details page for 'Microsoft Office 97 Starts Here' item is displayed to the user
	When User navigates to the 'Self Service' parent left menu item
	When User navigates to the 'Self Service Status' left submenu item
	Then following columns are displayed on the Item details page:
	| ColumnName   |
	| Self Service |
	| Page         |
	| Status       |
	When User checks following checkboxes in the filter dropdown menu for the 'Self Service' column:
	| checkboxes    |
	| Select All    |
	| DAS21202_SS_2 |
	Then 'DAS21202_SS_2' text is displayed in the filter dropdown for the 'Self Service' column
	Then Rows counter contains "2" found row of all rows