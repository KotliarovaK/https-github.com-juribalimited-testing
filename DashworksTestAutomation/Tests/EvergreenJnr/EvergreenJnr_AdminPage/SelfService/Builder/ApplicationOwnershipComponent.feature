Feature: ApplicationOwnershipComponent
	Application Ownership component

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

#Complete this test when DAS-20019 will be completelly implemented
@Evergreen @Admin @EvergreenJnr_AdminPage @SelfService @DAS20019 @Cleanup @Not_Ready
Scenario: EvergreenJnr_AdminPage_ApplicationOwnershipComponentUiCheck
	When Project created via API and opened
	| ProjectName    | Scope            | ProjectTemplate | Mode               |
	| DAS_20019_Proj | All Applications | None            | Standalone Project |
	When User create static list with "DAS_20019_1" name on "Applications" page with following items
	| ItemName |
	|          |
	When User create static list with "DAS_20019_11" name on "Users" page with following items
	| ItemName |
	|          |
	When User creates Self Service via API and open it
	| Name           | ServiceIdentifier | Enabled | AllowAnonymousUsers | Scope       |
	| DAS_20019_SS_1 | 20019_1_SI        | true    | true                | DAS_20019_1 |
	When User creates new Self Service Page via API
	| ServiceIdentifier | Name        | DisplayName    | ShowInSelfService |
	| 20019_1_SI        | TestPageSs2 | DAS_20019_Page | true              |
	When User navigates to the 'Builder' left submenu item
	When User selects 'Edit' cogmenu option for 'Text' item type with 'TestPageSs2' name on Self Service Builder Panel
	#
	#ADD Application Ownership component - currently Andrew is creating these steps
	#
	Then Page with 'Create Ownership Component' header is displayed to user
	Then 'DAS_20019_Page' label with self service parent page name is displayed
	Then '' content is displayed in 'Component Name' textbox
	#no project is selected
	Then '' content is displayed in 'Project' dropdown
	#If the Do not allow owner to be changed radio button is selected, the User Scope drop down is not shown
	Then 'Don't allow owner to be changed' radio button is checked
	Then 'User Scope' dropdown is not displayed
	Then 'Show this component' checkbox is unchecked
	#If the user does not enter a component name a hint is shown with the text: A component name must be entered
	Then 'A component name must be entered' error message is displayed for 'Component Name' field
	Then User sees that 'Project' dropdown contains following options:
	| values         |
	| DAS_20019_Proj |
	Then following Values are not displayed in the 'Project' dropdown:
	| values    |
	| Evergreen |

	When User clicks 'Allow owner to be removed only' radio button
	Then 'User Scope' dropdown is displayed
	When User clicks 'Allow owner to be set to another user only' radio button
	Then 'User Scope' dropdown is displayed
	When User clicks 'Allow owner to be set to another user' radio button
	Then 'User Scope' dropdown is displayed
	When User clicks 'Allow owner to be removed or set to another user' radio button
	Then 'User Scope' dropdown is displayed

	Then User sees that 'User Scope' dropdown contains following options:
	| values       |
	| All Users    |
	| DAS_20019_11 |
	Then 'All Users' option is first in the 'User Scope' dropdown

	Then 'CREATE' button is disabled