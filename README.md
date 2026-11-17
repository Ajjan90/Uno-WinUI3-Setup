# Setting up Uno Platform project to create a Windows WinUI3 App

<p> This repository will help programmers set up the your <b>Uno Platform</b> project to create Windows 11 apps using the Fluent Design </p>


## What is WinUI3
<img src="/Assets/WinUI.webp" width="150" height="150">
<p>  WinUI3 is the native UI framework for Windows desktop apps, it brings the Fluent design system into your application using XAML to deisgn the UI interface while using <b>C#</b> or <b>C++</b> for th backend of the desktop application. </p>

<p>More about WinUI3 on <a href="https://learn.microsoft.com/en-us/windows/apps/winui/winui3/" >Microsoft Learn - WinUI 3</a> </p>

## What is Uno Platform

<img src="/Assets/Uno-Logo.png" width="150" height="150">
<p> The Uno Platform is an open-source, cross-platform .NET and WinUI/XAML framework that allows developers to write single-codebase applications in C# and XAML and deploy them across mobile, desktop, web, and embedded systems </p>

<p>More about Uno Platform on <a href="https://platform.uno/docs/articles/what-is-uno.html" >Uno Platform - About</a> </p>

#
# Step-by-Step Guide: Creating a WinUI Project with Uno Platform

Uno Platform allows you to build cross-platform applications using **C#, .NET, and XAML**, while using WinUI-style APIs and controls.

This guide walks you through creating a new Uno Platform project targeting Windows.

## 1. Prerequisites

Before creating your project, make sure you have the following installed:

- Visual Studio 2022 (or a supported newer version).
- .NET SDK (compatible with your Uno Platform version).
- Uno Platform Extension for Visual Studio.
- Windows 10 or Windows 11.
- Windows App SDK and required Visual Studio workloads.

Download Visual Studio:

https://visualstudio.microsoft.com/

## 2. Install the Uno Platform Extension

1. Open Visual Studio.
2. Navigate to **Extensions → Manage Extensions**.
3. Search for `Uno Platform`.
4. Select the Uno Platform extension.
5. Click **Download**.
6. Close Visual Studio and allow the installation to complete.
7. Reopen Visual Studio.

Documentation:

https://platform.uno/docs/articles/get-started-vs.html

## 3. Create a New Uno Platform Project

1. Open Visual Studio.
2. Select **Create a new project**.
3. Search for `Uno Platform App`.
4. Select the Uno Platform application template.
5. Click **Next**.
6. Enter your project details:

   - **Project name:** `MyUnoWinUIApp`
   - **Location:** Choose your preferred directory.
   - **Solution name:** `MyUnoWinUIApp`

7. Click **Next**.

## 4. Configure the Project

The Uno Platform template wizard allows you to configure your application.

1. Select **Windows** as your target platform.
2. Choose the appropriate presentation framework or UI configuration.
3. Select any additional platforms you want to support.
4. Choose any optional features you need.
5. Click **Create**.

**Note:** Uno Platform provides WinUI-compatible APIs and controls. Its Windows target is an Uno Platform application, not necessarily a standalone native WinUI project.

## 5. Understand the Project Structure

A typical Uno Platform solution may look like this:

````text
MyUnoWinUIApp/
│
├── MyUnoWinUIApp/
│   ├── App.xaml
│   ├── App.xaml.cs
│   ├── MainPage.xaml
│   ├── MainPage.xaml.cs
│   └── Assets/
│
├── MyUnoWinUIApp.Windows/
│   └── Windows-specific files
│
├── MyUnoWinUIApp.Wasm/
│
├── MyUnoWinUIApp.Android/
│
├── MyUnoWinUIApp.iOS/
│
└── MyUnoWinUIApp.sln
````

The exact structure depends on the Uno Platform template and selected targets.

### Important Files

| File | Purpose |
|---|---|
| `App.xaml` | Application resources and configuration |
| `App.xaml.cs` | Application startup and lifecycle |
| `MainPage.xaml` | Main user interface |
| `MainPage.xaml.cs` | Main page C# logic |
| `.csproj` | Project configuration and dependencies |

## 6. Create a Simple WinUI Interface

Open `MainPage.xaml` and add the following XAML:

````xml
<Page
    x:Class="MyUnoWinUIApp.MainPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">

    </Grid>
</Page>
````

This creates a simple interface containing:

- A heading.
- A descriptive message.
- A clickable button.


Make sure the following namespaces are available:

````csharp
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
````

When the user clicks the button, a dialog will appear.

## 7. Build the Project

Before running the application, build the solution.

1. Open the **Build** menu in Visual Studio.
2. Select **Build Solution**.
3. Wait for compilation to finish.
4. Check the Error List window for any build errors.

Alternatively, use the keyboard shortcut:

`Ctrl + Shift + B`

## 8. Run the WinUI Application

To run your application:

1. Locate the Windows target in the Visual Studio startup target dropdown.
2. Select the Windows target.
3. Choose the appropriate deployment configuration.
4. Click the green **Start** button or press `F5`.

Your application should launch in a Windows desktop window.

You should see:

- The heading "Hello, Uno Platform!"
- The descriptive message.
- The "Click Me" button.

Clicking the button should display the welcome dialog.

## 9. Run the Application on Other Platforms (Optional)

One of the biggest advantages of Uno Platform is that you can reuse much of your XAML and C# code across different platforms.

Depending on the targets selected during project creation, you can also run your application on:

- WebAssembly (Web).
- Android.
- iOS.
- macOS.

Each platform may require additional SDKs, workloads, or development tools.

## 10. Useful Resources

| Resource | Link |
|---|---|
| Uno Platform Documentation | https://platform.uno/docs/ |
| Getting Started | https://platform.uno/docs/articles/get-started.html |
| WinUI Documentation | https://learn.microsoft.com/windows/apps/winui/ |
| Uno Platform Samples | https://github.com/unoplatform/uno |
| Uno Platform Tutorials | https://platform.uno/docs/articles/tutorials/ |

---

## Summary

You have now created a basic WinUI-style application using Uno Platform.

The overall process is:

1. Install Visual Studio and the Uno Platform extension.
2. Create a new Uno Platform application.
3. Configure the Windows target.
4. Explore the generated project structure.
5. Create your UI using XAML.
6. Add functionality using C#.
7. Build the solution.
8. Run the application on Windows.

**The key advantage:** You can develop using WinUI-compatible XAML and C# while retaining the option to expand your application to other platforms without rewriting the entire UI.

