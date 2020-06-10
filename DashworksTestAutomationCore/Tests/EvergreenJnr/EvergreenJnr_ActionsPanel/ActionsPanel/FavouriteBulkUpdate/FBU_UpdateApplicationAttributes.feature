Feature: FBU_UpdateApplicationAttributes
	Runs Favourite Bulk Update Update Application Attributes related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21005 @DAS21353 @Yellow_Dwarf
Scenario: EvergreenJnr_AllApplications_CheckFavouriteBulkUpdateUpdateApplicationAttributesValidationsForEvergreen
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' option from 'Bulk Update Type' autocomplete
	Then 'star' mat icon is disabled
	Then 'star' mat icon has tooltip with 'Some values are missing or not valid' text
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then 'UPDATE' button is disabled
	Then 'star' mat icon is not disabled
	Then 'star' mat icon has tooltip with 'Save as Favourite Bulk Update' text
	Then 'No change' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'In Catalog' dropdown
	Then 'No change' content is displayed in 'Criticality' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'No change' content is displayed in 'Hide From End Users' dropdown
	When User selects 'RED' in the 'Sticky Compliance' dropdown
	Then 'UPDATE' button is not disabled
	Then 'star' mat icon has tooltip with 'Save as Favourite Bulk Update' text

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21005 @DAS21353 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllApplications_CheckFavouriteBulkUpdateUpdateApplicationAttributesValidationsForProject
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' option from 'Bulk Update Type' autocomplete
	Then 'star' mat icon is disabled
	Then 'star' mat icon has tooltip with 'Some values are missing or not valid' text
	Then 'UPDATE' button has tooltip with 'Some values are missing or not valid' text
	When User selects 'Barry's User Project' option from 'Project or Evergreen' autocomplete
	Then 'UPDATE' button is disabled
	Then 'star' mat icon is not disabled
	Then 'star' mat icon has tooltip with 'Save as Favourite Bulk Update' text
	When User selects 'Core' in the 'Criticality' dropdown
	Then 'No change' content is displayed in 'Rationalisation' dropdown
	Then 'No change' content is displayed in 'Hide From End Users' dropdown
	Then 'UPDATE' button is not disabled
	Then 'star' mat icon has tooltip with 'Save as Favourite Bulk Update' text

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21006 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllApplications_CheckCreateFavouriteBulkUpdatePopupWindowUpdateApplicationAttributes
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' option from 'Bulk Update Type' autocomplete
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User clicks 'star' mat icon
	Then popup with 'Create Favourite Bulk Update' title is displayed
	Then 'This Favourite Bulk Update will be created with the following parameters:' text is displayed on popup
	Then following data is displayed in the '0' column of the table
	| Fields               |
	| Bulk Update Type     |
	| Project or Evergreen |
	Then User sees table with the following data
	| Field                | Data                          |
	| Bulk Update Type     | Update application attributes |
	| Project or Evergreen | Evergreen                     |

	Then 'CANCEL' button is not disabled
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	When User enters '' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update name must be entered' error message is displayed for 'Favourite Bulk Update Name' field
	When User enters '21006_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters '21006_TestFBU' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update with this name already exists' error message is displayed for 'Favourite Bulk Update Name' field

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21006 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllApplications_CheckCreateFavouriteBulkUpdatePopupWindowUpdateApplicationAttributesForProject
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' option from 'Bulk Update Type' autocomplete
	When User selects 'Barry's User Project' option from 'Project or Evergreen' autocomplete
	When User selects 'Core' in the 'Criticality' dropdown
	When User selects 'RETIRE' in the 'Rationalisation' dropdown
	When User selects 'FALSE' in the 'Hide From End Users' dropdown
	Then 'UPDATE' button is not disabled
	When User clicks 'star' mat icon
	Then popup with 'Create Favourite Bulk Update' title is displayed
	Then 'This Favourite Bulk Update will be created with the following parameters:' text is displayed on popup
	Then following data is displayed in the '0' column of the table
	| Fields               |
	| Bulk Update Type     |
	| Project or Evergreen |
	| Criticality          |
	| Rationalisation      |
	| Hide From End User   |
	Then User sees table with the following data
	| Field                | Data                          |
	| Bulk Update Type     | Update application attributes |
	| Project or Evergreen | Barry's User Project          |
	| Criticality          | Core                          |
	| Rationalisation      | Retire                        |
	| Hide From End User   | False                         |
	Then 'CANCEL' button is not disabled
	Then 'CREATE' button is disabled
	Then 'CREATE' button has tooltip with 'Some values are missing or not valid' text
	When User enters '' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update name must be entered' error message is displayed for 'Favourite Bulk Update Name' field
	When User enters '210061_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters '210061_TestFBU' text to 'Favourite Bulk Update Name' textbox
	Then 'A Favourite Bulk Update with this name already exists' error message is displayed for 'Favourite Bulk Update Name' field

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21007 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllApplications_CheckActionPanelWindowUpdateApplicationAttributes
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' option from 'Bulk Update Type' autocomplete
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User clicks 'star' mat icon
	When User enters '21007_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'TestFBU_21007' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'testFBU_210071' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User clicks 'star' mat icon
	When User enters 'abc_21007' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	Then following items have 'star' mat icon from 'Bulk Update Type' autocomplete
	| Items          |
	| 21007_TestFBU  |
	| TestFBU_21007  |
	| testFBU_210071 |
	| abc_21007      |
	Then items with 'star' mat icon for 'Bulk Update Type' autocomplete are displayed in ascending order

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21007 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllApplications_CheckActionPanelWindowUpdateApplicationAttributesForEvergreen
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' option from 'Bulk Update Type' autocomplete
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	When User selects 'GREEN' in the 'Sticky Compliance' dropdown
	When User selects 'Critical' in the 'Criticality' dropdown
	When User selects 'KEEP' in the 'Rationalisation' dropdown
	When User selects 'TRUE' in the 'Hide From End Users' dropdown
	When User clicks 'star' mat icon
	When User enters 'DAS21007_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User selects 'DAS21007_TestFBU' option from 'Bulk Update Type' autocomplete with 'star' icon
	Then 'GREEN' content is displayed in 'Sticky Compliance' dropdown
	Then 'No change' content is displayed in 'In Catalog' dropdown
	Then 'Critical' content is displayed in 'Criticality' dropdown
	Then 'KEEP' content is displayed in 'Rationalisation' dropdown
	Then 'TRUE' content is displayed in 'Hide From End Users' dropdown
	Then 'UPDATE' button is not disabled
	Then 'CANCEL' button is not disabled
	Then 'star' mat icon is not disabled

@Evergreen @AllApplications @EvergreenJnr_ActionsPanel @FavouriteBulkUpdate @DAS21007 @Cleanup @Yellow_Dwarf
Scenario: EvergreenJnr_AllApplications_CheckActionPanelWindowUpdateApplicationAttributesForProject
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Actions button
	Then Actions panel is displayed to the user
	When User select "Application" rows in the grid
	| SelectedRowsName                         |
	| 0047 - Microsoft Access 97 SR-2 Francais |
	When User selects 'Bulk update' in the 'Action' dropdown
	When User selects 'Update application attributes' option from 'Bulk Update Type' autocomplete
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	When User selects 'Important' in the 'Criticality' dropdown
	When User selects 'UNCATEGORISED' in the 'Rationalisation' dropdown
	When User selects 'FALSE' in the 'Hide From End Users' dropdown
	When User clicks 'star' mat icon
	When User enters 'DAS210071_TestFBU' text to 'Favourite Bulk Update Name' textbox
	When User clicks 'CREATE' button
	When User selects 'DAS210071_TestFBU' option from 'Bulk Update Type' autocomplete with 'star' icon
	Then 'Important' content is displayed in 'Criticality' dropdown
	Then 'UNCATEGORISED' content is displayed in 'Rationalisation' dropdown
	Then 'FALSE' content is displayed in 'Hide From End Users' dropdown
	Then 'UPDATE' button is not disabled
	Then 'CANCEL' button is not disabled
	Then 'star' mat icon is not disabled