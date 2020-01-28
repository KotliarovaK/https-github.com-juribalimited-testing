Feature: ProjectsPart26
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS19363 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatAppOwnersSectionIsDisabledWhenDoNotIncludeUsersRadioSelected
	When Project created via API and opened
	| ProjectName         | Scope         | ProjectTemplate | Mode               |
	| DAS19363_AllDevices | All Mailboxes | None            | Standalone Project |
	When User navigates to "DAS19363_AllDevices" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'User Scope' tab on Project Scope Changes page
	When User clicks 'Do not include users' radio button
	Then 'Do not include app owners' radio button is disabled
	Then 'Include app owners' radio button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS18759 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatProjectBasedOnListHavingFilteredByGroupCanBeCreated
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User add "Group" filter where type is "Equals" without added column and "AU\GAPP-A0121127" Lookup option
	When User clicks Save button on the list panel
	When User create dynamic list with "ListForDAS18759" name on "Devices" page
	Then "ListForDAS18759" list is displayed to user
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'TestProject18759' text to 'Project Name' textbox
	When User selects 'ListForDAS18759' option from 'Scope' autocomplete
	When User selects "Clone from Evergreen to Project" in the Mode Project dropdown
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	Then There are no errors in the browser console
	When User navigates to "TestProject18759" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left submenu item
	Then 'ListForDAS18759' content is displayed in 'Scope' dropdown
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User navigates to the "ListForDAS18759" list
	When User clicks the List Details button
	Then Details panel is displayed to the user
	When User expand Dependants section
	Then Dependants section is displayed to the user
	When User clicks "TestProject18759" list in the Dependants section
