using DashworksTestAutomationCore.DTO.Evergreen;
using System;
using System.Collections.Generic;
using System.Text;

namespace DashworksTestAutomationCore.DTO.RuntimeVariables
{
    class FavouriteBulkUpdate
    {
        public List<FavouriteBulkUpdateDto> Value { get; set; }

        public FavouriteBulkUpdate()
        {
            Value = new List<FavouriteBulkUpdateDto>();
        }
    }
}
