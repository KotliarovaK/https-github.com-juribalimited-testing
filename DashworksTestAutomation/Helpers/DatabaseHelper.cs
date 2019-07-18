﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using DashworksTestAutomation.DTO.Evergreen.Admin.Bucket;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.Projects;
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

        public static string GetTaskId(string name, string projectName)
        {
            var projId = GetProjectId(projectName);
            var projectId =
                DatabaseHelper.ExecuteReader(
                    $"select ptl.TaskId from [PM].[dbo].[ProjectTaskLanguage] as ptl join[PM].[dbo].[ProjectTasks] as pt on ptl.TaskId = pt.TaskID where pt.ProjectID = {projId} and ptl.[TaskName] = '{name}'",
                    0).LastOrDefault();
            return projectId;
        }

        public static void DeleteTask(TaskPropertiesDto task, string project)
        {
            DeleteTaskFromDb(task.GetId(project));
        }

        public static void DeleteTask(string name, string project)
        {
            var taskId = GetTaskId(name, project);
            DeleteTaskFromDb(taskId);
        }

        private static void DeleteTaskFromDb(string taskId)
        {
            DatabaseHelper.ExecuteQuery($"delete from [PM].[dbo].[ProjectTaskLanguage] where [TaskID] = {taskId}");
            DatabaseHelper.ExecuteQuery($"delete from [PM].[dbo].[ProjectTasks] where [TaskID] = {taskId}");
        }

        #endregion
    }
}