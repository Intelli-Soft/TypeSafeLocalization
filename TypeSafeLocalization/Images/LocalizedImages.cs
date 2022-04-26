using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TypeSafeLocalization.Images
{
    internal class LocalizedImages
    {
        const string Flag = "Flag";
        

        LocalizeMeShared.Data.Base myLocalizedMessages = new LocalizeMeShared.Data.Base()
        {
            NameSpace = "Images",
            TypeOfResource = LocalizeMeShared.Enums.TypesOfResource.Images
        };

        internal LocalizedImages()
        {
            AddLocalizedGermanResourceData();
            AddLocalizedEnglishResourceData();
        }

        internal LocalizeMeShared.Data.Base GetImages { get { return myLocalizedMessages; } }


        internal void AddLocalizedGermanResourceData()
        {

            

            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = Flag,
                        Comment = "Get the flag of country",
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.de_AT,
                        IsInvariant = true,
                        TypeOfFile = "png",
                        FileName = "Austria",
                        FileContent = File.ReadAllBytes(Path.Combine(Environment.CurrentDirectory, @"Images\Austria", "Austria.png"))
                        
                    });
        }

        internal void AddLocalizedEnglishResourceData()
        {
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = Flag,
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.en_US,
                        IsInvariant = false,
                        TypeOfFile = "png",
                        FileName = "Austria",
                        FileContent = File.ReadAllBytes(Path.Combine(Environment.CurrentDirectory, @"Images\English", "America.png"))
                    });
        }
    }
}
