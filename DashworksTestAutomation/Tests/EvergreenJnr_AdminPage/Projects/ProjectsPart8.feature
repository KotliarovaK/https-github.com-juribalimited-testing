Feature: ProjectsPart8
	Runs Projects related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @Cleanup @Cleanup @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckProjectCreationWithProjectBucketsFromListPage
	When User clicks "<PageName>" on the left-hand menu
	Then "All <PageName>" list should be displayed to the user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the "Project Name" field
	Then Scope field is automatically populated
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User create static list with "<StaticList>" name on "<PageName>" page with following items
	| ItemName |
	| <Item>   |
	Then "<StaticList>" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the "Project Name" field
	Then Scope field is automatically populated
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User selects all rows on the grid
	And User removes selected item
	When User clicks "<PageName>" on the left-hand menu
	Then "All <PageName>" list should be displayed to the user
	When User clicks on '<ColumnName>' column header
	And User create dynamic list with "<DynamicList>" name on "<PageName>" page
	Then "<DynamicList>" list is displayed to user
	When User clicks Create Project from the main list
	Then "Create Project" page should be displayed to the user
	When User enters "<ProjectName>" in the "Project Name" field
	Then Scope field is automatically populated
	When User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text

Examples:
	| ProjectName     | StaticList     | PageName  | Item                             | ColumnName    | DynamicList     |
	| TestProject9553 | StaticList8891 | Mailboxes | 00A5B910A1004CF5AC4@bclabs.local | Email Address | DynamicList9537 |
	| TestProject9554 | StaticList8892 | Users     | 003F5D8E1A844B1FAA5              | Username      | DynamicList9538 |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @Cleanup @Projects
Scenario Outline: EvergreenJnr_AdminPage_CheckOnboardingObjectUsingUpdateAppropriateChangesButton
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "TestProject9753" in the "Project Name" field
	And User selects '<AllListName>' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks newly created object link
	Then Project "TestProject9753" is displayed to user
	Then Info message is displayed and contains "There are no objects in this project, use Scope Changes to add objects to your project" text
	When User selects "Scope Changes" tab on the Project details page
	And User navigates to the '<TabName>' left menu item
	And User expands multiselect to add objects 
	And User expands multiselect and selects following Objects
	| Objects        |
	| <ObjectsToAdd> |
	And User clicks the "UPDATE ALL CHANGES" Action button
	Then Warning message with "<WarningMessageText>" text is displayed on the Admin page
	When User clicks the "UPDATE PROJECT" Action button
	Then Success message is displayed and contains "<SuccessMessageText>" text

Examples:
	| AllListName   | TabName   | ObjectsToAdd                                       | WarningMessageText      | SuccessMessageText                                   |
	| All Mailboxes | Mailboxes | 003F5D8E1A844B1FAA5@bclabs.local (Hunter, Melanie) | 1 mailbox will be added | 1 object queued for onboarding, 0 objects offboarded |
	| All Devices   | Users     | ADC714277 (Dina Q. Knight)                         | 1 user will be added    | 1 object queued for onboarding, 0 objects offboarded |

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS12999 @DAS13199 @DAS12781 @DAS12903 @DAS12485 @DAS13803 @DAS13930 @DAS13973 @DAS13530 @Projects @Cleanup
Scenario: EvergreenJnr_AdminPage_ChangingBucketFromUseEvergreenBucketsToCloneEvergreenBuckets
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "1MailboxesProject" in the "Project Name" field
	#And User selects "Evergreen" in the Mode Project dropdown
	When User selects 'All Mailboxes' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Evergreen" link on the Admin page
	When User navigates to the 'Buckets' left menu item
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Select All" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "1MailboxesProject" checkbox from String Filter with item list on the Admin page
	Then Rows counter contains "1" found row of all rows
	Then 'Unassigned' content is displayed in the 'Bucket' column
	When User clicks "Projects" link on the Admin page
	When User enters "1MailboxesProject" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "1MailboxesProject" is displayed to user
	When User navigates to the 'Details' left menu item
	Then "Mailbox scoped project" is displayed in the disabled Project Type field
	When User selects "Clone evergreen buckets to project buckets" in the Buckets Project dropdown
	Then There are no errors in the browser console
	When User navigates to the 'Scope' left menu item
	And User selects "Scope Changes" tab on the Project details page
	Then "Match to Evergreen Bucket" is displayed in the Bucket dropdown
	When User clicks "Administration" navigation link on the Admin page
	When User clicks "Evergreen" link on the Admin page
	When User navigates to the 'Buckets' left menu item
	When User clicks Reset Filters button on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "Select All" checkbox from String Filter with item list on the Admin page
	When User clicks String Filter button for "Project" column on the Admin page
	When User selects "1MailboxesProject" checkbox from String Filter with item list on the Admin page
	Then Rows counter contains "1" found row of all rows
	Then 'Unassigned' content is displayed in the 'Bucket' column

@Evergreen @Admin @EvergreenJnr_AdminPage @AdminPage @DAS13530 @Projects @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckThatNoAdditionalCapacityUnitsAreCreatedWhenChangingCapacityUnitsMode
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User clicks the "CREATE PROJECT" Action button
	Then "Create Project" page should be displayed to the user
	When User enters "13530Project" in the "Project Name" field
	And User selects 'All Devices' option from 'Scope' autocomplete
	And User clicks Create button on the Create Project page
	Then Success message is displayed and contains "The project has been created" text
	When User clicks "Evergreen" link on the Admin page
	And User navigates to the 'Capacity Units' left menu item
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "13530Project" checkbox from String Filter with item list on the Admin page
	Then Rows counter contains "1" found row of all rows
	And 'Unassigned' content is displayed in the 'Capacity Unit' column
	When User clicks "Projects" link on the Admin page
	And User enters "13530Project" text in the Search field for "Project" column
	And User clicks content from "Project" column
	Then Project "13530Project" is displayed to user
	When User navigates to the 'Capacity' left menu item
	And User selects 'Clone evergreen capacity units to project capacity units' in the 'Capacity Units' dropdown
	And User clicks the "UPDATE" Action button
	Then Success message is displayed and contains "The project capacity details have been updated" text
	When User clicks "Administration" navigation link on the Admin page
	And User clicks "Evergreen" link on the Admin page
	And User navigates to the 'Capacity Units' left menu item
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "Evergreen" checkbox from String Filter with item list on the Admin page
	And User clicks String Filter button for "Project" column on the Admin page
	And User selects "13530Project" checkbox from String Filter with item list on the Admin page
	Then Rows counter contains "1" found row of all rows
	Then 'Unassigned' content is displayed in the 'Capacity Unit' column
