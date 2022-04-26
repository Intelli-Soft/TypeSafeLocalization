

//The List of LocalizeMeShared.Data.Base holds all the informations, which will get created
var locListOfNamespaces = new List<LocalizeMeShared.Data.Base>();

//Here we generate the data for messages
var locMessages = new TypeSafeLocalization.Messages.LocalizedMessages();
var locEnums = new TypeSafeLocalization.Enums.LocalizedEnums();
var locImages = new TypeSafeLocalization.Images.LocalizedImages();


//Adding all the localized informations to the list
locListOfNamespaces.Add(locMessages.GetMessages);
locListOfNamespaces.Add(locEnums.GetEnums);
locListOfNamespaces.Add(locImages.GetImages);


//Creating the factory
var locFactory = new LocalizeMe.Standard.Factory();
//Checking the data for errors / warnings
locFactory.CheckData(locListOfNamespaces);
if(locFactory.HasErrors.Count == 0)
{
    //If no errors where found, whe can compile the new project
    
    locFactory.CleanFolder(Path.Combine(Environment.CurrentDirectory, @"Release\LocalizedProject")) //Cleaning the folder, where the project will get compiled into - Each time a compilation starts, the folder will be deleted! - The Project will be named, like the folder you specify
        .CreateProject(LocalizeMeShared.Enums.TypesOfProject.Net6) //specifiy the target framework (make sure, the framework SDK is installed properly
        .CreateResourceFiles(locListOfNamespaces) //adding the data
        .Compile(); //Compile and wait for a new, ready to use library
}

