Feature: ProjectsPart23
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @Senior_Projects @DAS14819 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatConvertButtonDisappearsAfterProjectConverting
	When User clicks 'Projects' on the left-hand menu
	When User clicks create Project button
	When User creates new Project on Senior
	| ProjectName     | ShortName | Description | Type |
	| DAS14819Project | 14819     |             |      |
	And User clicks the Switch to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	When User enters "DAS14819Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks Converts to Evergreen button
	Then 'Are you sure you want to convert this project to Evergreen? This cannot be undone' text is displayed on inline tip banner
	And Cancel button is displayed in warning message
	When User confirms converting to Evergreen process
	Then 'This legacy project has successfully been converted to Evergreen' text is displayed on inline success banner
	And Convert to Evergreen button is not displayed
	When User clicks 'Admin' on the left-hand menu
	And User enters "DAS14819Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @Senior_Projects @DAS15260 @DAS15794 @Cleanup
Scenario: EvergreenJnr_AdminPage_ChecksThatCorrectCountersDisplayedInRingGridForDeviceScopedProject
	When User clicks 'Projects' on the left-hand menu
	And User clicks create Project button
	And User creates new Project on Senior
	| ProjectName     | ShortName | Description | Type |
	| DAS15260Project | 15260     |             |      |
	And User clicks the Switch to Evergreen link
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	And User enters "DAS15260Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Details' left menu item
	And User converts project to evergreen project
	And User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User enters "DAS15260Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Devices' tab on Project Scope Changes page
	And User expands multiselect and selects following Objects
	| Objects         |
	| 001PSUMZYOW581  |
	And User navigates to the 'Users' tab on Project Scope Changes page
	And User expands multiselect and selects following Objects
	| Objects                        |
	| AAD1011948 (Pinabel Cinq-Mars) |
	And User navigates to the 'Applications' tab on Project Scope Changes page
	And User expands multiselect and selects following Objects
	| Objects                                            |
	| 0004 - Adobe Acrobat Reader 5.0.5 Francais (5.0.5) |
	And User clicks 'UPDATE ALL CHANGES' button 
	Then '1 device will be added, 1 user will be added, 1 application will be added' text is displayed on inline tip banner
	When User clicks 'UPDATE PROJECT' button 
	And User navigates to the 'Queue' left menu item
	And User waits until Queue disappears
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Evergreen' left menu item
	When User navigates to the 'Rings' left menu item
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "DAS15260Project" checkbox from String Filter with item list on the Admin page
	Then '1' content is displayed in the 'Devices' column
	And '' content is displayed in the 'Users' column
	And '' content is displayed in the 'Mailboxes' column
	When User clicks 'Admin' on the left-hand menu
	And User enters "DAS15260Project" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @DAS12389
Scenario: EvergreenJnr_AdminPage_CheckThatCorrectPageDisplayedWhenOpeningNotExistingProjectPage
	When User clicks 'Admin' on the left-hand menu
	And User navigates to the 'Projects' left menu item
	And User tries to open not existing page
	Then Page not found displayed for the user
	And There are only 'Page not found' errors in console

@Evergreen @Admin @EvergreenJnr_AdminPage @Projects @Senior_Projects @DAS16137 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThat403FullPageErrorAppearsAfterUserWithoutPermissionsNavigatesToAdminPages
	When User clicks 'Projects' on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to Manage link
	And User select "Manage Users" option in Management Console
	And User create new User
	| Username      | FullName  | Password | ConfirmPassword | Roles                     |
	| DAS16137_user | Test_User | 1234qwer | 1234qwer        | Analysis Editor           |
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
	| QueryType | QueryStringURL                                  |
	| Devices   | evergreen/#/admin/project/63/scope/scopeChanges |
	Then 'Admin' left-hand menu item is hidden
	Then error page with '403' status code and 'You are not authorized to view this page, speak to your Dashworks administrator' error message is displayed