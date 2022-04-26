using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOfCompiledProject.Messages
{
    internal static class Test
    {
        internal static void ShowMessages()
        {
            //The project was named "LocalizedProject" during compiling
            //you also find an Interface. This can be added into DI containers

            //After initialization the IsInvariant language is set by default
            //In our case it was the "Austrian" language
            var myTypeSafeLocalization = new LocalizedProject.LocalizeMe();

            //We have the namespace, used in the code and the property / methods as expected
            Console.WriteLine(myTypeSafeLocalization.GetLocalizedMessages.SetCustomerAge("5"));
            Console.WriteLine(myTypeSafeLocalization.GetLocalizedMessages.CustomerFirstName);
            Console.WriteLine(myTypeSafeLocalization.GetLocalizedMessages.CustomerLastName);

            //here we can change the language/culture only for the namespace. - The other namespaces would stay in the preset language
            myTypeSafeLocalization.GetLocalizedMessages.SetCulture(IS_Logic.Cultures.United_States);

            //Here we use the get method, because we don't want to change the input of the age
            Console.WriteLine(myTypeSafeLocalization.GetLocalizedMessages.GetCustomerAge);
            Console.WriteLine(myTypeSafeLocalization.GetLocalizedMessages.CustomerFirstName);
            Console.WriteLine(myTypeSafeLocalization.GetLocalizedMessages.CustomerLastName);


            //Other possible extension mehtods are:
            var locIsRightToLeft = myTypeSafeLocalization.GetLocalizedMessages.CustomerFirstName.IsRightToLeft;
            var locComment = myTypeSafeLocalization.GetLocalizedMessages.CustomerFirstName.Comment;
            var locTag = myTypeSafeLocalization.GetLocalizedMessages.CustomerFirstName.Tag;
            var locCurrentCultureInfo = myTypeSafeLocalization.GetLocalizedMessages.GetCultureInfo;

        }
    }
}
