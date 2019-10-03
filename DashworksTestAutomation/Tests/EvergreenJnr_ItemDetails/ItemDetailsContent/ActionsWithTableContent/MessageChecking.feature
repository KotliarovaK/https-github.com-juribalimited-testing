Feature: MessageChecking
	Runs Item Details Message Checking related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12043 @DAS11531 @DAS12321 @DAS17279 @DAS16678
Scenario Outline: EvergreenJnr_AllLists_CheckThatErrorsAreNotDisplayedWhenOpenedDetailsPageThatDoesNotContainOwnerInformation
	When User clicks '<PageName>' on the left-hand menu
	Then 'All <PageName>' list should be displayed to the user
	When User perform search by "<ObjectName>"
	And User click content from "<ColumnName>" column
	When User navigates to the "<TabName>" sub-menu on the Details page
	Then "<MessageText>" message is displayed on the Details Page
	And There are no errors in the browser console

Examples:
	| PageName  | ObjectName              | ColumnName    | TabName       | MessageText                                       |
	| Devices   | 06Y8HSNCPVHENV          | Hostname      | Device Owner  | No device owner information found for this device |
	| Mailboxes | alex.cristea@juriba.com | Email Address | Mailbox Owner | No mailbox owner found for this mailbox           |
	#Added new check for DAS17279
	| Devices   | 00BDM1JUR8IF419         | Hostname      | Custom Fields | No custom fields found for this device            |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12285 @DAS16678
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectMessageIsDisplayedForDevicesSectionOnTheDistributionTab
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User perform search by "ACT Data Collection Packages"
	And User click content from "Application" column
	When User navigates to the 'Distribution' left menu item
	When User navigates to the "Devices" sub-menu on the Details page
	Then "No devices found for this application" message is displayed on the Details Page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17278
Scenario: EvergreenJnr_DevicesList_CheckThatCorrectMessageIsDisplayedForDevicesSectionIfTheOwnerEqualUnknownForDeviceObjectInEvergreen
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User perform search by "06Y8HSNCPVHENV"
	And User click content from "Hostname" column
	When User navigates to the 'Users' left menu item
	Then "No users found for this device" message is displayed on the Details Page