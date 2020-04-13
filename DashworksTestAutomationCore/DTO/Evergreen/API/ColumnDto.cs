using System;
using KellermanSoftware.CompareNetObjects;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.API
{
    class ColumnDto
    {
        [JsonProperty("translatedColumnName")]
        public string TranslatedColumnName { get; set; }
        [JsonProperty("columnName")]
        public string ColumnName { get; set; }
        [JsonProperty("translatedCategory")]
        public string TranslatedCategory { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("categoryOrder")]
        public int CategoryOrder { get; set; }
        [JsonProperty("displayType")]
        public string DisplayType { get; set; }
        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
        [JsonProperty("default")]
        public bool Default { get; set; }
        [JsonProperty("visible")]
        public bool Visible { get; set; }
        [JsonProperty("hideOnColumns")]
        public bool HideOnColumns { get; set; }
        [JsonProperty("hideOnRowGroups")]
        public bool HideOnRowGroups { get; set; }
        [JsonProperty("hideOnValues")]
        public bool HideOnValues { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("uRL")]
        public string Url { get; set; }
        [JsonProperty("additionalURL")]
        public string AdditionalURL { get; set; }
        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }
        [JsonProperty("dataType")]
        public string DataType { get; set; }
        [JsonProperty("sortOrder")]
        public string SortOrder { get; set; }
        [JsonProperty("sortByField")]
        public string SortByField { get; set; }
        [JsonProperty("customUiTransformation")]
        public string CustomUiTransformation { get; set; }
        [JsonProperty("options")]
        public string Options { get; set; }

        public override bool Equals(Object obj)
        {
            CompareLogic compareLogic = new CompareLogic();
        
            ComparisonResult result = compareLogic.Compare(this, obj);

            return result.AreEqual;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
