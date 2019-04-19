Feature: Readiness
	Runs Readiness related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15665 @DAS14994 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatOptionsInTheCogMenuForReadinessAreCorrect
	When User clicks Admin on the left-hand menu
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "Project for DAS15665" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User clicks "Readiness" tab
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15884 @DAS15789 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAppearWhenDeleteReadiness
	When User clicks Admin on the left-hand menu
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "DAS15884_Project" in the "Project Name" field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	And User clicks "Readiness" tab
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

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS15769
Scenario: EvergreenJnr_AdminPage_ChecksThatNoWarningDisplayedWhenOpenningReadinessPage
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Details" tab
	Then Warning message with "created objects which are not displayed in Evergreen" text is displayed on the Project Details Page
	When User clicks "Readiness" tab
	Then No warning message displayed on the Project Details Page

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14937
Scenario: EvergreenJnr_AdminPage_ChecksThatDefaultForApplicationsCheckboxWorksOnEditReadinessPage
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Readiness" tab
	When User enters "BLUE" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	And User sets Default for Applications checkbox in "TRUE" on Edit Readiness
	And User clicks the "UPDATE" Action button
	And User clicks the "CREATE READINESS" Action button
	And User updates readiness properties on Edit Readiness
	| Readiness | Tooltip            | Ready | DefaultForApplications | ColourTemplate |
	| DAS14937  | tooltipForDas14937 | TRUE  | TRUE                   | RED            |
	And User clicks the "CREATE" Action button
	And User enters "BLUE" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	When User sets Default for Applications checkbox in "FALSE" on Edit Readiness
	And User clicks the "CANCEL" Action button
	And User enters "DAS14937" text in the Search field for "Readiness" column
	And User click content from "Readiness" column
	Then User sees Default for Applications checkbox in "TRUE" state on Edit Readiness

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14937
Scenario: EvergreenJnr_AdminPage_ChecksThatNewReadinessAddedBeforeNone
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Readiness" tab
	And User clicks the "CREATE READINESS" Action button
	And User updates readiness properties on Edit Readiness
	| Readiness  | Tooltip              | Ready | DefaultForApplications | ColourTemplate |
	| DAS14937_1 | tooltipForDas14937_1 | TRUE  | TRUE                   | RED            |
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The readiness has been created" text 
	And Readiness "DAS14937_1" displayed before None

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14937
Scenario: EvergreenJnr_AdminPage_ChecksCreateReadinessElements
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Readiness" tab
	And User clicks the "CREATE READINESS" Action button
	And User enters "testreadinesname_testreadinesname_testreadinesname_t" in Readiness input on Edit Readiness
	Then User sees "testreadinesname_testreadinesname_testreadinesname" in Readiness input on Edit Readiness
	And User sees "testreadinesname_testreadinesname_testreadinesname" in Tooltip input on Edit Readiness
	When User enters "testtooltipname_testtooltipname_testtooltipname_test" in Tooltip input on Edit Readiness
	Then User sees "testtooltipname_testtooltipname_testtooltipname_te" in Tooltip input on Edit Readiness
	When User clicks Colour Template field on Edit Readiness
	Then List of available colours displayed to user on Edit Readiness

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14938
Scenario: EvergreenJnr_AdminPage_CheckThatDefaultCheckboxCanNotBeUncheckedForReadiness
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Readiness" tab
	When User clicks String Filter button for "Default for Applications" column on the Admin page
	And User clicks "False" checkbox from boolean filter on the Admin page
	Then "TRUE" content is displayed in "Default for Applications" column
	When User click content from "Readiness" column
	And User remembers opened Readiness data on Edit Readiness
	Then User sees Default for Applications checkbox in "TRUE" state on Edit Readiness
	When User clicks Default for Applications checkbox on Edit Readiness
	Then User sees Default for Applications checkbox disabled on Edit Readiness
	And User sees Default for Applications checkbox in "TRUE" state on Edit Readiness
	When User clicks "Readiness" tab
	And User clicks the "CREATE READINESS" Action button
	And User updates readiness properties on Edit Readiness
	| Readiness  | Tooltip              | Ready | DefaultForApplications | ColourTemplate |
	| DAS14938_1 | tooltipForDas14938_1 | TRUE  | TRUE                   | RED            |
	And User clicks the "CREATE" Action button
	Then Success message is displayed and contains "The readiness has been created" text 
	When User enters stored readiness name in Search field for "Readiness" column
	And User click content from "Readiness" column
	Then User checks that opened readiness name is the same as stored one
	And User sees Default for Applications checkbox in "FALSE" state on Edit Readiness
	When User clicks "Readiness" tab
	And User clicks String Filter button for "Default for Applications" column on the Admin page
	And User clicks "False" checkbox from boolean filter on the Admin page
	And User click content from "Readiness" column
	Then User sees Default for Applications checkbox disabled on Edit Readiness
	And User sees Default for Applications checkbox in "TRUE" state on Edit Readiness

@Evergreen @Admin @EvergreenJnr_AdminPage @Readiness @DAS14938
Scenario: EvergreenJnr_AdminPage_CheckThatNoneReadinessCanBePartiallyEdited
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Readiness" tab
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
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Readiness" tab
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
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "Windows 7 Migration (Computer Scheduled Project)" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Readiness" tab
	When User clicks String Filter button for "Default for Applications" column on the Admin page
	And User clicks "False" checkbox from boolean filter on the Admin page
	When User click content from "Readiness" column
	And User remembers opened Readiness data on Edit Readiness
	When User clicks the "CANCEL" Action button
	And User clicks String Filter button for "Default for Applications" column on the Admin page
	And User clicks "False" checkbox from boolean filter on the Admin page
	Then Filtered readiness item equals to stored one