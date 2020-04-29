Feature: ProjectsPart27
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS18878 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckThatCorrectMessageDisplayedWhenProjectScopeIsListWithScopeTrue
	When User clicks '<List>' on the left-hand menu
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User add "<Filter1>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues  |
	| <Filter1_Value> |
	When User clicks Save button on the list panel
	When User create dynamic list with "<ListName>" name on "<List>" page
	Then "<ListName>" list is displayed to user
	When Project created via API
	| ProjectName   | Scope      | ProjectTemplate | Mode               |
	| <ProjectName> | <ListName> | None            | Standalone Project |
	When User navigates to the "<ListName>" list
	When User clicks the Filters button
	When User clicks Add And button on the Filter panel
	When User add "<Filter2>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| <Filter2_Value>    |
	When User clicks 'SAVE' button and select 'UPDATE DYNAMIC LIST' menu button
	When User navigates to "<ProjectName>" project details
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Details' left menu item
	When User navigates to the '<ScopeTab>' tab on Project Scope Changes page
	Then 'This list uses, or refers to a list that uses, an In Scope filter which is not valid as a project scope' error message is displayed for 'Scope' dropdown

Examples:
	| List      | Filter1          | Filter1_Value | ListName           | ProjectName    | Filter2              | Filter2_Value | ScopeTab      |
	| Devices   | Device Type      | Desktop       | aProjList_DAS18878 | 18878_ProjectA | 2004: Owner In Scope | TRUE          | Device Scope  |
	| Users     | Domain           | AU            | bProjList_DAS18878 | 18878_ProjectB | 2004: In Scope       | TRUE          | User Scope    |
	| Mailboxes | Mailbox Platform | Exchange 2003 | cProjList_DAS18878 | 18878_ProjectC | EmailMigra: In Scope | TRUE          | Mailbox Scope | 