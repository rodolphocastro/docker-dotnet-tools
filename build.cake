#addin nuget:?package=Cake.Docker&version=0.10.1

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "BuildDockerImages");
var configuration = Argument("configuration", "Release");
var dockerRepository = Argument("repository", "rodolphoalves/dotnet-tools");

///////////////////////////////////////////////////////////////////////////////
// SETUP / TEARDOWN
///////////////////////////////////////////////////////////////////////////////

Setup(ctx =>
{
   // Executed BEFORE the first task.
   Information("Running tasks...");
});

Teardown(ctx =>
{
   // Executed AFTER the last task.
   Information("Finished running tasks.");
});
///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("Build-3.1-Alpine-Base")
.Does(() =>{
   var settings = new DockerImageBuildSettings
   {
      File = File("./3.1/Alpine/Dockerfile"),
      Tag = new[] {$"{dockerRepository}:base-3.1"}
   };
   DockerBuild(settings, ".");
});

Task("Build-3.1-Alpine-Cake")
.Does(() =>{
   var settings = new DockerImageBuildSettings
   {
      File = File("./3.1/Alpine/Cake/Dockerfile"),
      Tag = new[] {$"{dockerRepository}:cake-3.1"}
   };
   DockerBuild(settings, ".");
});

Task("Build-3.1-Alpine-Coverlet")
.Does(() =>{
   var settings = new DockerImageBuildSettings
   {
      File = File("./3.1/Alpine/Coverlet/Dockerfile"),
      Tag = new[] {$"{dockerRepository}:coverlet-3.1"}
   };
   DockerBuild(settings, ".");
});

Task("Build-3.1-Alpine-Sonarscanner")
.Does(() =>{
   var settings = new DockerImageBuildSettings
   {
      File = File("./3.1/Alpine/Sonarscanner/Dockerfile"),
      Tag = new[] {$"{dockerRepository}:sonarscanner-3.1"}
   };
   DockerBuild(settings, ".");
});

Task("Build-3.1-Alpine-All")
.IsDependentOn("Build-3.1-Alpine-Base")
.IsDependentOn("Build-3.1-Alpine-Cake")
.IsDependentOn("Build-3.1-Alpine-Coverlet")
.IsDependentOn("Build-3.1-Alpine-Sonarscanner");

Task("BuildDockerImages")
.IsDependentOn("Build-3.1-Alpine-All");

RunTarget(target);