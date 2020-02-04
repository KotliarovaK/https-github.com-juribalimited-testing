Feature: FiltersFunctionalityPart13
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS12216 @DAS12212
Scenario: EvergreenJnr_ApplicationsList_CheckThatResultsAreDifferentWhenApplyingEqualAndDoesntEqualValuesForUserDescription
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Description" filter where type is "Does not equal" with following Value and Association:
	| Values                                                                                                                                                                                                                                                                                                                                                          | Association  |
	| Sed quad ut novum vobis regit, et pladior venit.  Tam quo, et nomen transit. Pro linguens imaginator pars fecit.  Et quad                                                                                                                                                                                                                                       | Has used app |
	| Tam quo, et pladior venit.  Tam quo, et quis gravis delerium.  Versus esset in dolorum cognitio, travissimantor quantare sed quartu manifestum egreddior estum.                                                                                                                                                                                                 | Has used app |
	| Quad rarendum habitatio quoque plorum in dolorum cognitio, travissimantor quantare sed quartu manifestum egreddior estum.  Multum gravum et nomen transit. Multum gravum et pladior venit.  Tam quo, et bono quorum glavans e funem.  Quad rarendum habitatio quoque plorum in dolorum cognitio, travissimantor quantare sed quartu manifestum egreddior estum. | Has used app |
	| Longam, e gravis et quis gravis delerium.  Versus esset in volcans essit.  Pro linguens non apparens vantis. Sed quad ut novum eggredior.  Longam, e gravis delerium.  Versus esset in volcans essit.  Pro linguens non quo linguens imaginator pars fecit.  Et quad fecit, non apparens vantis. Sed                                                            | Has used app |
	| Sed quad fecit, non quo linguens non trepicandor si quad fecit, non trepicandor si nomen transit. Id eudis quo plorum in dolorum cognitio, travissimantor quantare sed quartu manifestum egreddior estum.  Multum gravum et pladior venit.  Tam quo, et quis gravis et nomen transit. Sed quad ut novum eggredior.  Longam, e gravis et bono                    | Has used app |
	Then "User whose Description" filter is added to the list
	And "100" rows are displayed in the agGrid
	And There are no errors in the browser console
	When User click Edit button for "User " filter
	Then User changes filter type to "Equals"
	And "19" rows are displayed in the agGrid

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS10020
Scenario: EvergreenJnr_DevicesList_CheckDeviceOwnerLDAPColumnsAndFilters
	When User add following columns using URL to the "Devices" page:
	| ColumnName       |
	| Owner title      |
	| Owner usncreated |
	| Owner lastlogon  |
	| Owner admincount |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Owner Display Name" filter
	When User select "Empty" Operator value
	And User clicks Save filter button
	Then "460" rows are displayed in the agGrid
	Then Content is empty in the column
	| ColumnName       |
	| Owner title      |
	| Owner usncreated |
	| Owner lastlogon  |
	| Owner admincount |
	When User clicks on 'Owner title' column header
	Then Content is empty in the column
	| ColumnName       |
	| Owner title      |
	| Owner usncreated |
	| Owner lastlogon  |
	| Owner admincount |

@Evergreen @Users @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS14629 @DAS14664 @DAS14669
Scenario: EvergreenJnr_UsersList_PrimaryDeviceChipsCanBeRemoved
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Primary Device" filter
	#Equals Operator value
	When User select "Equals" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Does not equal Operator value
	When User select "Does not equal" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Contains Operator value
	When User select "Contains" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Does not contain Operator value
	When User select "Does not contain" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Begins with Operator value
	When User select "Begins with" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Does not begin with Operator value
	When User select "Does not begin with" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Ends with Operator value
	When User select "Ends with" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel
	#Does not end with Operator value
	When User select "Does not end with" Operator value
	And User enters "Text" text in Search field at selected Filter
	When User clicks Add button for input filter value
	Then "Text" value is displayed for selected Lookup Filter
	When User closes "Text" Chip item in the Filter panel
	Then Chip box is not displayed in the Filter panel