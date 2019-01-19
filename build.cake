#tool nuget:?package=Wyam&version=2.1.2
#addin nuget:?package=Cake.Wyam&version=2.1.2

var target = Argument("target", "Default");

Task("Build")
    .Does(() =>
    {
        Wyam(new WyamSettings {
            Recipe = "Docs",
            Theme = "Samson"
        });        
    });
    
Task("Preview")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Recipe = "Docs",
            Theme = "Samson",
            Preview = true,
            Watch = true
        });        
    });

Task("Default")
  .IsDependentOn("Preview");

RunTarget(target);