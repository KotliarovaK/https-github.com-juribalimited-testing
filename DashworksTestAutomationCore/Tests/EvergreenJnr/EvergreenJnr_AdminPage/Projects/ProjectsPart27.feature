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
	When User navigates to the 'Scope Changes' left menu item
	When User navigates to the '<ScopeChanges>' tab on Project Scope Changes page
	Then multiselect is disabled

Examples:
	| List      | Filter1          | Filter1_Value | ListName           | ProjectName    | Filter2              | Filter2_Value | ScopeTab      | ScopeChanges |
	| Devices   | Device Type      | Desktop       | aProjList_DAS18878 | 18878_ProjectA | 2004: Owner In Scope | TRUE          | Device Scope  | Devices      |
	| Users     | Domain           | AU            | bProjList_DAS18878 | 18878_ProjectB | 2004: In Scope       | TRUE          | User Scope    | Users        |
	| Mailboxes | Mailbox Platform | Exchange 2003 | cProjList_DAS18878 | 18878_ProjectC | EmailMigra: In Scope | TRUE          | Mailbox Scope | Applications |
	
@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS18878 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckThatInScopeFilteredListCantBeUsedForProjectCreation
	When User clicks '<List>' on the left-hand menu
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User add "<Filter1>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues  |
	| <Filter1_Value> |
	When User clicks Save button on the list panel
	When User create dynamic list with "<ListName>" name on "<List>" page
	Then "<ListName>" list is displayed to user
	When User clicks 'Create' dropdown
	Then tooltip is displayed with "This list uses, or refers to a list that uses, an In Scope filter which is not valid as a project scope" text for Create Project button
	Then Create Project button is disabled on the Base Dashboard Page
	When User clicks Body container
	When User clicks 'Admin' on the left-hand menu
	When User navigates to the 'Projects' left menu item
	When User clicks 'CREATE PROJECT' button 
	Then Page with 'Create Project' subheader is displayed to user
	Then 'Scope' autocomplete does NOT have options
	| Options    |
	| <ListName> |

Examples:
	| List      | Filter1              | Filter1_Value | ListName            |
	| Devices   | 2004: Owner In Scope | TRUE          | aaProjList_DAS18878 |
	| Users     | 2004: In Scope       | TRUE          | bbProjList_DAS18878 |
	| Mailboxes | EmailMigra: In Scope | TRUE          | ccProjList_DAS18878 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS18878 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckThatInScopeFilteredStaticListCanBeUsedForProjectCreation
	When User clicks '<List>' on the left-hand menu
	When User create static list with "<ListName>" name on "<List>" page with following items
	| ItemName       |
	| <Item> |
	Then "<ListName>" list is displayed to user
	When Project created via API and opened
	| ProjectName   | Scope      | ProjectTemplate | Mode               |
	| <ProjectName> | <ListName> | None            | Standalone Project |

Examples:
	| List      | Item                             | ListName              | ProjectName   |
	| Devices   | 001BAQXT6JWFPI                   | aaProjStList_DAS18878 | aProjDAS18878 |
	| Users     | AHU5323923                       | bbProjStList_DAS18878 | bProjDAS18878 |
	| Mailboxes | 040698EE82354C17B60@bclabs.local | ccProjStList_DAS18878 | bProjDAS18878 |