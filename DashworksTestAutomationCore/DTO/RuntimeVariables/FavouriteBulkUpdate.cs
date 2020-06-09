using System.Collections.Generic;
using DashworksTestAutomationCore.Steps.Dashworks.ActionsPanel.FavouriteBulkUpdate;

namespace DashworksTestAutomationCore.DTO.RuntimeVariables
{
    class FavouriteBulkUpdateObjects
    {
        public List<RemoveFbuMethods.Favourit> Value { get; set; }

        public FavouriteBulkUpdateObjects()
        {
            Value = new List<RemoveFbuMethods.Favourit>();
        }
    }
}
