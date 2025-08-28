# Azimzada.MVC.UserFriendlyException

This package enables you to display user-friendly error messages as modal pop-ups in ASP.NET Core MVC projects.

## Installation

To add as a NuGet package to your project:

```bash
dotnet add package Azimzada.MVC.UserFriendlyException
```

## Configuration

1. Add the filter to your MVC pipeline in your `Program.cs` file:

```csharp
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<UserFriendlyExceptionFilter>();
});
```

2. Add the modal partial view at the bottom of your `_Layout.cshtml` file, before the `</body>` tag:

```cshtml
@await Html.PartialAsync("_UserFriendlyErrorModal")
</body>
```

## Usage

To throw a user-friendly exception in your controllers:

```csharp
public class HomeController : Controller
{
    public IActionResult Index()
    {
        if (someErrorCondition)
        {
            throw new UserFriendlyException("Unable to access your account. Please try again later.");
        }
        return View();
    }
}
```

## Features

- Displays user-friendly error messages as modals
- Includes automatic styling and JavaScript
- Responsive design
- Easy integration
- Bootstrap compatible

## Contributing

Please open an Issue or submit a Pull Request to contribute.

## License

Licensed under the MIT License. See [LICENSE](LICENSE) file for details.
# Azimzada.MVC.UserFriendlyException
# Azimzada.MVC.UserFriendlyException
