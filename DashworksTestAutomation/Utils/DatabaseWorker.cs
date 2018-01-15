using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.Utils
{
    class DatabaseWorker
    {
        /// <summary>
        /// Update user profile language
        /// </summary>
        /// <param name="userName">User login on website</param>
        /// <param name="languag">[alias] from sys.syslanguages</param>
        public static void ChangeUserProfileLanguage(string userName, string languag)
        {
            var userFullName = GetUserFullNameByName(userName);
            var langId = DatabaseHelper.ExecuteReader($"select langid from sys.syslanguages where alias = '{languag}'", 0)[0];

            DatabaseHelper.ExecuteQuery($"update [DesktopBI].[dbo].[UserProfiles] set [UserLanguageId] = {langId} where FullName = '{userFullName}'");
        }

        /// <summary>
        /// Get user login name by his full name
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
        /// Get user full name by his login
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
    }
}
