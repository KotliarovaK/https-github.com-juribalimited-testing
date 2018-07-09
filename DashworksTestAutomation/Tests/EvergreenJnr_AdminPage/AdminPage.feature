@retry:1
Feature: AdminPage
	Runs Admin Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11747 @Delete_Newly_Created_Team
Scenario: EvergreenJnr_AdminPage_CheckThatErrorIsNotDisplayedWhenCreateTeamWithTheAlreadyExistName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text
	When User clicks Create New Item button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Error message with "A team already exists with this name" text is displayed
	And There are no errors in the browser console
	And Delete "TestTeam" Team in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11747
Scenario: EvergreenJnr_AdminPage_CheckThatErrorIsNotDisplayedWhenCreateBucketWithTheAlreadyExistName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket1" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User clicks Create New Item button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket1" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Error message with "A bucket already exists with this name" text is displayed
	And There are no errors in the browser console
	And Delete "TestBucket1" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726 @DAS12761
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyProjectName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters " " in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	Then Create Project button is disabled
	When User enters "All Devices Project" in the Project Name field
	And User clicks Create button on the Create Project page
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "all devices project" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Error message with "A project already exists with this name" text is displayed
	And Delete "All Devices Project" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyBucketName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	Then Search fields for "Devices" column contain correctly value
	Then Search fields for "Users" column contain correctly value
	Then Search fields for "Mailboxes" column contain correctly value
	When User clicks Create New Item button
	Then "Create Bucket" page should be displayed to the user
	When User enters " " in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	Then Create Bucket button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyTeamName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Team" page should be displayed to the user
	When User enters " " in the Team Name field
	And User enters "test" in the Team Description field
	Then Create Team button is disabled

@Evergreen @AllLists @EvergreenJnr_AdminPage @AdminPage @DAS11886 @DAS12613 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsDisplayedAfterDeletingUsedForProjectLists 
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	And User create dynamic list with "ListForProject" name on "Users" page
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject1" in the Project Name field
	And User selects "ListForProject" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to the "ListForProject" list
	Then "ListForProject" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "list is used by 1 project, do you wish to proceed?" message is displayed in the lists panel
	And User clicks Delete button on the warning message in the lists panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject1" record in the grid
	Then Project "TestProject1" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	Then Warning message with "The scope for this project refers to a deleted list, this must be updated before proceeding" text is displayed on the Admin page
	And Update Project buttons is disabled
	And Delete "TestProject1" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11977 @DAS11959 @DAS12553 @DAS11744 @DAS12742
Scenario: EvergreenJnr_AdminPage_CheckThatAfterApplyingDoNotIncludeDeviceOwnersListHas0ItemsInTheUsersTab
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject1" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User selects all rows on the grid
	And User clicks Actions button on the Projects page
	And User clicks Delete Project button
	And User clicks Delete button
	Then Delete button is displayed to the User on the Projects page
	When User cancels the selection of all rows on the Projects page
	Then Delete button is not displayed to the User on the Projects page
	When User enters "TestProject1" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	When User selects "Do not include device owners" checkbox on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section 
	Then "Users to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	And Delete "TestProject1" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11931 @DAS12742
Scenario Outline: EvergreenJnr_AdminPage_CheckThatProjectsAreDeletedSuccessfullyAndThereAreNoConsoleErrors
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	And User selects "<ScopeList>" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	Then Success message with "The selected project has been deleted" text is displayed on the Projects page
	And There are no errors in the browser console

Examples:
	| ProjectName  | ScopeList     |
	| TestProject2 | All Devices   |
	| TestProject3 | All Users     |
	| TestProject4 | All Mailboxes |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11762 @DAS12009
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextFieldForBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User have opened Column Settings for "Bucket" column
	And User clicks Filter button on the Column Settings panel
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11762 @DAS12009
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextFieldForTeams
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User have opened Column Settings for "Team" column
	And User clicks Filter button in the Column Settings panel on the Teams Page
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then There are no errors in the browser console
	When User enters "Administrative Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	Then "Administrative Team" team details is displayed to the user
	When User have opened Column Settings for "Username" column
	And User clicks Filter button in the Column Settings panel on the Teams Page
	And User enters "123455465" text in the Filter field
	And User clears Filter field
	Then Content is present in the table on the Teams Page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11879 @DAS12742 @DAS12752
Scenario: EvergreenJnr_AdminPage_CheckThatYouCanNotDeleteTheDefaultBucketWarningMessageIsNotDisplayedAfterTryingToDeleteNonDefaultBucket
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	When User enters "Administration" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	When User clicks "Bucket Settings" tab
	Then Default Bucket checkbox is selected
	When User click on Back button
	When User clicks Reset Filters button on the Admin page
	And User enters "Chicago" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	When User clicks Delete button
	Then "You can not delete the default bucket" warning message is not displayed on the Buckets page
	Then Warning message with "These bucket will be permanently deleted and any objects within them reassigned to the default bucket" text is displayed on the Admin page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12182
Scenario: EvergreenJnr_AdminPage_CheckThatNumberOfApplicationsInProjectScopeIsCorrectlyUpdated
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject5" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject5" record in the grid
	Then Project "TestProject5" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Device Scope" tab in the Scope section on the Project details page
	And User selects "Do not include owned devices" checkbox on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 247 selected)" is displayed to the user in the Project Scope Changes section
	When User click on Back button
	When User enters "TestProject5" text in the Search field for "Project" column
	When User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12154 @DAS12742 @DAS12872 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsNotDisplayedWhenDeletingListUsingInTheProjectThatWasDeleted
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Compliance" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	Then "Compliance" filter is added to the list
	When User create dynamic list with "TestList0A78U9" name on "Devices" page
	Then "TestList0A78U9" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject6" in the Project Name field
	And User selects "TestList0A78U9" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then "Projects" page should be displayed to the user
	Then Success message with "Your project has been created" text is displayed on the Projects page
	And There are no errors in the browser console
	When User enters "TestProject6" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User navigates to the "TestList0A78U9" list
	And User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "list will be permanently deleted" message is displayed in the lists panel
	And User clicks Delete button on the warning message in the lists panel
	And no Warning message is displayed in the lists panel

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11748
Scenario: EvergreenJnr_AdminPage_CheckThatNotificationMessageIsDisplayedAfterUpdatingBucketToDefaultType
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket2" in the Bucket Name field
	And User selects "Team 1045" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User enters "TestBucket2" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	Then "TestBucket2" bucket details is displayed to the user
	When User clicks "Bucket Settings" tab
	When User clicks Default Bucket checkbox on the Buckets page
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "TestBucket2" bucket has been updated is displayed on the Buckets page
	And Delete "TestBucket2" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11763 @DAS12742 @DAS12760
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeletingBucketFromBucketsSection
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "IB Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	Then "IB Team" team details is displayed to the user
	When User clicks "Buckets" tab
	And User enters "Group IB Team" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete Buckets" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11761
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterUpdatingTeamDescriptionField
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Team" page should be displayed to the user
	When User enters "TestTeam1" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text
	When User enters "TestTeam1" text in the Search field for "Team" column
	And User clicks content from "Team" column
	Then "TestTeam1" team details is displayed to the user
	When User clicks "Team Settings" tab
	And User enters "" in the Team Description field
	Then Update Team button is disabled
	When User enters " " in the Team Description field
	Then Update Team button is disabled
	When User enters "testTeamtest" in the Team Description field
	And User clicks Update Team button
	Then Success message is displayed and contains "The team was successfully updated" text
	And There are no errors in the browser console
	And Delete "TestTeam1" Team in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11765 @DAS12170
Scenario: EvergreenJnr_AdminPage_CheckThatMailboxesAreSuccessfullyAddedToBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Birmingham" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks "Mailboxes" tab
	And User clicks Create New Item button
	And User adds following items from list
	| Item                             |
	| 040698EE82354C17B60@bclabs.local |
	| 04D8FC40F25547E7B4D@bclabs.local |
	Then Success message is displayed and contains "The selected mailboxes have been added to the selected bucket" text
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11765 @DAS12170
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterAddingMailboxesToTheBucketWhereNoMailboxesExist
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Administration" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks "Mailboxes" tab
	And User clicks Create New Item button
	Then No items text is displayed
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11982
Scenario: EvergreenJnr_AdminPage_CheckThatAllAssociationsAreSelectedByDefaultInTheProjectApplicationsScope
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject7" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestProject7" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestProject7" is displayed to user
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then All Association are selected by default
	And Delete "TestProject7" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12170
Scenario: EvergreenJnr_AdminPage_CheckThatConsoleErrorsAreNotDisplayedAfterAddingDevicesInTheBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Bangor" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks Create New Item button
	And User adds following items from list
	| Item           |
	| VXERDNJ3KRJ421 |
	| XV20GW6HJRVE2R |
	Then Success message is displayed and contains "The selected devices have been added to the selected bucket" text
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12170
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterAddingDevicesToTheBucketWhereNoDevicesExist
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Amsterdam" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks Create New Item button
	Then No items text is displayed
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12170
Scenario: EvergreenJnr_AdminPage_CheckThatConsoleErrorsAreNotDisplayedAfterAddingUsersInTheBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Bangor" text in the Search field for "Bucket" column
	And User clicks content from "Bucket" column
	And User clicks "Users" tab
	And User clicks Create New Item button
	And User adds following items from list
	| Item                           |
	| UK\ADK614179 (Audrey B. Dixon) |
	| UK\AAT858228 (Cheri B. Evans)  |
	Then Success message is displayed and contains "The selected users have been added to the selected bucket" text
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11697 @DAS12744
Scenario Outline: EvergreenJnr_AdminPage_CheckThatCancelButtonOnTheCreateProjectPageRedirectsToTheLastPage
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User clicks Cancel button
	Then "<ListName>" list should be displayed to the user

Examples:
	| ListName  |
	| Devices   |
	| Users     |
	| Mailboxes |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12162 @DAS12532 @DAS12744
Scenario: EvergreenJnr_AdminPage_CheckThatConsoleErrorsAreNotDisplayedAfterNavigatingScopeChangesTab
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject8" in the Project Name field
	And User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject8" record in the grid
	Then Project "TestProject8" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section
	And User clicks "Devices" tab in the Project Scope Changes section
	And User clicks "Applications" tab in the Project Scope Changes section
	Then There are no errors in the browser console
	And Delete "TestProject8" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12189 @DAS12523 @DAS12521 @DAS12744 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AdminPage_CheckThatNoErrorsAreDisplayedInTheProjectScopeChangesSectionAfterUsingSavedDevicesList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Vendor" filter where type is "Equals" with added column and following value:
	| Values |
	| Adobe  |
	Then "Vendor" filter is added to the list
	When User create dynamic list with "Vendor is adobe" name on "Applications" page
	And User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList    | Association         |
	| Vendor is adobe | Used on device      |
	| Vendor is adobe | Entitled to device  |
	| Vendor is adobe | Installed on device |
	Then "Application" filter is added to the list
	When User create dynamic list with "DevicesList1584" name on "Devices" page
	Then "DevicesList1584" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject9" in the Project Name field
	And User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject9" record in the grid
	Then Project "TestProject9" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section
	And User clicks "Devices" tab in the Project Scope Changes section
	And User clicks "Applications" tab in the Project Scope Changes section
	Then There are no errors in the browser console
	And Delete "TestProject9" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12375
Scenario: EvergreenJnr_AdminPage_CheckThatPanelOfAvailableMemberslIsExpandedByDefault
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "K-Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	Then "K-Team" team details is displayed to the user
	When User clicks Add Members button on the Teams page
	Then Panel of available members is displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12552
Scenario: EvergreenJnr_AdminPage_CheckThatFiltersAreWorkingCorrectlyOnTheAdminPages
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "Migration phase 3 team" text in the Search field for "Team" column
	Then Counter shows "1" found rows
	When User clears Search field for "Project Buckets" column
	And User enters ">=5" text in the Search field for "Project Buckets" column
	Then Counter shows "5" found rows
	When User clears Search field for "Project Buckets" column
	And User enters "Administrative Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User enters "readonly" text in the Search field for "Username" column
	Then Counter shows "1" found rows
	When User clicks "Buckets" tab
	And User enters "Cardiff --- Test text fill; Test text fill; ------" text in the Search field for "Bucket" column
	Then Counter shows "1" found rows
	When User clears Search field for "Project Buckets" column
	When User enters "<35" text in the Search field for "Devices" column
	Then Counter shows "10" found rows
	When User clicks Admin on the left-hand menu
	And User clicks "Buckets" link on the Admin page
	When User clicks Reset Filters button on the Admin page
	And User enters "barry's" text in the Search field for "Bucket" column
	Then Counter shows "2" found rows
	When User clears Search field for "Project Buckets" column
	And User enters "=2" text in the Search field for "Users" column
	Then Counter shows "2" found rows
	When User clears Search field for "Project Buckets" column
	And User clicks content from "Bucket" column
	And User enters "M1D" text in the Search field for "Hostname" column
	Then Counter shows "1" found rows
	When User clears Search field for "Project Buckets" column
	And User enters "Windows XP" text in the Search field for "Operating System" column
	Then Counter shows "2" found rows
	When User clicks "Users" tab
	When User enters "Danielle A. Tate" text in the Search field for "Display Name" column
	Then Counter shows "1" found rows
	When User clears Search field for "Project Buckets" column
	And User enters "TZV202" text in the Search field for "Username" column
	Then Counter shows "1" found rows
	When User click on Back button
	And User clicks content from "Bucket" column
	When User clicks "Mailboxes" tab
	And User enters "DiscoverySearchMailbox{D919BA05-46A6-415f-80AD-7E09334BB852}@juriba1.onmicrosoft.com" text in the Search field for "Email Address (Primary)" column
	Then Counter shows "1" found rows
	When User clears Search field for "Project Buckets" column
	And User enters "RD-EXCH2K3" text in the Search field for "Server Name" column
	Then Counter shows "6" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12236
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedAfterUpdatingProjectScopeChanges
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject5" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestProject5" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestProject5" is displayed to user
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User clicks "Entitled to the device owner" checkbox on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2129 selected)" is displayed to the user in the Project Scope Changes section
	When User adds following items to the Project
	| Item                        |
	| 20040610sqlserverck (1.0.0) |
	| 7zip                        |
	| ACDSee 4.0 (4.0.0)          |
	Then message with "3 applications will be added" text is displayed on the Projects page
	When User clicks Update Project button on the Projects page
	Then Success message with "3 objects queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	And "Applications to add (0 of 2126 selected)" is displayed to the user in the Project Scope Changes section
	And There are no errors in the browser console
	When User click on Back button
	When User enters "TestProject5" text in the Search field for "Project" column
	And User selects all rows on the grid
	When User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12491
Scenario: EvergreenJnr_AdminPage_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbarforBucketsList
	When User clicks Admin on the left-hand menu
	And User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "birmingham" text in the Search field for "Bucket" column
	Then Counter shows "1" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12491
Scenario: EvergreenJnr_AdminPage_CheckThatSingularFoundItemLabelDisplaysOnActionsToolbarforTeamsList
	When User clicks Admin on the left-hand menu
	And User clicks "Teams" link on the Admin page
	And User enters "K-Team" text in the Search field for "Team" column
	Then Counter shows "1" found rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12370
Scenario: EvergreenJnr_ImportProjectPage_CheckThatImportProjectButtonEnabledAfterWarningOnImportProjectPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	And "Projects" page should be displayed to the user
	When User clicks Import Project button
	Then "Import Project" page should be displayed to the user
	When User selects incorrect file to upload on Import Project page
	And User selects "Import to new project" in the Import dropdown on the Import Project Page
	And User enters "TestProjectNameDAS12370" in the Project Name field on Import Project page
	And User clicks Import Project button on the Import Project page
	And User selects correct file to upload on Import Project page
	Then Import Project button is enabled

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12333
Scenario: EvergreenJnr_ChecksThatDeviceScopeDDLIsDisabledWhenDoNotIncludeOwnedDevicesIsSelected
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "Rainbow" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks Create button on the Create Project page
	And User enters "Rainbow" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "Rainbow" is displayed to user
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	When User selects "Do not include device owners" checkbox on the Project details page
	Then selecting device owners is disabled
	When User click on Back button
	And User enters "Rainbow" text in the Search field for "Project" column
	And User selects all rows on the grid
	When User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12578 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AdminPage_CheckThatTheEditListFunctionIsHiddenAfterCancelingCreatingProjectFromTheMainLists
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	And User create dynamic list with "<DynamicListName>" name on "<ListName>" page
	Then "<DynamicListName>" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User clicks Cancel button
	Then "<DynamicListName>" list is displayed to user
	And Edit List menu is not displayed

Examples:
	| ListName  | ColumnName    | DynamicListName |
	| Devices   | Hostname      | TestList6589    |
	| Users     | Username      | TestList6588    |
	| Mailboxes | Email Address | TestList6587    |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12751 @DAS12747
Scenario: EvergreenJnr_AdminPage_CheckThatSelectedCheckboxIsSelectedAfterSwitchingBetweenTabs
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject13" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestProject13" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestProject13" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User clicks "Devices" tab in the Project Scope Changes section
	Then Update Project buttons is disabled
	When User expands the object to add 
	And User selects following items to the Project
	| Item           |
	| 02UXAL8OAR3K1O |
	Then Update Project button is active
	And "Devices to add (1 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "Users" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following items to the Project
	| Item                      |
	| AAH0343264 (Luc Gauthier) |
	And User clicks "Devices" tab in the Project Scope Changes section
	When User expands the object to add 
	Then following items are still selected
	And "Devices to add (1 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	And Delete "TestProject13" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12760
Scenario: EvergreenJnr_AdminPage_CheckMessageThatDisplayedWhenDeletingBucket
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Reset Filters button on the Admin page
	And User enters "Amsterdam" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	When User enters "Unassigned" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "You cannot delete the default bucket" text is displayed on the Admin page
	When User clicks Create New Item button
	Then "Create Bucket" page should be displayed to the user
	When User enters "TestBucket4" in the Bucket Name field
	And User selects "Team 1045" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text
	When User enters "TestBucket4" text in the Search field for "Bucket" column
	And User selects all rows on the grid
	And User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "These bucket will be permanently deleted and any objects within them reassigned to the default bucket" text is displayed on the Admin page
	When User clicks Cancel button in the warning message on the Admin page
	Then Warning message is not displayed on the Admin page
	When User clicks on Actions button
	And User selects "Delete" in the Actions
	And User clicks Delete button 
	Then Warning message with "These bucket will be permanently deleted and any objects within them reassigned to the default bucket" text is displayed on the Admin page
	When User clicks Delete button in the warning message
	Then Success message is displayed and contains "The selected bucket has been deleted" text

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12387 @DAS12757
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardingOfObjectsIsProceedForScopedProjects
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject14" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestProject14" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestProject14" is displayed to user
	When User adds following items to the Project
	| Item           |
	| 0317IPQGQBVAQV |
	| 00I0COBFWHOF27 |
	When User clicks Update Project button on the Projects page
	Then Success message with "2 objects queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	When User clicks "Users" tab in the Project Scope Changes section
	And User adds following items to the Project
	| Item                          |
	| AAG081456 (Melanie Z. Fowler) |
	| AAH0343264 (Luc Gauthier)     |
	When User clicks Update Project button on the Projects page
	Then Success message with "2 objects queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	When User click on Back button
	And User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject15" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestProject15" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestProject15" is displayed to user
	And Success message is not displayed on the Projects page
	When User click on Back button
	When User enters "TestProject14" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	Then Delete "TestProject15" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12332
Scenario: EvergreenJnr_AdminPage_CheckingThatRedBannerWithOkMessageIsNotDisplayedAfterAddingItemsToCreatedProject
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12332" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestProject12332" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestProject12332" is displayed to user
	When User expands the object to add 
	And User selects following items to the Project
	| Item           |
	| 1DPQO52HJQZJ0H |
	And User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following items to the Project
	| Item                                                                 |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) (0.8.5.0) |
	And User clicks "Users" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following items to the Project
	| Item                       |
	| AAC860150 (Kerrie D. Ruiz) |
	And User clicks "UPDATE ALL CHANGES" button on the Projects page
	And User clicks Update Project button on the Projects page
	Then Success message with "3 objects queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	And There are no errors in the browser console
	When User click on Back button
	And User enters "TestProject12332" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12796 @DAS12872 @Delete_Newly_Created_List
Scenario Outline: EvergreenJnr_AdminPage_CheckThatNumberOfObjectIsUpdatedInTheScopeChangesOfProjectAfterTheChangeCustomList
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User click on '<ColumnName>' column header
	And User create dynamic list with "<DynamicListName>" name on "<ListName>" page
	Then "<DynamicListName>" list is displayed to user
	And "<RowsCount>" rows are displayed in the agGrid
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the Project Name field
	And User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "<ProjectName>" record in the grid
	Then Project "<ProjectName>" is displayed to user
	And "<ObjectsCount>" is displayed to the user in the Project Scope Changes section
	When User clicks "<ListName>" on the left-hand menu
	And User navigates to the "<DynamicListName>" list
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| <Checkbox>     |
	When User update current custom list
	Then "<NewRowsCount>" rows are displayed in the agGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "<ProjectName>" is displayed to user
	And "<NewCount>" is displayed to the user in the Project Scope Changes section
	When User click on Back button
	When User enters "TestProject45" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

Examples:
	| ListName  | ColumnName    | DynamicListName | RowsCount | ProjectName     | ObjectsCount | FilterName  | Checkbox | NewRowsCount | NewCount | DeleteProject   |
	| Devices   | Hostname      | ProjectList4587 | 17,225    | TestProject4511 | 17225        | Device Type | Desktop  | 8,103        | 8103     | TestProject4511 |
	| Users     | Username      | ProjectList4511 | 41,339    | TestProject4512 | 41339        | Domain      | CORP     | 103          | 103      | TestProject4512 |
	| Mailboxes | Email Address | ProjectList4548 | 14,784    | TestProject4513 | 14784        | Owner City  | London   | 3,294        | 3294     | TestProject4513 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12816 @DAS12873 @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatObjectsIsOnboardedToTheProjectWithCloneEvergreenBucketsToProjectBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject19" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestProject19" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestProject19" is displayed to user
	When User expands the object to add 
	And User selects following items to the Project
	| Item            |
	| 01BQIYGGUW5PRP6 |
	And User clicks "UPDATE DEVICE CHANGES" button on the Projects page
	And User clicks Update Project button on the Projects page
	Then Success message with "1 object queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	When User selects "Queue" tab on the Project details page
	Then following objects are onboarded
	| Object          |
	| 01BQIYGGUW5PRP6 |
	When User selects "History" tab on the Project details page
	Then following objects are onboarded
	| Object          |
	| 01BQIYGGUW5PRP6 |
	When User click on Back button
	And User enters "TestProject19" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks refresh button in the browser

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12490 @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckingThatProjectDetailsForOnboardedObjectsIsDisplayedCorrectly
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12490" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestProject12490" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestProject12490" is displayed to user
	When User clicks "Devices" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following items to the Project
	| Item           |
	| 0IJB93JZPG72PX |
	And User clicks "UPDATE ALL CHANGES" button on the Projects page
	And User clicks Update Project button on the Projects page
	When User selects "Queue" tab on the Project details page
	Then following objects are onboarded
	| Item           |
	| 0IJB93JZPG72PX |
	When User selects "History" tab on the Project details page
	Then following objects are onboarded
	| Item           |
	| 0IJB93JZPG72PX |
	When User type "0IJB93JZPG72PX" in Global Search Field
	Then User clicks on "0IJB93JZPG72PX (Carmen H. Benson)" search result
	When User navigates to the "Projects" tab
	And User opens "Device Projects" section on the Details Page
	And User clicks "TestProject12490" link on the Details Page
	Then "Project Object" page is displayed to the user
	Then There are no errors in the browser console
	And User click back button in the browser
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User enters "TestProject12490" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11737
Scenario: EvergreenJnr_AdminPage_CheckingThatCreatingTwoProjectsWithTheSameNameIsImpossible
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject11737" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject11737" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Error message with "A project already exists with this name" text is displayed
	When User enters "TestProject11737" text in the Search field for "Project" column
	Then Counter shows "1" found rows
	When User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11700
Scenario: EvergreenJnr_AdminPage_CheckingThatTheProjectIdColumnIsAddedAndDisplayedCorrectlyToTheAdminProjectGrid
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject11700" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	And User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User have opened Column Settings for "Project" column
	And User clicks Column button on the Column Settings panel
	Then Column Settings was opened
	When User select "Project ID" checkbox on the Column Settings panel
	And User clicks Column button on the Column Settings panel
	Then following columns added to the table:
	| ColumnName |
	| Project ID |
	And content is present in the following newly added columns:
	| ColumnName |
	| Project ID |
	When User enters "TestProject11700" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11985 @DAS12857
Scenario: EvergreenJnr_AdminPage_CheckingThatProjectNameIsDisplayedCorrectlyWhenSpecialSymbolsAreUsedInTheProjectName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "<TestProject11985>" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "<TestProject11985>" name is displayed correctly
	#Then Import Project button is not displayed
	When User enters "<TestProject11985>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12806
Scenario: EvergreenJnr_AdminPage_CheckThatOnboardedObjectsAreDisplayedAfterChangingProjectBucketsSetting
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject20" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	When User enters "TestProject20" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestProject20" is displayed to user
	When User clicks "Details" tab
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	When User clicks "UPDATE" button on the Projects page
	Then Success message is displayed and contains "The project details have been updated" text
	When User selects "Scope Changes" tab on the Project details page
	When User expands the object to add
	And User selects following items to the Project
	| Item            |
	| 0281Z793OLLLDU6 |
	| 03U75EKEMUQMUS  |
	And User clicks "UPDATE ALL CHANGES" button on the Projects page
	And User clicks Update Project button on the Projects page
	Then Success message with "2 objects queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	When User click on Back button
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "My Team" text in the Search field for "Team" column
	And User clicks content from "Team" column
	When User clicks "Buckets" tab
	When User enters "Unassigned2" text in the Search field for "Bucket" column
	Then "2" Onboarded objects are displayed
	When User clicks Admin on the left-hand menu
	When User enters "TestProject20" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12364
Scenario: EvergreenJnr_AdminPage_CheckingThatTheProjectIsUpdatedWithoutErrors
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12364" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestProject12364" name is displayed correctly
	When User enters "TestProject12364" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestProject12364" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	When User expands the object to add
	And User selects following items to the Project
	| Item                                  |
	| 003F5D8E1A844B1FAA5 (Hunter, Melanie) |
	| 01FF97A1FFAC48A1803 (Aultman, Chanel) |
	When User clicks "Devices" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following items to the Project
	| Item           |
	| 77JBRXGQLKJ6ZE |
	| 7FKJAVNVA2AGEM |
	When User clicks "Applications" tab in the Project Scope Changes section
	And User expands the object to add 
	And User selects following items to the Project
	| Item                                             |
	| ACDSee 4.0.2 PowerPack Trial Version (4.00.0002) |
	| Backburner (2.1.2.0)                             |
	And User clicks "UPDATE ALL CHANGES" button on the Projects page
	And User clicks Update Project button on the Projects page
	Then Success message with "6 objects queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	When User selects "Scope Details" tab on the Project details page
	When User selects "Scope Changes" tab on the Project details page
	When User clicks "Applications" tab in the Project Scope Changes section
	Then There are no errors in the browser console
	When User click on Back button
	When User enters "TestProject12364" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	#Then "TestProject12364" item was removed

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11729 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsDisplayedIfTryToRemoveCreatedListThatUsedInAnyProject
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create dynamic list with "TestDynamicList11729" name on "Devices" page
	Then "TestDynamicList11729" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName11729" in the Project Name field
	And User selects "TestDynamicList11729" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestName11729" name is displayed correctly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks Settings button for "TestDynamicList11729" list
	And User clicks Delete button for custom list
	Then "TestDynamicList11729" list "list is used by 1 project, do you wish to proceed?" message is displayed in the list panel
	And User clicks Delete button on the warning message in the lists panel
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestName11729" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestName11729" is displayed to user
	And message with "The scope for this project refers to a deleted list, this must be updated before proceeding" text is displayed on the Projects page
	And There are no errors in the browser console
	When User click on Back button
	And User enters "TestName11729" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11758
Scenario: EvergreenJnr_AdminPage_CheckThatSelectAllCheckboxIsWorkingCorrectlyOnAdminPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "1Checkbox11758" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "1Checkbox11758" name is displayed correctly
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "2Checkbox11758" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "2Checkbox11758" name is displayed correctly
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "3Checkbox11758" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "3Checkbox11758" name is displayed correctly
	When User selects all rows on the grid
	Then Select All selectbox is checked on the Admin page
	When User select "Project" rows in the grid on the Admin page
	| SelectedRowsName |
	| 1Checkbox11758   |
	Then Select All selectbox is unchecked on the Admin page
	When User select "Project" rows in the grid on the Admin page
	| SelectedRowsName |
	| 1Checkbox11758   |
	Then Select All selectbox is checked on the Admin page
	When User enters "Checkbox11758" text in the Search field for "Project" column
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11770 @Delete_Newly_Created_Team
Scenario: EvergreenJnr_AdminPage_CheckThatImpossibleToCreateSameNamedTeamUsingTheSpaceAsAFirstSymbol
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Team" page should be displayed to the user
	When User enters "11770" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text
	When User clicks Create New Item button
	Then "Create Team" page should be displayed to the user
	When User enters " 11770" in the Team Name field
	And User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Error message with "A team already exists with this name" text is displayed
	And Delete "11770" Team in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11770
Scenario: EvergreenJnr_AdminPage_CheckThatImpossibleToCreateSameNamedBucketUsingTheSpaceAsAFirstSymbol
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Bucket" page should be displayed to the user
	When User enters "11770" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created, Click here to view the 11770 bucket" text
	When User clicks Create New Item button
	Then "Create Bucket" page should be displayed to the user
	When User enters " 11770" in the Bucket Name field
	And User selects "Admin IT" team in the Team dropdown on the Buckets page
	And User clicks Create button on the Create Bucket page
	Then Error message with "A bucket already exists with this name" text is displayed
	And Delete "11770" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11770
Scenario: EvergreenJnr_AdminPage_CheckThatImpossibleToCreateSameNamedProjectUsingTheSpaceAsAFirstSymbol
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "11770" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "11770" name is displayed correctly
	Then Success message with "Your project has been created" text is displayed on the Projects page
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters " 11770" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then Error message with "A project already exists with this name" text is displayed
	When User enters "11770" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11881
Scenario: EvergreenJnr_AdminPage_CheckThatEmptyGreenAlertLineIsNotDisplayedOnProjectScopeChangesPageAfterMakingSomeChangesOnScopePage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName11881" in the Project Name field
	And User selects "All Users" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestName11881" name is displayed correctly
	And Success message with "Your project has been created" text is displayed on the Projects page
	When User enters "TestName11881" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestName11881" is displayed to user
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User selects "Do not include applications" checkbox on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	Then Warning message is not displayed on the Admin page
	When User click on Back button
	And User enters "TestName11881" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12155 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AdminPage_CheckThatScopePanelHaveCorrectlySizeWhenUsedListWithLongName
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click on 'Hostname' column header
	And User create dynamic list with "VERYLONGLOOOOOOOOOOOOOOOOOOOOOOOOONGNAME" name on "Devices" page
	Then "VERYLONGLOOOOOOOOOOOOOOOOOOOOOOOOONGNAME" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User clicks in the Scope field on the Admin page
	Then Scope DDL have the "304px" Height and the "658.406px" Width

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12349 @Delete_Newly_Created_List
Scenario: EvergreenJnr_AdminPage_CheckThat500ISEInvalidColumnNameIsNotDisplayedWhenUsedAppSavedListForFilteringDeviceList
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Key" filter where type is "Equals" without added column and following value:
	| Values |
	| 8      |
	And User create dynamic list with "ListName12349" name on "Applications" page
	Then "ListName12349" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList  | Association    |
	| ListName12349 | Used on device |
	Then "Application (Saved List)" filter is added to the list
	And "99" rows are displayed in the agGrid
	And "Any Application in list ListName12349 used on device" is displayed in added filter info
	And "(Application (Saved List) = ListName12349 ASSOCIATION = ("used on device"))" text is displayed in filter container
	When User create dynamic list with "SavedList12349" name on "Devices" page
	Then "SavedList12349" list is displayed to user
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject12349" in the Project Name field
	And User selects "SavedList12349" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestProject12349" name is displayed correctly
	When User enters "TestProject12349" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestProject12349" is displayed to user
	And There are no errors in the browser console
	When User selects "Scope Details" tab on the Project details page
	Then There are no errors in the browser console
	When User click on Back button
	And User enters "TestProject12349" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12777
Scenario: EvergreenJnr_AdminPage_CheckThatErrorIsNotDisplayedWhenCreatingProjectWithCloneEvergreenBucketsToProjectBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject22" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	And User clicks Create button on the Create Project page
	Then Success message with "Your project has been created" text is displayed on the Projects page
	And There are no errors in the browser console
	When User enters "TestProject22" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12336 @DAS12745
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsNotDisplayedAfterAddingObjectsOnTheProjectScopeChangesTab
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName12336" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestName12336" name is displayed correctly
	And Success message with "Your project has been created" text is displayed on the Projects page
	When User enters "TestName12336" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "TestName12336" is displayed to user
	When User selects "Scope Changes" tab on the Project details page
	And User expands the object to add
	And User selects all objects to the Project
	Then "Devices to add (17225 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	When User cancels the selection objects in the Project
	Then "Devices to add (0 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	When User enters "111" text in the Object Search field
	And User selects all objects to the Project
	Then "Devices to add (5 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	When User cancels the selection objects in the Project
	And User selects following items to the Project
	| Item            |
	| 07RJRCQQJNBJIJQ |
	| 0CFHJY5A8WLUB0J |
	Then "Devices to add (2 of 17225 selected)" is displayed to the user in the Project Scope Changes section
	When User clicks "UPDATE DEVICE CHANGES" button on the Projects page
	And User clicks Update Project button on the Projects page
	Then Success message with "2 objects queued for onboarding, 0 objects offboarded" text is displayed on the Projects page
	When User selects "Scope Details" tab on the Project details page
	Then Warning message is not displayed on the Admin page
	When User click on Back button
	And User enters "TestName12336" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12891
Scenario: EvergreenJnr_AdminPage_CheckThatCancelButtonIsDisplayedWithCorrectlyColorOnAdminPage
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create New Item button
	Then "Create Project" page should be displayed to the user
	When User enters "TestName12891" in the Project Name field
	And User selects "All Devices" in the Scope Project dropdown
	And User clicks Create button on the Create Project page
	Then created Project with "TestName12891" name is displayed correctly
	And Success message with "Your project has been created" text is displayed on the Projects page
	When User enters "TestName12891" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User clicks Actions button on the Projects page
	And User clicks Delete button in Actions
	And User clicks Delete button
	Then Cancel button is displayed with correctly color
	When User clicks Delete button in the warning message