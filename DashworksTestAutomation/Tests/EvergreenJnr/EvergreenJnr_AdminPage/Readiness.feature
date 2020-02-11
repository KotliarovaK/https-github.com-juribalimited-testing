Feature: Readiness
	Runs Readiness related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15665 @DAS14994 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatOptionsInTheCogMenuForReadinessAreCorrect
	When Project created via API and opened
	| ProjectName          | Scope       | ProjectTemplate | Mode               |
	| Project for DAS15665 | All Devices | None            | Standalone Project |
	And User navigates to the 'Readiness' left menu item
	When User clicks Cog-menu for 'RED' item in the 'Readiness' column and sees following cog-menu options
	| options                       |
	| Edit                          |
	| Move to top                   |
	| Move to bottom                |
	| Move to position              |
	| Change to ready               |
	| Make default for applications |
	| Delete                        |
	When User clicks Cog-menu for 'GREEN' item in the 'Readiness' column and sees following cog-menu options
	| options                       |
	| Edit                          |
	| Move to top                   |
	| Move to bottom                |
	| Move to position              |
	| Change to not ready           |
	| Make default for applications |
	| Delete                        |

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15884 @DAS15789 @DAS16131 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAppearWhenDeleteReadiness
	When Project created via API and opened
	| ProjectName      | Scope       | ProjectTemplate | Mode               |
	| DAS15884_Project | All Devices | None            | Standalone Project |
	And User navigates to the 'Readiness' left menu item
	Then grid headers are displayed in the following order
	| ColumnName                  |
	| Readiness                   |
	|                             |
	| Tooltip                     |
	| Ready                       |
	| Default for Applications    |
	| Task Values Count           |
	| Applications Count          |
	| Object App Override Count   |
	| Stage Overrides Count       |
	| Task Values Templates Count |
	When User select "Readiness" rows in the grid
	| SelectedRowsName |
	| RED              |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button 
	Then popup with 'Delete Readiness' title is displayed
	When User clicks 'DELETE' button on popup
	Then 'The selected readiness has been deleted' text is displayed on inline success banner
	Then There are no errors in the browser console
	When User select "Readiness" rows in the grid
	| SelectedRowsName |
	| AMBER            |
	When User selects 'Delete' in the 'Actions' dropdown
	When User clicks 'DELETE' button 
	Then popup with 'Delete Readiness' title is displayed
	When User clicks 'DELETE' button on popup
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS16131 @DAS16226 @DAS16163 @DAS19456 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckReadinessDialogContainerDisplay
	When Project created via API and opened
	| ProjectName      | Scope       | ProjectTemplate | Mode               |
	| DAS16131_Project | All Devices | None            | Standalone Project |
	And User navigates to the 'Readiness' left menu item
	Then grid headers are displayed in the following order
	| ColumnName                  |
	| Readiness                   |
	|                             |
	| Tooltip                     |
	| Ready                       |
	| Default for Applications    |
	| Task Values Count           |
	| Applications Count          |
	| Object App Override Count   |
	| Stage Overrides Count       |
	| Task Values Templates Count |
	When User select "Readiness" rows in the grid
	| SelectedRowsName |
	| RED              |
	When User selects 'Delete' in the 'Actions' dropdown
	And User clicks 'DELETE' button 
	Then popup with 'Delete Readiness' title is displayed
	When User clicks 'CANCEL' button on popup
	And User clicks 'DELETE' button 
	Then popup with 'Delete Readiness' title is displayed
	Then 'CANCEL' popup button color is 'rgba(236, 237, 239, 1)'
	Then 'DELETE' popup button color is 'rgba(242, 88, 49, 1)'
	Then User sees that 'Replacement Readiness' dropdown contains following options:
	| Options |
	| Ignore  |
	When User clicks 'DELETE' button on popup
	Then 'The selected readiness has been deleted' and ', changes might not take effect immediately' texts are displayed on inline success banner

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14937 @DAS16649 @Cleanup @Do_Not_Runt_With_Readiness
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultForApplicationsCheckboxWorksOnEditReadinessPage
	Given User remembers default Readiness for 'Windows 7 Migration (Computer Scheduled Project)' project
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	And User click content from "Readiness" column
	When User selects state 'true' for 'Default' checkbox
	And User clicks 'UPDATE' button 
	And User clicks 'CREATE READINESS' button 
	And User updates readiness properties on Edit Readiness
	| Readiness | Tooltip            | Ready | DefaultForApplications | ColourTemplate | ProjectName                                      |
	| DAS14937  | tooltipForDas14937 | TRUE  | TRUE                   | RED            | Windows 7 Migration (Computer Scheduled Project) |
	And User clicks 'CREATE' button 
	And User enters "BLUE" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	When User selects state 'false' for 'Default' checkbox
	And User clicks 'CANCEL' button 
	And User enters "DAS14937" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	Then 'Default' checkbox is checked

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14937 @DAS15669 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatNewReadinessAddedBeforeIgnore
	Given User remembers default Readiness for 'Windows 7 Migration (Computer Scheduled Project)' project
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	And User clicks 'CREATE READINESS' button 
	And User updates readiness properties on Edit Readiness
	| Readiness  | Tooltip              | Ready | DefaultForApplications | ColourTemplate | ProjectName                                      |
	| DAS14937_1 | tooltipForDas14937_1 | TRUE  | TRUE                   | RED            | Windows 7 Migration (Computer Scheduled Project) |
	And User clicks 'CREATE' button 
	Then 'The readiness has been created' text is displayed on inline success banner
	And Readiness "DAS14937_1" displayed before Ignore

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14937
Scenario: EvergreenJnr_AdminPage_ChecksCreateReadinessElements
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	And User clicks 'CREATE READINESS' button 
	When User enters 'testreadinesname_testreadinesname_testreadinesname_t' text to 'Readiness' textbox
	Then 'testreadinesname_testreadinesname_testreadinesname' content is displayed in 'Readiness' textbox
	Then 'testreadinesname_testreadinesname_testreadinesname' content is displayed in 'Tooltip' textbox
	When User enters 'testtooltipname_testtooltipname_testtooltipname_test' text to 'Readiness' textbox
	Then 'testtooltipname_testtooltipname_testtooltipname_te' content is displayed in 'Readiness' textbox
	When User clicks Colour Template field on Edit Readiness
	Then List of available colours displayed to user on Edit Readiness

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14938 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatDefaultCheckboxCanNotBeUncheckedForReadiness
	When Project created via API and opened
	| ProjectName           | Scope       | ProjectTemplate | Mode               |
	| ReadinessDAS14938_4A2 | All Devices | None            | Standalone Project |
	When User remembers default Readiness for 'ReadinessDAS14938_4A2' project
	And User navigates to the 'Readiness' left menu item
	When User unchecks following checkboxes in the filter dropdown menu for the 'Default for Applications' column:
	| checkboxes |
	| False      |
	Then 'TRUE' content is displayed in the 'Default for Applications' column
	When User click content from "Readiness" column
	And User remembers opened Readiness data on Edit Readiness
	Then 'Default' checkbox is checked
	When User checks 'Default' checkbox
	Then 'Default' checkbox is disabled
	Then 'Default' checkbox is checked
	When User navigates to the 'Readiness' left menu item
	And User clicks 'CREATE READINESS' button 
	And User updates readiness properties on Edit Readiness
	| Readiness  | Tooltip              | Ready | DefaultForApplications | ColourTemplate | ProjectName           |
	| DAS14938_1 | tooltipForDas14938_1 | TRUE  | TRUE                   | RED            | ReadinessDAS14938_4A2 |
	And User clicks 'CREATE' button 
	Then 'The readiness has been created' text is displayed on inline success banner
	When User enters stored readiness name in Search field for "Readiness" column
	And User click content from "Readiness" column
	Then User checks that opened readiness name is the same as stored one
	Then 'Default' checkbox is unchecked
	When User navigates to the 'Readiness' left menu item
	When User unchecks following checkboxes in the filter dropdown menu for the 'Default for Applications' column:
	| checkboxes |
	| False      |
	And User click content from "Readiness" column
	Then 'Default' checkbox is disabled
	Then 'Default' checkbox is checked

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14938 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatIgnoreReadinessCanBePartiallyEdited
	When Project created via API and opened
	| ProjectName       | Scope       | ProjectTemplate | Mode               |
	| ReadinessDAS14938 | All Devices | None            | Standalone Project |
	And User navigates to the 'Readiness' left menu item
	And User enters "Ignore" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	Then 'Readiness' textbox is disabled
	When User enters 'tooltip14938_1' text to 'Tooltip' textbox
	When User selects state 'true' for 'Ready' checkbox
	When User selects state 'true' for 'Default' checkbox
	And User clicks Colour Template field on Edit Readiness
	Then List of available colours is not displayed to user on Edit Readiness
	When User clicks 'UPDATE' button 
	And User enters "Ignore" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	Then 'IGNORE' content is displayed in 'Readiness' textbox
	Then 'tooltip14938_1' content is displayed in 'Tooltip' textbox
	Then 'Ready' checkbox is checked
	Then 'Default' checkbox is checked
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14938
Scenario: EvergreenJnr_AdminPage_CheckThatNoChangesAppliedAfterCancelButtonPressedOnEditReadiness
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	And User enters "Ignore" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	When User enters 'tooltip14938_2' text to 'Tooltip' textbox
	And User clicks 'CANCEL' button 
	And User enters "Ignore" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	Then 'Ignore' content is displayed in 'Readiness' textbox
	Then 'Tooltip' textbox content is not equal to 'tooltip14938_2' text
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14938 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatCancelReadinessAffectsNothingOnEditReadiness
	When Project created via API and opened
	| ProjectName      | Scope       | ProjectTemplate | Mode               |
	| DAS14938_Project | All Devices | None            | Standalone Project |
	And User navigates to the 'Readiness' left menu item
	When User unchecks following checkboxes in the filter dropdown menu for the 'Default for Applications' column:
	| checkboxes |
	| False      |
	When User click content from "Readiness" column
	And User remembers opened Readiness data on Edit Readiness
	When User clicks 'CANCEL' button 
	When User unchecks following checkboxes in the filter dropdown menu for the 'Default for Applications' column:
	| checkboxes |
	| False      |
	Then "IGNORE" content is displayed for "Readiness" column
	Then Filtered readiness item equals to stored one

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS16148 @DAS16226 @DAS16163
Scenario: EvergreenJnr_AdminPage_ChecksThatValuesForReadinessGridAreDisplayedProperlyAfterUsingCogMenuOptions
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User enters "2004 Rollout" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Readiness' left menu item
	When User enters "Grey" text in the Search field for "Readiness" column
	Then "FALSE" content is displayed for "Ready" column
	Then "1" content is displayed for "Task Values Count" column
	When User clicks 'Change to ready' option in Cog-menu for 'GREY' item from 'Readiness' column
	Then 'click here to view the Grey readiness' link is displayed
	Then 'The readiness has been updated' and ', changes might not take effect immediately' texts are displayed on inline success banner
	When User clicks newly created object link
	Then 'Update Readiness' page subheader is displayed to user
	When User clicks 'CANCEL' button 
	When User enters "Grey" text in the Search field for "Readiness" column
	Then "TRUE" content is displayed for "Ready" column
	Then "1" content is displayed for "Task Values Count" column
	When User clicks 'Change to not ready' option in Cog-menu for 'GREY' item from 'Readiness' column
	Then 'click here to view the Grey readiness' link is displayed
	Then 'The readiness has been updated' and ', changes might not take effect immediately' texts are displayed on inline success banner
	When User enters "Grey" text in the Search field for "Readiness" column
	Then "FALSE" content is displayed for "Ready" column
	Then "1" content is displayed for "Task Values Count" column
	When User clicks newly created object link
	Then 'Update Readiness' page subheader is displayed to user
	When User clicks 'CANCEL' button 
	When User clicks 'Make default for applications' option in Cog-menu for 'AMBER' item from 'Readiness' column
	Then 'click here to view the Amber readiness' link is displayed
	Then 'The readiness has been updated' and ', changes might not take effect immediately' texts are displayed on inline success banner
	When User clicks newly created object link
	Then 'Update Readiness' page subheader is displayed to user
	When User clicks 'CANCEL' button 
	When User clicks 'Make default for applications' option in Cog-menu for 'BLOCKED' item from 'Readiness' column
	When User opens 'Readiness' column settings
	And User clicks Column button on the Column Settings panel
	And User select "Ready" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then grid headers are displayed in the following order
	| ColumnName                  |
	| Readiness                   |
	|                             |
	| Tooltip                     |
	| Default for Applications    |
	| Task Values Count           |
	| Applications Count          |
	| Object App Override Count   |
	| Stage Overrides Count       |
	| Task Values Templates Count |

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15769
Scenario: EvergreenJnr_AdminPage_ChecksThatNoWarningDisplayedWhenOpenningReadinessPage
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Details' left menu item
	Then 'This project contains 10870 created objects which are not displayed in Evergreen' text is displayed on inline tip banner
	When User navigates to the 'Readiness' left menu item
	Then inline tip banner is not displayed

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15673
Scenario: EvergreenJnr_AdminPage_CheckThatReadinessRightClickMenuCopyOptionsWorks
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "User Evergreen Capacity Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	When User right clicks on 'RED' cell from 'Readiness' column
	And User selects 'Copy row' option in context menu
	Then There are no errors in the browser console
	And Next data 'Red\t\tRed\tFalse\tFalse\t5\t0\t0\t0\t4' is copied
	When User clicks refresh button in the browser
	When User right clicks on 'AMBER' cell from 'Readiness' column
	And User selects 'Copy cell' option in context menu
	Then There are no errors in the browser console
	And Next data 'Amber' is copied

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15720 @DAS15720 @DAS16653 @DAS16617
Scenario: EvergreenJnr_AdminPage_CheckThatReadinessCanBeSortedByClickingColumnHeader
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Havoc (Big Data)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	When User opens 'Readiness' column settings
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Priority" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Priority   |
	When User clicks on 'Readiness' column header
	Then numeric data in table is sorted by 'Priority' column in descending order
	When User clicks on 'Readiness' column header
	Then numeric data in table is sorted by 'Priority' column in ascending order
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15898
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageAboutUnconfirmedChangesAppears
	When User navigates to "2004 Rollout" project details
	And User navigates to the 'Readiness' left menu item
	And User enters "GREY" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	When User selects state 'true' for 'Default' checkbox
	And User navigates to the 'Capacity' left menu item
	Then 'You have unsaved changes. Are you sure you want to leave the page?' text is displayed on popup
	Then "YES" button is displayed in the warning message
	Then "NO" button is displayed in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS16363
Scenario: EvergreenJnr_AdminPage_CheckThatReadinessAreTranslatedAccordingToAccountLanguageOnCreatePage
	When User language is changed to "Deutsch" via API
	And User navigates to Create Readiness page of "2004 Rollout" project
	And User clicks Colour Template field on Edit Readiness
	Then User sees following options for Colour Template selector on Create Readiness page:
	| ColorTemplate |
	| SCHWARZ       |
	| BLAU          |
	| TÜRKIS        |
	| ROT           |
	| BRAUN         |
	| PINK          |
	| BERNSTEIN     |
	| ORANGE        |
	| LILA          |
	| GRÜN          |
	| GRAU          |
	| SILBER        |

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS16363
Scenario: EvergreenJnr_AdminPage_CheckThatReadinessAreTranslatedAccordingToAccountLanguageOnEditPage
	When User language is changed to "Deutsch" via API
	And User navigates to Readiness page of "2004 Rollout" project
	And User enters "GREEN" text in the Search field for "Bereitschaft" column
	And User click content from "Bereitschaft" column
	And User clicks Colour Template field on Edit Readiness
	Then User sees following options for Colour Template selector on Create Readiness page:
	| ColorTemplate |
	| SCHWARZ       |
	| BLAU          |
	| TÜRKIS        |
	| ROT           |
	| BRAUN         |
	| PINK          |
	| BERNSTEIN     |
	| ORANGE        |
	| LILA          |
	| GRÜN          |
	| GRAU          |
	| SILBER        |