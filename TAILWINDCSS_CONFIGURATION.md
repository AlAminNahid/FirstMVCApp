# Tailwind CSS Configuration

This ASP.NET Core MVC project originally included Bootstrap by default. The layout has been updated to use Tailwind CSS instead of Bootstrap.

## Files Added

### package.json

This file contains the Tailwind CSS npm dependencies and scripts.

```json
{
  "scripts": {
    "css:build": "tailwindcss -i ./wwwroot/css/tailwind.input.css -o ./wwwroot/css/tailwind.css",
    "css:watch": "tailwindcss -i ./wwwroot/css/tailwind.input.css -o ./wwwroot/css/tailwind.css --watch"
  }
}
```

### wwwroot/css/tailwind.input.css

This is the Tailwind input file.

```css
@import "tailwindcss";

@source "../../Views";
@source "../../Controllers";
@source "../../Models";
```

### wwwroot/css/tailwind.css

This is the generated Tailwind output file. It is created by running the Tailwind build command.

## Files Updated

### Views/Shared/_Layout.cshtml

The Bootstrap stylesheet was removed:

```html
<link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
```

The Bootstrap JavaScript bundle was also removed:

```html
<script src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
```

The Tailwind output stylesheet was added:

```html
<link rel="stylesheet" href="~/css/tailwind.css" asp-append-version="true" />
```

Bootstrap layout classes such as `navbar`, `container`, `nav-link`, and `border-top` were replaced with Tailwind utility classes.

### Views/Home/Index.cshtml

Bootstrap classes were replaced with Tailwind utility classes.

### wwwroot/css/site.css

Bootstrap-specific CSS selectors were removed.

## Install Dependencies

Run this command from the project root:

```bash
npm install
```

## Build Tailwind CSS

Run this once to generate the Tailwind CSS file:

```bash
npm run css:build
```

## Watch Tailwind CSS During Development

Run this while editing views:

```bash
npm run css:watch
```

Keep this running in one terminal, then run the ASP.NET Core app in another terminal:

```bash
dotnet run
```
