using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Utils
{
    class LockCategory
    {
        private static bool CategoryToLock { get; set; }

        public static void AwaitForCategory(IList categories)
        {
            if (categories.Contains("Name_Of_Category"))
                if (!CategoryToLock)
                {
                    CategoryToLock = true;
                }
                else
                {
                    while (CategoryToLock)
                    {
                        Thread.Sleep(3000);
                    }
                }
        }

        public static void FreeCategory(IList categories)
        {
            if (categories.Contains("Name_Of_Category"))
                CategoryToLock = false;
        }
    }
}
