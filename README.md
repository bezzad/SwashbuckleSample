# Swashbuckle Sample
Create **Web API Help** page by __Swashbuckle__ auto document generator

[Main project Link](https://github.com/domaindrivendev/Swashbuckle)

Then manually enable the Swagger docs and, optionally, the swagger-ui by invoking the following extension methods (in namespace Swashbuckle.Application) on an instance of HttpConfiguration (e.g. in Program.cs)

```csharp
httpConfiguration
     .EnableSwagger(c => c.SingleApiVersion("v1", "A title for your API"))
     .EnableSwaggerUi();
```

### OWIN  ###

If your service is hosted using OWIN middleware, just install the Core library:

    Install-Package Swashbuckle.Core

Then manually enable the Swagger docs and swagger-ui by invoking the extension methods (in namespace Swashbuckle.Application) on an instance of HttpConfiguration (e.g. in Startup.cs)

```csharp
httpConfiguration
    .EnableSwagger(c => c.SingleApiVersion("v1", "A title for your API"))
    .EnableSwaggerUi();    
```
