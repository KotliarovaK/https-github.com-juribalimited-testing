﻿using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Store all created Lists names and Ids in this class
    public class ListsDetails
    {
        public ListsDetails()
        {
            Lists = new Dictionary<string, string>();
        }

        private Dictionary<string, string> Lists { get; }

        public void AddList(string listName)
        {
            AddNewList(listName, string.Empty);
        }

        public void AddList(string listName, string listId)
        {
            AddNewList(listName, listId);
        }

        private void AddNewList(string listName, string listId)
        {
            Lists.ToList().Add(new KeyValuePair<string, string>(listName, listId));
        }

        public void SetListId(string listName, string listId)
        {
            Lists[listName] = listId;
        }

        public string GetListIdByName(string listName)
        {
            try
            {
                var listId = Lists.ToList().Find(x => x.Key.Equals(listName)).Value;

                if (string.IsNullOrEmpty(listId))
                {
                    listId = DatabaseHelper.GetListId(listName);
                    SetListId(listName, listId);
                }

                return listId;
            }
            catch (Exception e)
            {
                throw new Exception($"List with '{listName}' was not found: {e}");
            }
        }
    }
}