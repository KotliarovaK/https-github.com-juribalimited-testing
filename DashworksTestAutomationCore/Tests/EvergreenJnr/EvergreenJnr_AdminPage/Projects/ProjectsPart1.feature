Feature: ProjectsPart1
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11697 @DAS12744 @DAS12999 @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckThatCancelButtonOnTheCreateProjectPageRedirectsToTheLastPage
	When User clicks '<ListName>' on the left-hand menu
	Then 'All <ListName>' list should be displayed to the user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User clicks 'CANCEL' button 
	Then 'All <ListName>' list should be displayed to the user

Examples:
	| ListName  |
	| Devices   |
	| Users     |
	| Mailboxes |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11982 @DAS12773 @DAS19205 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatAllAssociationsAreSelectedByDefaultInTheProjectApplicationsScope
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	Then There are no errors in the browser console
	Then All items in the 'Scope' autocomplete have icons
	Then All icon items in the 'Scope' autocomplete have any of tooltip
	| tooltip |
	| System  |
	| Private |
	| Shared  |
	When User enters 'TestProject7' text to 'Project Name' textbox
	When User selects 'All Devices' option from 'Scope' autocomplete
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	Then Page with 'TestProject7' header is displayed to user
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 2129 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	Then 'Entitled to the device owner' checkbox is checked
	Then 'Entitled to the device' checkbox is checked
	Then 'Installed on the device' checkbox is checked
	Then 'Used by the device owner on any device' checkbox is checked
	Then 'Used on the device by the device owner' checkbox is checked
	Then 'Used on the device by any user' checkbox is checked
	When User selects "Do not include applications" checkbox on the Project details page
	Then 'Entitled to the device owner' checkbox is disabled
	Then 'Entitled to the device' checkbox is disabled
	Then 'Installed on the device' checkbox is disabled
	Then 'Used by the device owner on any device' checkbox is disabled
	Then 'Used on the device by the device owner' checkbox is disabled
	Then 'Used on the device by any user' checkbox is disabled
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the 'Application Scope' tab on Project Scope Changes page
	When User selects "Include applications" checkbox on the Project details page
	Then 'Entitled to the device owner' checkbox is checked
	Then 'Entitled to the device' checkbox is checked
	Then 'Installed on the device' checkbox is checked
	Then 'Used by the device owner on any device' checkbox is checked
	Then 'Used on the device by the device owner' checkbox is checked
	Then 'Used on the device by any user' checkbox is checked

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS14283 @DAS17167 @DAS20240 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatExistingProjectNameCantBeRemoved
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	Then Page with 'Projects' header is displayed to user
	When User clicks 'CREATE PROJECT' button 
	When User enters 'TestProject14283' text to 'Project Name' textbox
	When User selects 'All Devices' option from 'Scope' autocomplete
	When User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	Then Page with 'TestProject14283' header is displayed to user
	When User selects 'Dependant List Filter - BROKEN LIST' in the 'Scope' dropdown
	Then 'This list has errors' error message is displayed for 'Scope' dropdown
	When User navigates to the 'Details' left menu item
	When User enters '' text to 'Project Name' textbox
	When User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	When User navigates to the 'Projects' left menu item
	When User enters "TestProject14283" text in the Search field for "Project" column
	Then 'TestProject14283' content is displayed in the 'Project' column
	When User clicks 'CREATE PROJECT' button 
	When User enters 'TestProject14283' text to 'Project Name' textbox
	When User selects 'All Devices' option from 'Scope' autocomplete
	Then 'A project already exists with this name' error message is displayed for 'Project Name' field

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12189 @DAS12523 @DAS12521 @DAS12744 @DAS12162 @DAS12532 @Cleanup @Project_Creation_and_Scope @Projects
Scenario: EvergreenJnr_AdminPage_CheckThatNoErrorsAreDisplayedInTheProjectScopeChangesSectionAfterUsingSavedDevicesList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values |
	| Adobe  |
	Then "Vendor" filter is added to the list
	When User create dynamic list with "Vendor is adobe" name on "Applications" page
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList    | Association         |
	| Vendor is adobe | Used on device      |
	| Vendor is adobe | Entitled to device  |
	| Vendor is adobe | Installed on device |
	Then "Any Application" filter is added to the list
	When User create dynamic list with "DevicesList1584" name on "Devices" page
	Then "DevicesList1584" list is displayed to user
	When User selects 'Project' in the 'Create' dropdown
	Then Page with 'Create Project' subheader is displayed to user
	When User enters 'TestProject9' text to 'Project Name' textbox
	And User clicks 'CREATE' button
	Then 'The project has been created' text is displayed on inline success banner
	When User clicks newly created object link
	Then Page with 'TestProject9' header is displayed to user
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Users' tab on Project Scope Changes page
	And User navigates to the 'Devices' tab on Project Scope Changes page
	And User navigates to the 'Applications' tab on Project Scope Changes page
	Then There are no errors in the browser console
	