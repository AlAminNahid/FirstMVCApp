# FirstMVCApp Project Structure

This project is an ASP.NET Core MVC application. MVC stands for Model, View, and Controller.

## Common .NET Commands

Create a new MVC project:

```bash
dotnet new mvc -n FirstMVCApp
```

Restore project dependencies:

```bash
dotnet restore
```

Run the application:

```bash
dotnet run
```

## Common Tailwind CSS Commands

Install Tailwind dependencies:

```bash
npm install
```

Build Tailwind CSS once:

```bash
npm run css:build
```

Watch Tailwind CSS while developing:

```bash
npm run css:watch
```

## Folder Structure

```text
FirstMVCApp/
├── Controllers/
│   └── HomeController.cs
├── Models/
│   └── ErrorViewModel.cs
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   ├── Shared/
│   │   ├── Error.cshtml
│   │   ├── _Layout.cshtml
│   │   ├── _Layout.cshtml.css
│   │   └── _ValidationScriptsPartial.cshtml
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
├── wwwroot/
│   ├── css/
│   │   ├── site.css
│   │   ├── tailwind.css
│   │   └── tailwind.input.css
│   ├── js/
│   │   └── site.js
│   ├── lib/
│   │   ├── jquery/
│   │   ├── jquery-validation/
│   │   └── jquery-validation-unobtrusive/
│   └── favicon.ico
├── Properties/
│   └── launchSettings.json
├── Program.cs
├── FirstMVCApp.csproj
├── PROJECT_STRUCTURE.md
├── TAILWINDCSS_CONFIGURATION.md
├── appsettings.json
├── appsettings.Development.json
├── package.json
├── package-lock.json
├── node_modules/
├── bin/
└── obj/
```

## Role of Each File and Folder

### Program.cs

This is the starting point of the application. It configures services, middleware, routing, static files, HTTPS redirection, authorization, and controller routes.

### FirstMVCApp.csproj

This is the project file. It defines the project SDK, target framework, package references, build settings, and other project-level configuration.

### appsettings.json

This is the main configuration file. It is commonly used for logging settings, connection strings, API keys, and other app settings.

### appsettings.Development.json

This file contains configuration used only in the Development environment. Values here can override values from `appsettings.json` while developing locally.

### Controllers/

Controllers handle incoming HTTP requests and decide what response to return.

### Controllers/HomeController.cs

This controller handles routes for pages such as the home page, privacy page, and error page.

In MVC:

```text
Controller = receives request, runs logic, returns response
```

### Models/

Models represent data used by the application.

### Models/ErrorViewModel.cs

This model stores data used by the error page, such as the request ID.

In MVC:

```text
Model = data structure used by the app
```

### Views/

Views contain the UI pages. They use Razor syntax with the `.cshtml` file extension.

### Views/Home/Index.cshtml

This is the view for the home page.

### Views/Home/Privacy.cshtml

This is the view for the privacy page.

### Views/Shared/Error.cshtml

This is the shared error page shown when something goes wrong.

### Views/Shared/_Layout.cshtml

This is the main layout file. It contains the common HTML structure, navigation bar, footer, CSS links, and JavaScript references. Other views render inside this layout.

This project now loads Tailwind CSS from:

```html
<link rel="stylesheet" href="~/css/tailwind.css" asp-append-version="true" />
```

Bootstrap CSS and Bootstrap JavaScript are no longer referenced in this layout.

### Views/Shared/_Layout.cshtml.css

This is scoped CSS for `_Layout.cshtml`. The layout styling is currently handled with Tailwind utility classes, so this file only contains a note.

### Views/Shared/_ValidationScriptsPartial.cshtml

This partial view loads client-side validation scripts, usually for forms.

### Views/_ViewImports.cshtml

This file imports namespaces and tag helpers for Razor views, so they do not need to be repeated in every view file.

### Views/_ViewStart.cshtml

This file runs before views are rendered. It usually sets the default layout for the views.

Example:

```cshtml
@{
    Layout = "_Layout";
}
```

### wwwroot/

This is the public web root. Files inside this folder can be served directly to the browser.

### wwwroot/css/site.css

This contains custom global CSS for the application. Bootstrap-specific selectors were removed from this file.

### wwwroot/css/tailwind.input.css

This is the Tailwind CSS input file. It imports Tailwind and tells Tailwind where to scan for utility classes.

### wwwroot/css/tailwind.css

This is the generated Tailwind CSS output file. It is created by running:

```bash
npm run css:build
```

### wwwroot/js/site.js

This contains custom JavaScript for the application.

### wwwroot/favicon.ico

This is the small icon shown in the browser tab.

### wwwroot/lib/jquery/

This contains the jQuery library.

### wwwroot/lib/jquery-validation/

This contains the jQuery validation library used for client-side form validation.

### wwwroot/lib/jquery-validation-unobtrusive/

This connects ASP.NET Core validation attributes with jQuery validation.

### Properties/launchSettings.json

This file controls local launch settings, including ports, environment variables, browser launch behavior, and HTTP/HTTPS profiles.

### package.json

This file contains npm scripts and Tailwind CSS development dependencies.

Important scripts:

```bash
npm run css:build
npm run css:watch
```

### package-lock.json

This file locks the exact npm dependency versions installed for the project.

### node_modules/

This folder contains installed npm packages. It is generated by `npm install` and should not be edited manually.

### TAILWINDCSS_CONFIGURATION.md

This file explains how Tailwind CSS was configured in this project and which Bootstrap references were removed.

### PROJECT_STRUCTURE.md

This file documents the folder structure and role of important generated files.

### bin/

This folder contains compiled output generated when the project is built or run.

### obj/

This folder contains temporary and intermediate build files generated by .NET.

## Quick Summary

```text
Controllers/  -> Request handling
Models/       -> Data objects
Views/        -> UI pages
wwwroot/      -> Tailwind CSS output, custom CSS, JS, images, libraries
Program.cs    -> App startup and configuration
.csproj       -> Project and build definition
appsettings   -> Configuration
package.json  -> Tailwind CSS scripts and npm dependencies
bin/ obj/     -> Generated build output
```
