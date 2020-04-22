Feature: ItemDetails_TabCounterChecking_GroupsPage
	Runs Item Details TabCounterChecking_GroupsPage related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS16833 @DAS17415
Scenario: EvergreenJnr_GroupsList_CheckThatNewPatternOfTheVerticalMenuIsDisplayedCorrectlyForGroupsPage
	When User type "Allowed RODC Password Replication Group" in Global Search Field
	Then User clicks on "Allowed RODC Password Replication Group" search result
	And Details page for 'Allowed RODC Password Replication Group' item is displayed to the user
	And User sees following parent left menu items
	| TabName      |
	| Applications |
	| Members      |
	And 'Group' left submenu item is displayed without count
	And 'LDAP' left submenu item is displayed without count
	#================ checks sub-menu for main Applications tab ================#
	When User navigates to the 'Applications' left menu item
	Then 'Applications' left menu have following submenu items:
	| SubTabName   |
	| Applications |
	| Collections  |
	#================ checks counters ================#
	And 'Applications' left submenu item with some count is displayed
	And 'Collections' left submenu item with some count is displayed
	#================ checks sub-menu for main Members tab ================#
	When User navigates to the 'Members' left menu item
	Then 'Members' left menu have following submenu items:
	| SubTabName     |
	| User Members   |
	| Device Members |
	| Member Of      |
	#================ checks counters ================#
	And 'User Members' left submenu item with some count is displayed
	And 'Device Members' left submenu item with some count is displayed
	And 'Member Of' left submenu item with some count is displayed

@Evergreen @Groups @EvergreenJnr_ItemDetails @ItemDetailsDisplay @DAS20677
Scenario: EvergreenJnr_GroupsList_CheckThatNewStyleForSelectAllCheckboxInTheSelectFilterOfTheAgridIsDisplayedCorrectly
	#When User type "Domain Computers" in Global Search Field
	#Then User clicks on "Domain Computers" search result
	When User navigates to the 'Group' details page for the item with '61654' ID
	Then Details page for 'Domain Computers' item is displayed to the user
	When User navigates to the 'Members' left menu item
	When User navigates to the 'Device Members' left submenu item
	When User clicks String Filter button for "Operating System" column
	Then Select All checkbox have full checked state
	When User selects "Select All" checkbox from String Filter with item list on the Admin page
	Then select all rows checkbox is unchecked
	When User selects "Device" checkbox from String Filter on the Admin page
	Then Select All checkbox have indeterminate checked state
	When User selects "Select All" checkbox from String Filter with item list on the Admin page
	Then Select All checkbox have full checked state