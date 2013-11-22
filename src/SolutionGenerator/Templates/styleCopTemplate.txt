The aim of this project is to create a simple application that will help create a blank C# solution.

Things that it needs to be able to do:

- Select a folder location to create the solution.
- Create sub folders
- Create a solution (.sln) file
- Create a project file
- Change the location of the build artifacts.
- Create a README.md file
- Create a .gitignore file (with some content in it)
- Create a .gitAttribtues file (with some content in it)
- Create a stylecop file
- Create a Resharper settings file

For example when I want to create a new solution i would start this application. Select the folder I want to create the solution in. Then enter the name of the solution.

It will then create the following folders and files:
- src
- lib
- docs
- output
- tools
- README.md
- .gitignore
- .gitattributes

Then in the "src" folder it will create the solution .sln file and create a folder with the name of the project, which will include the project file.

The project file will be configured so that the output of the binaries will end up in the "output" folder at the root level.

Once all this is done, I should be able to just double click on the solution to start VS and start working.

I would prefer if this project was done in C# but am open to other suggestions.