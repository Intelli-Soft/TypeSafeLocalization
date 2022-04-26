using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Extensions;

namespace TestOfCompiledProject.Enums
{
    internal static class Test
    {
        internal static void ShowEnums()
        {
            var myTypeSafeLocalization = new LocalizedProject.LocalizeMe();

            //Here we have the localization for the enumerations as extension
            //Use the using Extensions on top, so you can get the extension called GetLocalizedEnums
            //When the text is found, you will see the translated version
            //if not, the name of the enum will be returned

            Console.WriteLine(TypeOfColors.White.GetLocalizedText(myTypeSafeLocalization.GetLocalizedEnums.GetActualLocalization));
            Console.WriteLine(TypeOfColors.Black.GetLocalizedText(myTypeSafeLocalization.GetLocalizedEnums.GetActualLocalization));
            Console.WriteLine(TypeOfColors.Red.GetLocalizedText(myTypeSafeLocalization.GetLocalizedEnums.GetActualLocalization));

            
            //Here we set all namespaces. 
            //So, all namespaces will be changed 

            myTypeSafeLocalization.SetAllToCulture(IS_Logic.Cultures.United_States);

            Console.WriteLine(TypeOfColors.White.GetLocalizedText(myTypeSafeLocalization.GetLocalizedEnums.GetActualLocalization));
            Console.WriteLine(TypeOfColors.Black.GetLocalizedText(myTypeSafeLocalization.GetLocalizedEnums.GetActualLocalization));
            Console.WriteLine(TypeOfColors.Red.GetLocalizedText(myTypeSafeLocalization.GetLocalizedEnums.GetActualLocalization));


        }
    }
}
