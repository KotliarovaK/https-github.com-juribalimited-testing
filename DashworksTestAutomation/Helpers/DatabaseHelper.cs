using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.Evergreen.Admin.Bucket;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Helpers
{
    internal class DatabaseHelper
    {
        private static readonly string _connectionString = Database.ConnectionsString;

        public static void ExecuteQuery(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = query,
                Connection = sqlConnection
            };

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        /// <summary>
        ///     columnIndex starts from 0.
        ///     columnIndex is the index of the column
        ///     [0] is the index of the row
        ///     Usage: DatabaseWorker.ExecuteReader(dbName.ECA_database, query, 0)[0]
        ///     To get data from the last row just use '.LastOrDefault()' instead of [0] index
        /// </summary>
        /// <returns></returns>
        public static List<string> ExecuteReader(string query, int columnIndex)
        {
            var results = ExecuteReaderWithoutZeroResultCheck(query, columnIndex);

            if (results.Any())
                return results;
            throw new Exception("Database query returns zero results");
        }

        public static List<string> ExecuteReaderWithoutZeroResultCheck(string query, int columnIndex)
        {
            SqlConnection sqlConnection1 = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(reader);

            sqlConnection1.Close();

            return dt.AsEnumerable().ToList().Select(row => row[columnIndex].ToString()).ToList();
        }

        public static DataTable ExecuteReaderWithoutZeroResultCheck(string query)
        {
            SqlConnection sqlConnection1 = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(reader);

            sqlConnection1.Close();

            return dt;
        }

        public static void RemoveLists(List<string> listsIds)
        {
            foreach (string id in listsIds)
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[API].[List_Remove]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ListId", id);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
        }

        #region User

        /// <summary>
        ///     Get user login name by his full name
        /// </summary>
        /// <param name="fullName">[FullName] from [DesktopBI].[dbo].[UserProfiles] database</param>
        /// <returns></returns>
        public static string GetUserNameByFullName(string fullName)
        {
            var userName = DatabaseHelper.ExecuteReader(
                $"select u.LoweredUserName from[aspnetdb].[dbo].[aspnet_Users] u join[DesktopBI].[dbo].[UserProfiles] up on up.UserId = u.UserId where up.FullName = '{fullName}'",
                0)[0];
            return userName;
        }

        /// <summary>
        ///     Get user full name by his login
        /// </summary>
        /// <param name="name">User login on website</param>
        /// <returns></returns>
        public static string GetUserFullNameByName(string name)
        {
            var fullName = DatabaseHelper.ExecuteReader(
                $"select up.FullName from[aspnetdb].[dbo].[aspnet_Users] u join [DesktopBI].[dbo].[UserProfiles] up on up.UserId = u.UserId where u.LoweredUserName = '{name}'",
                0)[0];
            return fullName;
        }

        /// <summary>
        ///     Get user ID by his login
        /// </summary>
        /// <param name="name">User login on website</param>
        /// <returns></returns>
        public static string GetUserIdByLogin(string name)
        {
            var userId =
                DatabaseHelper.ExecuteReader(
                    $"select [UserId] from[aspnetdb].[dbo].[aspnet_Users] where [LoweredUserName] = '{name}'",
                    0)[0];
            return userId;
        }

        #endregion

        #region Item Details - All lists: Devices, Users, Applications, Mailboxes

        public static string GetDeviceDetailsIdByName(string name)
        {
            var id =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [ComputerKey] FROM [DesktopBI].[dbo].[DimComputer] WHERE [Hostname] = '{name}'",
                    0).LastOrDefault();
            return id;
        }

        #region Application

        public static string GetApplicationDetailsIdByName(string name)
        {
            var id =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [PackageKey] FROM [DesktopBI].[dbo].[DimPackage] WHERE [PackageName] = '{name}'",
                    0).LastOrDefault();
            return id;
        }

        //First is [OwnerUser] and second is [OwnerUserDirectoryObjectKey]
        public static List<string> GetApplicationOwnedUser(string applicationId)
        {
            List<string> result = new List<string>();
            var query =
                $"SELECT [OwnerUser],[OwnerUserDirectoryObjectKey] FROM [DesktopBI].[dbo].[DimPackage] WHERE [PackageKey] = {applicationId}";
            result.Add(DatabaseHelper.ExecuteReader(query, 0)[0]);
            result.Add(DatabaseHelper.ExecuteReader(query, 1)[0]);
            return result;
        }

        public static void SetApplicationOwnedUser(ApplicationOwnedUserDto aou)
        {
            DatabaseHelper.ExecuteQuery(
                $"UPDATE [DesktopBI].[dbo].[DimPackage] SET [OwnerUser] = '{aou.OwnerUser}' ,[OwnerUserDirectoryObjectKey] = {aou.OwnerUserDirectoryObjectKey} WHERE PackageKey = {aou.PackageKey}");
        }

        #endregion

        public static string GetMailboxDetailsIdByName(string name)
        {
            var id =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [MailboxKey] FROM [DesktopBI].[dbo].[DimMailbox] WHERE [PrincipalEmailAddress] = '{name}'",
                    0).LastOrDefault();
            return id;
        }

        #region User Details

        public static string GetUserDetailsIdByName(string name)
        {
            var id =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [ObjectKey] FROM [DesktopBI].[dbo].[DimDirectoryObject] WHERE [Username] = '{name}'",
                    0).LastOrDefault();
            return id;
        }

        public static string GetUserDisplayName(string name)
        {
            var id =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [DisplayName] FROM [DesktopBI].[dbo].[DimDirectoryObject] where [Username] = '{name}'",
                    0).LastOrDefault();
            return id;
        }

        #endregion

        #endregion

        #region CapacityUnits

        public static CapacityUnitDto GetCapacityUnit(string name)
        {
            return GetCapacityUnitFromDb(name);
        }

        public static CapacityUnitDto GetCapacityUnit(string name, string projectName)
        {
            return GetCapacityUnitFromDb(name, projectName);
        }

        //Null for Evergreen projects
        private static CapacityUnitDto GetCapacityUnitFromDb(string name, string projectName = "")
        {
            string query = string.IsNullOrEmpty(projectName)
                ? $"select [UnitId], [UnitName], [UnitDescription], [IsDefault], [ProjectID] from [PM].[dbo].[CapacityUnits] where UnitName='{name}' and [ProjectID] is NULL"
                : $"select [UnitId], [UnitName], [UnitDescription], [IsDefault], [ProjectID] from [PM].[dbo].[CapacityUnits] where UnitName='{name}' and [ProjectId] = {GetProjectId(projectName)}";

            var dataTable = DatabaseHelper
                .ExecuteReaderWithoutZeroResultCheck(query);

            if (dataTable.Rows.Count < 1)
                throw new Exception($"Unable to find Capacity Unit with name {name} in the Database");

            var cu = new CapacityUnitDto(dataTable.Rows[0][0].ToString())
            {
                Name = dataTable.Rows[0][1].ToString(),
                Description = dataTable.Rows[0][2].ToString(),
                IsDefault = bool.Parse(dataTable.Rows[0][3].ToString())
            };
            return cu;
        }

        #endregion

        #region Teams

        public static TeamDto GetTeam(string name)
        {
            var dataTable = DatabaseHelper
                .ExecuteReaderWithoutZeroResultCheck(
                    $"select [TeamID],[TeamName],[TeamShortDescription],[IsDefault] from [PM].[dbo].[Teams] where [TeamName] = '{name}'");

            if (dataTable.Rows.Count < 1)
                throw new Exception($"Unable to find Team with '{name}' name");

            var team = new TeamDto(dataTable.Rows[0][0].ToString())
            {
                TeamName = dataTable.Rows[0][1].ToString(),
                Description = dataTable.Rows[0][2].ToString(),
                IsDefault = bool.Parse(dataTable.Rows[0][3].ToString())
            };
            return team;
        }

        public static TeamDto GetTeamById(string id)
        {
            var dataTable = DatabaseHelper
                .ExecuteReaderWithoutZeroResultCheck(
                    $"select [TeamName],[TeamShortDescription],[IsDefault] from [PM].[dbo].[Teams] where [TeamID] = {id}");

            if (dataTable.Rows.Count < 1)
                throw new Exception($"Unable to find Team with {id} id");

            var team = new TeamDto(id)
            {
                TeamName = dataTable.Rows[0][0].ToString(),
                Description = dataTable.Rows[0][1].ToString(),
                IsDefault = bool.Parse(dataTable.Rows[0][2].ToString())
            };
            return team;
        }

        public static void UnlinkTeamWithBucket(string teamName)
        {
            try
            {
                var groupIds = DatabaseHelper.ExecuteReader(
                    $"select GroupID from[PM].[dbo].[ProjectGroups] buckets join[PM].[dbo].[Teams] teams on buckets.OwnedByTeamID = teams.TeamID where teams.TeamName = '{teamName}'",
                    0);

                foreach (var groupId in groupIds)
                {
                    DatabaseHelper.ExecuteQuery(
                        $"update [PM].[dbo].[ProjectGroups] set OwnedByTeamID = null where GroupID = '{groupId}'");
                }
            }
            catch (Exception e)
            {
                Logger.Write($"Some issues appears during Team Unlinking: {e}");
            }
        }

        #endregion

        #region Rings

        public static RingDto GetRing(string name)
        {
            return GetRingFromDb(name);
        }

        public static RingDto GetRing(string name, string projectName)
        {
            return GetRingFromDb(name, projectName);
        }

        //Null for Evergreen projects
        private static RingDto GetRingFromDb(string name, string projectName = "")
        {
            string query = string.IsNullOrEmpty(projectName)
                ? $"select [RingId],[RingName],[RingDescription],[IsDefault] from [PM].[dbo].[Rings] where [ProjectId] is NULL and [RingName] = '{name}'"
                : $"select [RingId],[RingName],[RingDescription],[IsDefault] from [PM].[dbo].[Rings] where [ProjectId] = {GetProjectId(projectName)} and [RingName] = '{name}'";

            var dataTable = DatabaseHelper
                .ExecuteReaderWithoutZeroResultCheck(query);

            if (dataTable.Rows.Count < 1)
                throw new Exception($"Unable to find Ring with name {name} in the Database");

            var ring = new RingDto(dataTable.Rows[0][0].ToString())
            {
                Name = dataTable.Rows[0][1].ToString(),
                Description = dataTable.Rows[0][2].ToString(),
                IsDefault = bool.Parse(dataTable.Rows[0][3].ToString())
            };
            return ring;
        }

        #endregion

        #region Buckets

        public static BucketDto GetBucket(string name)
        {
            return GetBucketFromDb(name);
        }

        public static BucketDto GetBucket(string name, string projectName)
        {
            return GetBucketFromDb(name, projectName);
        }

        //Null for Evergreen projects
        private static BucketDto GetBucketFromDb(string name, string projectName = "")
        {
            string query = string.IsNullOrEmpty(projectName)
                ? $"select [GroupID],[GroupName],[IsEvergreenDefault],[OwnedByTeamID] from [PM].[dbo].[ProjectGroups] where [ProjectID] is NULL and [GroupName] = '{name}'"
                : $"select [GroupID],[GroupName],[IsEvergreenDefault],[OwnedByTeamID] from [PM].[dbo].[ProjectGroups] where [ProjectId] = {GetProjectId(projectName)} and [GroupName] = '{name}'";

            var dataTable = DatabaseHelper
                .ExecuteReaderWithoutZeroResultCheck(query);

            if (dataTable.Rows.Count < 1)
                throw new Exception($"Unable to find Bucket with name {name} in the Database");

            var ring = new BucketDto(dataTable.Rows[0][0].ToString())
            {
                Name = dataTable.Rows[0][1].ToString(),
                IsDefault = bool.Parse(dataTable.Rows[0][2].ToString()),
                Team = GetTeamById(dataTable.Rows[0][3].ToString())
            };
            return ring;
        }

        #endregion

        #region Projects

        public static string GetProjectId(string projectName)
        {
            var projectId =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [ProjectID] FROM [PM].[dbo].[Projects] where [ProjectName] = '{projectName}' AND [IsDeleted] = 0",
                    0).LastOrDefault();
            return projectId;
        }

        public static string GetProjectName(string projectId)
        {
            var projectName =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [ProjectName] FROM [PM].[dbo].[Projects] where [ProjectID] = {projectId} AND [IsDeleted] = 0",
                    0).LastOrDefault();
            return projectName;
        }

        public static string GetProjectListIdScope(string listName)
        {
            //string userId =
            //    DatabaseHelper.ExecuteReader(
            //        $"SELECT [aspnetdb].[dbo].[aspnet_Users].[UserId] FROM[aspnetdb].[dbo].[aspnet_Users] where UserName = '{_user.UserName}'", 0).LastOrDefault();

            return DatabaseHelper.ExecuteReader(
                $"select [ListId] from [DesktopBI].[dbo].[EvergreenList] where [ListName]='{listName}'", 0).LastOrDefault();
        }

        #endregion

        #region Task

        public static string GetTaskId(TaskPropertiesDto task)
        {
            var query =
                $"select ptl.TaskId from [PM].[dbo].[ProjectTaskLanguage] as ptl join[PM].[dbo].[ProjectTasks] as pt on ptl.TaskId = pt.TaskID where pt.ProjectID = {task.ProjectId} and ptl.[TaskName] = '{task.Name}'";
            var taskId =
                DatabaseHelper.ExecuteReader(query, 0).LastOrDefault();
            return taskId;
        }

        public static void DeleteTask(TaskPropertiesDto task)
        {
            DeleteTaskFromDb(task.Id);
        }

        private static void DeleteTaskFromDb(string taskId)
        {
            DatabaseHelper.ExecuteQuery($"delete from [PM].[dbo].[ProjectTaskLanguage] where [TaskID] = {taskId}");
            DatabaseHelper.ExecuteQuery($"delete from [PM].[dbo].[ProjectTasks] where [TaskID] = {taskId}");
        }

        #endregion

        #region Stage

        public static void DeleteStageFromDb(string stageName, string projectId)
        {
            DatabaseHelper.ExecuteQuery($"Delete from [PM].[dbo].[ProjectStages] where [StageName] = '{stageName}' AND [ProjectID] = {projectId}");
        }

        //TODO try to avoid usage of this method
        public static void DeleteStageFromDb(string stageName)
        {
            DatabaseHelper.ExecuteQuery($"Delete from [PM].[dbo].[ProjectStages] where [StageName] = '{stageName}'");
        }

        #endregion

        #region User

        public static string GetUserId(string name)
        {
            var userId =
                DatabaseHelper.ExecuteReader(
                    $"select [UserId] from [aspnetdb].[dbo].[aspnet_Users] where [LoweredUserName] = '{name}'",
                    0)[0];
            return userId;
        }

        public static string GetUserIdByFullName(string fullName)
        {
            var userId =
                DatabaseHelper.ExecuteReader(
                    $"select [UserId] from [DesktopBI].[dbo].[UserProfiles] where [FullName] = '{fullName}'",
                    0)[0];
            return userId;
        }

        public static string GetFullNameByUserName(string userName)
        {
            var fullName = DatabaseHelper.ExecuteReader(
                $"select up.FullName from [DesktopBI].[dbo].[UserProfiles] up join [aspnetdb].[dbo].[aspnet_Users] u on up.UserId = u.UserId where u.LoweredUserName = '{userName}'",
                0)[0];
            return fullName;
        }

        public static void DeleteUser(UserDto user)
        {
            DatabaseHelper.ExecuteQuery($"delete from [aspnetdb].[dbo].[aspnet_UsersInRoles] where [UserId] = '{user.Id}'");
            DatabaseHelper.ExecuteQuery($"delete from [aspnetdb].[dbo].[aspnet_Membership] where [UserId] = '{user.Id}'");
            DatabaseHelper.ExecuteQuery($"delete from [aspnetdb].[dbo].[aspnet_Users] where [UserName] = '{user.Username}'");
        }

        #endregion

        #region ReauestType

        public static string GetRequestTypeId(string name, string projectId)
        {
            var query =
                $"select rtl.[RequestTypeId] from [PM].[dbo].[RequestTypeLanguage] as rtl join[PM].[dbo].[RequestTypes] as rt on rtl.RequestTypeId = rt.RequestTypeId where rtl.RequestType = '{name}' and rt.ProjectId = {projectId}";
            var userId = DatabaseHelper.ExecuteReader(query, 0)[0];
            return userId;
        }

        #endregion

        #region Slot

        public static string GetSlotId(string name, string projectId)
        {
            var query =
                $"select [SlotId] from [PM].[dbo].[CapacitySlots] where [SlotName] = '{name}' and [ProjectId] = {projectId}";
            var userId = DatabaseHelper.ExecuteReader(query, 0)[0];
            return userId;
        }

        public static string GetSlotId(string name)
        {
            try
            {
                var query =
                    $"select [SlotId] from [PM].[dbo].[CapacitySlots] where [SlotName] = '{name}'";
                var queryResult = ExecuteReader(query, 0);
                //Get ID if just one Slot with such name. In other case we need ProjectName to get Slot ID
                return queryResult.Count == 1 ? queryResult.First() : null;
            }
            catch
            {
                return null;
            }
        }

        public static string GetSlotProjectId(string slotId)
        {
            var query =
                $"select [ProjectId] from [PM].[dbo].[CapacitySlots] where [SlotId] = {slotId}";
            var userId = DatabaseHelper.ExecuteReader(query, 0)[0];
            return userId;
        }

        #endregion

        #region Custom Field

        public static string GetCustomFieldId(string name)
        {
            string query = $"SELECT [CustomFieldID] FROM [DesktopBI].[dbo].[CustomFields] where Label = '{name}'";
            var id = DatabaseHelper.ExecuteReader(query, 0)[0];
            return id;
        }

        public static void DeleteCustomField(string id)
        {
            DatabaseHelper.ExecuteQuery($"delete from [DesktopBI].[dbo].[CustomFields] where [CustomFieldID] = {id}");
        }

        #endregion

        #region Automation

        public static string GetAutomationId(string name)
        {
            return DatabaseHelper.ExecuteReader($"select [AutomationId] from [PM].[dbo].[Automations] where [AutomationName] = '{name}'", 0)[0];
        }

        public static string GetAutomationActionId(string actionName, string id)
        {
            return DatabaseHelper.ExecuteReader($"select [ActionId] from [PM].[dbo].[AutomationActions] where [AutomationId] = {id} and [ActionName] = '{actionName}'", 0)[0];
        }

        public static List<string> GetAutomationActions(string actionName)
        {
            return DatabaseHelper.ExecuteReader($"select [ActionId] from [PM].[dbo].[AutomationActions] where [ActionName] = '{actionName}'", 0);
        }

        public static string GetAutomationIdByActionId(string actionId)
        {
            return DatabaseHelper.ExecuteReader($"select [AutomationId] from [PM].[dbo].[AutomationActions] where [ActionId] = '{actionId}'", 0)[0];
        }

        public static bool IsAutomationRunFinishedSuccess(string automationId)
        {
            return Convert.ToInt32(DatabaseHelper.ExecuteReader($"select count(*) from [PM].[dbo].[AutomationLog] as al join[PM].[dbo].[AutomationLogOutcomes] as alo on al.OutcomeId = alo.OutcomeId join[PM].[dbo].[AutomationLogTypes] as alt on al.LogTypeId = alt.LogTypeId where alo.Outcome = 'Success' and alt.LogType = 'Action Finish' and al.AutomationId = {automationId}", 0)[0]) > 0;
        }

        public static bool IsAutomationRunFinished(string automation, DateTime dateTime)
        {
            try
            {
                var time = dateTime.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.fff");
                var result = Convert.ToInt32(ExecuteReader($"SELECT [LogId] FROM [PM].[dbo].[AutomationLog] WHERE [AutomationName] = '{automation}' AND [LogDate] >= Convert(datetime, '{time}')  AND [LogTypeId] = 2", 0)[0]) > 0;
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsAutomationActionRunFinished(string automation, string action, DateTime dateTime)
        {
            try
            {
                var time = dateTime.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.fff");
                var result = Convert.ToInt32(ExecuteReader($"SELECT [LogId] FROM [PM].[dbo].[AutomationLog] WHERE [AutomationName] = '{automation}' AND [ActionName] = '{action}' AND [LogDate] >= Convert(datetime, '{time}')  AND [LogTypeId] = 4", 0)[0]) > 0;
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetAutomationActiveStatus(string automation)
        {
            return DatabaseHelper.ExecuteReader($"select [Active] from [PM].[dbo].[Automations] WHERE [AutomationName] = '{automation}'", 0)[0];
        }

        #endregion

        #region Readiness

        public static string GetReadinessId(string readinessName, int projectId)
        {
            try
            {
                return DatabaseHelper.ExecuteReader($"select [RAGStatusId] from [PM].[dbo].[RAGStatus] where [ProjectId] = {projectId} and [RAGStatus] = '{readinessName}'", 0)[0];
            }
            catch (Exception e)
            {
                throw new Exception("GetReadinessId returned no results", e);
            }
        }

        public static List<string> GetProjectReadinessesIds(int projectId)
        {
            try
            {
                return DatabaseHelper.ExecuteReader($"select [RAGStatusId] from [PM].[dbo].[RAGStatus] where [ProjectId] = {projectId}", 0);
            }
            catch (Exception e)
            {
                throw new Exception("GetProjectReadinessesIds returned no results", e);
            }
        }

        public static string GetProjectDefaultReadinessId(int projectId)
        {
            return DatabaseHelper.ExecuteReader($"SELECT [DefaultPkgOnboardRagStatusID] FROM [PM].[dbo].[Projects] WHERE [ProjectID] = {projectId}", 0)[0];
        }

        public static void SetProjectDefaultReadinessId(int projectId, int readinessId)
        {
            DatabaseHelper.ExecuteQuery($"UPDATE [PM].[dbo].[Projects] SET [DefaultPkgOnboardRagStatusID] = {readinessId} WHERE  [ProjectID] = {projectId}");
        }

        #endregion

        #region Dashboard

        public static string GetDashboardId(string dashboardName, string userId)
        {
            try
            {
                return DatabaseHelper.ExecuteReader($"SELECT [DashboardId] FROM [DesktopBI].[dbo].[EvergreenDashboards] where [DashboardName] = '{dashboardName}' AND [UserId] = '{userId}'", 0)[0];
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to get '{dashboardName}' Dashboard name for '{userId}' user", e);
            }
        }

        #endregion

        #region Self Service

        public static string GetSelfServiceId(string selfServiceName, string createdBy)
        {
            string query = $"SELECT [SelfServiceId] FROM [PM].[SS].[SelfService] WHERE [Name] = {selfServiceName} AND [CreatedBy] = {createdBy}";
            var selfServiceId = DatabaseHelper.ExecuteReader(query, 0)[0];
            return selfServiceId;
        }

        public static string GetSelfServiceId(string selfServiceName)
        {
            string query = $"SELECT [SelfServiceId] FROM [PM].[SS].[SelfService] WHERE [Name] = {selfServiceName}";
            var selfServiceId = DatabaseHelper.ExecuteReader(query, 0)[0];
            return selfServiceId;
        }

        public static string GetSelfServiceIdByIdentifier(string identifier)
        {
            string query = $"SELECT [SelfServiceId] from [PM].[SS].[SelfService] where [SelfServiceIdentifier] = '{identifier}'";
            var selfServiceId = DatabaseHelper.ExecuteReader(query, 0)[0];
            return selfServiceId;
        }

        //ListID - Id of the list used in Scope for created Self Service
        public static string GetSelfServiceObjectGuid(string selfServiceIdentifier, int componentId)
        {
            string query = $"declare @SelfServiceIdentifier nvarchar(100) = '{selfServiceIdentifier}' declare @ComponentId int = {componentId} declare @ProjectId int declare @ListId int select @ProjectId = ProjectId from[PM].[SS].[OwnershipComponent] where ComponentId = @ComponentId select @ListId = ListId from[PM].[SS].[SelfService] where SelfServiceIdentifier = @SelfServiceIdentifier select EO.ObjectGuid from DesktopBI.dbo.EvergreenObjects EO join[PM].[API].[ApplicationListItems_Get](@ListId, DEFAULT) LI on LI.ApplicationKey = EO.ObjectKey and EO.ObjectTypeID = 3 join[PM].[dbo].[ProjectObjects] PO on PO.ObjectKey = EO.ObjectKey and PO.ObjectTypeID = EO.ObjectTypeID and PO.ProjectId = @ProjectId where EO.ObjectTypeId = 3";
            
            var guid = DatabaseHelper.ExecuteReader(query, 0)[0];
            return guid;
        }

        #region Builder

        public static int GetSelfServicePageId(SelfServicePageDto page)
        {
            string query = $"SELECT [PageId]  FROM [PM].[SS].[SelfServicePage] WHERE [Name] = '{page.Name}' AND [SelfServiceId] = '{page.ServiceId}'";
            var selfServiceId = DatabaseHelper.ExecuteReader(query, 0)[0];
            return int.Parse(selfServiceId);
        }

        #endregion

        #endregion
    }
}