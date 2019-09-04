Feature: Offboard
	Runs Offboard related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#Ann.Ilchenko 8/27/19: ready on 'quasar';
@Evergreen @Applications @EvergreenJnr_ItemDetails @Offboard @DAS17919 @Cleanup @Not_Ready
Scenario: EvergreenJnr_ApplicationsList_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageOnApplicationsPage
	When Project created via API and opened
	| ProjectName  | Scope       | ProjectTemplate | Mode               |
	| Project17919 | All Devices | None            | Standalone Project |
	#TODO create API ONBOARDING step;
	When User clicks "Applications" on the left-hand menu
	Then "All Applications" list should be displayed to the user
	When User perform search by "Technical Information Sampler: January 2003"
	And User click content from "Application" column
	Then Details page for "Technical Information Sampler: January 2003" item is displayed to the user
	When User switches to the "Project17919" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Warning message with "This application will be offboarded, this cannot be undone" text is displayed on the Project Details Page
	When User clicks 'OFFBOARD' button in the warning message
	Then Success message is displayed and contains "The application was successfully queued for offboarding from Project17919" text

	#Ann.Ilchenko 8/28/19: ready on 'quasar';
	#TODO create API ONBOARDING step;
@Evergreen @AllLists @EvergreenJnr_ItemDetails @Offboard @DAS17843 @DAS17926 @Cleanup @Not_Ready
Scenario Outline: EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageWhichHasAssociatedObjects
	When User clicks "<PageName>" on the left-hand menu
	Then "<LoadedPage>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User switches to the "<ProjectName>" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Offboard Pop-up is displayed on the Item Details page
	When User clicks the "OFFBOARD" Action button
	Then Warning message with "The selected objects will be offboarded, this cannot be undone" text is displayed on the Project Details Page
	When User clicks the "OFFBOARD" Action button
	#going to check the object state
	When User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User clicks content from "Project" column
	And User clicks "Scope" tab
	And User selects "History" tab on the Project details page
	And User enters "<ItemName>" text in the Search field for "Item" column
	Then "<ItemName>" content is displayed in "Item" column

Examples: 
	| PageName  | LoadedPage    | ItemName                         | ColumnName    | ProjectName                        |
	| Devices   | All Devices   | 063X2ZOB8V3GUY                   | Hostname      | I-Computer Scheduled Project       |
	| Users     | All Users     | ANN485030                        | Username      | I-Computer Scheduled Project       |
	| Mailboxes | All Mailboxes | 06A573B6200A4A10BC2@bclabs.local | Email Address | Mailbox Evergreen Capacity Project |

	#Ann.Ilchenko 8/28/19: ready on 'quasar';
	#TODO create API ONBOARDING step;
@Evergreen @AllLists @EvergreenJnr_ItemDetails @Offboard @DAS17843 @DAS17926 @Cleanup @Not_Ready
Scenario Outline: EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageWhichHasNoAssociatedObjects
	When User clicks "<PageName>" on the left-hand menu
	Then "<LoadedPage>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User switches to the "<ProjectName>" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Offboard Pop-up is displayed on the Item Details page
	When User clicks the "OFFBOARD" Action button
	Then Warning message with "<Message>" text is displayed on the Project Details Page
	When User clicks the "OFFBOARD" Action button
	#going to check the object state
	And User clicks Admin on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User clicks "Scope" tab
	And User selects "History" tab on the Project details page
	And User enters "<ItemName>" text in the Search field for "Item" column
	Then "<ItemName>" content is displayed in "Item" column

Examples: 
	| PageName  | LoadedPage    | ItemName                | ColumnName    | ProjectName                  | Message                                                |
	| Devices   | All Devices   | 02M88BG4P29EEM          | Hostname      | I-Computer Scheduled Project | This device will be offboarded, this cannot be undone  |
	| Users     | All Users     | 0088FC8A50DD4344B92     | Username      | I-Computer Scheduled Project | This user will be offboarded, this cannot be undone    |
	| Mailboxes | All Mailboxes | alex.cristea@juriba.com | Email Address | Email Migration              | This mailbox will be offboarded, this cannot be undone |

@Evergreen @AllLists @EvergreenJnr_ItemDetails @Offboard @DAS17964 @Not_Ready
Scenario Outline: EvergreenJnr_AllLists_VerifyThatTheMessageAppearsCorrectlyOnTheOffboardPopUpWindow
	When User clicks "<PageName>" on the left-hand menu
	Then "<LoadedPage>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User switches to the "<ProjectName>" project in the Top bar on Item details page
	And User navigates to the "Projects" main-menu on the Details page
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Offboard Pop-up is displayed on the Item Details page
	Then following text '<Text>' is displayed in Offboard Pop-up

Examples: 
	| PageName  | LoadedPage    | ItemName                | ColumnName    | ProjectName                          | Text                                                                                                                                                                       |
	| Devices   | All Devices   | 001BAQXT6JWFPI          | Hostname      | USE ME FOR AUTOMATION(DEVICE SCHDLD) | Offboarding device 001BAQXT6JWFPI. Select any associated users below to offboard at the same time. Offboarding an object deletes all project related information about it. |
	| Devices   | All Devices   | 001BAQXT6JWFPI          | Hostname      | USE ME FOR AUTOMATION(USR SCHDLD)    | Offboarding device 001BAQXT6JWFPI. Offboarding an object deletes all project related information about it.                                                                 |
	#add check for Project with assotiated users
	| Users     | All Users     | 0088FC8A50DD4344B92     | Username      | USE ME FOR AUTOMATION(USR SCHDLD)    | Offboarding user BCLABS\0088FC8A50DD4344B92 (Barland, Steinar). Offboarding an object deletes all project related information about it.                                    |
	#add check for Project with assotiated users
	| Mailboxes | All Mailboxes | alex.cristea@juriba.com | Email Address | Email Migration                      | Offboarding mailbox alex.cristea@juriba.com (Alex Cristea). Offboarding an object deletes all project related information about it.                                        |