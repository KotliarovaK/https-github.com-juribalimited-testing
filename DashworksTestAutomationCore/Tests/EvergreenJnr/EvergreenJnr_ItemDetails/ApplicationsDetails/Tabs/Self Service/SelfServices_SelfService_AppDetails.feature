Feature: SelfServices_SelfService_AppDetails
	Runs related tests for Self Service tab

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#AnnI 5/26/20: This functionality is implemented only for 'Yellow_Dwarf'
@Evergreen @Applications @EvergreenJnr_ItemDetails @SelfServicesTab @DAS21182 @DAS21202 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_ApplicationsList_CheckThatSelfServicesTabIsDisplayedCorrectly
	#precondition
	When User create static list with "DAS_21202_SS_List" name on "Applications" page with following items
	| ItemName                        |
	| Microsoft Office 97 Starts Here |
	When User creates Self Service via API and open it
	| Name          | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope             |
	| DAS21202_SS_1 | 21202_SS_1        | true    | true                | DAS_21202_SS_List |
	#scenario1
	When User navigates to the 'Application' details page for the item with '645' ID
	Then Details page for 'Microsoft Office 97 Starts Here' item is displayed to the user
	When User navigates to the 'Self Service' parent left menu item
	When User navigates to the 'Self Services' left submenu item
	Then following columns are displayed on the Item details page:
	| ColumnName              |
	| Self Service            |
	| Self Service Identifier |
	| Status                  |
	| Self Service Link       |
	When User enters "DAS21202_SS_1" text in the Search field for "Self Service" column
	Then Rows counter contains "1" found row of all rows
	When User clicks button with 'ResetFilters' aria label
	When User enters "21202_SS_1" text in the Search field for "Self Service Identifier" column
	Then Rows counter contains "1" found row of all rows
	When User clicks button with 'ResetFilters' aria label
	When User enters "21202_SS_1" text in the Search field for "Self Service Link" column
	Then Rows counter contains "1" found row of all rows
	When User clicks button with 'ResetFilters' aria label
	When User unchecks following checkboxes in the filter dropdown menu for the 'Status' column:
	| checkboxes  |
	| Not Started |
	When User checks following checkboxes in the filter dropdown menu for the 'Status' column:
	| checkboxes  |
	| Not Started |
	#scenario2
	When User selects 'User Evergreen Capacity Project' in the 'Item Details Project' dropdown with wait
	Then following columns are displayed on the Item details page:
	| ColumnName              |
	| Self Service            |
	| Self Service Identifier |
	| Status                  |
	| Self Service Link       |

@Evergreen @Applications @EvergreenJnr_ItemDetails @SelfServicesTab @DAS21178 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatStatusIsUpdatedToThePartiallyCompleteOnTheApplicationSelfServicePageAfterOpeningTheSelfService
	#precondition
	When User create static list with "DAS_21178_SS_List" name on "Applications" page with following items
	| ItemName          |
	| 7-Zip 16.02 (x64) |
	When User creates Self Service via API
	| Name          | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope             |
	| DAS21178_SS_1 | 21178_SS_1        | true    | true                | DAS_21178_SS_List |
	#scenario
	When User navigates to the 'Application' details page for the item with '4093' ID
	Then Details page for '7-Zip 16.02 (x64)' item is displayed to the user
	When User navigates to the 'Self Service' parent left menu item
	When User navigates to the 'Self Services' left submenu item
	When User enters "DAS21178_SS_1" text in the Search field for "Self Service" column
	Then "Not Started" content is displayed for "Status" column
	When User clicks button with 'ResetFilters' aria label
	When User enters "21178_SS_1" text in the Search field for "Self Service Link" column
	When User click content from "Self Service Link" column
	Then Page with 'Welcome' subheader is displayed to user
	Then User click back button in the browser
	When User enters "DAS21178_SS_1" text in the Search field for "Self Service" column
	Then "Partially complete (1 of 2)" content is displayed for "Status" column

@Evergreen @Applications @EvergreenJnr_ItemDetails @SelfServicesTab @DAS21179 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatSelfServiceWhichHasTheUnknowncustomNameIsDisplayedCorrectlyForSelfServicePage
	#precondition
	When User create static list with "DAS_21179_SS_List" name on "Applications" page with following items
	| ItemName          |
	| 7-Zip 16.02 (x64) |
	When User creates Self Service via API
	| Name    | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope             |
	| Unknown | 21179_SS_1        | true    | true                | DAS_21179_SS_List |
	#scenario
	When User navigates to the 'Application' details page for the item with '4093' ID
	Then Details page for '7-Zip 16.02 (x64)' item is displayed to the user
	When User navigates to the 'Self Service' parent left menu item
	When User navigates to the 'Self Services' left submenu item
	When User enters "Unknown" text in the Search field for "Self Service" column
	Then "Unknown" content is displayed for "Self Service" column