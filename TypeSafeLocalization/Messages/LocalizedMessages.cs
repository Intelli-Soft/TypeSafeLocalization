using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Messages can be understood as normal text, which should get generated
// You can create some static text, or text with placeholders => {0}

namespace TypeSafeLocalization.Messages
{
    internal class LocalizedMessages
    {

        //You need unique names, within each namespace
        //this names will be the property name
        const string CustomerFirstName = "Customer First Name"; //This name will create a property called: CustomerFirstName
        const string CustomerLastName = "Customer Last Name"; //This name will create a proprety called: CustomerLastName
        const string CustomerAge = "Customer Age {0}"; //This name will create two methods, one called SetCustomerAge(string Item1) and one called GetCustomerAge 
        //Placeholders must be set within the name!



        //First, the initialize base data is needed.
        //Here the Namespace will be declared.

        LocalizeMeShared.Data.Base myLocalizedMessages = new LocalizeMeShared.Data.Base()
        {
            NameSpace = "Messages", //The namespace within the project will be: GetLocalizedMessages (The praefix GetLocalized will be attached 
            TypeOfResource = LocalizeMeShared.Enums.TypesOfResource.Messages //The type of the resource will be set
        };

        internal LocalizedMessages()
        {
            AddLocalizedGermanResourceData();
            AddLocalizedEnglishResourceData();
        }

        internal LocalizeMeShared.Data.Base GetMessages { get { return myLocalizedMessages; } }


        internal void AddLocalizedGermanResourceData()
        {
            //Into the base data, we add the resource data for each language
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    { 
                        Name = CustomerFirstName, //The const name string, for the generated property / methods
                        Comment = "Get the first name of the customer", //The comment will be visible within the IDE as helper. This will taken only on the IsInvariant property=true
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.de_AT, //You have to choose from the country, to which your text is set
                        IsInvariant = true, // One property must be set as IsInvariant = true, this is the default language 
                        Value = "Vorname des Kunden", //The localized text you want to show
                        Tag = "just a placeholder" //here you can store a string, which could be used for internal things
                    });
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = CustomerLastName,
                        Comment = "Get the last name of the customer",
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.de_AT,
                        IsInvariant = true,
                        Value = "Nachname des Kunden"
                    });
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = CustomerAge,
                        Comment = "Show the age of the customer",
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.de_AT,
                        IsInvariant = true,
                        Value = "Der Kunde ist {0} Jahre alt"
                    });
        }


        // Here we add a second language for the resources
        internal void AddLocalizedEnglishResourceData()
        {
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = CustomerFirstName,
                        Comment = "Get the first name of the customer",
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.en_US,
                        IsInvariant = false,
                        Value = "First name"
                    });
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = CustomerLastName,
                        Comment = "Get the last name of the customer",
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.en_US,
                        IsInvariant = false,
                        Value = "Last name"
                    });
            myLocalizedMessages.ResourceData
                .Add(
                    new LocalizeMeShared.Data.ResourceData
                    {
                        Name = CustomerAge,
                        Comment = "Show the age of the customer",
                        CultureCodeName = LocalizeMeShared.Enums.TypesOfCulture.en_US,
                        IsInvariant = false,
                        Value = "The age of the current customer is {0} years"
                    });
        }
    }
}
