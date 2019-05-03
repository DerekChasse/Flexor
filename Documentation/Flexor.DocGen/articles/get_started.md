# Get Started With Flexor

## Prerequisites
* Visual Studio 2019 
  * [https://visualstudio.microsoft.com/](https://visualstudio.microsoft.com/)
* Dot Net Core SDK 3.0.0 preview4 
  * [https://dotnet.microsoft.com/download/dotnet-core/3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0])

### Startup.cs
Update `Startup.cs` to include the following.

```csharp
...
public void ConfigureServices(IServiceCollection services)
{
    services.AddFlexor();
}
...
```

### _Imports.razor
Get intellisense for Flexor components and classes by adding the following to the root `_Imports.razor` file.

```csharp
...
@using Flexor
...
```

### All Done!
Start using Flexor in your own Blazor components.  Take a look at the [Demo site](http://flexor.azurewebsites.net/) for examples.
