Feature: CapacitySlotsPart10
	Runs Capacity related tests on Admin page

Background: Pre-Conditions
	Given User is logged in to the Evergreen
	Then Evergreen Dashboards page should be displayed to the user

@Evergreen @Admin @EvergreenJnr_AdminPage @Capacity @Slots @DAS17091 @Cleanup
Scenario: EvergreenJnr_AdminPage_CheckPaginationDisplayingForCapacityUnitAutocomplete
	When Project created via API and opened
	| ProjectName        | Scope       | ProjectTemplate | Mode               |
	| ProjectForDAS17091 | All Devices | None            | Standalone Project |
	When User creates new Capacity Unit via api
	| Name           | Description | IsDefault | Project            |
	| cu_DAS17091_1  | DAS17091_1  | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_2  | DAS17091_2  | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_3  | DAS17091_3  | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_4  | DAS17091_4  | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_5  | DAS17091_5  | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_6  | DAS17091_6  | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_7  | DAS17091_7  | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_8  | DAS17091_8  | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_9  | DAS17091_9  | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_10 | DAS17091_10 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_11 | DAS17091_11 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_12 | DAS17091_12 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_13 | DAS17091_13 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_14 | DAS17091_14 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_15 | DAS17091_15 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_16 | DAS17091_16 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_17 | DAS17091_17 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_18 | DAS17091_18 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_19 | DAS17091_19 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_20 | DAS17091_20 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_21 | DAS17091_21 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_22 | DAS17091_22 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_23 | DAS17091_23 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_24 | DAS17091_24 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_25 | DAS17091_25 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_26 | DAS17091_26 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_27 | DAS17091_27 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_28 | DAS17091_28 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_29 | DAS17091_29 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_30 | DAS17091_30 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_31 | DAS17091_31 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_32 | DAS17091_32 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_33 | DAS17091_33 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_34 | DAS17091_34 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_35 | DAS17091_35 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_36 | DAS17091_36 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_37 | DAS17091_37 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_38 | DAS17091_38 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_39 | DAS17091_39 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_40 | DAS17091_40 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_41 | DAS17091_41 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_42 | DAS17091_42 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_43 | DAS17091_43 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_44 | DAS17091_44 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_45 | DAS17091_45 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_46 | DAS17091_46 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_47 | DAS17091_47 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_48 | DAS17091_48 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_49 | DAS17091_49 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_50 | DAS17091_50 | FALSE     | ProjectForDAS17091 |
	| cu_DAS17091_51 | DAS17091_51 | FALSE     | ProjectForDAS17091 |
	When User navigates to "ProjectForDAS17091" project details
	When User navigates to the 'Capacity' left menu item
	When User navigates to the 'Slots' left menu item
	When User clicks 'CREATE SLOT' button 
	When User expands 'Capacity Units' autocomplete
	Then '50' of all shown label is displayed in expanded autocomplete

	
