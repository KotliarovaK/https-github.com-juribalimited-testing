Feature: AssociationsFunctionality8
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

@Evergreen @Associations @DAS20852
Scenario: EvergreenJnr_ApplicationsList_CheckAssociationValuesAreNotDuplicatedAfterUsingSameProject
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All Device Applications" list
	When User clicks Add New button on the Filter panel
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	When User selects 'Current' option in 'Search associations' autocomplete of Associations panel
	When User clicks Add New button on the Filter panel
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	When User selects 'Target' option in 'Search associations' autocomplete of Associations panel
	When User clicks 'RUN LIST' button
	Then table content is present
	When User clicks Add New button on the Filter panel
	When User selects '2004 Rollout' option from 'Project or Evergreen' autocomplete
	Then User sees options in 'Search associations' autocomplete of Associations panel
	| Associations |
	| Current      |
	| Target       |

@Evergreen @Associations @DAS18837 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatAllUserApplicatoinsWork
	When User clicks 'Applications' on the left-hand menu
	When User navigates to the "All User Applications" list
	When User navigates to the "All Device Applications" list
	When User navigates to the "All User Applications" list
	When User navigates to the "All Applications" list
	When User navigates to the "All User Applications" list
	When User clicks Add New button on the Filter panel
	When User selects 'Evergreen' option from 'Project or Evergreen' autocomplete
	Then User sees options in 'Search associations' autocomplete of Associations panel
	| Associations     |
	| Used by user     |
	| Entitled to user |
	When User navigates to 'userapplications?$association=(ubu%20AND%20netu)%20OR%20(etu%20AND%20nubu)%20OR%20(ubu%20AND%20etu)' url via address line
	Then URL contains 'userapplications?$association=(ubu%20AND%20netu)%20OR%20(etu%20AND%20nubu)%20OR%20(ubu%20AND%20etu)'
	Then Remove icon displayed in 'false' state for 'Used by user' association
	Then Remove icon displayed in 'true' state for 'Not entitled to user' association
	When User clicks the Columns button
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName  |
	| User Domain |
	When User navigates to 'userapplications?$filter=(objectKey%20>%200%20AND%20packageKey%20<>%2011111111%20AND%20packageType%20IS%20NOT%20EMPTY%20()%20AND%20packageId%20IS%20NOT%20EMPTY%20())&$select=username,displayName,fullyDistinguishedObjectName,packageName,packageManufacturer,packageVersion,directoryName,objectKey,packageKey,packageType,packageId&$association=(ubu%20AND%20netu)%20OR%20(etu%20AND%20nubu)%20OR%20(ubu%20AND%20etu)' url via address line
	When User clicks 'RUN LIST' button
	Then table content is present
	Then URL contains 'userapplications?$filter=(objectKey%20%3E%200%20AND%20packageKey%20%3C%3E%2011111111%20AND%20packageType%20IS%20NOT%20EMPTY%20()%20AND%20packageId%20IS%20NOT%20EMPTY%20())&$select=username,displayName,fullyDistinguishedObjectName,packageName,packageManufacturer,packageVersion,directoryName,objectKey,packageKey,packageType,packageId&$association=(ubu%20AND%20netu)%20OR%20(etu%20AND%20nubu)%20OR%20(ubu%20AND%20etu)'
	When User navigates to 'userapplications?$filter=(objectKey%20>%200%20AND%20packageKey%20<>%2011111111%20AND%20packageType%20IS%20NOT%20EMPTY%20()%20AND%20packageId%20IS%20NOT%20EMPTY%20())%20OR%20(userListId%20IN%20('38')%20AND%20applicationListId%20IN%20('36'))&$select=username,displayName,fullyDistinguishedObjectName,packageName,packageManufacturer,packageVersion,directoryName,objectKey,packageKey,packageType,packageId&$association=(ubu%20AND%20netu)%20OR%20(etu%20AND%20nubu)%20OR%20(ubu%20AND%20etu)' url via address line
	When User clicks 'RUN LIST' button
	Then table content is present
	Then URL contains 'userapplications?$filter=(objectKey%20%3E%200%20AND%20packageKey%20%3C%3E%2011111111%20AND%20packageType%20IS%20NOT%20EMPTY%20()%20AND%20packageId%20IS%20NOT%20EMPTY%20())%20OR%20(userListId%20IN%20('38')%20AND%20applicationListId%20IN%20('36'))&$select=username,displayName,fullyDistinguishedObjectName,packageName,packageManufacturer,packageVersion,directoryName,objectKey,packageKey,packageType,packageId&$association=(ubu%20AND%20netu)%20OR%20(etu%20AND%20nubu)%20OR%20(ubu%20AND%20etu)'
	When User clicks on 'User Display Name' column header
	Then data in table is sorted by 'User Display Name' column in ascending order
	When User creates 'List_DAS18837' dynamic list
	Then "List_DAS18837" list is displayed to user
	When User selects 'Pivot' in the 'Create' dropdown
	When User selects the following Row Groups on Pivot:
		| RowGroups        |
		| Package Type     |
		| Inventory App ID |
	When User selects the following Columns on Pivot:
		| Columns     |
		| User Domain |
		| User Key    |
	When User selects the following Values on Pivot:
		| Values     |
		| App Vendor |
	#commented due to long time pivot loading so it's never load
	#When User clicks 'RUN PIVOT' button
	#Then Pivot run was completed
	#When User creates Pivot list with "Pivot_DAS18837" name
	#Then "Pivot_DAS18837" list is displayed to user
	When User navigates to the "List_DAS18837" list
	When User clicks the Columns button
	When User removes "User Domain" column by Column panel
	When User clicks 'RUN LIST' button
	Then '(Edited)' prefix for active list is displayed to user
	Then 'SAVE' button is not disabled
	When User clicks the Filters button
	When User have removed "Application Key" filter
	When User clicks 'RUN LIST' button
	Then '(Edited)' prefix for active list is displayed to user
	Then 'SAVE' button is not disabled