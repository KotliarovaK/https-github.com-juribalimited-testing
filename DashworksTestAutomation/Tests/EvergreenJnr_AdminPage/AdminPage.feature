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
	When User click "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks Create Team button
	Then Create Team page should be displayed to the user
	And User enters "TestTeam" in the Team Name field
	When User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text on the Teams page
	When User clicks Create Team button
	Then Create Team page should be displayed to the user
	And User enters "TestTeam" in the Team Name field
	When User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Error message with "A team already exists with this name" text is displayed on the Teams page
	And There are no errors in the browser console
	And Delete "TestTeam" Team in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11747
Scenario: EvergreenJnr_AdminPage_CheckThatErrorIsNotDisplayedWhenCreateBucketWithTheAlreadyExistName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Create Bucket button
	Then Create Bucket page should be displayed to the user
	And User enters "TestBucket1" in the Bucket Name field
	And User select "Admin IT" team in the Team dropdown on the Buckets page
	When User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text on the Buckets page
	When User clicks Create Bucket button
	Then Create Bucket page should be displayed to the user
	And User enters "TestBucket1" in the Bucket Name field
	And User select "Admin IT" team in the Team dropdown on the Buckets page
	When User clicks Create button on the Create Bucket page
	Then Error message with "A bucket already exists with this name" text is displayed on the Buckets page
	And There are no errors in the browser console
	Then Delete "TestBucket1" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyProjectName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create Project button
	Then Create Project page should be displayed to the user
	And User enters " " in the Project Name field
	And User select "All Devices" in the Scope Project dropdown
	And Create Project button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyBucketName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Create Bucket button
	Then Create Bucket page should be displayed to the user
	And User enters " " in the Bucket Name field
	And User select "Admin IT" team in the Team dropdown on the Buckets page
	Then Create Bucket button is disabled

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11726
Scenario: EvergreenJnr_AdminPage_CheckThatCreateButtonIsDisabledForEmptyTeamName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks Create Team button
	Then Create Team page should be displayed to the user
	And User enters " " in the Team Name field
	When User enters "test" in the Team Description field
	Then Create Team button is disabled

@Evergreen @AllLists @EvergreenJnr_AdminPage @AdminPage @DAS11886 @DAS12613 @Delete_Newly_Created_List @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatWarningMessageIsDisplayedAfterDeletingUsedForProjectLists 
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User click on 'Username' column header
	And User create dynamic list with "ListForProject" name on "Users" page
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create Project button
	Then Create Project page should be displayed to the user
	And User enters "TestProject" in the Project Name field
	And User select "ListForProject" in the Scope Project dropdown
	When User clicks Create Project button
	And User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to the "ListForProject" list
	Then "ListForProject" list is displayed to user
	When User clicks Settings button in the list panel
	Then Settings panel is displayed to the user
	When User clicks Delete in the list panel
	Then "list is used by 1 project, do you wish to proceed?" message is displayed in the lists panel
	When User clicks Delete in the warning message on the list panel 
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject" Project name
	Then Project "TestProject" is displayed to user
	When User select "Scope Changes" tab on the Project details page
	Then Warning message with "The scope for this project refers to a deleted list, this must be updated before proceeding" text is displayed on the Project details page
	And Update Project button is disabled
	And Delete "TestProject" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11977 @DAS11959 @DAS12553
Scenario: EvergreenJnr_AdminPage_CheckThatAfterApplyingDoNotIncludeDeviceOwnersListHas0ItemsInTheUsersTab
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create Project button
	Then Create Project page should be displayed to the user
	And User enters "TestProject1" in the Project Name field
	And User select "All Devices" in the Scope Project dropdown
	When User clicks Create Project button
	And User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject1" Project name
	Then Project "TestProject1" is displayed to user
	When User select "Do not include device owners" checkbox on the Project details page
	When User select "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section 
	Then "Users to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	And Delete "TestProject1" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11931
Scenario Outline: EvergreenJnr_AdminPage_CheckThatProjectsAreDeletedSuccessfullyAndThereAreNoConsoleErrors
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create Project button
	Then Create Project page should be displayed to the user
	And User enters "<ProjectName>" in the Project Name field
	And User select "<ScopeList>" in the Scope Project dropdown
	When User clicks Create Project button
	And User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column on the Projects page
	And User selects all rows on the Projects page
	And User removes selected Project
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
	When User click "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User have opened Column Settings for "Bucket" column on the Buckets Page
	And User clicks Filter button on the Column Settings panel
	Then User enters "123455465" text in the Filter field
	When User clears Filter field
	Then There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11762 @DAS12009
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeleteDataFromFilterTextFieldForTeams
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User have opened Column Settings for "Team" column on the Teams Page
	And User clicks Filter button in the Column Settings panel on the Teams Page
	Then User enters "123455465" text in the Filter field
	When User clears Filter field
	Then There are no errors in the browser console
	When User enters "Administrative Team" text in the Search field for "Team" column on the Teams page
	And User clicks content from "Team" column on the Teams page
	Then "Administrative Team" team details is displayed to the user
	When User have opened Column Settings for "Username" column on the Teams Page
	And User clicks Filter button in the Column Settings panel on the Teams Page
	Then User enters "123455465" text in the Filter field
	When User clears Filter field
	Then Content is present in the table on the Teams Page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11879
Scenario: EvergreenJnr_AdminPage_CheckThatYouCanNotDeleteTheDefaultBucketWarningMessageIsNotDisplayedAfterTryingToDeleteNonDefaultBucket
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Unassigned" text in the Search field for "Bucket" column on the Buckets page
	When User selects all rows on the Buckets page
	Then User clicks on Actions button on the Buckets page
	And User select "Delete Bucket" in the Actions dropdown on the Buckets page
	When User clicks Delete button on the Buckets page
	Then "You can not delete the default bucket" warning message is not displayed on the Buckets page

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12182
Scenario: EvergreenJnr_AdminPage_CheckThatNumberOfApplicationsInProjectScopeIsCorrectlyUpdated
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create Project button
	Then Create Project page should be displayed to the user
	And User enters "TestProject5" in the Project Name field
	And User select "All Users" in the Scope Project dropdown
	When User clicks Create Project button
	And User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject5" Project name
	Then Project "TestProject5" is displayed to user
	When User select "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 2081 selected)" is displayed to the user in the Project Scope Changes section
	When User select "Scope Details" tab on the Project details page
	And User select "Do not include owned devices" checkbox on the Project details page
	When User select "Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (0 of 247 selected)" is displayed to the user in the Project Scope Changes section
	And Delete "TestProject5" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12154 @Delete_Newly_Created_List
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
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create Project button
	Then Create Project page should be displayed to the user
	And User enters "TestProject6" in the Project Name field
	And User select "TestList0A78U9" in the Scope Project dropdown
	When User clicks Create Project button
	Then "Projects" page should be displayed to the user
	When User enters "TestProject6" text in the Search field for "Project" column on the Projects page
	And User selects all rows on the Projects page
	And User removes selected Project
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
	When User click "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User clicks Create Bucket button
	Then Create Bucket page should be displayed to the user
	And User enters "TestBucket2" in the Bucket Name field
	Then User select "Team 1045" team in the Team dropdown on the Buckets page
	When User clicks Create button on the Create Bucket page
	Then Success message is displayed and contains "The bucket has been created" text on the Buckets page
	When User enters "TestBucket2" text in the Search field for "Bucket" column on the Buckets page
	And User clicks content from "Bucket" column on the Buckets page
	Then "TestBucket2" bucket details is displayed to the user
	And User clicks "Bucket Settings" tab on the Buckets page
	When User clicks Default Bucket checkbox on the Buckets page
	And User clicks Update Bucket button on the Buckets page
	Then Success message The "TestBucket2" bucket has been updated is displayed on the Buckets page
	And Delete "TestBucket2" Bucket in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11763
Scenario: EvergreenJnr_AdminPage_CheckThatNoConsoleErrorsAreDisplayedWhenDeletingBucketFromBucketsSection
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "IB Team" text in the Search field for "Team" column on the Teams page
	And User clicks content from "Team" column on the Teams page
	Then "IB Team" team details is displayed to the user
	And User clicks "Buckets" tab on the Teams page
	When User enters "Group IB Team" text in the Search field for "Bucket" column on the Teams page
	And User selects all rows on the Teams page
	Then User clicks on Actions button on the Teams page
	And User select "Delete Buckets" in the Actions dropdown on the Teams page
	When User clicks Delete button on the Teams page
	Then Reassign Objects is displayed on the Teams page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11761
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterUpdatingTeamDescriptionField
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks Create Team button
	Then Create Team page should be displayed to the user
	And User enters "TestTeam1" in the Team Name field
	When User enters "test" in the Team Description field
	And User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text on the Teams page
	When User enters "TestTeam1" text in the Search field for "Team" column on the Teams page
	And User clicks content from "Team" column on the Teams page
	Then "TestTeam1" team details is displayed to the user
	And User clicks "Team Settings" tab on the Teams page
	When User enters "" in the Team Description field
	Then Update Team button is disabled
	When User enters " " in the Team Description field
	Then Update Team button is disabled
	When User enters "testTeamtest" in the Team Description field
	And User clicks Update Team button
	Then Success message is displayed and contains "The team was successfully updated" text on the Teams page
	And There are no errors in the browser console
	And Delete "TestTeam1" Team in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11765 @DAS12170
Scenario: EvergreenJnr_AdminPage_CheckThatMailboxesAreSuccessfullyAddedToBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Birmingham" text in the Search field for "Bucket" column on the Buckets page
	And User clicks content from "Bucket" column on the Buckets page
	Then User clicks "Mailboxes" tab on the Buckets page
	When User clicks Add Mailbox button on the Buckets page
	Then User add following mailboxes to the Bucket
	| MailboxName                  |
	| alexis.f.bright@dwlabs.local |
	| alice.n.foster@dwlabs.local  |
	And Success message is displayed and contains "The selected mailboxes have been added to the selected bucket" text on the Buckets page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11765 @DAS12170
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterAddingMailboxesToTheBucketWhereNoMailboxesExist
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Administration" text in the Search field for "Bucket" column on the Buckets page
	And User clicks content from "Bucket" column on the Buckets page
	Then User clicks "Mailboxes" tab on the Buckets page
	When User clicks Add Mailbox button on the Buckets page
	Then No items text is displayed on the Buckets page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11982
Scenario: EvergreenJnr_AdminPage_CheckThatAllAssociationsAreSelectedByDefaultInTheProjectApplicationsScope
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create Project button
	Then Create Project page should be displayed to the user
	And User enters "TestProject7" in the Project Name field
	And User select "All Devices" in the Scope Project dropdown
	When User clicks Create Project button
	And User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "TestProject7" text in the Search field for "Project" column on the Projects page
	And User clicks content from "Project" column on the Buckets page
	Then Project "TestProject7" is displayed to user
	When User navigates to the "Application Scope" tab in the Scope section on the Project details page
	Then All Association are selected by default
	And Delete "TestProject7" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12170
Scenario: EvergreenJnr_AdminPage_CheckThatConsoleErrorsAreNotDisplayedAfterAddingDevicesInTheBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Bangor" text in the Search field for "Bucket" column on the Buckets page
	And User clicks content from "Bucket" column on the Buckets page
	When User clicks Add Device button on the Buckets page
	Then User add following devices to the Bucket
	| DeviceName     |
	| 01DRMO46G58SXK |
	| XV20GW6HJRVE2R |
	And Success message is displayed and contains "The selected devices have been added to the selected bucket" text on the Buckets page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12170
Scenario: EvergreenJnr_AdminPage_CheckThatErrorsDoNotAppearAfterAddingDevicesToTheBucketWhereNoDevicesExist
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Amsterdam" text in the Search field for "Bucket" column on the Buckets page
	And User clicks content from "Bucket" column on the Buckets page
	When User clicks Add Device button on the Buckets page
	Then No items text is displayed on the Buckets page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12170
Scenario: EvergreenJnr_AdminPage_CheckThatConsoleErrorsAreNotDisplayedAfterAddingUsersInTheBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Buckets" link on the Admin page
	Then "Buckets" page should be displayed to the user
	When User enters "Bangor" text in the Search field for "Bucket" column on the Buckets page
	And User clicks content from "Bucket" column on the Buckets page
	Then User clicks "Users" tab on the Buckets page
	When User clicks Add User button on the Buckets page
	Then User add following users to the Bucket
	| UserName                          |
	| UK\LBM661859 (Jenifer V. Allison) |
	| UK\ANK462406 (Nakia D. Norton)    |
	And Success message is displayed and contains "The selected users have been added to the selected bucket" text on the Buckets page
	And There are no errors in the browser console

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11697 @Not_Run
Scenario Outline: EvergreenJnr_AdminPage_CheckThatCancelButtonOnTheCreateProjectPageRedirectsToTheLastPage
	When User clicks "<ListName>" on the left-hand menu
	Then "<ListName>" list should be displayed to the user
	When User clicks Create Project from the main list
	Then Create Project page should be displayed to the user
	When User clicks Cancel button
	Then "<ListName>" list should be displayed to the user

	Examples:
	| ListName  |
	| Devices   |
	| Users     |
	| Mailboxes |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12162 @DAS12532 @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatConsoleErrorsAreNotDisplayedAfterNavigatingScopeChangesTab
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks Create Project from the main list
	Then Create Project page should be displayed to the user
	And User enters "TestProject8" in the Project Name field
	When User clicks Create Project button
	And User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject8" Project name
	Then Project "TestProject8" is displayed to user
	When User select "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section
	And User clicks "Devices" tab in the Project Scope Changes section
	And User clicks "Applications" tab in the Project Scope Changes section
	Then There are no errors in the browser console
	And Delete "TestProject8" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12189 @DAS12523 @DAS12521 @Delete_Newly_Created_List @Not_Run
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
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with SelectedList list and following Association:
	| SelectedList    | Association         |
	| Vendor is adobe | Used on device      |
	| Vendor is adobe | Entitled to device  |
	| Vendor is adobe | Installed on device |
	Then "Application" filter is added to the list
	When User create dynamic list with "DevicesList1584" name on "Devices" page
	Then "DevicesList1584" list is displayed to user
	When User clicks Create Project from the main list
	Then Create Project page should be displayed to the user
	And User enters "TestProject9" in the Project Name field
	When User clicks Create Project button
	And User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject9" Project name
	Then Project "TestProject9" is displayed to user
	When User select "Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section
	And User clicks "Devices" tab in the Project Scope Changes section
	And User clicks "Applications" tab in the Project Scope Changes section
	Then There are no errors in the browser console
	And Delete "TestProject9" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12375
Scenario: EvergreenJnr_AdminPage_CheckThatPanelOfAvailableMemberslIsExpandedByDefault
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "K-Team" text in the Search field for "Team" column on the Teams page
	And User clicks content from "Team" column on the Teams page
	Then "K-Team" team details is displayed to the user
	When User clicks Add Members button on the Teams page
	Then Panel of available members is displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12552
Scenario: EvergreenJnr_AdminPage_CheckThatFiltersAreWorkingCorrectlyOnTheAdminPages
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User enters "Migration phase 3 team" text in the Search field for "Team" column on the Teams page
	Then "1" rows are displayed on the Teams page
	When User enters ">=5" text in the Search field for "Project Buckets" column on the Teams page
	Then "5" rows are displayed on the Teams page
	When User enters "Administrative Team" text in the Search field for "Team" column on the Teams page
	And User clicks content from "Team" column on the Teams page
	When User enters "readonly" text in the Search field for "Username" column on the Teams page
	Then "1" rows are displayed on the Teams page
	And User clicks "Buckets" tab on the Teams page
	When User enters "Cardiff --- Test text fill; Test text fill; ------" text in the Search field for "Bucket" column on the Teams page
	Then "1" rows are displayed on the Teams page
	When User enters "<10" text in the Search field for "Devices" column on the Teams page
	Then "4" rows are displayed on the Teams page
	When User clicks Admin on the left-hand menu
	When User click "Buckets" link on the Admin page
	When User enters "barry's" text in the Search field for "Bucket" column on the Buckets page
	Then "2" rows are displayed on the Buckets page
	When User enters "=13" text in the Search field for "Users" column on the Buckets page
	Then "7" rows are displayed on the Buckets page
	When User enters "Unassigned" text in the Search field for "Bucket" column on the Buckets page
	And User clicks content from "Bucket" column on the Buckets page
	When User enters "BG4H" text in the Search field for "Hostname" column on the Buckets page
	Then "2" rows are displayed on the Buckets page
	When User enters "Mac OS X 10.12.3" text in the Search field for "Operating System" column on the Buckets page
	Then "1" rows are displayed on the Buckets page
	And User clicks "Users" tab on the Buckets page
	When User enters "Pinabel Cinq-Mars" text in the Search field for "Display Name" column on the Buckets page
	Then "1" rows are displayed on the Buckets page
	When User enters "1DFF" text in the Search field for "Username" column on the Buckets page
	Then "3" rows are displayed on the Buckets page
	And User clicks "Mailboxes" tab on the Buckets page
	When User enters "DiscoverySearchMailbox{D919BA05-46A6-415f-80AD-7E09334BB852}@juriba1.onmicrosoft.com" text in the Search field for "Email Address (Primary)" column on the Buckets page
	Then "1" rows are displayed on the Buckets page
	When User enters "RD-EXCH2K3" text in the Search field for "Server Name" column on the Buckets page
	Then "6" rows are displayed on the Buckets page