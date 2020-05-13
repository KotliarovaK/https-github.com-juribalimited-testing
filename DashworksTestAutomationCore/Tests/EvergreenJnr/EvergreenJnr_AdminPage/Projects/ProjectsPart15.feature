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
	When User clicks 'Admin' on the left-hand menu
	When User clicks 'Projects' on the left-hand menu
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
	And User clicks 'Admin' on the left-hand menu
	Then 'Admin' list should be displayed to the user
	And Page with 'Projects' header is displayed to user
	When User enters "UsersProject3" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Page with 'UsersProject3' header is displayed to user
	When User selects 'UsersProject3Group' in the 'Bucket' dropdown
	And User expands multiselect and selects following Objects
	| Objects                               |
	| 003F5D8E1A844B1FAA5 (Hunter, Melanie) |
	And User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
	Then following Items are displayed in the Queue table
	| Items               |
	| 003F5D8E1A844B1FAA5 |
	Then 'UsersProject3Group' content is displayed in the 'Bucket' column
	Then 'Unassigned' content is displayed in the 'Capacity Unit' column
	Then grid headers are displayed in the following order
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
	When User navigates to the 'History' left menu item
	Then following Items are displayed in the History table
	| Items               |
	| 003F5D8E1A844B1FAA5 |
	And 'UsersProject3Group' content is displayed in the 'Bucket' column
	Then 'Unassigned' content is displayed in the 'Capacity Unit' column
	Then grid headers are displayed in the following order
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

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS12157 @DAS18943 @Cleanup
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
	Then Page with '<TestName>' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User selects '<ListToScope1>' in the 'Scope' dropdown with wait
	And User navigates to the '<ScopeTab1>' tab on Project Scope Changes page
	And User selects '<ListToScope2>' in the '<ScopeSelectbox>' dropdown with wait
	And User navigates to the 'Application Scope' tab on Project Scope Changes page
	When  User selects "Include applications" checkbox on the Project details page
	And User selects 'ApplicationsStaticList12157' in the 'Application Scope' dropdown with wait
	And User navigates to the 'Scope Changes' left menu item
	Then "<ObjectsToAdd1>" is displayed to the user in the Project Scope Changes section
	When User navigates to the '<ScopeChanges1>' tab on Project Scope Changes page
	Then "<ObjectsToAdd2>" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Applications' tab on Project Scope Changes page
	Then "<ObjectsToAdd3>" is displayed to the user in the Project Scope Changes section
	Then There are no errors in the browser console

Examples:
	| MainList      | TestName  | ObjectsToAdd1                      | ListToScope1       | ScopeTab1    | ScopeSelectbox | ListToScope2     | ScopeChanges1 | ObjectsToAdd2                    | ObjectsToAdd3                         |
	| All Devices   | DAS12157A | Devices to add (0 of 1 selected)   | DevicesList12157   | User Scope   | User Scope     | UsersList12157   | Users         | Users to add (0 of 1 selected)   | Applications to add (0 of 1 selected) |
	| All Users     | DAS12157B | Users to add (0 of 1 selected)     | UsersList12157     | Device Scope | Device Scope   | DevicesList12157 | Devices       | Devices to add (0 of 1 selected) | Applications to add (0 of 1 selected) |
	| All Mailboxes | DAS12157C | Mailboxes to add (0 of 1 selected) | MailboxesList12157 | User Scope   | User Scope     | UsersList12157   | Users         | Users to add (0 of 0 selected)   | Applications to add (0 of 0 selected) |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS11981 @Projects @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatItemsToAddValuesAreNotCachedAfterScopeOptionsChangeOnProjectDetailsPage
	When Project created via API and opened
	| ProjectName | Scope       | ProjectTemplate | Mode               |
	| DAS11981    | All Devices | None            | Standalone Project |
	When User navigates to the 'Scope' left menu item
	And User navigates to the 'Application Scope' tab on Project Scope Changes page
	And User unchecks 'Entitled to the device' checkbox
	And User unchecks 'Installed on the device' checkbox
	And User unchecks 'Used by the device owner on any device' checkbox
	And User unchecks 'Used on the device by the device owner' checkbox
	And User unchecks 'Used on the device by any user' checkbox
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 212 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 14629 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Scope Details' left menu item
	And User navigates to the 'Application Scope' tab on Project Scope Changes page
	And User checks 'Entitled to the device' checkbox
	And User navigates to the 'User Scope' tab on Project Scope Changes page
	And User selects "Do not include device owners" checkbox on the Project details page
	And User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Applications' tab on Project Scope Changes page
	Then "Applications to add (0 of 1059 selected)" is displayed to the user in the Project Scope Changes section
	When User navigates to the 'Users' tab on Project Scope Changes page
	Then "Users to add (0 of 35 selected)" is displayed to the user in the Project Scope Changes section

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @Projects @DAS13428 @Cleanup
Scenario: EvergreenJnr_AdminPage_TheGreenBannerIsNotDisplayedIfBannerWasBeShownOnce
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project13428 | All Devices | None            | Standalone Project |
	Then Page with 'Project13428' header is displayed to user
	When User navigates to the 'Scope' left menu item
	When User navigates to the 'Scope Changes' left menu item
	And User navigates to the 'Devices' tab on Project Scope Changes page
	And User expands multiselect to add objects 
	And User selects following Objects from the expandable multiselect
	| Objects         |
	| 0623U41CZ73RV2Q |
	When User clicks 'UPDATE ALL CHANGES' button 
	And User clicks 'UPDATE PROJECT' button 
	Then '1 object queued for onboarding, 0 objects offboarded' text is displayed on inline success banner
	When User navigates to the 'Queue' left menu item
	Then following Items are displayed in the Queue table
	| Items           |
	| 0623U41CZ73RV2Q |
	When User navigates to the 'History' left menu item
	Then following Items are displayed in the History table
	| Items           |
	| 0623U41CZ73RV2Q |
	When User navigates to the 'Scope Changes' left menu item
	Then inline success banner is not displayed