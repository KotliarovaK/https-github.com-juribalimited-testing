Feature: ProjectsPart15
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12787 @DAS13529 @DAS16128 @DAS15201 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatSelectedBucketsIsDisplayedForOnboardedObjectsInQueueAndHistory
	When Project created via API and opened
	| ProjectName   | Scope     | ProjectTemplate | Mode               |
	| UsersProject3 | All Users | None            | Standalone Project |
	When User clicks Admin on the left-hand menu
	When User clicks "Projects" on the left-hand menu
	Then "Projects Home" page is displayed to the user
	When User navigate to "UsersProject3" Project
	Then Project with "UsersProject3" name is displayed correctly
	And "Manage Project Details" page is displayed to the user
	When User navigate to "Groups" tab
	Then "Manage Groups" page is displayed to the user
	When User clicks "Create Group" button
	And User create Group owned existing "Admin IT" Team
	| GroupName          |
	| UsersProject3Group |
	When User clicks "Create Group" button
	And User navigate to Evergreen link
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	And "Projects" page should be displayed to the user
	When User enters "UsersProject3" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "UsersProject3" is displayed to user
	When user selects "UsersProject3Group" in the Bucket dropdown
	And User expands the object to add 
	And User selects following Objects to the Project
	| Objects                               |
	| 003F5D8E1A844B1FAA5 (Hunter, Melanie) |
	And User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "1 object queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items               |
	| 003F5D8E1A844B1FAA5 |
	Then "UsersProject3Group" content is displayed in "Bucket" column
	Then "Unassigned" content is displayed in "Capacity Unit" column
	Then Column is displayed in following order:
	| ColumnName    |
	| Date          |
	| Item          |
	| Object Type   |
	| Action        |
	| Bucket        |
	| Capacity Unit |
	| Ring          |
	When User enters "Unassigned" text in the Search field for "Capacity Unit" column
	Then Rows counter shows "1" of "1" rows
	When User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items               |
	| 003F5D8E1A844B1FAA5 |
	And "UsersProject3Group" content is displayed in "Bucket" column
	Then "Unassigned" content is displayed in "Capacity Unit" column
	Then Column is displayed in following order:
	| ColumnName    |
	| Date          |
	| Item          |
	| Object Type   |
	| Action        |
	| Bucket        |
	| Capacity Unit |
	| Ring          |
	| Status        |
	When User enters "Units" text in the Search field for "Capacity Unit" column
	Then Rows counter shows "0" of "1" rows

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12157 @Cleanup
Scenario Outline: EvergreenJnr_AdminPage_CheckThatProjectScopeChangesIsLoadedSuccessfullyAfterChangingProjectScopeToACustomList
	When User create static list with "DevicesList12157" name on "Devices" page with following items
	| ItemName       |
	| 0I29CJMQ159EOR |
	Then "DevicesList12157" list is displayed to user
	When User create static list with "UsersList12157" name on "Users" page with following items
	| ItemName  |
	| TSI892249 |
	Then "UsersList12157" list is displayed to user
	When User create static list with "MailboxesList12157" name on "Mailboxes" page with following items
	| ItemName             |
	| elsonje@bclabs.local |
	Then "MailboxesList12157" list is displayed to user
	When User create static list with "ApplicationsStaticList12157" name on "Applications" page with following items
	| ItemName             |
	| Adobe SVG Viewer 3.0 |
	Then "ApplicationsStaticList12157" list is displayed to user
	When Project created via API and opened
	| ProjectName | Scope      | ProjectTemplate | Mode               |
	| <TestName>  | <MainList> | None            | Standalone Project |
	Then Project "<TestName>" is displayed to user
	When User selects "Scope" tab on the Project details page
	When User selects "<ListToScope1>" in the Scope Project details
	And User navigates to the "<ScopeTab1>" tab in the Scope section on the Project details page
	And User selects "<ListToScope2>" in the Scope Project details
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	When  User selects "Include applications" checkbox on the Project details page
	And User selects "ApplicationsStaticList12157" in the Scope Project details
	And User selects "Scope Changes" tab on the Project details page
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User navigates to the '<ScopeChanges1>' left menu item
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Applications' tab on Scope Changes page
	Then "<ObjectsToAdd3>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| MainList      | TestName  | ObjectsToAdd1                      | ListToScope1       | ScopeTab1    | ListToScope2     | ScopeChanges1 | ObjectsToAdd2                    | ObjectsToAdd3                         |
	| All Devices   | DAS12157A | Devices to add (0 of 1 selected)   | DevicesList12157   | User Scope   | UsersList12157   | Users         | Users to add (0 of 1 selected)   | Applications to add (0 of 1 selected) |
	| All Users     | DAS12157B | Users to add (0 of 1 selected)     | UsersList12157     | Device Scope | DevicesList12157 | Devices       | Devices to add (0 of 1 selected) | Applications to add (0 of 1 selected) |
	| All Mailboxes | DAS12157C | Mailboxes to add (0 of 1 selected) | MailboxesList12157 | User Scope   | UsersList12157   | Users         | Users to add (0 of 0 selected)   | Applications to add (0 of 0 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11981 @Projects @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatItemsToAddValuesAreNotCachedAfterScopeOptionsChangeOnProjectDetailsPage
	When Project created via API and opened
	| ProjectName | Scope       | ProjectTemplate | Mode               |
	| DAS11981    | All Devices | None            | Standalone Project |
	When User selects "Scope" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User clicks following checkboxes on the Project details page:
	| CheckboxesToBeClicked                  |
	| Entitled to the device                 |
	| Installed on the device                |
	| Used by the device owner on any device |
	| Used on the device by the device owner |
	| Used on the device by any user         |
	And User selects "Scope Changes" tab on the Project details page
	And User navigates to the 'Applications' left menu item
	Then "Applications to add (0 of 212 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Users' tab on Scope Changes page
	Then "Users to add (0 of 14629 selected)" is displayed to the user in the Project Scope Changes section
	When User selects "Scope Details" tab on the Project details page
	And User navigates to the "Application Scope" tab in the Scope section on the Project details page
	And User clicks "Entitled to the device" checkbox on the Project details page
	And User navigates to the "User Scope" tab in the Scope section on the Project details page
	And User selects "Do not include device owners" checkbox on the Project details page
	And User selects "Scope Changes" tab on the Project details page
	And User navigates to the 'Applications' left menu item
	Then "Applications to add (0 of 1059 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Users' tab on Scope Changes page
	Then "Users to add (0 of 0 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS13428 @Cleanup
Scenario: EvergreenJnr_AdminPage_TheGreenBannerIsNotDisplayedIfBannerWasBeShownOnce
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project12965 | All Devices | None            | Standalone Project |
	Then Project "Project12965" is displayed to user
	When User selects "Scope" tab on the Project details page
	When User selects "Scope Changes" tab on the Project details page
	And User navigates to the 'Devices' left menu item
	And User expands the object to add 
	And User adds following Objects to the Project
	| Objects         |
	| 0623U41CZ73RV2Q |
	When User clicks the "UPDATE ALL CHANGES" Action button
	And User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "1 object queued for onboarding, 0 objects offboarded" text
	When User selects "Queue" tab on the Project details page
	Then following Items are displayed in the Queue table
	| Items           |
	| 0623U41CZ73RV2Q |
	When User selects "History" tab on the Project details page
	Then following Items are displayed in the History table
	| Items           |
	| 0623U41CZ73RV2Q |
	When User selects "Scope Changes" tab on the Project details page
	Then Success message is not displayed on the Admin page