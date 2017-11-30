#@retry:3
Feature: FiltersDisplay
	Runs Item Details Display related tests

Background: Pre-Conditions
	Given User is on Dashworks Homepage
	And Login link is visible
	When User clicks on the Login link
	Then Login Page is displayed to the user
	When User provides the Login and Password and clicks on the login button
	Then Dashworks homepage is displayed to the user in a logged in state
	When User clicks the Switch to Evergreen link
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-10781
Scenario: EvergreenJnr_DevicesList_Check that 'Add column' option as available for "Compliance" filter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Compliance" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes    |
	| Add Compliance column |   
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS-10651
Scenario: EvergreenJnr_ApplicationsList_Check true-false options and images in filter info
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Hide from End Users" filter
	Then correct true and false options are displayed in filter settings
	When User have created "Equals" filter without column and following options:
	| SelectedCheckboxes |
	| TRUE               |
	| FALSE              |
	| UNKNOWN            |
	Then "Windows7Mi: Hide from End Users" filter is added to the list
	Then Values is displayed in added filter info
	| Values      |
	| true, false |
	| Unknown     |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS-10754 @DAS-11142 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_Check special characters display in filter info
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Display Name" filter
	When User have create "Equals" Values filter with column and following options:
	| Values           |
	| O'Conn"/\or#@!() |
	Then "Display Name" filter is added to the list
	Then Values is displayed in added filter info
	| Values           |
	| O'Conn"/\or#@!() |
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
	| Values           |
	| O'Conn"/\or#@!() |
	When User navigates to the "All Users" list
	When User navigates to the "TestList" list
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
	| Values           |
	| O'Conn"/\or#@!() |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS-10781
Scenario: EvergreenJnr_ApplicationsList_Check that 'Group' and 'Team' related filters is not presented in the list
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then "Windows7Mi: Group" filter is not presented in the filters list
	Then "Windows7Mi: Group Key" filter is not presented in the filters list
	Then "Windows7Mi: Team" filter is not presented in the filters list
	Then "Windows7Mi: Team Key" filter is not presented in the filters list
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-10776
Scenario: EvergreenJnr_DevicesList_Check that "Empty" and "Not Empty" options is availdable for ObjectKey filter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "AD Object Key" filter
	Then "Equals, Does not equal, Greater than, Greater than or equal to, Less than, Less than or equal to, Empty, Not empty" option is available for this filter

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-10795
Scenario: EvergreenJnr_DevicesList_Check that 'Add column' option is available for "Operating System" filter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Operating System" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes          |
	| Add Operating System column |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-10795
Scenario: EvergreenJnr_DevicesList_Check that 'Add column' option is available for "City" filter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "City" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes |
	| Add City column    |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-10795 @DAS-11187
Scenario: EvergreenJnr_DevicesList_Check that 'Add column' option is not available for Application Custom Fields filters
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Computer Warranty" filter
	Then "Add column" checkbox is not displayed
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS-10795
Scenario: EvergreenJnr_UsersList_Check that 'Add column' option is available for filter
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Zip Code" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes  |
	| Add Zip Code column |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS-10795
Scenario: EvergreenJnr_ApplicationsList_Check that 'Add column' option is available for filter
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application Owner" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes           |
	| Add Application Owner column |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS-10795
Scenario: EvergreenJnr_MailboxesList_Check that 'Add column' option is available for filter
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Mailbox Filter 1" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes          |
	| Add Mailbox Filter 1 column |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-10771
Scenario: EvergreenJnr_DevicesList_Check that 'None' option is available for filter
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Category" filter
	Then "None" option is available at first place
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS-10771
Scenario: EvergreenJnr_UsersList_Check that 'None' option is available for filter
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "UserSchedu: Category" filter
	Then "None" option is available at first place
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS-10771
Scenario: EvergreenJnr_ApplicationsList_Check that 'None' option is available for filter
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Havoc(BigD: Category" filter
	Then "None" option is available at first place
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS-10771
Scenario: EvergreenJnr_MailboxesList_Check that 'None' option is available for filter
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "EmailMigra: Category" filter
	Then "None" option is available at first place
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-10696 @Delete_Newly_Created_List
Scenario: EvergreenJnr_DevicesList_Check that filter data is displayed correctly when navigating between lists
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Hostname" filter
	And User have create "Equals" Values filter with column and following options:
	| Values          |
	| 00BDM1JUR8IF419 |
	Then "Hostname" filter is added to the list
	Then Values is displayed in added filter info
	| Values          |
	| 00BDM1JUR8IF419 |
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
	| Values          |
	| 00BDM1JUR8IF419 |
	When User navigates to the "All Devices" list
	When User navigates to the "TestList" list
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
	| Values          |
	| 00BDM1JUR8IF419 |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS-10696 @Delete_Newly_Created_List
Scenario: EvergreenJnr_UsersList_Check that filter data is displayed correctly when navigating between lists
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Compliance" filter
	When User have created "Does not equal" filter with column and following options:
	| SelectedCheckboxes |
	| Red                |
	| Amber              |
	| Green              |
	Then "Compliance" filter is added to the list
	Then Values is displayed in added filter info
	| Values     |
	| Red, Amber |
	| Green      |
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
	| Values     |
	| Red, Amber |
	| Green      |
	When User navigates to the "All Users" list
	When User navigates to the "TestList" list
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
	| Values     |
	| Red, Amber |
	| Green      |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS-10696 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_Check that filter data is displayed correctly when navigating between lists
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Device Count (Entitled)" filter
	When User have create "Greater than or equal to" Values filter with column and following options:
	| Values |
	| 1      |
	Then "Device Count (Entitled)" filter is added to the list
	Then Values is displayed in added filter info
	| Values |
	| 1      |
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
	| Values |
	| 1      |
	When User navigates to the "All Applications" list
	When User navigates to the "TestList" list
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
	| Values |
	| 1      |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS-10696 @Delete_Newly_Created_List
Scenario: EvergreenJnr_MailboxesList_Check that filter data is displayed correctly when navigating between lists
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Created Date" filter
	And User have create "Before" Values filter with column and following options:
	| Values          |
	| Fri Nov 17 2017 |
	Then "Created Date" filter is added to the list
	Then Values is displayed in added filter info
	| Values      |
	| 17 Nov 2017 |
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
	| Values      |
	| 17 Nov 2017 |
	When User navigates to the "All Mailboxes" list
	When User navigates to the "TestList" list
	Then "TestList" list is displayed to user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	Then Values is displayed in added filter info
	| Values      |
	| 17 Nov 2017 |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-10696
Scenario Outline: EvergreenJnr_DevicesList_Check that filter Operators is correct in filter info
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Hostname" filter
	And User have create "<operatorValue>" Values filter with column and following options:
	| Values         |
	| <filterOption> |
	Then "Hostname" filter is added to the list
	Then "<rowsCount>" rows are displayed in the agGrid
	Then Options is displayed in added filter info
	| Values                |
	| <operatorValueInInfo> |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

Examples: 
	| operatorValue    | filterOption    | rowsCount | operatorValueInInfo |
	| Equals           | 00BDM1JUR8IF419 | 1         | is                  |
	| Does not equal   | 00BDM1JUR8IF419 | 17,224    | is not              |
	| Contains         | 00B             | 6         | contains            |
	| Does not contain | 00BDM1J         | 17,224    | does not contain    |
	| Begins with      | 00              | 14        | begins with         |
	| Ends with        | 41              | 7         | ends with           |
	| Empty            |                 |           | is empty            |
	| Not empty        |                 | 17,225    | is not empty        |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS-10696
Scenario Outline: EvergreenJnr_UsersList_Check that filter Operators is correct in filter info
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Compliance" filter
	When User have created "<operatorValue>" filter with column and following options:
	| SelectedCheckboxes |
	| <filterOption>     |
	Then "Compliance" filter is added to the list
	Then "<rowsCount>" rows are displayed in the agGrid
	Then Options is displayed in added filter info
	| Values                |
	| <operatorValueInInfo> |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

Examples: 
	| operatorValue  | filterOption | rowsCount | operatorValueInInfo |
	| Equals         | Red          | 9,438     | is                  |
	| Does not equal | Red          | 31,897    | is not              |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS-10696
Scenario Outline: EvergreenJnr_ApplicationsList_Check that filter Operators is correct in filter info
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Device Count (Entitled)" filter
	And User have create "<operatorValue>" Values filter with column and following options:
	| Values         |
	| <filterOption> |
	Then "Device Count (Entitled)" filter is added to the list
	Then "<rowsCount>" rows are displayed in the agGrid
	Then Options is displayed in added filter info
	| Values                |
	| <operatorValueInInfo> |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

Examples: 
	| operatorValue            | filterOption | rowsCount | operatorValueInInfo         |
	| Equals                   | 1            | 2         | is                          |
	| Does not equal           | 1            | 2,221     | is not                      |
	| Greater than             | 1            | 1,057     | is greater than             |
	| Greater than or equal to | 1            | 1,059     | is greater than or equal to |
	| Less than                | 1            | 1,164     | is less than                |
	| Less than or equal to    | 1            | 1,166     | is less than or equal to    |

 @Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS-10696
Scenario Outline: EvergreenJnr_MailboxesList_Check that filter Operators is correct in filter info
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Created Date" filter
	And User have create "<operatorValue>" Values filter with column and following options:
	| Values         |
	| <filterOption> |
	Then "Created Date" filter is added to the list
	Then "<rowsCount>" rows are displayed in the agGrid
	Then Options is displayed in added filter info
	| Values                |
	| <operatorValueInInfo> |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

Examples: 
	| operatorValue  | filterOption | rowsCount | operatorValueInInfo |
	| Equals         | 08 Mar 2016  | 3         | is                  |
	| Does not equal | 08 Mar 2016  | 4,832     | is not              |
	| Before         | 08 Mar 2016  | 33        | is before           |
	| After          | 08 Mar 2016  | 4,799     | is after            |
	| Empty          |              |           | is empty            |
	| Not empty      |              | 4,835     | is not empty        |

 @Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-10696
Scenario Outline: EvergreenJnr_DevicesList_Check that filter Operators is correct in filter info (datetime)
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Date & Time Task" filter
	And User have create "<operatorValue>" Values filter with column and following options:
	| Values         |
	| <filterOption> |
	Then "Windows7Mi: Date & Time Task" filter is added to the list
	Then "<rowsCount>" rows are displayed in the agGrid
	Then Options is displayed in added filter info
	| Values                |
	| <operatorValueInInfo> |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

Examples: 
	| operatorValue  | filterOption | rowsCount | operatorValueInInfo |
	| Equals         | 22 Nov 2012  | 16        | is                  |
	| Does not equal | 22 Nov 2012  | 17,209    | is not              |
	| Before         | 22 Nov 2012  | 1         | is before           |
	| After          | 14 May 2012  | 16        | is after            |
	| Empty          |              | 17,208    | is empty            |
	| Not empty      |              | 17        | is not empty        |

@Evergreen @Users @Evergreen_FiltersFeature @FiltersDisplay @DAS-10696
Scenario Outline: EvergreenJnr_UsersList_Check that filter Operators is correct in filter info (Enabled)
	When User clicks "Users" on the left-hand menu
	Then "Users" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Enabled" filter
	When User have created "<operatorValue>" filter with column and following options:
	| SelectedCheckboxes |
	| <filterOption>     |
	Then "Enabled" filter is added to the list
	Then "<rowsCount>" rows are displayed in the agGrid
	Then Options is displayed in added filter info
	| Values                |
	| <operatorValueInInfo> |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

Examples: 
	| operatorValue  | filterOption | rowsCount | operatorValueInInfo |
	| Equals         | TRUE         | 41,228    | is                  |
	| Does not equal | TRUE         | 107       | is not              |

@Evergreen @Applications @Evergreen_FiltersFeature @FiltersDisplay @DAS-10696 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_Check that Applications filter is working correct
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Columns button
	Then Columns panel is displayed to the user
	When ColumnName is entered into the search box and the selection is clicked
	| ColumnName      |
	| Application Key |
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application (Saved List)" filter
	When User have created "Equals" filter with SelectedList list and following Association:
	| SelectedList | Association        |
	| TestList     | Not used on device |
	Then "Application" filter is added to the list
	Then "17,095" rows are displayed in the agGrid
	Then Options is displayed in added filter info
	| Values  |
	| in list |

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-10696
Scenario: EvergreenJnr_DevicesList_Check that Applications filter is contains all expected associations
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application (Saved List)" filter
	Then Associations is displayed in the filter
	| Associations                   |
	| Used on device                 |
	| Entitled to device             |
	| Installed on device            |
	| Used by device's owner         |
	| Entitled to device's owner     |
	| Not used on device             |
	| Not entitled to device         |
	| Not installed on device        |
	| Not used by device's owner     |
	| Not entitled to device's owner |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS-11142 @Delete_Newly_Created_List
Scenario: EvergreenJnr_ApplicationsList_Check that brackets are displayed correctly in filter info
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application" filter
	And User have create "Equals" Values filter with column and following options:
	| Values                                    |
	| wxPython 2.5.3.1 (unicode) for Python 2.3 |
	Then "Application" filter is added to the list
	When user select "Application" filter
	And User have create "Equals" Values filter with column and following options:
	| Values                                               |
	| Windows Installer SDK (Version 2.0) (3718.1)         |
	| Janus Systems Controls for Microsoft .NET (TRIAL)    |
	| NI LabVIEW PID Control Toolset 6.0 (for LabVIEW 7.1) |
	Then "Application" filter is added to the list
	When user select "Application" filter
	And User have create "Equals" Values filter with column and following options:
	| Values                                      |
	| Application contains (Version 6.0) (3672.1) |
	Then "Application" filter is added to the list
	When user select "Application" filter
	And User have create "Equals" Values filter with column and following options:
	| Values                              |
	| Application begins with ((((test))) |
	Then "Application" filter is added to the list
	When User create custom list with "TestList" name
	Then "TestList" list is displayed to user
	And "4" rows are displayed in the agGrid
	When User navigates to the "All Applications" list
	Then "Applications" list should be displayed to the user
	When User navigates to the "TestList" list
	And User clicks the Filters button
	Then "TestList" list is displayed to user
	And "4" rows are displayed in the agGrid
	And Edit List menu is not displayed
	And Values is displayed in added filter info
	| Values                                                                                          |
	| wxPython 2.5.3.1 (unicode) for Python 2.3                                                       |
	| Windows Installer SDK (Version 2.0) (3718.1), Janus Systems Controls for Microsoft .NET (TRIAL) |
	| NI LabVIEW PID Control Toolset 6.0 (for LabVIEW 7.1)                                            |
	| Application contains (Version 6.0) (3672.1)                                                     |
	| Application begins with ((((test)))                                                             |

@Evergreen @Mailboxes @Evergreen_FiltersFeature @FiltersDisplay @DAS-11351
Scenario: EvergreenJnr_MailboxesList_Check that 'Add column' option as available for "Owner Department" filter
	When User clicks "Mailboxes" on the left-hand menu
	Then "Mailboxes" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Owner Department" filter
	Then checkboxes are displayed to the User:
	| SelectedCheckboxes                    |
	| Add Owner Department Name column      |
	| Add Owner Department Full Path column |
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS-11087
Scenario: EvergreenJnr_DevicesList_Check that Date and Time filters with "Equals" Values are working correctly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Date & Time Task" filter
	And User have create "Equals" Values filter with column and following options:
	| Values      |
	| 22 Nov 2012 |
	Then "Windows7Mi: Date & Time Task" filter is added to the list
	Then "16" rows are displayed in the agGrid
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS-11087
Scenario: EvergreenJnr_DevicesList_Check that Date and Time filters with "Does not equal" Values are working correctly
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Windows7Mi: Date & Time Task" filter
	And User have create "Does not equal" Values filter with column and following options:
	| Values      |
	| 22 Nov 2012 |
	Then "Windows7Mi: Date & Time Task" filter is added to the list
	Then "17,209" rows are displayed in the agGrid
	When User clicks the Logout button
	Then Signed Out page is displayed to the user
	And User is logged out

@Evergreen @Devices @Evergreen_FiltersFeature @FiltersDisplay @DAS-11187
Scenario Outline: EvergreenJnr_DevicesList_Check that Custom Filters are contains all expected associations
	When User clicks "Devices" on the left-hand menu
	Then "Devices" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "<FilterName>" filter
	Then Associations is displayed in the filter
	| Associations                   |
	| Used on device                 |
	| Entitled to device             |
	| Installed on device            |
	| Used by device's owner         |
	| Entitled to device's owner     |
	| Not used on device             |
	| Not entitled to device         |
	| Not installed on device        |
	| Not used by device's owner     |
	| Not entitled to device's owner |

Examples: 
	| FilterName                  |
	| App field 1                 |
	| App field 2                 |
	| Application Owner           |
	| Computer Field 1            |
	| Computer Field 2            |
	| Computer Warranty           |
	| ComputerCustomField         |
	| DAS-1814                    |
	| End of Life Date            |
	| Friendly Model Name         |
	| General information field 1 |
	| General information field 2 |
	| General information field 3 |
	| General information field 4 |
	| General information field 5 |
	| Mailbox Filter 1            |
	| Mailbox Filter 2            |
	| Telephone                   |
	| User Field 1                |
	| User Field 2                |
	| Zip Code                    |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS-11165
Scenario: EvergreenJnr_ApplicationsList_Check that '500 error' is not displayed for "DirectX SDK (Version 8.1) (3663.0)" filter
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application" filter
	And User have create "Equals" Values filter with column and following options:
	| Values                             |
	| DirectX SDK (Version 8.1) (3663.0) |
	Then "Application" filter is added to the list
	And Values is displayed in added filter info
	| Values                             |
	| DirectX SDK (Version 8.1) (3663.0) |

@Evergreen @Applications @EvergreenJnr_FiltersFeature @FilterFunctionality @DAS-11165
Scenario: EvergreenJnr_ApplicationsList_Check that '500 error' is not displayed for ""WPF/E" (codename) Community Technology Preview (Feb 2007)" filter
	When User clicks "Applications" on the left-hand menu
	Then "Applications" list should be displayed to the user
	When User clicks the Filters button
	Then Filters panel is displayed to the user
	When user select "Application" filter
	And User have create "Equals" Values filter with column and following options:
	| Values                                                     |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |
	Then "Application" filter is added to the list
	And Values is displayed in added filter info
	| Values                                                     |
	| "WPF/E" (codename) Community Technology Preview (Feb 2007) |