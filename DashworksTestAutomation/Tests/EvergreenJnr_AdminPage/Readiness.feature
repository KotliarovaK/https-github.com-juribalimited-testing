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
	When User clicks Cog-menu for "Red" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items                         |
	| Edit                          |
	| Move to top                   |
	| Move to bottom                |
	| Move to position              |
	| Change to ready               |
	| Make default for applications |
	| Delete                        |
	When User clicks Cog-menu for "Green" item on Admin page
	Then User sees following cog-menu items on Admin page:
	| items                         |
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
	Then Columns on Admin page is displayed in following order:
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
	When User clicks on Actions button
	When User clicks Delete button in Actions
	When User clicks the "DELETE" Action button
	Then Readiness Dialog Container is displayed to the User
	When User clicks "DELETE" button in the Readiness dialog screen
	Then Success message is displayed and contains "The selected readiness has been deleted" text
	Then There are no errors in the browser console
	When User select "Readiness" rows in the grid
	| SelectedRowsName |
	| AMBER            |
	When User clicks on Actions button
	When User clicks Delete button in Actions
	When User clicks the "DELETE" Action button
	Then Readiness Dialog Container is displayed to the User
	When User clicks "DELETE" button in the Readiness dialog screen
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS16131 @DAS16226 @DAS16163 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckReadinessDialogContainerDisplay
	When Project created via API and opened
	| ProjectName      | Scope       | ProjectTemplate | Mode               |
	| DAS16131_Project | All Devices | None            | Standalone Project |
	And User navigates to the 'Readiness' left menu item
	Then Columns on Admin page is displayed in following order:
	| ColumnName |
	| Readiness  |
	|            |
	| Tooltip    |
	| Ready      |
	| Default for Applications    |
	| Task Values Count           |
	| Applications Count          |
	| Object App Override Count   |
	| Stage Overrides Count       |
	| Task Values Templates Count |
	When User select "Readiness" rows in the grid
	| SelectedRowsName |
	| RED              |
	When User clicks on Actions button
	And User clicks Delete button in Actions
	And User clicks the "DELETE" Action button
	Then Readiness Dialog Container is displayed to the User
	And "Delete Readiness" title is displayed in the Readiness Dialog Container
	When User clicks "CANCEL" button in the Readiness dialog screen
	And User select "Readiness" rows in the grid
	| SelectedRowsName |
	| GREEN            |
	And User clicks the "DELETE" Action button
	Then Readiness Dialog Container is displayed to the User
	Then "Delete Readinesses" title is displayed in the Readiness Dialog Container
	Then Cancel button in the pop up is colored gray
	Then Delete button in the pop up is colored amber
	When User clicks "DELETE" button in the Readiness dialog screen
	Then Success message is displayed and contains "The selected readinesses have been deleted, changes might not take effect immediately" text
	When User clicks 'Admin' on the left-hand menu
	And User enters "DAS16131_Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14937 @DAS16649 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultForApplicationsCheckboxWorksOnEditReadinessPage
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	And User click content from "Readiness" column
	And User sets Default for Applications checkbox in "TRUE" on Edit Readiness
	And User clicks the "UPDATE" Action button
	And User clicks the "CREATE READINESS" Action button
	And User updates readiness properties on Edit Readiness
	| Readiness | Tooltip            | Ready | DefaultForApplications | ColourTemplate | ProjectName                                      |
	| DAS14937  | tooltipForDas14937 | TRUE  | TRUE                   | RED            | Windows 7 Migration (Computer Scheduled Project) |
	And User clicks the "CREATE" Action button
	And User enters "BLUE" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	When User sets Default for Applications checkbox in "FALSE" on Edit Readiness
	And User clicks the "CANCEL" Action button
	And User enters "DAS14937" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	Then User sees Default for Applications checkbox in "TRUE" state on Edit Readiness

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14937 @DAS15669 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatNewReadinessAddedBeforeNone
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	And User clicks the "CREATE READINESS" Action button
	And User updates readiness properties on Edit Readiness
	| Readiness  | Tooltip              | Ready | DefaultForApplications | ColourTemplate | ProjectName                                      |
	| DAS14937_1 | tooltipForDas14937_1 | TRUE  | TRUE                   | RED            | Windows 7 Migration (Computer Scheduled Project) |
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The readiness has been created" text
	And Readiness "DAS14937_1" displayed before None

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14937
Scenario: EvergreenJnr_AdminPage_ChecksCreateReadinessElements
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	And User clicks the "CREATE READINESS" Action button
	And User enters "testreadinesname_testreadinesname_testreadinesname_t" in Readiness input on Edit Readiness
	Then User sees "testreadinesname_testreadinesname_testreadinesname" in Readiness input on Edit Readiness
	And User sees "testreadinesname_testreadinesname_testreadinesname" in Tooltip input on Edit Readiness
	When User enters "testtooltipname_testtooltipname_testtooltipname_test" in Tooltip input on Edit Readiness
	Then User sees "testtooltipname_testtooltipname_testtooltipname_te" in Tooltip input on Edit Readiness
	When User clicks Colour Template field on Edit Readiness
	Then List of available colours displayed to user on Edit Readiness

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14938 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatDefaultCheckboxCanNotBeUncheckedForReadiness
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	When User clicks String Filter button for "Default for Applications" column on the Admin page
	And User clicks "False" checkbox from boolean filter on the Admin page
	Then "TRUE" content is displayed in "Default for Applications" column
	When User click content from "Readiness" column
	And User remembers opened Readiness data on Edit Readiness
	Then User sees Default for Applications checkbox in "TRUE" state on Edit Readiness
	When User clicks Default for Applications checkbox on Edit Readiness
	Then User sees Default for Applications checkbox disabled on Edit Readiness
	And User sees Default for Applications checkbox in "TRUE" state on Edit Readiness
	When User navigates to the 'Readiness' left menu item
	And User clicks the "CREATE READINESS" Action button
	And User updates readiness properties on Edit Readiness
	| Readiness  | Tooltip              | Ready | DefaultForApplications | ColourTemplate | ProjectName                                      |
	| DAS14938_1 | tooltipForDas14938_1 | TRUE  | TRUE                   | RED            | Windows 7 Migration (Computer Scheduled Project) |
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The readiness has been created" text
	When User enters stored readiness name in Search field for "Readiness" column
	And User click content from "Readiness" column
	Then User checks that opened readiness name is the same as stored one
	And User sees Default for Applications checkbox in "FALSE" state on Edit Readiness
	When User navigates to the 'Readiness' left menu item
	And User clicks String Filter button for "Default for Applications" column on the Admin page
	And User clicks "False" checkbox from boolean filter on the Admin page
	And User click content from "Readiness" column
	Then User sees Default for Applications checkbox disabled on Edit Readiness
	And User sees Default for Applications checkbox in "TRUE" state on Edit Readiness

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14938
Scenario: EvergreenJnr_AdminPage_CheckThatNoneReadinessCanBePartiallyEdited
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	And User enters "None" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	Then Readiness input displayed disabled on Edit Readiness
	When User enters "tooltip14938_1" in Tooltip input on Edit Readiness
	And User sets Ready checkbox in "TRUE" on Edit Readiness
	And User sets Default for Applications checkbox in "TRUE" on Edit Readiness
	And User clicks Colour Template field on Edit Readiness
	Then List of available colours is not displayed to user on Edit Readiness
	When User clicks the "UPDATE" Action button
	And User enters "None" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	Then User sees "None" in Readiness input on Edit Readiness
	And User sees "tooltip14938_1" in Tooltip input on Edit Readiness
	And User sees Ready checkbox in "TRUE" state on Edit Readiness
	And User sees Default for Applications checkbox in "TRUE" state on Edit Readiness
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14938
Scenario: EvergreenJnr_AdminPage_CheckThatNoChangesAppliedAfterCancelButtonPressedOnEditReadiness
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	And User enters "None" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	And User enters "tooltip14938_2" in Tooltip input on Edit Readiness
	And User clicks the "CANCEL" Action button
	And User enters "None" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	Then User sees "None" in Readiness input on Edit Readiness
	And User sees Tooltip field not equal to "tooltip14938_2" on Edit Readiness
	
@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14938
Scenario: EvergreenJnr_AdminPage_CheckThatCancelReadinessAffectsNothingOnEditReadiness
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	When User clicks String Filter button for "Default for Applications" column on the Admin page
	And User clicks "False" checkbox from boolean filter on the Admin page
	When User click content from "Readiness" column
	And User remembers opened Readiness data on Edit Readiness
	When User clicks the "CANCEL" Action button
	And User clicks String Filter button for "Default for Applications" column on the Admin page
	And User clicks "False" checkbox from boolean filter on the Admin page
	Then Filtered readiness item equals to stored one

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS16148 @DAS16226 @DAS16163
Scenario: EvergreenJnr_AdminPage_ChecksThatValuesForReadinessGridAreDisplayedProperlyAfterUsingCogMenuOptions
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User enters "1803 Rollout" text in the Search field for "Project" column
	When User clicks content from "Project" column
	When User navigates to the 'Readiness' left menu item
	When User enters "Grey" text in the Search field for "Readiness" column
	Then "FALSE" content is displayed for "Ready" column
	Then "1" content is displayed for "Task Values Count" column
	When User clicks "Change to ready" option in Cog-menu for "Grey" item on Admin page
	Then Success message is displayed and contains "The readiness has been updated" text
	Then Success message is displayed and contains "click here to view the Grey readiness" link
	Then Green banner contains following text "changes might not take effect immediately"
	When User clicks newly created object link
	Then 'Update Readiness' page subheader is displayed to user
	When User clicks the "CANCEL" Action button
	When User enters "Grey" text in the Search field for "Readiness" column
	Then "TRUE" content is displayed for "Ready" column
	Then "1" content is displayed for "Task Values Count" column
	When User clicks "Change to not ready" option in Cog-menu for "Grey" item on Admin page
	Then "FALSE" content is displayed for "Ready" column
	Then "1" content is displayed for "Task Values Count" column
	When User clicks Reset Filters button on the Admin page
	When User clicks "Change to not ready" option in Cog-menu for "Green" item on Admin page
	Then Success message is displayed and contains "The readiness has been updated" text
	Then Success message is displayed and contains "click here to view the Green readiness" link
	Then Green banner contains following text "changes might not take effect immediately"
	When User clicks newly created object link
	Then 'Update Readiness' page subheader is displayed to user
	When User clicks the "CANCEL" Action button
	When User clicks "Change to ready" option in Cog-menu for "Green" item on Admin page
	When User clicks "Make default for applications" option in Cog-menu for "Apps In Initiation" item on Admin page
	Then Success message is displayed and contains "The readiness has been updated" text
	Then Success message is displayed and contains "click here to view the Light Blue readiness" link
	Then Green banner contains following text "changes might not take effect immediately"
	When User clicks newly created object link
	Then 'Update Readiness' page subheader is displayed to user
	When User clicks the "CANCEL" Action button
	When User clicks "Make default for applications" option in Cog-menu for "Red" item on Admin page
	When User have opened column settings for "Readiness" column
	And User clicks Column button on the Column Settings panel
	And User select "Ready" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then Columns on Admin page is displayed in following order:
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
	Then Warning message with "created objects which are not displayed in Evergreen" text is displayed on the Project Details Page
	When User navigates to the 'Readiness' left menu item
	Then No warning message displayed on the Project Details Page

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15673
Scenario: EvergreenJnr_AdminPage_CheckThatReadinessRightClickMenuCopyOptionsWorks
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "Havoc (Big Data)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Readiness' left menu item
	And User performs right-click on "Red" cell in the grid
	And User selects 'Copy row' option in context menu
	Then There are no errors in the browser console
	And Next data '\tRed\t\tRed\tFalse\tFalse\t50\t1\t0\t0\t4' is copied
	When User clicks refresh button in the browser
	And User performs right-click on "Amber" cell in the grid
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
	When User have opened Column Settings for "Readiness" column
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
	When User navigates to "1803 Rollout" project details
	And User navigates to the 'Readiness' left menu item
	And User enters "GREY" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	And User sets Default for Applications checkbox in "TRUE" on Edit Readiness
	And User navigates to the 'Capacity' left menu item
	Then "You have unsaved changes. Are you sure you want to leave the page?" text is displayed in the warning message
	Then "YES" button is displayed in the warning message
	Then "NO" button is displayed in the warning message

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS16363
Scenario: EvergreenJnr_AdminPage_CheckThatReadinessAreTranslatedAccordingToAccountLanguageOnCreatePage
	When User language is changed to "Deutsch" via API
	And User navigates to Create Readiness page of "1803 Rollout" project
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
	And User navigates to Readiness page of "1803 Rollout" project
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