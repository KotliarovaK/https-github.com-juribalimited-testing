Feature: Offboard
	Runs Offboard related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

	#TODO create API ONBOARDING step;
@Evergreen @AllLists @EvergreenJnr_ItemDetails @Offboard @DAS17843 @DAS17926 @Cleanup @Not_Ready
Scenario Outline: EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageWhichHasAssociatedObjects
	When User clicks '<PageName>' on the left-hand menu
	Then "<LoadedPage>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User switches to the "<ProjectName>" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Dialog Pop-up is displayed for User
	When User clicks the "OFFBOARD" Action button
	Then Warning message with "The selected objects will be offboarded, this cannot be undone" text is displayed on the Project Details Page
	When User clicks the "OFFBOARD" Action button
	#going to check the object state
	When User clicks 'Admin' on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User navigates to the 'Scope' left menu item
	And User selects "History" tab on the Project details page
	And User enters "<ItemName>" text in the Search field for "Item" column
	Then "<ItemName>" content is displayed in "Item" column

Examples: 
	| PageName  | LoadedPage    | ItemName                         | ColumnName    | ProjectName                        |
	| Devices   | All Devices   | 063X2ZOB8V3GUY                   | Hostname      | I-Computer Scheduled Project       |
	| Users     | All Users     | ANN485030                        | Username      | I-Computer Scheduled Project       |
	| Mailboxes | All Mailboxes | 06A573B6200A4A10BC2@bclabs.local | Email Address | Mailbox Evergreen Capacity Project |

	#TODO create API ONBOARDING step;
@Evergreen @AllLists @EvergreenJnr_ItemDetails @Offboard @DAS17843 @DAS17926 @Cleanup @Not_Ready
Scenario Outline: EvergreenJnr_AllLists_CheckThatOffboardOptionIsWorkedCorrectlyForProjectDetailsPageWhichHasNoAssociatedObjects
	When User clicks '<PageName>' on the left-hand menu
	Then "<LoadedPage>" list should be displayed to the user
	When User perform search by "<ItemName>"
	And User click content from "<ColumnName>" column
	Then Details page for "<ItemName>" item is displayed to the user
	When User switches to the "<ProjectName>" project in the Top bar on Item details page
	When User navigates to the 'Projects' left menu item
	And User navigates to the "Project Details" sub-menu on the Details page
	And User clicks the "OFFBOARD" Action button
	Then Dialog Pop-up is displayed for User
	When User clicks the "OFFBOARD" Action button
	Then Warning message with "<Message>" text is displayed on the Project Details Page
	When User clicks the "OFFBOARD" Action button
	#going to check the object state
	And User clicks 'Admin' on the left-hand menu
	Then Admin page should be displayed to the user
	When User clicks "Projects" link on the Admin page
	Then "Projects" page should be displayed to the user
	When User enters "<ProjectName>" text in the Search field for "Project" column
	And User clicks content from "Project" column
	When User navigates to the 'Scope' left menu item
	And User selects "History" tab on the Project details page
	And User enters "<ItemName>" text in the Search field for "Item" column
	Then "<ItemName>" content is displayed in "Item" column

Examples: 
	| PageName  | LoadedPage    | ItemName                | ColumnName    | ProjectName                  | Message                                                |
	| Devices   | All Devices   | 02M88BG4P29EEM          | Hostname      | I-Computer Scheduled Project | This device will be offboarded, this cannot be undone  |
	| Users     | All Users     | 0088FC8A50DD4344B92     | Username      | I-Computer Scheduled Project | This user will be offboarded, this cannot be undone    |
	| Mailboxes | All Mailboxes | alex.cristea@juriba.com | Email Address | Email Migration              | This mailbox will be offboarded, this cannot be undone |