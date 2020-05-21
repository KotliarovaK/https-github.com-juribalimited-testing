Feature: FiltersFunctionalityApplications
	Runs Filters Functionality related tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS10639 @DAS12207
Scenario: EvergreenJnr_ApplicationsList_Check500ErrorIsNotReturnedForBooleanFilterWithUnknownOption
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Hide From End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| FALSE              |
	| Empty              |
	Then "Windows7Mi: Hide From End Users" filter is added to the list
	And "2,223" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Hide From End Users" filter
	When User add "Windows7Mi: Hide From End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| FALSE              |
	| Empty              |
	Then "Windows7Mi: Hide From End Users" filter is added to the list
	And "2,223" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Hide From End Users" filter
	When User add "Windows7Mi: Hide From End Users" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| Empty              |
	Then "Windows7Mi: Hide From End Users" filter is added to the list
	And "1,156" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS11166 @DAS11665 @DAS13172 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredAfterGoingBackToTheListAgain
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                       |
	| Microsoft Office 97, Professional Edition    |
	| Microsoft Office 97, Developer Edition Tools |
	| Microsoft Office 97, Standard Edition        |
	Then "Application" filter is added to the list
	When User create dynamic list with "TestList5D30CF" name on "Applications" page
	Then "TestList5D30CF" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Application is Microsoft Office 97, Professional Edition, Microsoft Office 97, Developer Edition Tools or Microsoft Office 97, Standard Edition" is displayed in added filter info
	When User navigates to the "All Applications" list
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "TestList5D30CF" list
	Then "TestList5D30CF" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Application is Microsoft Office 97, Professional Edition, Microsoft Office 97, Developer Edition Tools or Microsoft Office 97, Standard Edition" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS10977 @DAS12954
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowserbackButtonForValuesFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                    |
	| Microsoft Office 97, Professional Edition |
	Then "Application is Microsoft Office 97, Professional Edition" is displayed in added filter info
	Then "5" rows are displayed in the agGrid
	When User perform search by "Microsoft Office 97, Professional Edition"
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	Then select all rows checkbox is unchecked
	When User click content from "Application" column
	Then User click back button in the browser
	Then "5" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "Application is Microsoft Office 97, Professional Edition" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS10977 @DAS13376 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterIsRestoredCorrectlyAfterLeavingThePageAndGoingBackViaTheBrowseBackButtonForListFilters
	When User add following columns using URL to the "Applications" page:
	| ColumnName      |
	| Application Key |
	When User create dynamic list with "TestListD75CD3" name on "Applications" page
	Then "TestListD75CD3" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association        |
	| TestListD75CD3 | Not used on device |
	Then "Any Application in list TestListD75CD3 not used on device" is displayed in added filter info
	Then "17,185" rows are displayed in the agGrid
	When User perform search by "001BAQXT6JWFPI"
	And User click content from "Hostname" column
	Then User click back button in the browser
	Then "17,185" rows are displayed in the agGrid
	When User clicks the Filters button
	Then "Any Application in list TestListD75CD3 not used on device" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS11560
Scenario: EvergreenJnr_ApplicationsList_CheckThat500ErrorInNotDisplayedWhenUserApplyASelectedNumericFilter 
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Count (Installed)" filter where type is "Less than" with added column and following value:
	| Values |
	| 10     |
	Then "Device Count (Installed)" filter is added to the list
	Then "1,269" rows are displayed in the agGrid
	Then "(Device Count (Installed) < 10)" text is displayed in filter container

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS11838 @DAS13001
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheTargetAppReadinessItemIsMatchingTheCaption
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "ComputerSc: Target App Readiness" filter where type is "Equals" with added column and Lookup option
	| SelectedValues     |
	| <SelectedCheckbox> |
	Then '<ColorName>' content is displayed in all 'ComputerSc: Target App Readiness' column
	Then '<SelectedCheckbox>' path is displayed in the 'ComputerSc: Target App Readiness' column

Examples:
	| SelectedCheckbox        | ColorName               |
	| Red                     | RED                     |
	| Blue                    | BLUE                    |
	| Light Blue              | LIGHT BLUE              |
	| Brown                   | BROWN                   |
	| Amber                   | AMBER                   |
	| Really Extremely Orange | REALLY EXTREMELY ORANGE |
	| Purple                  | PURPLE                  |
	| Green                   | GREEN                   |
	| Grey                    | GREY                    |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS11838
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTheColourOfTheRationalisationItemIsMatchingTheCaption
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "ComputerSc: Rationalisation" filter where type is "Equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| <SelectedCheckbox> |
	Then '<SelectedCheckbox>' content is displayed in all 'ComputerSc: Rationalisation' column
	Then '<SelectedCheckbox>' path is displayed in the 'ComputerSc: Rationalisation' column

Examples:
	| SelectedCheckbox |
	| FORWARD PATH     |
	| KEEP             |
	| UNCATEGORISED    |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12202 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedAfterApplyingAStaticListWithApplicationSavedListFilter
	When User add following columns using URL to the "Applications" page:
	| ColumnName              |
	| Device Count (Entitled) |
	Then Content is present in the newly added column
	| ColumnName              |
	| Device Count (Entitled) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                                     |
	| Exemples de conception de bases de données |
	When User clicks on 'Device Count (Entitled)' column header
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList6581" name
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association        |
	| StaticList6581 | Entitled to device |
	Then "38" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12202 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedWhenUsingAStaticListAsTheFilteredApplicationSavedList
	When User add following columns using URL to the "Applications" page:
	| ColumnName               |
	| Device Count (Entitled)  |
	| Device Count (Used)      |
	| Device Count (Installed) |
	Then Content is present in the newly added column
	| ColumnName               |
	| Device Count (Entitled)  |
	| Device Count (Used)      |
	| Device Count (Installed) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                    |
	| MKS Source Integrity 7.3d |
	And User clicks the Actions button
	Then Actions panel is displayed to the user
	When User selects all rows on the grid
	And User selects 'Create static list' in the 'Action' dropdown
	And User create static list with "StaticList6778" name
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList   | Association        |
	| StaticList6778 | Entitled to device |
	Then "123" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12202 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatCorrectDeviceDataIsReturnedWhenUsingADynamicListAsTheFilteredApplicationSavedList
	When User add following columns using URL to the "Applications" page:
	| ColumnName               |
	| Device Count (Entitled)  |
	| Device Count (Used)      |
	| Device Count (Installed) |
	Then Content is present in the newly added column
	| ColumnName               |
	| Device Count (Entitled)  |
	| Device Count (Used)      |
	| Device Count (Installed) |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application" filter where type is "Equals" with added column and following value:
	| Values                    |
	| MKS Source Integrity 7.3d |
	When User clicks the Filters button
	And User create dynamic list with "DynamicList4116" name on "Applications" page
	And User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application (Saved List)" filter where type is "In list" with Selected Value and following Association:
	| SelectedList    | Association        |
	| DynamicList4116 | Entitled to device |
	Then "123" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12875
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoConsoleErrorIsDisplayedAfterEditingUserSurnameFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Surname" filter where type is "Equals" with following Value and Association:
	| Values       | Association     |
	| Cotuand      | Entitled to app |
	| Courtemanche |                 |
	When User click Edit button for "User " filter
	Then There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12181 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoErrorIsDisplayedAfterAddingFewAdvancedFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User" filter where type is "Does not equal" with following Lookup Value and Association:
	| SelectedValues              | Association  |
	| DWLABS\$231000-3AC04R8AR431 | Has used app |
	When User add "User Last Logon Date" filter where type is "Before" with following Data and Association:
	| Values     | Association     |
	| 1 Feb 2018 | Entitled to app |
	When User add "User SID" filter where type is "Begins with" with following Value and Association:
	| Values | Association                         |
	| 555    | Owns a device which app was used on |
	Then "247" rows are displayed in the agGrid
	And There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12181 @DAS11561 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoErrorIsDisplayedAfterAddingFewAdvancedFiltersAndFewStandardFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Compliance" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association  |
	| Red                | Has used app |
	When User add "User Enabled" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association     |
	| TRUE               | Entitled to app |
	When User Add And "User Last Logon Date" filter where type is "Before" with following Data and Association:
	| Values      | Association     |
	| 15 Feb 2016 | Entitled to app |
	When User add "Application" filter where type is "Contains" with added column and following value:
	| Values |
	| Office |
	When User add "Vendor" filter where type is "Contains" with added column and following value:
	| Values    |
	| Microsoft |
	Then "1,514" rows are displayed in the agGrid
	And There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12827 @DAS12812
Scenario: EvergreenJnr_ApplicationsList_CheckThatUserLastLogonDateFilterWorksCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Equals" with following Data and Association:
	| Values      | Association  |
	| 30 Apr 2018 | Has used app |
	Then message 'No applications found' is displayed to the user
	And Filter name is colored in the added filter info
	And Filter value is shown in bold in the added filter info
	And There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12058 @Cleanup @archived
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectGroupCurrentStateFiltersInTheApplicationListWorksCorrectly
	When User add following columns using URL to the "Applications" page:
	| ColumnName                              |
	| Windows7Mi: Rationalisation |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Group (Current State)" filter where type is "Equal" without added column and "Parkfield Office" Lookup option
	And User click Edit button for "Windows7Mi: Group (Current State)" filter
	And User enters "Administration" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	Then "34" rows are displayed in the agGrid
	When User create dynamic list with "Project Group (Current State)" name on "Applications" page
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User Add And "Windows7Mi: Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| FORWARD PATH       |
	Then "1" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Rationalisation" filter
	And User Add And "Windows7Mi: Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| RETIRE             |
	Then "4" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Rationalisation" filter
	And User Add And "Windows7Mi: Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| KEEP               |
	Then "8" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Rationalisation" filter
	And User Add And "Windows7Mi: Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| UNCATEGORISED      |
	Then "21" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12058 @Cleanup @archived
Scenario: EvergreenJnr_ApplicationsList_CheckThatProjectGroupTargetStateFiltersInTheApplicationListWorksCorrectly
	When User add following columns using URL to the "Applications" page:
	| ColumnName                  |
	| Windows7Mi: Rationalisation |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Windows7Mi: Group (Target State)" filter where type is "Equal" without added column and "Parkfield Office" Lookup option
	And User click Edit button for "Windows7Mi: Group (Target State)" filter
	And User enters "Administration" text in Search field at selected Lookup Filter
	And User clicks checkbox at selected Lookup Filter
	And User clicks Save filter button
	Then "29" rows are displayed in the agGrid
	When User create dynamic list with "Project Group (Target State)" name on "Applications" page
	And User clicks the Filters button
	Then Filters panel is displayed to the user
	When User Add And "Windows7Mi: Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| KEEP               |
	Then "9" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Rationalisation" filter
	And User Add And "Windows7Mi: Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| UNCATEGORISED      |
	Then "20" rows are displayed in the agGrid
	When User have removed "Windows7Mi: Rationalisation" filter
	And User Add And "Windows7Mi: Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| RETIRE			 |
	Then message 'No applications found' is displayed to the user
	When User have removed "Windows7Mi: Rationalisation" filter
	And User Add And "Windows7Mi: Rationalisation" filter where type is "Equal" without added column and following checkboxes:
	| SelectedCheckboxes |
	| FORWARD PATH		 |
	Then message 'No applications found' is displayed to the user

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12200
Scenario: EvergreenJnr_ApplicationsList_CheckThatAdvancedUserFilterReturnsCorrectResults
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association  |
	| FR\APB5713645  | Has used app |
	Then "1" rows are displayed in the agGrid
	When User click Edit button for "User" filter
	When User is deselect "Has used app" Association for Application filter with Lookup value
	When User select "Has not used app" Association for Application filter with Lookup value
	And User clicks Save filter button
	Then "2,222" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12351
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThat500ISEInvalidColumnNameErrorIsNotDisplayedIfUseSelectedFilterOnApplicationsPage
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "<FilterName>" filter where type is "Equals" with added column and following checkboxes:
	| SelectedCheckboxes   |
	| <SelectedCheckboxes> |
	Then "<FilterName>" filter is added to the list
	Then table data is filtered correctly
	Then "<Rows>" rows are displayed in the agGrid
	
Examples:
	| FilterName                                           | SelectedCheckboxes      | Rows  |
	| Windows7Mi: Category                                 | A Star Packages         | 3     |
	| Windows7Mi: Application Information \ Technical Test | Started                 | 4     |
	| EmailMigra: Category                                 | Empty                   | 2,223 |
	| UserSchedu: Category                                 | Empty                   | 2,223 |
	| prK: Path                                            | [Default (Application)] | 1,030 |
	| EmailMigra: Path                                     | Public Folder           | 50    |
	| UserSchedu: Path                                     | Request Type A          | 47    |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12855
Scenario: EvergreenJnr_ApplicationsList_CheckThatDataIsDisplayedCorrectlyForAdvancedUserFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User" filter where type is "Does not equal" with following Lookup Value and Association:
	| SelectedValues | Association                         |
	| FR\RZM6552051  | Owns a device which app was used on |
	Then "100" rows are displayed in the agGrid
	Then table content is present

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS13414 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_ChecksThatApplicationListWhichIncludeADateBasedAdvancedFilterAreSavedAndNotOpenedInEditMode
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Equals" with following Data and Association:
	| Values      | Association  |
	| 12 Sep 2018 | Has used app |
	Then "User whose Last Logon Date" filter is added to the list
	When User create dynamic list with "DAS13414" name on "Applications" page
	Then "DAS13414" list is displayed to user
	And URL contains 'evergreen/#/applications?$listid='
	And Edit List menu is not displayed
	When User navigates to the "All Applications" list
	And User navigates to the "DAS13414" list
	Then URL contains 'evergreen/#/applications?$listid='
	And Edit List menu is not displayed

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS13588
Scenario: EvergreenJnr_ApplicationsList_CheckThatUsingUserLDAPFilterDoesNotProduceServerError
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "badpasswordtime" filter where type is "Equals" with following Value and Association:
	| Values | Association     |
	| test   | Has used app    |
	|        | Entitled to app |
	Then There are no errors in the browser console
	And 'All Applications' list should be displayed to the user
	And message 'No applications found' is displayed to the user 

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS13473 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_ChecksThatIfListWithAnAdvancedUserDescriptionIsEmptyFilterIsSavedAndOpenedNotInEditMode
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User Description" filter where type is "Empty" with following Lookup Value and Association:
	| SelectedValues | Association     |
	|                | Has used app    |
	|                | Entitled to app |
	Then "User whose Description" filter is added to the list
	And "User whose Description is empty has used app; or entitled to app" is displayed in added filter info
	When User creates 'DAS13473' dynamic list
	Then "DAS13473" list is displayed to user
	And "113" rows are displayed in the agGrid
	And URL contains 'evergreen/#/applications?$listid='
	And Edit List menu is not displayed
	When User navigates to the "All Applications" list
	And User navigates to the "DAS13473" list
	Then "113" rows are displayed in the agGrid
	Then URL contains 'evergreen/#/applications?$listid='
	And Edit List menu is not displayed

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS13377
Scenario: EvergreenJnr_ApplicationsList_ChecksThatApplicationNameIsDisplayedAfterUsingTargetAppFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Barry'sUse: Target App" filter where type is "Equals" with added column and Lookup option
	| SelectedValues         |
	| Python 2.2a4 (SMS_GEN) |
	Then "Barry'sUse: Target App" filter is added to the list
	And "Barry'sUse: Target App is Python 2.2a4 (SMS_GEN)" is displayed in added filter info
	When User click content from "Application" column
	Then User click back button in the browser
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	And "Barry'sUse: Target App is Python 2.2a4 (SMS_GEN)" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12214
Scenario: EvergreenJnr_ApplicationsList_CheckThatFiltersWorksProperlyWithPositiveAndNegativeAssociation
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "After" with following Data and Association:
	| Values     | Association                             |
	| 1 May 2011 | Has used app                            |
	|            | Entitled to app                         |
	|            | Owns a device which app was used on     |
	|            | Owns a device which app is entitled to  |
	|            | Owns a device which app is installed on |
	Then "1,206" rows are displayed in the agGrid
	When User click Edit button for " Last Logon Date" filter
	Then only positive Associations is displayed
	When User is deselect "Has used app" in Association
	And User is deselect "Entitled to app" in Association
	And User is deselect "Owns a device which app was used on" in Association
	And User is deselect "Owns a device which app is entitled to" in Association
	And User is deselect "Owns a device which app is installed on" in Association
	And User select "Has not used app" in Association
	Then only negative Associations is displayed
	When User select "Not entitled to app" in Association
	And User select "Does not own a device which app was used on" in Association
	And User select "Does not own a device which app is entitled to" in Association
	And User select "Does not own a device which app is installed on" in Association
	And User clicks Save filter button
	Then "2,223" rows are displayed in the agGrid
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Application Name" filter where type is "Begins with" with following Value and Association:
	| Values | Association    |
	| Adobe  | Used on device |
	When User click Edit button for "Application " filter
	Then only positive Associations is displayed
	When User is deselect "Used on device" in Association
	And User select "Not used on device" in Association
	Then only negative Associations is displayed

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12211
Scenario: EvergreenJnr_ApplicationsList_CheckThatResultsAreDifferentWhenApplyingEqualAndDoesntEqualValues
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Last Logon Date" filter where type is "Does not equal" with following Data and Association:
	| Values      | Association  |
	| 26 Apr 2018 | Has used app |
	Then "100" rows are displayed in the agGrid
	When User click Edit button for " Last Logon Date" filter
	Then User changes filter type to "Equals"
	Then message 'No applications found' is displayed to the user 

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12216 @DAS12212
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

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS14524 @DAS15223
Scenario: EvergreenJnr_ApplicationsList_CheckRowsCountedForOwnerOrganizationalUnitFilterWithEmptyValue
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Organisational Unit" filter where type is "Empty" with following Value and Association:
	| Values | Association                             |
	|        | Has used app                            |
	|        | Entitled to app                         |
	|        | Owns a device which app was used on     |
	|        | Owns a device which app is entitled to  |
	|        | Owns a device which app is installed on |
	Then "User whose Organisational Unit" filter is added to the list
	And "215" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS15291
Scenario: EvergreenJnr_ApplicationsList_CheckSlotsSortOrderForApplicationsList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	And User clicks Add New button on the Filter panel
	When User add "UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)" filter where type is "Does not equal" with added column and following checkboxes:
	| SelectedCheckboxes |
	| Empty              |
	When User clicks on 'UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)' column header
	Then Content in the 'UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)' column is equal to
	| Content            |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 2 |
	When User clicks on 'UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)' column header
	Then Content in the 'UserEvergr: Stage 3 \ Radiobutton Readiness Date Owner (Application) (Slot)' column is equal to
	| Content            |
	| Application Slot 2 |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 1 |
	| Application Slot 1 |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS17004
Scenario: EvergreenJnr_ApplicationsList_CheckDepartmentLevelFilterItems
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Department Level 1" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Sales              | Used on device      |
	| Support            | Entitled to device  |
	| Technology         | Installed on device |
	Then "854" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS15082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartI
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	When User add "Device CPU Architecture" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device CPU Speed (GHz)" filter where type is "Does not equal" with following Number and Association:
	| Number | Association     |
	| 0      | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Format" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device HDD Total Size (GB)" filter where type is "Greater than" with following Number and Association:
	| Number | Association     |
	| 0      | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	Then "2,128" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS15082 @DAS17717
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device IP Address" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device IPv6 Address" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Manufacturer" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Memory (GB)" filter where type is "Greater than" with following Number and Association:
	| Number | Association     |
	| 0      | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Model" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	Then "1,032" rows are displayed in the agGrid
	And There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS15082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceHardwareItemsCounterPartIII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device TPM Enabled" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| FALSE              | Used on device      |
	| TRUE               | Entitled to device  |
	And User Add And "Device TPM Version" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Target Drive Free Space (GB)" filter where type is "Greater than" with following Number and Association:
	| Number | Association         |
	| 0      | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Type" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| Data Centre    | Used on device      |
	| Desktop        | Entitled to device  |
	| Laptop         | Installed on device |
	| Mobile         |                     |
	| Other          |                     |
	| Virtual        |                     |
	Then "212" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS15082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceDeviceOperatingSystemItemsCounterI
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device OS Architecture" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Empty              | Used on device      |
	| 32                 | Entitled to device  |
	| 64                 | Installed on device |
	And User Add And "Device OS Branch" filter where type is "Does not equal" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association             |
	| Current Branch     | Not entitled to device  |
	|                    | Not installed on device |
	|                    | Not used on device      |
	And User Add And "Device OS Full Name" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| Android 4.3    | Used on device      |
	| Empty          | Entitled to device  |
	| Android 4.4    | Installed on device |
	| Android 5.0    |                     |
	| Android 5.1    |                     |
	Then "4" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS15082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceDeviceOperatingSystemItemsCounterII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device OS Servicing State" filter where type is "Does not equal" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Empty              | Used on device      |
	|                    | Entitled to device  |
	|                    | Installed on device |
	And User Add And "Device OS Version Number" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| 10.0           | Used on device      |
	| 10.0.10240     | Entitled to device  |
	| Empty          | Installed on device |
	| 10.0.15063     |                     |
	| 10.0.14393     |                     |
	And User Add And "Device Service Pack or Build" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues  | Association         |
	| Service Pack 1  | Used on device      |
	| Empty           | Entitled to device  |
	| No Service Pack | Installed on device |
	| Service Pack 2  |                     |
	| Service Pack 3  |                     |
	Then "170" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartI
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	When User add "Device Owner Building" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Owner City" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| Belfast        | Used on device      |
	| Los Angeles    | Entitled to device  |
	|                | Installed on device |
	And User Add And "Device Owner Compliance" filter where type is "Does not equal" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Red                | Used on device      |
	|                    | Entitled to device  |
	|                    | Installed on device |
	And User Add And "Device Owner Country" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association             |
	| Empty          | Not installed on device |
	|                | Not entitled to device  |
	|                | Not used on device      |
	Then "846" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Department" filter where type is "Equals" with selected Expanded Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| Finance            | Used on device      |
	| Sales              | Entitled to device  |
	| Support            | Installed on device |
	| Technology         |                     |
	And User Add And "Device Owner Description" filter where type is "Does not begin with" with following Value and Association:
	| Values | Association         |
	| pro       | Not installed on device     |
	Then "854" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartIII
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Display Name" filter where type is "Contains" with following Value and Association:
	| Values  | Association         |
	| Aceline | Entitled to device  |
	|         | Installed on device |
	And User Add And "Device Owner Domain" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Entitled to device  |
	|        | Installed on device |
	And User Add And "Device Owner Email Address" filter where type is "Ends with" with following Value and Association:
	| Values          | Association         |
	| demo.juriba.com | Entitled to device  |
	|                 | Installed on device |
	And User Add And "Device Owner Enabled" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association         |
	| TRUE               | Entitled to device  |
	|                    | Installed on device |
	Then "23" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartIV
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Floor" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	| Empty          | Entitled to device  |
	|                | Installed on device |
	And User Add And "Device Owner Given Name" filter where type is "Does not end with" with following Value and Association:
	| Values | Association         |
	| sdsds  | Entitled to device  |
	|        | Installed on device |
	Then "1,139" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartV
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Home Directory" filter where type is "Begins with" with following Value and Association:
	| Values         | Association         |
	| \\\\fileserver | Used on device      |
	|                | Entitled to device  |
	|                | Installed on device |
	And User Add And "Device Owner Home Drive" filter where type is "Equals" with selected Checkboxes and following Association:
	| SelectedCheckboxes | Association        |
	| H:                 | Entitled to device |
	And User Add And "Device Owner Username" filter where type is "Does not equal" with following Value and Association:
	| Values     | Association             |
	| ZZW1565756 | Not installed on device |
	When User Add And "Device Owner Last Logon Date" filter where type is "Before" with following Data and Association:
	| Values     | Association        |
	| 8 Aug 2019 | Entitled to device |
	And User Add And "Device Owner Key" filter where type is "Greater than" with following Number and Association:
	| Number | Association        |
	| 4      | Entitled to device |
	And User Add And "Device Owner Region" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association        |
	| Empty          | Entitled to device |
	| US-E           |                    |
	Then "213" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS15194
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOwnerItemsCounterPartVI
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Owner Telephone" filter where type is "Not empty" with following Value and Association:
	| Values | Association         |
	|        | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	And User add "Device Owner Zip Code" filter where type is "Begins with" with following Value and Association:
	| Values | Association         |
	| EC1    | Used on device      |
	|        | Entitled to device  |
	|        | Installed on device |
	Then "18" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS17557
Scenario: EvergreenJnr_DevicesList_CheckThatNo500ErrorOnApplicationPageAfterUpdatingTheAdvancedFilterWithTheEmptyValueOfTheEqualsDoesNotEqualsField
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Virtual Machine Host" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association         |
	|                | Used on device      |
	|                | Entitled to device  |
	|                | Installed on device |
	Then 'ADD' button is disabled

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS18082
Scenario: EvergreenJnr_ApplicationsList_CheckDeviceOperatingSystemFilterWork
	When User clicks 'Applications' on the left-hand menu
	And User clicks the Filters button
	And User add "Device Operating System" filter where type is "Equals" with following Lookup Value and Association:
	| SelectedValues | Association        |
	| Other          | Entitled to device |
	Then "4" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS18560 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoErrorMessageDisplayedAfterOpeningListWithFilterRelatedToDeletedList
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Type" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | Mobile         |
	When User create dynamic list with "ListToBeDeleted18560" name on "Devices" page
	Then "ListToBeDeleted18560" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	When User add "Device (Saved List)" filter where type is "In list" with following Lookup Value and Association:
    | SelectedValues       | Association    |
    | ListToBeDeleted18560 | Used on device |
	When User creates 'SecondList18560' dynamic list
	Then "SecondList18560" list is displayed to user
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks 'Delete' option in cogmenu for 'ListToBeDeleted18560' list
	When User confirms list removing
	Then list with "ListToBeDeleted18560" name is removed
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User navigates to the "SecondList18560" list
	When User clicks the Filters button
	Then message 'This list could not be processed, it may refer to a list with errors' is displayed to the user

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS18560 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterBasedOnListHavingNotEmptyOperatorCanBeCreated
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks the Filters button
	When User add "Import Type" filter where type is "Not empty" with added column and Lookup option
    | SelectedValues |
	When User clicks Save button on the list panel
	When User create dynamic list with "ListForDAS18100_4" name on "Devices" page
	Then "ListForDAS18100_4" list is displayed to user
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	When User add "Device (Saved List)" filter where type is "In list" with following Lookup Value and Association:
    | SelectedValues    | Association    |
    | ListForDAS18100_4 | Used on device |
	When User creates 'SecondList18100' dynamic list
	Then "SecondList18100" list is displayed to user
	Then There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS18922
Scenario: EvergreenJnr_ApplicationsList_CheckThatGridDataDisplayedAfterSortingByOwnerCompliance
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Owner Compliance" filter where type is "Equals" with added column and Lookup option
    | SelectedValues |
    | Empty          |
	When User clicks on 'Owner Compliance' column header
	Then table content is present

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS19384
Scenario: EvergreenJnr_ApplicationsList_CheckzzMailboxAuOwnerInScopeFilterWork
	When User clicks 'Mailboxes' on the left-hand menu
	Then 'All Mailboxes' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName                 |
	| zMailboxAu: Owner In Scope |
	Then Content is present in the newly added column
	| ColumnName                 |
	| zMailboxAu: Owner In Scope |
	Then "14,884" rows are displayed in the agGrid
	When User clicks on 'zMailboxAu: Owner In Scope' column header
	Then data in table is sorted by 'zMailboxAu: Owner In Scope' column in descending order
	When User clicks on 'zMailboxAu: Owner In Scope' column header
	Then data in table is sorted by 'zMailboxAu: Owner In Scope' column in ascending order
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "zMailboxAu: Owner In Scope" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| TRUE               |
	| FALSE              |
	| Empty              |
	Then "zMailboxAu: Owner In Scope" filter is added to the list
	Then "14,884" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS19550
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoErrorDisplayedWhenFilteringListBySavedList
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Device Owner (Saved List)" filter where type is "In list" with selected Checkboxes and following Association:
	| SelectedCheckboxes      | Association    |
	| Users with Device Count | Used on device |
	Then There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS19669
Scenario: EvergreenJnr_Applications_CheckThatFilterStaysWorkingAfterAddingDepartmentFilter
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User add "Device Owner Department" filter where type is "Equals" with following Tree List option and Association:
	| Value | Association    |
	| Empty | Used on device |
	Then table content is present
	When User clicks refresh button in the browser
	Then table content is present
	When User clicks the Filters button
	Then "Device Owner whose Department is Empty used on device" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS19713
Scenario: EvergreenJnr_ApplicationsList_CheckThatErrorsDoNotAppearWhenAddingInvalidDateFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When user select "Device Boot Up Date" filter
	When User changes filter date to "13 Dec 2017"
	When User changes filter date to "R."
	When User select "Installed on device" in Association
	Then 'ADD' button is disabled

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS11552
Scenario: EvergreenJnr_ApplicationsList_CheckThatRelevantDataSetBeDisplayedAfterRemovingFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Import Type" filter where type is "Equals" with added column and following checkboxes:
		| SelectedCheckboxes |
		| App-V              |
	Then "Import Type" filter is added to the list
	And message 'No applications found' is displayed to the user
	When User have removed "Import Type" filter
	Then 'All Applications' list should be displayed to the user
	And "2,223" rows are displayed in the agGrid

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12908
Scenario: EvergreenJnr_ApplicationsList_ChecksThatAdvancedFilterOfUserWhoseFilterNameIsEmptyIsWorkingCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Description" filter where type is "Empty" with following Value and Association:
		| Values | Association     |
		|        | Entitled to app |
	Then "113" rows are displayed in the agGrid
	Then table content is present
	When User have reset all filters
	Then "2,223" rows are displayed in the agGrid
	When User add "User Building" filter where type is "Equals" with following Lookup Value and Association:
		| SelectedValues | Association     |
		| Empty          | Entitled to app |
	Then "245" rows are displayed in the agGrid
	And table content is present

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS10828
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTargetAppFilterIsAddedToTheList
	When User add following columns using URL to the "Applications" page:
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" Lookup filter with column and "<FilterOption>" option
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order 

Examples:
	| ColumnName                  | FilterName             | Operators                         | FilterOption      | Text                                        | RowsCount |
	| Windows7Mi: Target App Name | Windows7Mi: Target App | Equals, Does not equal, Not empty | WebZIP (A01)      | Windows7Mi: Target App is WebZIP (A01)      | 3         |
	| MailboxEve: Target App Name | MailboxEve: Target App | Equals, Does not equal, Not empty | Empty             | MailboxEve: Target App is Empty             | 2,223     |
	| Barry'sUse: Target App Name | Barry'sUse: Target App | Equals, Does not equal, Not empty | World Watch (A01) | Barry'sUse: Target App is World Watch (A01) | 1         |
	| ComputerSc: Target App Name | ComputerSc: Target App | Equals, Does not equal, Not empty | World Watch (A01) | ComputerSc: Target App is World Watch (A01) | 1         |
	| Havoc(BigD: Target App Name | Havoc(BigD: Target App | Equals, Does not equal, Not empty | WebZIP (A01)      | Havoc(BigD: Target App is WebZIP (A01)      | 1         |
	| Barry'sUse: Target App Name | Barry'sUse: Target App | Equals, Does not equal, Not empty | Zune (A01)        | Barry'sUse: Target App is Zune (A01)        | 1         |
	| UserSchedu: Target App Name | UserSchedu: Target App | Equals, Does not equal, Not empty | Zune (A01)        | UserSchedu: Target App is Zune (A01)        | 1         |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS10828 @DAS14287
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTargetAppKeyFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have create "Equals" Values filter with column and following options:
	| Values         |
	| <FilterOption> |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order 

Examples:
	| ColumnName                 | Operators                                                                                        | FilterOption | Text                               | RowsCount |
	| Windows7Mi: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1051         | Windows7Mi: Target App Key is 1051 | 4         |
	| Barry'sUse: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 115          | Barry'sUse: Target App Key is 115  | 1         |
	| ComputerSc: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1060         | ComputerSc: Target App Key is 1060 | 1         |
	| Havoc(BigD: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1050         | Havoc(BigD: Target App Key is 1050 | 1         |
	| UserSchedu: Target App Key | Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to | 1            | UserSchedu: Target App Key is 1    | 1         |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS10828 @DAS13001
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatTargetAppReadinessFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" Lookup filter with column and "<FilterOption>" option
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples:
	| ColumnName                       | Operators                         | FilterOption | Text                                      | RowsCount |
	| Windows7Mi: Target App Readiness | Equals, Does not equal, Not empty | Red          | Windows7Mi: Target App Readiness is Red   | 28        |
	| Barry'sUse: Target App Readiness | Equals, Does not equal, Not empty | Empty        | Barry'sUse: Target App Readiness is Empty | 1,145     |
	| ComputerSc: Target App Readiness | Equals, Does not equal, Not empty | Green        | ComputerSc: Target App Readiness is Green | 913       |
	| Havoc(BigD: Target App Readiness | Equals, Does not equal, Not empty | Empty        | Havoc(BigD: Target App Readiness is Empty | 1,155     |
	| UserSchedu: Target App Readiness | Equals, Does not equal, Not empty | Grey         | UserSchedu: Target App Readiness is Grey  | 981       |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12388
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatAddColumnCheckboxIsDisplayedForTargetAppKeyFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes        |
	| Add Target App Key column |

Examples:
	| FilterName                 |
	| Windows7Mi: Target App Key |
	| Barry'sUse: Target App Key |
	| ComputerSc: Target App Key |
	| Havoc(BigD: Target App Key |
	| UserSchedu: Target App Key |
	| prK: Target App Key        |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12388
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatAddColumnCheckboxIsDisplayedForTargetAppIDFilters
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes        |
	| Add Target App ID column |

Examples:
	| FilterName                |
	| Windows7Mi: Target App ID |
	| Barry'sUse: Target App ID |
	| ComputerSc: Target App ID |
	| EmailMigra: Target App ID |
	| Havoc(BigD: Target App ID |
	| UserSchedu: Target App ID |
	| prK: Target App ID        |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS10512 @DAS13001
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatApplicationReadinessFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" Lookup filter with column and "<FilterOption>" option
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples:
	| ColumnName                        | Operators                         | FilterOption | Text                                       | RowsCount |
	| Windows7Mi: Application Readiness | Equals, Does not equal, Not empty | Red          | Windows7Mi: Application Readiness is Red   | 27        |
	| Barry'sUse: Application Readiness | Equals, Does not equal, Not empty | Empty        | Barry'sUse: Application Readiness is Empty | 1,145     |
	| ComputerSc: Application Readiness | Equals, Does not equal, Not empty | Green        | ComputerSc: Application Readiness is Green | 911       |
	| Havoc(BigD: Application Readiness | Equals, Does not equal, Not empty | Empty        | Havoc(BigD: Application Readiness is Empty | 1,155     |
	| UserSchedu: Application Readiness | Equals, Does not equal, Not empty | Empty        | UserSchedu: Application Readiness is Empty | 1,242     |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS10512 @DAS11509 @DAS11507 @DAS11509 @DAS12026
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatRationalisationFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" filter with column and following options:
	| SelectedCheckboxes |
	| <FilterOption>     |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in ascending order 

Examples: 
	| ColumnName                  | Operators                         | FilterOption  | Text                                         | RowsCount |
	| Windows7Mi: Rationalisation | Equals, Does not equal, Not empty | RETIRE        | Windows7Mi: Rationalisation is Retire        | 85        |
	| Barry'sUse: Rationalisation | Equals, Does not equal, Not empty | KEEP          | Barry'sUse: Rationalisation is Keep          | 2         |
	| ComputerSc: Rationalisation | Equals, Does not equal, Not empty | FORWARD PATH  | ComputerSc: Rationalisation is Forward Path  | 15        |
	| Havoc(BigD: Rationalisation | Equals, Does not equal, Not empty | UNCATEGORISED | Havoc(BigD: Rationalisation is Uncategorised | 1,068     |
	| UserSchedu: Rationalisation | Equals, Does not equal, Not empty | UNCATEGORISED | UserSchedu: Rationalisation is Uncategorised | 981       |

# Yurii T. 11 Mar 2020: tag archived is aadded accroding to DAS-20152 - Project Core Application should not exists
@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS10512 @DAS11507 @archived
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatCoreApplicationFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" filter with column and following options:
	| SelectedCheckboxes |
	| <FilterOption>     |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName                   | Operators                         | FilterOption | Text                                  | RowsCount |
	| Windows7Mi: Core Application | Equals, Does not equal, Not empty | TRUE         | Windows7Mi: Core Application is True  | 11        |
	| Barry'sUse: Core Application | Equals, Does not equal, Not empty | Empty        | Barry'sUse: Core Application is Empty | 1,145     |
	| ComputerSc: Core Application | Equals, Does not equal, Not empty | FALSE        | ComputerSc: Core Application is False | 1,043     |
	| Havoc(BigD: Core Application | Equals, Does not equal, Not empty | Empty        | Havoc(BigD: Core Application is Empty | 1,155     |
	| UserSchedu: Core Application | Equals, Does not equal, Not empty | Empty        | UserSchedu: Core Application is Empty | 1,242     |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS10512 @DAS11509 @DAS11507 @DAS11509
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatHideFromEndUsersFilterIsAddedToTheList
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName   |
	| <ColumnName> |
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<ColumnName>" filter
	Then "<Operators>" option is available for this filter
	When User have created "Equals" filter with column and following options:
	| SelectedCheckboxes |
	| <FilterOption>     |
	Then "<Text>" is displayed in added filter info
	Then "<RowsCount>" rows are displayed in the agGrid
	When User clicks on '<ColumnName>' column header
	Then data in table is sorted by '<ColumnName>' column in descending order 

Examples: 
	| ColumnName                      | Operators                         | FilterOption | Text                                     | RowsCount |
	| Windows7Mi: Hide From End Users | Equals, Does not equal, Not empty | FALSE        | Windows7Mi: Hide From End Users is False | 1,067     |
	| Pr000: Hide From End Users      | Equals, Does not equal, Not empty | Empty        | Pr000: Hide From End Users is Empty      | 1,096     |
	| Barry'sUse: Hide From End Users | Equals, Does not equal, Not empty | FALSE        | Barry'sUse: Hide From End Users is False | 1,078     |
	| ComputerSc: Hide From End Users | Equals, Does not equal, Not empty | FALSE        | ComputerSc: Hide From End Users is False | 1,043     |
	| Havoc(BigD: Hide From End Users | Equals, Does not equal, Not empty | Empty        | Havoc(BigD: Hide From End Users is Empty | 1,155     |
	| DeviceSche: Hide From End Users | Equals, Does not equal, Not empty | FALSE        | DeviceSche: Hide From End Users is False | 100       |
	| UserSchedu: Hide From End Users | Equals, Does not equal, Not empty | Empty        | UserSchedu: Hide From End Users is Empty | 1,242     |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS18875 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckStickyComplianceFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Sticky Compliance" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| Red                |
	When User creates 'DAS18875_list' dynamic list
	Then "DAS18875_list" list is displayed to user
	When User clicks the Filters button
	Then "Sticky Compliance is Red" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS18961 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckTargetAppFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Target App" filter where type is "Equals" with added column and Lookup option
	| SelectedValues      |
	| Multi Edit 9 Client |
	When User creates 'DAS18875_list' dynamic list
	Then "DAS18875_list" list is displayed to user
	When User clicks the Filters button
	Then "2004: Target App is Multi Edit 9 Client" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS18961 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckEvergreeargetAppKeyFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Target App Key" filter where type is "Does not equal" with added column and following value:
	| Values |
	| 12     |
	When User creates 'DAS18875_list1' dynamic list
	Then "DAS18875_list1" list is displayed to user
	When User clicks the Filters button
	Then "2004: Target App Key is not 12" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS18961 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckTargetAppVendorFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Evergreen Target App Vendor" filter where type is "Contains" with added column and following value:
	| Values |
	| Adobe  |
	When User creates 'DAS18875_list2' dynamic list
	Then "DAS18875_list2" list is displayed to user
	When User clicks the Filters button
	Then "Evergreen Target App Vendor contains Adobe" is displayed in added filter info
	Then 'Adobe Systems, Inc.' content is displayed in the 'Evergreen Target App Vendor' column

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS18961 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckEvergreenTargetAppVersionFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Evergreen Target App Version" filter where type is "Does not contain" with added column and following value:
	| Values    |
	| Microsoft |
	When User creates 'DAS18875_list3' dynamic list
	Then "DAS18875_list3" list is displayed to user
	When User clicks the Filters button
	Then "Evergreen Target App Version does not contain Microsoft" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS18961 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckTargetAppReadinessFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "2004: Target App Readiness" filter where type is "Not empty" with added column and following value:
	| Values |
	|        |
	When User creates 'DAS18875_list4' dynamic list
	Then "DAS18875_list4" list is displayed to user
	When User clicks the Filters button
	Then "2004: Target App Readiness is not empty" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS18896 @Cleanup @Universe
Scenario: EvergreenJnr_ApplicationsList_CheckEvergreenRationalisationFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Evergreen Rationalisation" filter where type is "Equals" without added column and following checkboxes:
	| SelectedCheckboxes |
	| UNCATEGORISED      |
	When User creates 'DAS18896_list' dynamic list
	Then "DAS18896_list" list is displayed to user
	When User clicks the Filters button
	Then "Evergreen Rationalisation is Uncategorised" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS19262 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckEvergreenTargetAppNameFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Evergreen Target App Name" filter where type is "Not empty" with added column and following value:
	| Values |
	When User creates 'DAS19262_list' dynamic list
	Then "DAS19262_list" list is displayed to user
	When User clicks the Filters button
	Then "Evergreen Target App Name is not empty" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS19262 @Cleanup @Universe @archived
Scenario: EvergreenJnr_ApplicationsList_CheckEvergreenTargetAppFilterWithNoTargetApplication
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Evergreen Target App" filter where type is "Equals" with added column and "No Target Application" Lookup option
	When User creates 'DAS192621_list' dynamic list
	Then "DAS192621_list" list is displayed to user
	When User clicks the Filters button
	Then "Evergreen Target App is No Target Application" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS17413
Scenario: EvergreenJnr_ApplicationsList_CheckThatUserCanAddAssociationAfterSelectingNotEmptyOperator
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "Device Owner Department" filter where type is "Not empty" with following Tree List option and Association:
	| Value | Association        |
	|       | Entitled to device |
	Then table content is present

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS17413 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatFilterValueDisregardsWhenNotEmptyOperatorIsSelected
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add "User Department" filter where type is "Equals" with following Tree List option and Association:
	| Value | Association  |
	| Empty | Has used app |
	When User click Edit button for "User " filter
	When User select "Not empty" Operator value
	When User clicks 'UPDATE' button
	Then "User whose Department is not empty has used app" is displayed in added filter info

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS19773
Scenario: EvergreenJnr_ApplicationsList_CheckThatNoUnknownOptionAvailableForDeviceFilter
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When user select "Device" filter
	When User enters "Unknown" text in Search field at selected Lookup Filter
	Then No options are displayed for selected Lookup Filter

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS12793 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatTheValueInTheFiltersPanelIsDisplayedCorrectly
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User add Advanced "User" filter where type is "Equals" with following Lookup Value and Association:
		| SelectedValues | Association     |
		| AAD1011948     | Entitled to app |
	Then "4" rows are displayed in the agGrid
	When User create dynamic list with "UsersFilterList" name on "Applications" page
	Then "UsersFilterList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When User click Edit button for "User" filter
	Then "FR\AAD1011948 (Pinabel Cinq-Mars)" value is displayed in the filter info
	And There are no errors in the browser console
	When User clicks 'Devices' on the left-hand menu
	Then 'All Devices' list should be displayed to the user
	When User clicks 'Users' on the left-hand menu
	Then 'All Users' list should be displayed to the user
	And There are no errors in the browser console

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS16426
Scenario: EvergreenJnr_ApplicationsList_CheckTooltipsForUpdateButtonWhenDateFieldIsEmpty
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "User Dashworks First Seen" filter
	And User select "Equals" Operator value
	Then 'ADD' button has tooltip with 'You must enter a date' text
	When User select "Between" Operator value
	Then 'ADD' button has tooltip with 'You must enter a start date' text
	When User select "Empty" Operator value
	Then 'ADD' button has tooltip with 'Complete all fields before saving this filter' text
	When User select "Not empty" Operator value
	Then 'ADD' button has tooltip with 'Complete all fields before saving this filter' text

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS18367
Scenario Outline: EvergreenJnr_ApplicationsList_CheckThatThereIsNoEmptyOptionInInListFilter
	When User clicks 'Applications' on the left-hand menu
	Then 'All Applications' list should be displayed to the user
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When User selects "<List>" filter from "Saved List" category
	Then "Empty" checkbox is not available for current opened filter

	Examples:
		| List                      |
		| Application (Saved List)  |
		| Device (Saved List)       |
		| Device Owner (Saved List) |
		| User (Saved List)         |

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS19721 @Cleanup
Scenario: EvergreenJnr_ApplicationsList_CheckThatCriticalityFilterWorks
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When User clicks Add New button on the Filter panel
	When user select "Windows7Mi: Criticality" filter
	When User clicks in search field in the Filter block
	Then Tasks are displayed in the following order on Action panel:
	| items         |
	| Empty         |
	| Core          |
	| Critical      |
	| Important     |
	| Not Important |
	| Uncategorised |
	When User clicks Body container
	When User deletes filter and agGrid does not reload
	When User add "Windows7Mi: Criticality" filter where type is "Does not equal" with added column and Lookup option
	| SelectedValues |
	| Empty          |
	Then table content is present
	Then ColumnName is added to the list
	| ColumnName              |
	| Windows7Mi: Criticality |
	Then Content is not empty in the column
	| ColumnName                  |
	| Windows7Mi: Criticality |
	When User have removed "Windows7Mi: Criticality" filter
	When User add "Windows7Mi: Criticality" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Core           |
	Then 'Core' content is displayed in the 'Windows7Mi: Criticality' column
	When User clicks Add New button on the Filter panel
	When User add "Windows7Mi: Criticality" filter where type is "Equals" with added column and Lookup option
	| SelectedValues |
	| Empty          |
	Then table data is filtered correctly
	When User creates 'DAS19721_List' dynamic list
	Then "DAS19721_List" list is displayed to user

@Evergreen @Evergreen_FiltersFeature @Filter_ApplicationsList @DAS20998
Scenario: EvergreenJnr_ApplicationsList_CheckThatOwnerFilterInTheApplicationListWorksCorrectly
	When User clicks 'Applications' on the left-hand menu
	When User clicks the Filters button
	When user select "Owner" filter
	Then There are no errors in the browser console
	When User select "Does not equal" Operator value
	Then There are no errors in the browser console
	When User enters "AU\ACG224403 (Xavier R. Ball)" text in Search field at selected Lookup Filter
	When User clicks checkbox at selected Lookup Filter
	Then "Add column" checkbox is not displayed
	When User clicks Save filter button
	Then table content is present
	Then There are no errors in the browser console