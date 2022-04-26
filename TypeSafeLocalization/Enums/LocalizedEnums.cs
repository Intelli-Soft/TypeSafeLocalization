using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSafeLocalization.Enums
{
    internal class LocalizedEnums
    {

        const string Red = "Red";
        const string Black = "Black";
        const string White = "White";

        //Enumerations are specific and can be used as extension
        //Make sure, you can use them correct, that the name is set exact as the enumeration name, which you want translate

        LocalizeMeShared.Data.Base myLocalizedMessages = new LocalizeMeShared.Data.Base()
        {
            NameSpace = "Enums",
            TypeOfResource = LocalizeMeShared.Enums.TypesOfResource.Enumerations
        };

        internal LocalizedEnums()
        {
            AddLocalizedGermanResourceData();
            AddLocalizedEnglishResourceData();
        }

        internal LocalizeMeShared.Data.Base GetEnums { get { return myLocalizedMessages; } }

        internal void AddLocalizedGermanResourceData()
        {
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = Red,
                        Comment = "Get the localized value for the enumeration Red",
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.de_AT,
                        IsInvariant = true,
                        Value = "Rot"
                    });
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = Black,
                        Comment = "Get the localized value for the enumeration Black",
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.de_AT,
                        IsInvariant = true,
                        Value = "Schwarz"
                    });
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = White,
                        Comment = "Get the localized value for the enumeration White",
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.de_AT,
                        IsInvariant = true,
                        Value = "Weiss"
                    });
        }
        internal void AddLocalizedEnglishResourceData()
        {
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = Red,
                        Comment = "Get the localized value for the enumeration Red",
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.en_US,
                        IsInvariant = false,
                        Value = "Red"
                    });
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = Black,
                        Comment = "Get the localized value for the enumeration Black",
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.en_US,
                        IsInvariant = false,
                        Value = "Black"
                    });
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = White,
                        Comment = "Get the localized value for the enumeration White",
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.en_US,
                        IsInvariant = false,
                        Value = "White"
                    });
        }

    }
}
