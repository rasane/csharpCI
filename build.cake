#load nuget:https://www.myget.org/F/cake-contrib/api/v2?package=Cake.Recipe&prerelease

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            sourceDirectoryPath: "./Solutions",
                            testDirectoryPath:"./Tests",
                            title: "classLibrary1",
                            shouldGenerateDocumentation: true,
                            shouldRunCodecov: true,
                            shouldBuildNugetSourcePackage: true,
                            shouldRunGitVersion: true,
                            shouldPublishMyGet: true,
                            nuspecFilePath: "./Production/nuspec_sample.nuspec");


ToolSettings.SetToolSettings(context: Context);

BuildParameters.PrintParameters(Context);
Build.Run();
Build.RunNuGet();