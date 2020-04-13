using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Extensions
{
    public static class TableExtensions
    {
        public static List<string> GetHeaders(this Table table)
        {
            return table.Rows.First().Keys.ToList();
        }

        public static List<string[]> GetContent(this Table table)
        {
            var result = new List<string[]>();
            foreach (TableRow row in table.Rows)
            {
                var line = new List<string>();
                foreach (KeyValuePair<string, string> pair in row)
                {
                    line.Add(pair.Value);
                }

                result.Add(line.ToArray());
            }

            return result;
        }

        public static List<string> GetDataByKey(this Table table, string key)
        {
            List<string> result = new List<string>();
            foreach (TableRow row in table.Rows)
            {
                foreach (KeyValuePair<string, string> pair in row)
                {
                    if (pair.Key.Equals(key))
                    {
                        result.Add(pair.Value);
                        continue;
                    }
                }
            }

            if (result.Count > 0) return result;

            throw new Exception($"Unable to find element with '{key}' in the table.");
        }

        public static void CompareWith(this Table expectedTable, Table actualTable, int rowsToCompare)
        {
            CompareWithTable(expectedTable, actualTable, rowsToCompare);
        }

        private static void CompareWithTable(this Table expectedTable, Table actualTable, int rowsToCompare)
        {
            if (rowsToCompare > actualTable.RowCount)
                throw new Exception($"Unable to compare tables. Tables have less than {rowsToCompare} rows");

            Verify.AreEqual(expectedTable.Header.Count, actualTable.Header.Count,
                "Headers count is different");
            //Verify.AreEqual(expectedTable.RowCount, actualTable.RowCount,
            //    $"Rows count is different in tables: {expectedTable.RowCount} != {actualTable.RowCount}");

            for (int i = 0; i < rowsToCompare; i++)
            {
                var expectedTableRow = expectedTable.Rows[i];
                var actualTableRow = actualTable.Rows[i];
                for (int j = 0; j < actualTable.Header.Count; j++)
                {
                    Verify.AreEqual(expectedTableRow[j], actualTableRow[j], "Content in Tables doesn't match");
                }
            }
        }

    }
}