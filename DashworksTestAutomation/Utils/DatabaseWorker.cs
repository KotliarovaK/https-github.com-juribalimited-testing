using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.Utils
{
    class DatabaseWorker
    {
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

        /// <summary>
        /// Get user ID by his login
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
    }
}
