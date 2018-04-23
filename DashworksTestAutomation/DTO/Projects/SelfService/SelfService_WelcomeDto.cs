using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class SelfService_WelcomeDto
    {
        //TODO add a language?
        public bool AllowToSearchForAnotherUser;
        public bool AllowToChangeLanguage;
        public bool ShowProjectSelector;
        public bool ShowMoreDetailsLink;
        public TypeEnum Type;
        public FieldEnum Field;
        //TODO Add button
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public string PageDescription { get; set; }
        public string ProjectName { get; set; }

        public SelfService_WelcomeDto()
        {
            //Type = EnumExtensions.GetRandomValue<TypeEnum>();
            Field = EnumExtensions.GetRandomValue<FieldEnum>();
        }
    }

    public enum TypeEnum
    {
        Attribute,
        [Description("Custom Field")]
        CustomField,
        Task
    }

    public enum FieldEnum
    {
        [Description("Address 2")]
        Address2,
        [Description("Address 3")]
        Address3,
        [Description("Address 4")]
        Address4,
        Building,
        Category,
        City,
        Country,
        Department,
        [Description("Display Name")]
        DisplayName,
        Domain,
        Floor,
        [Description("Full Name")]
        FullName,
        Language,
        Location,
        [Description("Postal Code")]
        PostalCode,
        Region,
        [Description("Request Type")]
        RequestType,
        Username
    }

    public enum FieldEnum2
    {
        [Description("App field 1")]
        AppField1,
        [Description("Application Owner")]
        ApplicationOwner,
        ComputerCustomField,
        ComputerWarranty,
        [Description("DAS-1814")]
        DAS1814,
        [Description("End of Life Date")]
        EndOfLifeDate,
        [Description("Friendly Model Name")]
        FriendlyModelName,
        [Description("Zip Code")]
        ZipCode
    }
}