using System;
using System.Collections.Generic;
using KellermanSoftware.CompareNetObjects;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.API
{
    public class FilterDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("translatedShortLabel")]
        public string TranslatedShortLabel { get; set; }
        [JsonProperty("translatedTextLabel")]
        public string TranslatedTextLabel { get; set; }
        [JsonProperty("customTranslatedTextLabel")]
        public string CustomTranslatedTextLabel { get; set; }
        [JsonProperty("translatedCategory")]
        public string TranslatedCategory { get; set; }
        [JsonProperty("translatedNoItems")]
        public string TranslatedNoItems { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("filterType")]
        public int FilterType { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("operators")]
        public List<Operator> Operators = new List<Operator>();
        [JsonProperty("options")]
        public List<Options> OptionsList = new List<Options>();
        [JsonProperty("optionsUrl")]
        public string OptionsUrl { get; set; }
        [JsonProperty("getOptionsMethodParams")]
        public List<string> GetOptionsMethodParams;
        [JsonProperty("validate")]
        public bool Validate { get; set; }
        [JsonProperty("displayType")]
        public string DisplayType { get; set; }
        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
        [JsonProperty("parameterCount")]
        public int ParameterCount { get; set; }
        [JsonProperty("getAssociationsMethodParams")]
        public string GetAssociationsMethodParams { get; set; }
        [JsonProperty("associations")]
        public List<Associations> AssociationsList = new List<Associations>();
        [JsonProperty("hasCorrespondingColumn")]
        public bool HasCorrespondingColumn { get; set; }
        [JsonProperty("columns")]
        public List<Columns> columns { get; set; }
        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }
        [JsonProperty("includeOperators")]
        public string IncludeOperators { get; set; }
        [JsonProperty("savedListFilter")]
        public bool SavedListFilter { get; set; }
        [JsonProperty("objectTypeId")]
        public int ObjectTypeId { get; set; }
        [JsonProperty("typeId")]
        public string TypeId { get; set; }

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

        public class Operator
        {
            [JsonProperty("key")]
            public string Key { get; set; }
            [JsonProperty("translatedDropdownValue")]
            public string TranslatedDropdownValue { get; set; }
            [JsonProperty("translatedTextValue")]
            public string TranslatedTextValue { get; set; }

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

        public class Options { }

        public class Associations
        {
            [JsonProperty("key")]
            public string Key { get; set; }
            [JsonProperty("translatedCheckboxValue")]
            public string TranslatedCheckboxValue { get; set; }
            [JsonProperty("translatedTextValue")]
            public string TranslatedTextValue { get; set; }
            [JsonProperty("group")]
            public int Group { get; set; }
            [JsonProperty("isPositive")]
            public bool IsPositive { get; set; }

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

        public class Columns
        {
            [JsonProperty("translatedName")]
            public string TranslatedName { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }

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
}
