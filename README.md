# Hello World OOP

## Story

Making friends on a new neighbourhood is tough, first, learning all of that
names, then say hello to all of them!

[´Hello Janice!´](https://www.youtube.com/watch?v=FrBFfjdRGeA) ...doesn't it
sound better than 'Hello World!'?

## What are you going to learn?

- setup the IDE of your choice,
- creating new `class`,
- instantiate and use `object`,
- `build` and `run`
- and also, running your script from command line with arguments!

## Tasks

1. Create your own class in the project folder with name `App` using the chosen IDE. Make sure you put the class into the proper folder.
    - New `App` class is in the `src/HelloWorld` folder
    - `namespace` is `Codecool.HelloWorld`

2. Create a main method (entry point) in the `App` class and in the method initialize your own instance of `HelloWorld` and call its welcome method. The app should pass its first command line argument to this method.
    - In class `App` there is a main method as the entry point of your program
    - There is a `HelloWorld` instance created in the main method
    - The welcome method in the `HelloWorld` instance is called with the first command line argument

3. Compile your source files and run `App` with a command line argument using the terminal.
    - `.exe` file is generated from source files.
    - Running the `App` from the terminal with a command line argument, it displays `Hello <argument>!` (Example: argument `"Andrew"` prints `Hello Andrew!` to the output)

4. Write the commands used for compiling and running your program into the `make.sh` / `make.ps1` file you can do both actions with one command. Make sure that you can run this file with a command line argument as well.
    - Previously used commands are saved in script file in separated lines
    - Executing `make.ps1` with an argument compiles the source code and calls `App` with the given argument to do the `Compile and run` task in one step

5. Compile your source files and run `App` with a command line argument using your chosen IDE.
    - `.exe` file is generated from source files.
    - Running the `App` from the IDE with a command line argument, it displays `Hello <argument>!` (Example: argument `"Andrew"` prints `Hello Andrew!` to the output)

## General requirements

None

## Hints

- You can set command line arguments (parameters) in IDEs usually in project
  settings/configuration dialogs.
- Running your `App` class without command line arguments will result in an
  exception (and that's fine). Try to find out why it is happening.
- In case of docs.microsoft.com articles many times only the first article is linked but the category may contain further sub-articles.
You can browse these connected pages on the left navigation of articles.
- On docs.microsoft.com there are a bunch of code samples as well: [C# code samples](https://docs.microsoft.com/en-us/samples/browse/?languages=csharp&expanded=dotnet&products=dotnet-core)


## Background materials

- <i class="far fa-exclamation"></i> [Introducing docs.microsoft.com](https://docs.microsoft.com/en-us/teamblog/introducing-docs-microsoft-com)
- <i class="far fa-exclamation"></i> [Open project in Visual Studio](project/curriculum/materials/pages/tools/open-project-in-visual-studio.md)
- <i class="far fa-exclamation"></i> [.NET Core](project/curriculum/materials/pages/csharp/dotnet-core.md)
- <i class="far fa-exclamation"></i> [How to build your project using .NET Core CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build)
- <i class="far fa-exclamation"></i> [How to run your project using .NET Core CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-run)
- <i class="far fa-exclamation"></i> [Passing parameters to PowerShell script](https://windows.tips.net/T002902_Passing_Parameters_to_a_PowerShell_Script.html)
- <i class="far fa-book-open"></i> [Introduction to PowerShell](https://www.itprotoday.com/powershell/running-powershell-scripts-easy-1-2-3)

