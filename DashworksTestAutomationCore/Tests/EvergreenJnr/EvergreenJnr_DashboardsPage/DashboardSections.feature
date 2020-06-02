Feature: DashboardSections
	Runs Section and Widget management tests

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14358 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatParticularSectionWithWidgetsCanBeDuplicated
	When Dashboard with 'Dashboard for DAS14358' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14358 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	When User remembers number of Sections and Widgets on Dashboards page
	When User clicks 'Duplicate' menu option for section with 'WidgetForDAS14358' widget
	Then User sees number of Sections increased by '1' on Dashboards page
	Then User sees number of Widgets increased by '1' on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14728 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatWidgetLegendCopiedWhenDuplicatingSection
	When Dashboard with 'Dashboard for DAS14728' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | WidgetForDAS14728 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	Then User sees '1' Widgets with Legend on Dashboards page
	When User clicks 'Duplicate' menu option for section with 'WidgetForDAS14728' widget
	Then User sees '2' Widgets with Legend on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS15721 @DAS15937 @DAS18911 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatNoMoreSectionsCanBeAddedAfter10WidgetsCreating
	When Dashboard with 'Dashboard for DAS15721' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 1_Widget | All Devices | 5       | 5          |
	Then '1_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 2_Widget | All Devices | 5       | 5          |
	Then '2_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 3_Widget | All Devices | 5       | 5          |
	Then '3_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 4_Widget | All Devices | 5       | 5          |
	Then '4_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 5_Widget | All Devices | 5       | 5          |
	Then '5_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 6_Widget | All Devices | 5       | 5          |
	Then '6_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 7_Widget | All Devices | 5       | 5          |
	Then '7_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 8_Widget | All Devices | 5       | 5          |
	Then '8_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 9_Widget | All Devices | 5       | 5          |
	Then '9_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title     | List        | MaxRows | MaxColumns |
	| List       | 10_Widget | All Devices | 5       | 5          |
	Then '10_Widget' Widget is displayed to the user
	#==========================================================#
	Then 'ADD WIDGET' button is disabled
	Then 'ADD WIDGET' button has tooltip with 'Maximum number of widgets has been reached for this dashboard' text
	Then 'Duplicate' menu item for '10_Widget' widget is disabled and has 'Maximum number of widgets has been reached for this dashboard' tooltip
	When User remembers number of Sections and Widgets on Dashboards page
	When User clicks 'ADD SECTION' button
	Then 'Section successfully created' text is displayed on inline success banner
	Then User sees number of Sections increased by '1' on Dashboards page
	
@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14618 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckMovingWidgetsBetweenSections
	When Dashboard with 'Dashboard_DAS14618' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button
	When User creates new Widget
	| WidgetType | Title             | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    |
	| Pie        | WidgetForDAS14618 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC |
	Then 'WidgetForDAS14618' Widget is displayed to the user
	When User clicks 'ADD SECTION' button 
	When User clicks 'Move to section' menu option for 'WidgetForDAS14618' widget
	Then popup is displayed to User
	When User clicks 'CANCEL' button
	Then popup is not displayed to User
	When User clicks 'Move to section' menu option for 'WidgetForDAS14618' widget
	When User selects '2' in the 'Select Section' dropdown
	When User clicks 'MOVE' button
	When User expands all sections on Dashboards page
	Then 'WidgetForDAS14618' Widget is displayed to the user
	When User clicks 'Move to section' menu option for 'WidgetForDAS14618' widget
	When User selects '1' in the 'Select Section' dropdown
	When User clicks 'MOVE' button
	Then 'WidgetForDAS14618' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Sections @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatSectionCanBeDeleted
	When Dashboard with 'Dashboard for DAS12974SECTION' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title            | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | DAS12974SECTION1 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	Then 'DAS12974SECTION1' Widget is displayed to the user
	When User clicks 'ADD SECTION' button 
	When User clicks ADD WIDGET button for '2' Section on Dashboards page
	When User creates new Widget
	| WidgetType | Title            | List             | SplitBy | AggregateBy | AggregateFunction | OrderBy    | MaxValues | ShowLegend |
	| Pie        | DAS12974SECTION2 | All Applications | Vendor  | Version     | Count distinct    | Vendor ASC | 10        | true       |
	Then 'DAS12974SECTION2' Widget is displayed to the user
	When User remembers number of Sections and Widgets on Dashboards page
	When User clicks 'Delete' menu option for section with 'DAS12974SECTION1' widget
	When User confirms item deleting on Dashboards page
	Then User sees number of Sections increased by '-1' on Dashboards page
	Then User sees number of Widgets increased by '-1' on Dashboards page

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS20827 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatCollapsedSectionCanBeDeleted
	When Dashboard with 'Dashboard to delete' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 1_Widget | All Devices | 5       | 5          |
	Then '1_Widget' Widget is displayed to the user
	When User clicks 'Edit' menu option for section with '1_Widget' widget
	When User enters 'SectionName' text to 'Title' textbox
	When User clicks 'UPDATE' button
	When User clicks 'ADD SECTION' button 
	When User remembers number of Sections and Widgets on Dashboards page
	When User sets expand status to 'false' for 'SectionName' section
	When User clicks 'Delete' menu option for section with '1_Widget' widget
	When User confirms item deleting on Dashboards page
	Then User sees number of Sections increased by '-1' on Dashboards page	

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14472 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatSectionCanBeHiddenAndShown
	When Dashboard with 'Dashboard for HiddenSection' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title             | List        | Type       |
	| Card       | SectionDisplaying | All Devices | First Cell |
	Then 'SectionDisplaying' Widget is displayed to the user
	#hide section
	When User clicks 'Hide' menu option for section with 'SectionDisplaying' widget
	Then 'Section successfully updated' text is displayed on inline success banner
	When User unchecks 'Edit mode' slide toggle
	When User clicks refresh button in the browser
	Then Widget with the name 'SectionDisplaying' is missing
	#show section
	When User checks 'Edit mode' slide toggle
	When User clicks 'Show' menu option for section with 'SectionDisplaying' widget
	Then 'Section successfully updated' text is displayed on inline success banner
	When User unchecks 'Edit mode' slide toggle
	When User clicks refresh button in the browser
	Then 'SectionDisplaying' Widget is displayed to the user

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14472 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatSectionCanMovedUpAndDown
	When Dashboard with 'Dashboard for MovedSection' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title         | List        | Type       |
	| Card       | SectionMoving | All Devices | First Cell |
	Then 'SectionMoving' Widget is displayed to the user
	When User clicks 'ADD SECTION' button
	When User clicks 'ADD SECTION' button 
	#check to bottom for both modes
	When User clicks 'Move to bottom' menu option for section with 'SectionMoving' widget
	Then User sees 'SectionMoving' widget placed in '3' section
	When User clicks refresh button in the browser
	When User unchecks 'Edit mode' slide toggle
	Then User sees 'SectionMoving' widget placed in '3' section
	#check to top for both modes
	When User checks 'Edit mode' slide toggle
	When User clicks 'Move to top' menu option for section with 'SectionMoving' widget
	Then User sees 'SectionMoving' widget placed in '1' section
	When User clicks refresh button in the browser
	When User unchecks 'Edit mode' slide toggle
	Then User sees 'SectionMoving' widget placed in '1' section
	#check to position for both modes
	When User checks 'Edit mode' slide toggle
	When User clicks 'Move to position' menu option for section with 'SectionMoving' widget
	When User enters '2' text to 'Move to position' textbox
	When User clicks 'MOVE' button
	Then User sees 'SectionMoving' widget placed in '2' section
	When User clicks refresh button in the browser
	When User unchecks 'Edit mode' slide toggle
	Then User sees 'SectionMoving' widget placed in '2' section

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14472 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatSectionCantBeDuplicatedWhenWidgetLimitIsReached
	When Dashboard with 'Dashboard for Duplicating' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 1_Widget | All Devices | 5       | 5          |
	Then '1_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 2_Widget | All Devices | 5       | 5          |
	Then '2_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 3_Widget | All Devices | 5       | 5          |
	Then '3_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 4_Widget | All Devices | 5       | 5          |
	Then '4_Widget' Widget is displayed to the user
	#==========================================================#
	
	When User clicks 'ADD SECTION' button 
	#==========================================================#
	When User clicks ADD WIDGET button for '2' Section on Dashboards page
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 6_Widget | All Devices | 5       | 5          |
	Then '6_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks ADD WIDGET button for '2' Section on Dashboards page
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 7_Widget | All Devices | 5       | 5          |
	Then '7_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks ADD WIDGET button for '2' Section on Dashboards page
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 8_Widget | All Devices | 5       | 5          |
	Then '8_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks ADD WIDGET button for '2' Section on Dashboards page
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 9_Widget | All Devices | 5       | 5          |
	Then '9_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'Duplicate' menu option for section with '9_Widget' widget
	Then 'Maximum number of widgets has been reached for this dashboard' text is displayed on inline error banner

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14472 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckThatUserCanEditSection
	When Dashboard with 'Dashboard for SectionEditing' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 1_Widget | All Devices | 5       | 5          |
	Then '1_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 2_Widget | All Devices | 5       | 5          |
	Then '2_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 3_Widget | All Devices | 5       | 5          |
	Then '3_Widget' Widget is displayed to the user
	#==========================================================#
	When User clicks 'Edit' menu option for section with '3_Widget' widget
	When User enters 'SectionName' text to 'Title' textbox
	When User enters 'DescriptionName' text to 'Description' textbox
	When User selects '3 Column' in the 'Layout' dropdown
	When User checks 'Collapsed on load' checkbox
	When User clicks 'UPDATE' button
	When User sets expand status to 'true' for 'SectionName' section
	Then User sees 'DescriptionName' description for 'SectionName' section
	Then Listed widgets are placed by '3' in line:
	| WidgetName |
	| 1_Widget   |
	| 2_Widget   |
	| 3_Widget   |

	When User clicks 'Edit' menu option for section with '3_Widget' widget
	When User selects '1 Column' in the 'Layout' dropdown
	When User unchecks 'Collapsed on load' checkbox
	When User clicks 'UPDATE' button
	When User sets expand status to 'true' for 'SectionName' section
	Then Listed widgets are placed by '1' in line:
	| WidgetName |
	| 1_Widget   |
	| 2_Widget   |
	| 3_Widget   |

	When User clicks 'Edit' menu option for section with '3_Widget' widget
	When User clicks Hide section checkbox on Edit Section page
	Then 'Hide section' checkbox is checked
	When User clicks 'UPDATE' button
	Then '1_Widget' Widget is displayed to the user
	When User unchecks 'Edit mode' slide toggle
	Then Widget with the name '1_Widget' is missing

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS14472 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckLongDescriptionCanBeHiddenAndShown
	When Dashboard with 'Dashboard for SectionDescription' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 1_Widget | All Devices | 5       | 5          |
	Then '1_Widget' Widget is displayed to the user
	When User clicks 'Edit' menu option for section with '1_Widget' widget
	When User enters 'SectionName' text to 'Title' textbox
	When User enters 'Description Long Text Description Long Text Description Long Text Description Long Text Description Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long' text to 'Description' textbox
	When User clicks 'UPDATE' button
	When User clicks 'See full description' link in description for 'SectionName' section
	Then User sees 'Description Long Text Description Long Text Description Long Text Description Long Text Description Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long Text Long' description for 'SectionName' section
	When User clicks 'Hide full description' link in description for 'SectionName' section

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS21111 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckSectionsDisplayingAfterWidgetReordering
	When Dashboard with 'Dashboard_21111' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 1_Widget | All Devices | 5       | 5          |
	Then '1_Widget' Widget is displayed to the user
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 2_Widget | All Devices | 5       | 5          |
	Then '2_Widget' Widget is displayed to the user
	When User clicks 'ADD SECTION' button
	When User clicks ADD WIDGET button for '2' Section on Dashboards page
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 3_Widget | All Devices | 5       | 5          |
	Then '3_Widget' Widget is displayed to the user
	When User clicks 'Duplicate' menu option for '2_Widget' widget
	When User clicks 'Move to section' menu option for '2_Widget2' widget
	When User selects '2' in the 'Select Section' dropdown
	When User clicks 'MOVE' button
	When User clicks refresh button in the browser
	Then User sees '1_Widget' widget placed in '1' section
	Then User sees '2_Widget' widget placed in '1' section
	Then User sees '3_Widget' widget placed in '2' section
	Then User sees '2_Widget2' widget placed in '2' section

@Evergreen @EvergreenJnr_DashboardsPage @Sections @DAS21109 @Cleanup
Scenario: EvergreenJnr_DashboardsPage_CheckNoConsoleErrorDisplayedAfterDuplicatingSectionAndWidget
	When Dashboard with 'Dashboard for DAS21109' name created via API and opened
	When User checks 'Edit mode' slide toggle
	When User clicks 'ADD WIDGET' button 
	When User creates new Widget
	| WidgetType | Title    | List        | MaxRows | MaxColumns |
	| List       | 1_Widget | All Devices | 5       | 5          |
	Then '1_Widget' Widget is displayed to the user
	When User remembers number of Sections and Widgets on Dashboards page
	When User clicks 'Duplicate' menu option for '1_Widget' widget
	When User clicks 'Duplicate' menu option for section with '1_Widget' widget
	Then There are no errors in the browser console
	Then User sees number of Sections increased by '1' on Dashboards page	