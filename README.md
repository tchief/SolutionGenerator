SolutionGenerator
=================

Simple application that will create the project structure, solution and project files as well as other artifacts to start working on a new project at the click of a button.

There are a lot of projects out there that make building and releasing code easier, but there is not a lot out there that makes creating new projects easier. Our aim is to fill this gap with SolutionGenerator.

This project was born out of the need to have a "standard" for creating projects quickly.

We follow the standards documented here: https://github.com/Orcomp/Standards, but the tool should be flexible enough to be customised to your own needs.

![ScreenShot](/img/screenshot.png)

## Features

Things SolutionGenerator will do for you **at the click of a button**:

- Create the folder structure you want.
- Create the following files (and populates them):
    - Readme.md
    - .gitignore
    - .gitattributes
    - stlylecop settings
    - Resharper settings
- It also creates a solution file and associated project as well as a project to write your tests.
- The project is configured to build its artifacts into an "output" folder.

Once you click the button to create the solution, it will do all of the above, and  immediately start Visual Studio, so you can start working on your project in no time ;)

## Customising

- You can change the content of the various template files in the "\template" folder.
- You can also customize the folder structure.

## Roadmap

- **SolutionChecker** : will be used to check whether the solution structure and code conforms to a set of standards.

## License

This project is open source and released under the MIT license.

Please contribute to make it better ;)