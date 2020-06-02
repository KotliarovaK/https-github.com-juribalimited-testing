Feature: ItemDetailsDisplay
	Runs Item Details Display related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @AllLists @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12386 @DAS14923
Scenario Outline: EvergreenJnr_AllLists_CheckThatHyperlinkForKeyColumnsIsRedirectedToTheRelevantDetailsPage
	When User add following columns using URL to the "<PageName>" page:
	| ColumnName |
	| <Column>   |
	Then Content is present in the newly added column
	| ColumnName |
	| <Column>   |
	When User perform search by "<ItemName>"
	When User click content from "<Column>" column
	Then Details page for '<ItemName>' item is displayed to the user
	Then URL contains '<URL>'

Examples:
	| PageName     | Column          | ItemName                         | URL                                             |
	| Devices      | Device Key      | 00KLL9S8NRF0X6                   | evergreen/#/device/8892/details/device          |
	| Users        | User Key        | 0072B088173449E3A93              | evergreen/#/user/85167/details/user             |
	| Applications | Application Key | ACDSee for Windows 95            | evergreen/#/application/312/details/application |
	| Mailboxes    | Mailbox Key     | 01BC4B0500344065B61@bclabs.local | evergreen/#/mailbox/45374/details/mailbox       |

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16338
Scenario: EvergreenJnr_DevicesList_CheckThatCrumbTrailElementInTheHeaderOfThePageIsDisplayed
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for '001BAQXT6JWFPI' item is displayed to the user
	When User clicks 'Devices' header breadcrumb
	Then 'All Devices' list should be displayed to the user
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User navigates to the 'User' details page for '0072B088173449E3A93' item
	Then Details page for '0072B088173449E3A93' item is displayed to the user
	When User clicks 'Users' header breadcrumb
	Then 'All Users' list should be displayed to the user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the 'Application' details page for 'ABBYY FineReader 8.0 Professional Edition' item
	Then Details page for 'ABBYY FineReader 8.0 Professional Edition' item is displayed to the user
	When User clicks 'Applications' header breadcrumb
	Then 'All Applications' list should be displayed to the user
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User navigates to the 'Mailbox' details page for '00B5CCB89AD0404B965@bclabs.local' item
	Then Details page for '00B5CCB89AD0404B965@bclabs.local' item is displayed to the user
	When User clicks 'Mailboxes' header breadcrumb
	Then 'All Mailboxes' list should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS18827
Scenario: EvergreenJnr_UsersList_CheckThatSiteContinueWorkingAfterNavigationToNotExistingItem
	When User navigates to the 'Device' details page for '001PSUMZYOW581' item
	Then Details page for '001PSUMZYOW581' item is displayed to the user
	When User tries to open same page with non existing item id
	Then There are only 'Page not found' errors in console
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	Then There are no errors in the browser console

#sz: waiting for Lisa response for DAS15785
@Evergreen @AllLists  @EvergreenJnr_ItemDetails @DAS15785 @Not_Ready
Scenario Outline: EvergreenJnr_AllLists_CheckThatNumberOfRequestsToItemDontExceedAllowedCount
	When User clicks '<listType>' on the left-hand menu
	Then '<listTitle>' list should be displayed to the user
	When User perform search by "<itemName>"
	When User click content from "<column>" column
	Then Details page for '<itemName>' item is displayed to the user
	Then Number of requests to '<url>' is not greater than '<requests>'

Examples:
	| listType     | listTitle        | itemName                                                  | column        | url               | requests |
	| Devices      | All Devices      | 00KLL9S8NRF0X6                                            | Hostname      | /device/8892/     | 7        |
	| Users        | All Users        | $231000-3AC04R8AR431                                      | Username      | /user/67941/      | 7        |
	| Applications | All Applications | WPF/E" (codename) Community Technology Preview (Feb 2007) | Application   | /application/493/ | 6        |
	| Mailboxes    | All Mailboxes    | 000F977AC8824FE39B8@bclabs.local                          | Email Address | /mailbox/43917/   | 6        |