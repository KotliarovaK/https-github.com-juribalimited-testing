Feature: ProjectsPart23
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @Senior_Projects @DAS14819 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatConvertButtonDisappearsAfterProjectConverting
	When User clicks "Projects" on the left-hand menu
	When User clicks create Project button
	When User creates new Project on Senior
	| ProjectName     | ShortName | Description | Type |
	| DAS14819Project | 14819     |             |      |
	And User clicks the Switch to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	When User enters "DAS14819Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks Converts to Evergreen button
	Then Warning message with "Are you sure you want to convert this project to Evergreen? This cannot be undone" text is displayed on the Project Details Page
	And Cancel button is displayed in warning message
	When User confirms converting to Evergreen process
	Then Success converting message appears with the next "This legacy project has successfully been converted to Evergreen" text
	And Convert to Evergreen button is not displayed
	When User clicks Admin on the left-hand menu
	And User enters "DAS14819Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @Senior_Projects @DAS15260 @DAS15794 @Delete_Newly_Created_Project
Scenario: EvergreenJnr_AdminPage_ChecksThatCorrectCountersDisplayedInRingGridForDeviceScopedProject
	When User clicks "Projects" on the left-hand menu
	And User clicks create Project button
	And User creates new Project on Senior
	| ProjectName     | ShortName | Description | Type |
	| DAS15260Project | 15260     |             |      |
	And User clicks the Switch to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	And User enters "DAS15260Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Details" tab
	And User converts project to evergreen project
	And User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User enters "DAS15260Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	And User selects following Objects to the Project
	| Objects         |
	| 001PSUMZYOW581  |
	And User clicks "Users" tab in the Project Scope Changes section
	And User selects following Objects to the Project
	| Objects                        |
	| AAD1011948 (Pinabel Cinq-Mars) |
	And User clicks "Applications" tab in the Project Scope Changes section
	And User selects following Objects to the Project
	| Objects                                            |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais (5.0.5) |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "1 device will be added, 1 user will be added, 1 application will be added" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	And User selects "Queue" tab on the Project details page
	And User waits until Queue disappears
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Evergreen" link on the Admin page
	When User clicks "Rings" tab
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "DAS15260Project" checkbox from String Filter with item list on the Admin page
	Then "1" content is displayed in "Devices" column
	And "0" content is displayed in "Users" column
	And "0" content is displayed in "Mailboxes" column
	When User clicks Admin on the left-hand menu
	And User enters "DAS15260Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @DAS12389 @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectPageDisplayedWhenOpeningNotExistingProjectPage
	When User clicks Admin on the left-hand menu
	And User clicks "Projects" link on the Admin page
	And User tries to open not existing page
	Then Page not found displayed for the user
	And There are only page not found errors in console

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @Senior_Projects @DAS16137
Scenario: EvergreenJnr_AdminPage_CheckThat403FullPageErrorAppearsAfterUserWithoutPermissionsNavigatesToAdminPages
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username      | FullName  | Password | ConfirmPassword | Roles                     |
	| DAS16137_user | Test_User | 1234qwer | 1234qwer        | Dashworks Evergreen Users |
	|               |           |          |                 | Analysis Editor           |
	Then Success message is displayed
	When User cliks Logout link
	Then User is logged out
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User login with following credentials:
	| Username      | Password |
	| DAS16137_user | 1234qwer |
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user
	When Evergreen QueryStringURL is entered for Simple QueryType with expecting error
	| QueryType | QueryStringURL                            |
	| Devices   | evergreen/#/admin/project/63/scope/scopeChanges |
	Then Admin menu item is hidden
	Then Error is displayed to the User