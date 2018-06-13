﻿using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class TaskProperties_DetailsDto
    {
        public ValueTypeUpdateEnum ValueType;
        public bool TaskHaADueDate { get; set; }
        public DateModeEnum DateMode;
        public TaskProjectRoleEnum TaskProjectRole;
        public bool TaskImpactsReadiness { get; set; }
        public bool TaskHasAnOwner { get; set; }
        public bool ShowDetails { get; set; }
        public bool ProjectObject { get; set; }
        public bool BulkUpdate { get; set; }
        public bool SelfService { get; set; }


        public TaskProperties_DetailsDto()
        {
            ValueType = ValueTypeUpdateEnum.Radiobutton;
            TaskProjectRole = EnumExtensions.GetRandomValue<TaskProjectRoleEnum>();
            DateMode = DateModeEnum.DateOnly;
        }
    }

    public enum ValueTypeUpdateEnum
    {
        Radiobutton,
        DropDownList,
        Date,
        Text
    }

    public enum DateModeEnum
    {
        [Description("Date Only")]
        DateOnly,
        [Description("Date & Time")]
        DateTime
    }

    public enum TaskProjectRoleEnum
    {
        [Description("Email Notifications (User)")]
        EmailNotificationsUser,
        [Description("Self Service Applications List Completed (User mode)")]
        SelfServiceApplicationsListCompletedUserMode,
        [Description("Self Service Applications List Enabled (User mode)")]
        SelfServiceApplicationsListEnabledUserMode,
        [Description("Self Service Computer Ownership Completed (User mode)")]
        SelfServiceComputerOwnershipCompletedUserMode,
        [Description("Self Service Applications List Enabled (User mode)")]
        SelfServiceComputerOwnershipEnabledUserMode,
        [Description("Self Service Department & Location Completed (User mode)")]
        SelfServiceDepartmentLocationCompletedUserMode,
        [Description("Self Service Department & Location Enabled (User mode)")]
        SelfServiceDepartmentLocationEnabledUserMode
    }
}