﻿@retry:1
Feature: AdminPage
	Runs Admin Page related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11747
Scenario: EvergreenJnr_AdminPage_CheckThatErrorIsNotDisplayedWhenCreateTeamWithTheAlreadyExistName
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Teams" link on the Admin page
	Then "Teams" page should be displayed to the user
	When User clicks Create Team button
	Then Create Team page should be displayed to the user
	And User enters "TestTeam" in the Team Name field
	And User enters "test" in the Team Description field
	When User clicks Create Team button on the Create Team page
	Then Success message is displayed and contains "The team has been created" text on the Teams page
	When User clicks Create Team button
	Then Create Team page should be displayed to the user
	And User enters "TestTeam" in the Team Name field
	And User enters "test" in the Team Description field
	When User clicks Create Team button on the Create Team page
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
	And User enters "test" in the Team Description field
	Then Create Team button is disabled

@Evergreen @AllLists @EvergreenJnr_AdminPage @AdminPage @DAS11886
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
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User navigates to the "ListForProject" list
	Then "ListForProject" list is displayed to user
	When User removes custom list with "ListForProject" name
	Then "This list is used by the 1 projects, do you wish to proceed?" message is displayed in the lists panel
	When User clicks Delete in the warning message on the list panel 
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject" Project name
	Then Project "TestProject" is displayed to user
	When User navigates to the "Project Scope Changes" tab on the Project details page
	Then Warning message with "The scope for this project refers to a deleted list, this must be updated before proceeding" text is displayed on the Project details page
	And Update Project button is disabled
	And Delete "TestProject" Project in the Administration

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11977 @DAS11959
Scenario: EvergreenJnr_AdminPage_CheckThatAfterApplyingDoNotIncludeDeviceOwnersListHas0ItemsInTheUsersTab
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create Project button
	Then Create Project page should be displayed to the user
	And User enters "TestProject1596" in the Project Name field
	And User select "All Devices" in the Scope Project dropdown
	When User clicks Create Project button
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject1596" Project name
	Then Project "TestProject1596" is displayed to user
	When User select "Do not include device owners" checkbox on the Project details page
	And User navigates to the "Project Scope Changes" tab on the Project details page
	And User clicks "Users" tab in the Project Scope Changes section 
	Then "Users to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section
	And Delete "TestProject1596" Project in the Administration

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
	When User selects all rows on the Projects page
	And User removes selected Project
	Then Success message with "The selected project has been deleted" text is displayed on the Projects page
	#Then There are no errors in the browser console

	Examples:
	| ProjectName     | ScopeList     |
	| TestProject1626 | All Devices   |
	| TestProject7586 | All Users     |
	| TestProject7511 | All Mailboxes |

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

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12182 @Not_Run
Scenario: EvergreenJnr_AdminPage_CheckThatNumberOfApplicationsInProjectScopeIsCorrectlyUpdated
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks Create Project button
	Then Create Project page should be displayed to the user
	And User enters "TestProject9512" in the Project Name field
	And User select "All Users" in the Scope Project dropdown
	When User clicks Create Project button
	And User click "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks "TestProject9512" Project name
	Then Project "TestProject9512" is displayed to user
	When User navigates to the "Project Scope Changes" tab on the Project details page
	And User clicks "Applications" tab in the Project Scope Changes section
	Then "Applications to add (2081 of 2081 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the "Scope" tab on the Project details page
	And User select "Do not include owned devices" checkbox on the Project details page
	And User navigates to the "Project Scope Changes" tab on the Project details page
	Then "Applications to add (247 of 247 selected)" is displayed to the user in the Project Scope Changes section
	And Delete "TestProject9512" Project in the Administration

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
	And User enters "TestProject9547" in the Project Name field
	And User select "TestList0A78U9" in the Scope Project dropdown
	When User clicks Create Project button
	Then "Projects" page should be displayed to the user
	When User enters "TestProject9547" text in the Search field for "Project" column on the Projects page
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
	When User clicks Update Bucket button on the Buckets page
	Then Success message The "TestBucket2" bucket has been updated is displayed on the Buckets page
	Then Delete "TestBucket2" Bucket in the Administration

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
	When User selects all rows on the Teams page
	Then User clicks on Actions button on the Teams page
	Then User select "Delete Buckets" in the Actions dropdown on the Teams page
	When User clicks Delete button on the Teams page
	Then Reassign Objects is displayed on the Teams page
	Then There are no errors in the browser console