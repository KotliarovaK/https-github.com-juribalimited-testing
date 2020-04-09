﻿Feature: AssociationsFunctionality8
	Runs Associations Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Associations @DAS19810 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatListCanBeCreatedWithFilterApplicationCustomField
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All User Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Computer Scheduled Test (Jo)' option from 'Project or Evergreen' autocomplete
	When User selects 'Current' option in 'Search associations' autocomplete of Associations panel
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "App Phoenix Field" filter where type is "Not empty" with added column and following value:
	| Values |
	When User clicks 'RUN LIST' button
	Then table content is present
	When User creates 'AssociationList19810Filter' dynamic list
	Then "AssociationList19810Filter" list is displayed to user

@Evergreen @Associations @DAS18467 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatListWithAllDeviceOsFiltersCanBeCreated
	When User navigates to 'deviceapplications?$filter=(oSCategory%20NOT%20EQUALS%20('NULL')%20AND%20oSArchitecture%20EQUALS%20('64')%20AND%20oSName%20NOT%20EQUALS%20('NULL')%20AND%20oSVersion%20EQUALS%20('Service%20Pack%204')%20AND%20oSServicePackName%20NOT%20EQUALS%20('NULL'%2C'No%20Service%20Pack'%2C'Service%20Pack%201')%20AND%20oSBranch%20EQUALS%20('NULL')%20AND%20oSServicingState%20EQUALS%20('Expired'%2C'NULL'%2C'Expire%20soon'%2C'Current'))&$select=hostname,chassisCategory,packageName,packageManufacturer,packageVersion,oSCategory,oSArchitecture,oSName,oSServicePackName,oSVersion,oSBranch,oSServicingState&$association=(etd)' url via address line
	When User clicks 'RUN LIST' button
	Then table content is present
	Then URL contains 'deviceapplications?$filter=(oSCategory%20NOT%20EQUALS%20('NULL')%20AND%20oSArchitecture%20EQUALS%20('64')%20AND%20oSName%20NOT%20EQUALS%20('NULL')%20AND%20oSVersion%20EQUALS%20('Service%20Pack%204')%20AND%20oSServicePackName%20NOT%20EQUALS%20('NULL'%2C'No%20Service%20Pack'%2C'Service%20Pack%201')%20AND%20oSBranch%20EQUALS%20('NULL')%20AND%20oSServicingState%20EQUALS%20('Expired'%2C'NULL'%2C'Expire%20soon'%2C'Current'))&$select=hostname,chassisCategory,packageName,packageManufacturer,packageVersion,oSCategory,oSArchitecture,oSName,oSServicePackName,oSVersion,oSBranch,oSServicingState&$association=(etd)'
	When User creates 'List_DAS18467' dynamic list
	Then "List_DAS18467" list is displayed to user
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
		| RowGroups              |
		| Device OS Branch       |
		| Device OS Architecture |
		| Device OS Full Name    |
	When User selects the following Columns on Pivot:
		| Columns                   |
		| Device OS Servicing State |
		| Device Operating System   |
	When User selects the following Values on Pivot:
		| Values                       |
		| Device Service Pack or Build |
	When User clicks 'RUN PIVOT' button
	Then Pivot run was completed
	When User creates Pivot list with "Pivot_DAS18467" name
	Then "Pivot_DAS18467" list is displayed to user
	When User navigates to the "List_DAS18467" list
	When User clicks the Columns button
	When User removes "Device OS Full Name" column by Column panel
	When User clicks 'RUN LIST' button
	Then '(Edited)' prefix for active list is displayed to user
	Then 'SAVE' button is not disabled
	When User clicks the Filters button
	When User have removed "Device OS Architecture" filter
	When User clicks 'RUN LIST' button
	Then '(Edited)' prefix for active list is displayed to user
	Then 'SAVE' button is not disabled