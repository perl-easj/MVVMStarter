# MVVMStarter
The MVVMStarter Framework

This repository contains the **MVVMStarter Framework**, which is intended to be an MVVM-based C# Framework offering basic CRUD (Create, Read, Update, Delete) functionality for domain classes.

The main features of the framework are:
* Viewing collections of domain classes in (configurable) Master/Details views
* CRUD functionality
* Property-level validation
* Property-dependency management (automatic updates of aggregated view properties)
* Multiple-criteria object filtering
* View configuration based on current view state
* Load/save to files in JSON format
* Management of hard-coded image objects

Once you have downloaded the framework, you can add domain classes (say, a **Car** class, a **Student** class, etc.) to the framework, by following the steps in the **MVVMStarter Guide** (see the *Documentation* folder).

## FAQ (typical problems encountered so far)

*Why does my view not show up when I select it in the main navigation?*

When you create a new View, you **must** create it by choosing **Add | New Item | XAML | Blank Page** If you don't do this, a .cs file associated with the xaml file will not be created, which is the cause for the view not showing up.

*I just cloned a project from GitHub that runs fine on another PC, but I cannot compile it?*

All of the binary files created when compiling a project are **not** saved to GitHub. This is perfectly fine, since they take up a lot of space, but it has the unfortunate consequence that the "target platform" is reset to **ARM**, The target platform should be changed to **x86**. Once you have changed it, rebuild the project.


