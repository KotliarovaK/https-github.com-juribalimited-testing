﻿Feature: ItemDetails_TabsMenu
	Runs Item Details Tabs Menu related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS17230
Scenario: EvergreenJnr_ApplicationsList_ChecksThatDisabledDistributionSectionCantBeEnteredByUsingTheBackButtonInTheBrowser
	When User navigates to the 'Application' details page for 'ACD Display 3.4' item
	When User navigates to the 'Distribution' left menu item
	When User navigates to the 'Devices' left submenu item
	When User switches to the "Email Migration" project in the Top bar on Item details page
	Then User click back button in the browser
	Then "Distribution" tab-menu on the Details page is expanded
	Then "Evergreen" project is selected in the Top bar on Item details page

@Evergreen @Devices @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16366 @DAS16246
Scenario: EvergreenJnr_DevicesList_CheckThatVerticalMenuIsUnfoldedCorrectlyOnMenuSubItems
	When User navigates to the 'Device' details page for '001BAQXT6JWFPI' item
	Then Details page for "001BAQXT6JWFPI" item is displayed to the user
	Then "Details" tab-menu on the Details page is expanded
	Then "Projects" tab-menu on the Details page is not expanded
	Then "Specification" tab-menu on the Details page is not expanded
	Then "Active Directory" tab-menu on the Details page is not expanded
	Then "Applications" tab-menu on the Details page is not expanded
	Then "Compliance" tab-menu on the Details page is not expanded
	When User navigates to the 'Projects' left menu item
	When User navigates to the 'Projects Summary' left submenu item
	Then "Projects" tab-menu on the Details page is expanded
	Then "Details" tab-menu on the Details page is not expanded
	Then "Specification" tab-menu on the Details page is not expanded
	Then "Active Directory" tab-menu on the Details page is not expanded
	Then "Applications" tab-menu on the Details page is not expanded
	Then "Compliance" tab-menu on the Details page is not expanded
	When User navigates to the 'Active Directory' left menu item
	When User navigates to the 'Active Directory' left submenu item
	Then "Active Directory" tab-menu on the Details page is expanded
	Then "Details" tab-menu on the Details page is not expanded
	Then "Projects" tab-menu on the Details page is not expanded
	Then "Specification" tab-menu on the Details page is not expanded
	Then "Applications" tab-menu on the Details page is not expanded
	Then "Compliance" tab-menu on the Details page is not expanded