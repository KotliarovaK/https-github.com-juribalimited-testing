Feature: ItemDetails_TabsMenu
	Runs Item Details Tabs Menu related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12071
Scenario: EvergreenJnr_DevicesList_CheckThatOpenedSectionIsDisplayedCorrectlyOnTheDetailsPage
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	And User navigates to the "Applications" main-menu on the Details page
	And User navigates to the "Evergreen Detail" sub-menu on the Details page
	Then "Microsoft Internet Explorer 6.0 MUI Pack (Greek) - Menus and Dialogs" content is displayed in "Application" column
	And "Advert - A0129C4E" content is displayed in "Advertisement" column
	And "14" rows found label displays on Details Page
	And table content is present
	Then User sees loaded tab "Evergreen Detail" on the Details page
	When User navigates to the "Advertisements" sub-menu on the Details page
	Then "Advert - A0121431" content is displayed in "Advertisement" column
	And "Hewlett-Packard" content is displayed in "Vendor" column
	And "7" rows found label displays on Details Page
	And table content is present
	Then User sees loaded tab "Advertisements" on the Details page
	When User navigates to the "Collections" sub-menu on the Details page
	Then "Collection A01131CA" content is displayed in "Collection" column
	And "A01 SMS (Spoof)" content is displayed in "Source" column
	And "7" rows found label displays on Details Page
	And table content is present
	And User sees loaded tab "Collections" on the Details page

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS12245 @DAS12321
Scenario: EvergreenJnr_MailboxesList_CheckThatListLoadedCorrectlyAndNoConsoleErrorIsNotDisplayed
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "julia.bell@juriba.com"
	And User click content from "Email Address" column
	When User navigates to the "Trend" main-menu on the Details page
	Then Highcharts graphic is displayed on the Details Page
	And There are no errors in the browser console
	When User navigates to the "Details" main-menu on the Details page
	Then There are no errors in the browser console
	When User navigates to the "Trend" main-menu on the Details page
	Then There are no errors in the browser console
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	And There are no errors in the browser console

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17230
Scenario: EvergreenJnr_ApplicationsList_ChecksThatDisabledDistributionSectionCantBeEnteredByUsingTheBackButtonInTheBrowser
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ACD Display 3.4"
	And User click content from "Application" column
	When User navigates to the "Distribution" main-menu on the Details page
	When User navigates to the "Devices" sub-menu on the Details page
	When User switches to the "Email Migration" project in the Top bar on Item details page
	Then User click back button in the browser
	Then "Distribution" tab-menu on the Details page is expanded
	Then "Evergreen" project is selected in the Top bar on Item details page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16366 @DAS16246
Scenario: EvergreenJnr_DevicesList_CheckThatVerticalMenuIsUnfoldedCorrectlyOnMenuSubItems
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	Then "Details" tab-menu on the Details page is expanded
	Then "Projects" tab-menu on the Details page is not expanded
	Then "Specification" tab-menu on the Details page is not expanded
	Then "Active Directory" tab-menu on the Details page is not expanded
	Then "Applications" tab-menu on the Details page is not expanded
	Then "Compliance" tab-menu on the Details page is not expanded
	When User navigates to the "Projects" main-menu on the Details page
	When User navigates to the "Projects Summary" sub-menu on the Details page
	Then "Projects" tab-menu on the Details page is expanded
	Then "Details" tab-menu on the Details page is not expanded
	Then "Specification" tab-menu on the Details page is not expanded
	Then "Active Directory" tab-menu on the Details page is not expanded
	Then "Applications" tab-menu on the Details page is not expanded
	Then "Compliance" tab-menu on the Details page is not expanded
	When User navigates to the "Active Directory" main-menu on the Details page
	When User navigates to the "Active Directory" sub-menu on the Details page
	Then "Active Directory" tab-menu on the Details page is expanded
	Then "Details" tab-menu on the Details page is not expanded
	Then "Projects" tab-menu on the Details page is not expanded
	Then "Specification" tab-menu on the Details page is not expanded
	Then "Applications" tab-menu on the Details page is not expanded
	Then "Compliance" tab-menu on the Details page is not expanded

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS16379 @DAS16415 @DAS16500 @DAS16297 @DAS15583 @DAS15559
Scenario: EvergreenJnr_DevicesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForDevicesPageInEvergreenMode
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Specification    |
	| Active Directory |
	| Applications     |
	| Compliance       |
	Then "Users" tab is displayed on left menu on the Details page and contains count of items
	Then "Related" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Device                  |
	| Device Owner            |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Device" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Device Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Evergreen Details      |
	| Projects Summary       |
	| Owner Projects Summary |
	Then "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	Then "Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Owner Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Specification tab ================#
	Then "Specification" main-menu on the Details page contains following sub-menu:
	| SubTabName    |
	| Specification | 
	| Network Cards | 
	| CPUS          |
	| Video Cards   |
	| Monitors      |
	| Sound Cards   | 
	#================ checks counters ================#
	Then "Network Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "CPUS" tab is displayed on left menu on the Details page and contains count of items
	Then "Video Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "Monitors" tab is displayed on left menu on the Details page and contains count of items
	Then "Sound Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "Specification" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       | 
	| Active Directory |  
	| Groups           |
	| LDAP             | 
	#================ checks counters ================#
	Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary | 
	| Evergreen Detail  |
	| Advertisements    | 
	| Collections       |
	#================ checks counters ================#
	Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          | 
	| Overview            |          
	| Hardware Summary    |            
	| Hardware Rules      |           
	| Application Summary |            
	| Application Issues  |
	#================ checks counters ================#
	Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS15560
Scenario: EvergreenJnr_DevicesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForDevicesPageInProjectMode
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User perform search by "001BAQXT6JWFPI"
	When User click content from "Hostname" column
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	When User switches to the "Havoc (Big Data)" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Specification    |
	| Active Directory |
	| Applications     |
	| Compliance       |
	Then "Users" tab is displayed on left menu on the Details page and contains count of items
	Then "Related" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Tasks Disabled in Evergreen" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Device                  |
	| Device Owner            |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Device" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Device Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Evergreen Details      |
	| Project Details        |
	| Projects Summary       |
	| Owner Projects Summary |
	#================ checks counters ================#
	Then "Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Owner Projects Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Specification tab ================#
	Then "Specification" main-menu on the Details page contains following sub-menu:
	| SubTabName    |
	| Specification | 
	| Network Cards | 
	| CPUS          |
	| Video Cards   |
	| Monitors      |
	| Sound Cards   | 
	#================ checks counters ================#
	Then "Network Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "CPUS" tab is displayed on left menu on the Details page and contains count of items
	Then "Video Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "Monitors" tab is displayed on left menu on the Details page and contains count of items
	Then "Sound Cards" tab is displayed on left menu on the Details page and contains count of items
	Then "Specification" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       | 
	| Active Directory |  
	| Groups           |
	| LDAP             | 
	#================ checks counters ================#
	Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary | 
	| Evergreen Detail  |
	| Advertisements    | 
	| Collections       |
	#================ checks counters ================#
	Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          | 
	| Overview            |          
	| Hardware Summary    |            
	| Hardware Rules      |           
	| Application Summary |            
	| Application Issues  |
	#================ checks counters ================#
	Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS16418 @DAS16415 @DAS15583 @DAS15348 @DAS17141 @DAS16830
Scenario: EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInEvergreenMode
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	When User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Active Directory |
	| Applications     |
	| Mailboxes        |
	| Compliance       |
	Then "Devices" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| User                    |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "User" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Evergreen Details       |
	| User Projects           |
	| Device Project Summary  |
	| Mailbox Project Summary |
	Then "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	Then "User Projects" tab is displayed on left menu on the Details page and contains count of items
	Then "Device Project Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Mailbox Project Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	#| Active Directory |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Mailboxes tab ================#
	Then "Mailboxes" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	Then "Mailboxes" tab is displayed on left menu on the Details page and contains count of items
	Then "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Overview            |
	| Hardware Summary    |
	| Hardware Rules      |
	| Application Summary |
	| Application Issues  |
	#================ checks counters ================#
	Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	#Ann.Ilchenko 7/11/19: waiting for an error response
	#Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

	#remove hash when the functionality will be implemented
@Evergreen @Users @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16884
Scenario: EvergreenJnr_UsersList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForUsersPageInProjectMode
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User perform search by "0072B088173449E3A93"
	When User click content from "Username" column
	Then Details page for "0072B088173449E3A93" item is displayed to the user
	When User switches to the "User Evergreen Capacity Project" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName          |
	| Details          |
	| Projects         |
	| Active Directory |
	| Applications     |
	| Mailboxes        |
	| Compliance       |
	Then "Devices" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| User                    |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "User" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Evergreen Details       |
	| Project Details         |
	| User Projects           |
	| Device Project Summary  |
	| Mailbox Project Summary |
	#================ checks counters ================#
	Then "User Projects" tab is displayed on left menu on the Details page and contains count of items
	Then "Device Project Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Mailbox Project Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Active Directory tab ================#
	Then "Active Directory" main-menu on the Details page contains following sub-menu:
	| SubTabName       |
	#| Active Directory |
	| Groups           |
	| LDAP             |
	#================ checks counters ================#
	Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	#Then "Active Directory" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "LDAP" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Applications tab ================#
	Then "Applications" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Summary |
	| Evergreen Detail  |
	| Advertisements    |
	| Collections       |
	#================ checks counters ================#
	Then "Evergreen Summary" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Detail" tab is displayed on left menu on the Details page and contains count of items
	Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	Then "Collections" tab is displayed on left menu on the Details page and contains count of items
	#================ checks sub-menu for main Mailboxes tab ================#
	Then "Mailboxes" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Mailboxes           |
	| Mailbox Permissions |
	#================ checks counters ================#
	Then "Mailboxes" tab is displayed on left menu on the Details page and contains count of items
	Then "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Compliance tab ================#
	Then "Compliance" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Overview            |
	| Hardware Summary    |
	| Hardware Rules      |
	| Application Summary |
	| Application Issues  |
	#================ checks counters ================#
	Then "Application Issues" tab is displayed on left menu on the Details page and contains count of items
	Then "Overview" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Hardware Summary" tab is displayed on left menu on the Details page and NOT contains count of items
	#Ann.Ilchenko 7/11/19: waiting for an error response
	#Then "Hardware Rules" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Application Summary" tab is displayed on left menu on the Details page and NOT contains count of items

	#remove hash when the functionality will be implemented
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS15583 @DAS15345
Scenario: EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForApplicationsPageInEvergreenMode
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	When User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName      |
	| Details      |
	| Projects     |
	| MSI          |
	| Distribution |
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName     |
	| Application    |
	| Advertisements |
	| Programs       |
	| Custom Fields  |
	#================ checks counters ================#
	#Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	#Then "Programs" tab is displayed on left menu on the Details page and contains count of items
	#Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Application" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Details |
	| Projects          |
	Then "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	#Then "Projects" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main MSI tab ================#
	Then "MSI" main-menu on the Details page contains following sub-menu:
	| SubTabName |
	| MSIFiles   |
	| AOK        |
	#================ checks counters ================#
	Then "MSIFiles" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "AOK" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Distribution tab ================#
	Then "Distribution" main-menu on the Details page contains following sub-menu:
	| SubTabName |
	| Users      |
	| Devices    |
	| Groups     |
	| AD         |
	#================ checks counters ================#
	#Then "Users" tab is displayed on left menu on the Details page and contains count of items
	#Then "Devices" tab is displayed on left menu on the Details page and contains count of items
	#Then "Groups" tab is displayed on left menu on the Details page and contains count of items
	Then "AD" tab is displayed on left menu on the Details page and NOT contains count of items

	#remove hash when the functionality will be implemented
@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16885 @DAS17213
Scenario: EvergreenJnr_ApplicationsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForApplicationsPageInProjectMode
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User perform search by "ABBYY FineReader 8.0 Professional Edition"
	When User click content from "Application" column
	Then Details page for "ABBYY FineReader 8.0 Professional Edition" item is displayed to the user
	When User switches to the "Project K-Computer Scheduled Project" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName      |
	| Details      |
	| Projects     |
	| MSI          |
	| Distribution |
	Then "Distribution" main-tab is displayed with disabled state on left menu on the Details page
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName     |
	| Application    |
	| Advertisements |
	| Programs       |
	| Custom Fields  |
	#================ checks counters ================#
	#Then "Advertisements" tab is displayed on left menu on the Details page and contains count of items
	#Then "Programs" tab is displayed on left menu on the Details page and contains count of items
	#Then "Custom Fields" tab is displayed on left menu on the Details page and contains count of items
	Then "Application" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName        |
	| Evergreen Details |
	| Project Details   |
	| Projects          |
	#================ checks counters ================#
	#Then "Projects" tab is displayed on left menu on the Details page and contains count of items
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main MSI tab ================#
	Then "MSI" main-menu on the Details page contains following sub-menu:
	| SubTabName |
	| MSIFiles   |
	| AOK        |
	#================ checks counters ================#
	Then "MSIFiles" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "AOK" tab is displayed on left menu on the Details page and NOT contains count of items

	#remove hash when the functionality will be implemented
@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16378 @DAS15583 @DAS16905
Scenario: EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInEvergreenMode
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	When User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	Then User sees following main-tabs on left menu on the Details page:
	| TabName  |
	| Details  |
	| Projects |
	| Users    |
	| Trend    |
	#Then "Related" sub-tab is displayed with disabled state on left menu on the Details page
	#Then "Notes" sub-tab is displayed with disabled state on left menu on the Details page
	#Then "Audit History" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Mailbox                 |
	| Mailbox Owner           |
	| Email Addresses         |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Mailbox" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Email Addresses" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Custom Fields" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName            |
	| Evergreen Details     |
	| Mailbox Projects      |
	| Mailbox User Projects |
	Then "Project Details" sub-tab is displayed with disabled state on left menu on the Details page
	#================ checks counters ================#
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Projects" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox User Projects" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Users tab ================#
	Then "Users" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Users               |
	| Groups              |
	| Unresolved Users    |
	| Mailbox Permissions |
	| Folder Permissions  |
	#================ checks counters ================#
	Then "Users" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Groups" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Unresolved Users" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Folder Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Trend tab ================#
	Then "Trend" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Email Count            |
	| Mailbox Size (MB)      |
	| Associated Item Count  |
	| Deleted Item Count     |
	| Deleted Item Size (MB) |
	#================ checks counters ================#
	Then "Email Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Associated Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Deleted Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Deleted Item Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items

@Evergreen @Mailboxes @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS15583 @DAS16906
Scenario: EvergreenJnr_MailboxesList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForMailboxesPageInProjectMode
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User perform search by "00B5CCB89AD0404B965@bclabs.local"
	When User click content from "Email Address" column
	Then Details page for "00B5CCB89AD0404B965@bclabs.local" item is displayed to the user
	When User switches to the "Mailbox Evergreen Capacity Project" project in the Top bar on Item details page
	Then User sees following main-tabs on left menu on the Details page:
	| TabName  |
	| Details  |
	| Projects |
	| Users    |
	| Trend    |
	#================ checks sub-menu for main Details tab ================#
	Then "Details" main-menu on the Details page contains following sub-menu:
	| SubTabName              |
	| Mailbox                 |
	| Mailbox Owner           |
	| Email Addresses         |
	| Department and Location |
	| Custom Fields           |
	#================ checks counters ================#
	Then "Mailbox" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Owner" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Email Addresses" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Department and Location" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Custom Fields" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Projects tab ================#
	Then "Projects" main-menu on the Details page contains following sub-menu:
	| SubTabName            |
	| Evergreen Details     |
	| Project Details       |
	| Mailbox Projects      |
	| Mailbox User Projects |
	#================ checks counters ================#
	Then "Evergreen Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Project Details" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Projects" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox User Projects" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Users tab ================#
	Then "Users" main-menu on the Details page contains following sub-menu:
	| SubTabName          |
	| Users               |
	| Groups              |
	| Unresolved Users    |
	| Mailbox Permissions |
	| Folder Permissions  |
	#================ checks counters ================#
	Then "Users" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Groups" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Unresolved Users" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Folder Permissions" tab is displayed on left menu on the Details page and NOT contains count of items
	#================ checks sub-menu for main Trend tab ================#
	Then "Trend" main-menu on the Details page contains following sub-menu:
	| SubTabName             |
	| Email Count            |
	| Mailbox Size (MB)      |
	| Associated Item Count  |
	| Deleted Item Count     |
	| Deleted Item Size (MB) |
	#================ checks counters ================#
	Then "Email Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Mailbox Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Associated Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Deleted Item Count" tab is displayed on left menu on the Details page and NOT contains count of items
	Then "Deleted Item Size (MB)" tab is displayed on left menu on the Details page and NOT contains count of items