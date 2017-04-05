# Swashbuckle Sample
Create **Web API Help** page by __Swashbuckle__ auto document generator

[Main project Link](https://github.com/domaindrivendev/Swashbuckle)

Swashbuckle
=========

Seamlessly adds a [Swagger](http://swagger.io/) to WebApi projects! Combines ApiExplorer and Swagger/swagger-ui to provide a rich discovery, documentation and playground experience to your API consumers.

In addition to its Swagger generator, Swashbuckle also contains an embedded version of [swagger-ui](https://github.com/swagger-api/swagger-ui) which it will automatically serve up once Swashbuckle is installed. This means you can complement your API with a slick discovery UI to assist consumers with their integration efforts. Best of all, it requires minimal coding and maintenance, allowing you to focus on building an awesome API!

And that's not all ...

Once you have a Web API that can describe itself in Swagger, you've opened the treasure chest of Swagger-based tools including a client generator that can be targeted to a wide range of popular platforms. See [swagger-codegen](https://github.com/swagger-api/swagger-codegen) for more details.

**Swashbuckle Core Features:**

* Auto-generated [Swagger 2.0](https://github.com/swagger-api/swagger-spec/blob/master/versions/2.0.md)
* Seamless integration of swagger-ui
* Reflection-based Schema generation for describing API types
* Extensibility hooks for customizing the generated Swagger doc
* Extensibility hooks for customizing the swagger-ui
* Out-of-the-box support for leveraging Xml comments
* Support for describing ApiKey, Basic Auth and OAuth2 schemes ... including UI support for the Implicit OAuth2 flow

**\*Swashbuckle 5.0**

Swashbuckle 5.0 makes the transition to Swagger 2.0. The 2.0 schema is significantly different to its predecessor (1.2) and, as a result, the Swashbuckle config interface has undergone yet another overhaul. Checkout the [transition guide](#transitioning-to-swashbuckle-50) if you're upgrading from a prior version.

## Getting Started ##

There are currently two Nuget packages - the Core library (Swashbuckle.Core) and a convenience package (Swashbuckle)  - that provides automatic bootstrapping. The latter is only applicable to regular IIS hosted Web APIs. For all other hosting environments, you should only install the Core library and then follow the instructions below to manually enable the Swagger routes.

Once installed and enabled, you should be able to browse the following Swagger docs and UI endpoints respectively:

***\<your-root-url\>/swagger/docs/v1***

***\<your-root-url\>/swagger***

### IIS Hosted ###

If your service is hosted in IIS, you can start exposing Swagger docs and a corresponding swagger-ui by simply installing the following Nuget package:

    Install-Package Swashbuckle

This will add a reference to Swashbuckle.Core and also install a bootstrapper (App_Start/SwaggerConfig.cs) that enables the Swagger routes on app start-up using [WebActivatorEx](https://github.com/davidebbo/WebActivator).

### Self-hosted ###

If your service is self-hosted, just install the Core library:

    Install-Package Swashbuckle.Core

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
