# MVVMStarter (NB: Now deprecated - see MVVMStarterLibrary instead)
## The MVVMStarter Framework - overview

This repository contains the **MVVMStarter Framework**, which is intended to be an MVVM-based C# Framework offering basic CRUD (Create, Read, Update, Delete) functionality for domain classes.

The main features of the framework are:
* Viewing collections of domain classes in (configurable) Master/Details views
* CRUD functionality
* Property-level validation
* Property-dependency management (automatic updates of aggregated view properties)
* Multiple-criteria object filtering
* View configuration based on current view state
* Load/save to files in JSON format
* Management of hard-coded image objects with tags

Once you have downloaded the framework, you can add domain classes (say, a **Car** class, a **Student** class, etc.) to the framework, by following the steps in the **MVVMStarter Guide** (see the *Documentation* folder).

## FAQ (typical problems encountered so far)

*__Why does my view not show up when I select it in the main navigation?__*

When you create a new View, you **must** create it by choosing **Add | New Item | XAML | Blank Page** If you don't do this, a .cs file associated with the xaml file will not be created, which is the cause for the view not showing up.


*__When I try to open a View, I get an exception with the title "The value cannot be converted to type ImageSource"...?__*

The default setting for the ListView control in the View is to use a DataTemplate containing an Image control and a TextBlock control. If you don't want to include an image in your data template, you can just remove the Image control from the data template in the View. If you do want to use an image, you should override the ImageSource property in the ItemViewModel class, such that it returns a path to the actual image file. 

NB: In MVVM versions from 10 May 2017 and forward, you should not get this exception, but instead see an "Image not set" graphics (a white cross in a black circle).


*__I just cloned a project from GitHub that runs fine on another PC, but I cannot compile it?__*

All of the binary files created when compiling a project are **not** saved to GitHub. This is perfectly fine, since they take up a lot of space, but it has the unfortunate consequence that the "target platform" is reset to **ARM**, The target platform should be changed to **x86**. Once you have changed it, rebuild the project. It seems that this problem does not occur when using Visual Studio 2017...




