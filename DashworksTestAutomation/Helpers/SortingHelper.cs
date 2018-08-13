using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.DTO;
using NUnit.Framework;

namespace DashworksTestAutomation.Helpers
{
    public class SortingHelper
    {
        public static void IsListSorted(List<string> originalList, bool isAscending = true)
        {
            originalList = originalList.Where(x => !x.Equals("") && !x.Equals("Empty")).ToList();
            //Ascending
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
                    Assert.AreEqual(expectedList[i],
                        originalList[i], "Incorrect sorting order");
            }
        }

        public static void IsListSortedByEnum<T>(List<string> originalList, bool isAscending = true)
        {
            originalList = originalList.Where(x => !x.Equals("")).ToList();
            var originalColorsList = originalList.Select(x => Enum.Parse(typeof(T), x.Replace(" ", String.Empty))).ToList();
            var originalColorsListSorted = originalColorsList.OrderBy(s => s).ToList();

            //Return if nothing to sort
            if (!originalList.Any())
                return;

            if (!isAscending)
                originalColorsListSorted.Reverse();

            try
            {
                //Compare two lists
                Assert.AreEqual(originalColorsListSorted, originalColorsList, "Incorrect sorting order");
            }
            catch (Exception)
            {
                //Compare each elements just to find elements that a different
                for (int i = 0; i < originalColorsList.Count; i++)
                    Assert.AreEqual(originalColorsListSorted.ToList()[i],
                        originalColorsList[i], "Incorrect sorting order");
            }
        }

        public static void IsNumericListSorted(List<string> originalList, bool isAscending = true)
        {
            originalList = originalList.Where(x => !x.Equals("")).ToList();

            //Return if nothing to sort
            if (!originalList.Any())
                return;

            List<KeyValuePair<int, string>> unsortedList = new List<KeyValuePair<int, string>>();
            int intValue;
            foreach (var num in originalList)
            {
                var unconvertedInt = int.TryParse(num.Replace(",", string.Empty), out intValue);
                unsortedList.Add(unconvertedInt
                    ? new KeyValuePair<int, string>(intValue, num)
                    : new KeyValuePair<int, string>(int.MinValue, num));
            }

            //Get count of the values from original list that can't be converted to Numeric
            var unsortedCount = originalList.Count(x => !int.TryParse(x.Replace(",", string.Empty), out intValue));
            Assert.AreNotEqual(unsortedCount, originalList.Count,
                "Original list was not sorted at all/Can't be sorted. Nothing to compare. Please check method logic or input list");

            List<KeyValuePair<int, string>> sortedList = unsortedList.OrderBy(s => s.Key).ToList();
            if (!isAscending)
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

        public static void IsListSortedByDate(List<string> originalList, bool isAscending = true)
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
            Assert.AreNotEqual(unsortedCount, originalList.Count,
                "Original list was not sorted at all/Can't be sorted. Nothing to compare. Please check method logic or input list");

            List<KeyValuePair<DateTime, string>> sortedList = unsortedList.OrderBy(s => s.Key).ToList();
            if (!isAscending)
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
                    Assert.AreEqual(sortedList[i].Value, originalList[i], "Incorrect sorting order");
            }
        }
    }
}