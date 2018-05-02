using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DashworksTestAutomation.Helpers
{
    public class SortingHelper
    {
        public static void IsListSorted(List<string> originalList, bool isAscending = true)
        {
            originalList = originalList.Where(x => !x.Equals("")).ToList();
            List<string> expectedList = originalList.OrderBy(s => s).ToList();
            if (!isAscending)
                expectedList.Reverse();

            try
            {
                //Compare two lists
                Assert.AreEqual(expectedList, originalList, "Incorrect sorting order");
            }
            catch (Exception)
            {
                //Compare each elements just to find elements that a different
                for (int i = 0; i < originalList.Count; i++)
                {
                    Assert.AreEqual(expectedList[i],
                        originalList[i], "Incorrect sorting order");
                }
            }
        }

        public static void IsNumericListSorted(List<string> originalList, bool isDescending = true)
        {
            originalList = originalList.Where(x => !x.Equals("")).ToList();

            //Return if nothing to sort
            if (!originalList.Any())
                return;

            List<KeyValuePair<int, string>> unsortedList = new List<KeyValuePair<int, string>>();
            int intValue;
            foreach (var date in originalList)
            {
                var unconvertedInt = int.TryParse(date, out intValue);
                unsortedList.Add(unconvertedInt
                    ? new KeyValuePair<int, string>(intValue, date)
                    : new KeyValuePair<int, string>(int.MinValue, date));
            }

            //Get count of the values from original list that can't be converted to DateTime
            var unsortedCount = originalList.Count(x => !int.TryParse(x, out intValue));
            Assert.AreNotEqual(unsortedCount, originalList.Count,
                "Original list was not sorted at all/Can't be sorted. Nothing to compare. Please check method logic or input list");

            try
            {
                //Compare two lists
                Assert.AreEqual(originalList.OrderBy(s => s).ToList(), originalList, "Incorrect sorting order");
            }
            catch (Exception)
            {
                //Compare each elements just to find elements that a different
                for (int i = 0; i < originalList.Count; i++)
                {
                    Assert.AreEqual(unsortedList.OrderBy(x => x.Key).Select(x => x.Value).ToArray()[i],
                        originalList[i], "Incorrect sorting order");
                }
            }
        }

        public static void IsListSortedByDate(List<string> originalList, bool isDescending = true)
        {
            originalList = originalList.Where(x => !x.Equals("")).ToList();

            //Return if nothing to sort
            if (!originalList.Any())
                return;

            List<KeyValuePair<DateTime, string>> unsortedList = new List<KeyValuePair<DateTime, string>>();
            DateTime datevalue;
            foreach (var date in originalList)
            {
                var unconvertedDate = DateTime.TryParse(date, out datevalue);
                unsortedList.Add(unconvertedDate
                    ? new KeyValuePair<DateTime, string>(datevalue, date)
                    : new KeyValuePair<DateTime, string>(DateTime.MinValue, date));
            }

            //Get count of the values from original list that can't be converted to DateTime
            var unsortedCount = originalList.Count(x => !DateTime.TryParse(x, out datevalue));
            Assert.AreNotEqual(unsortedCount, originalList.Count, "Original list was not sorted at all/Can't be sorted. Nothing to compare. Please check method logic or input list");

            List<KeyValuePair<DateTime, string>> sortedList = unsortedList.OrderBy(s => s.Key).ToList();
            if (isDescending)
                sortedList.Reverse();

            try
            {
                //Compare two lists
                Assert.AreEqual(sortedList.Select(s => s.Value), originalList, "Incorrect sorting order");
            }
            catch (Exception)
            {

                //Compare each elements just to find elements that a different
                for (int i = 0; i < originalList.Count; i++)
                {
                    Assert.AreEqual(sortedList[i].Value, originalList[i], "Incorrect sorting order");
                }
            }
        }
    }
}
