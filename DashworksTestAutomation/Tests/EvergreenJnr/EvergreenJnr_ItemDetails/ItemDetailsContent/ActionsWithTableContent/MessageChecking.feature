Feature: MessageChecking
	Runs Item Details Message Checking related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12043 @DAS11531 @DAS12321 @DAS17279 @DAS16678 @Zion_NewGrid
Scenario Outline: EvergreenJnr_AllLists_CheckThatErrorsAreNotDisplayedWhenOpenedDetailsPageThatDoesNotContainOwnerInformation
	When User navigates to the '<PageName>' details page for '<ObjectName>' item
	Then Details page for '<ObjectName>' item is displayed to the user
	When User navigates to the '<TabName>' left submenu item
	Then '<MessageText>' message is displayed on empty greed
	And There are no errors in the browser console

Examples:
	| PageName | ObjectName              | TabName       | MessageText                                       |
	| Device   | 06Y8HSNCPVHENV          | Device Owner  | No device owner information found for this device |
	| Mailbox  | alex.cristea@juriba.com | Mailbox Owner | No mailbox owner found for this mailbox           |
	#Added new check for DAS17279
	| Device   | 00BDM1JUR8IF419         | Custom Fields | No custom fields found for this device            |

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12285 @DAS16678 @Zion_NewGrid
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectMessageIsDisplayedForDevicesSectionOnTheDistributionTab
	When User navigates to the 'Application' details page for 'ACT Data Collection Packages' item
	Then Details page for 'ACT Data Collection Packages' item is displayed to the user
	When User navigates to the 'Distribution' left menu item
	When User navigates to the 'Devices' left submenu item
	Then 'No devices found for this application' message is displayed on empty greed

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17278 @Zion_NewGrid
Scenario: EvergreenJnr_DevicesList_CheckThatCorrectMessageIsDisplayedForDevicesSectionIfTheOwnerEqualUnknownForDeviceObjectInEvergreen
	When User navigates to the 'Device' details page for '06Y8HSNCPVHENV' item
	Then Details page for '06Y8HSNCPVHENV' item is displayed to the user
	When User navigates to the 'Users' left menu item
	Then 'No users found for this device' message is displayed on empty greed