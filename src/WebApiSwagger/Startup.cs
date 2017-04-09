using Microsoft.Owin;
using Owin;
using System.Linq;
using System.Web.Http;
using Swashbuckle.Application;
using WebApiSwagger.App_Start;

[assembly: OwinStartup(typeof(WebApiSwagger.Startup))]
namespace WebApiSwagger
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
            HttpConfiguration config = new HttpConfiguration();
            
            // Enable Swagger (see https://github.com/domaindrivendev/Swashbuckle)
            config.EnableSwagger(c =>
             {
                 c.Schemes(new[] { "http", "https" });
                 c.SingleApiVersion("v1", "Test Student API Help")
                     .Description("A sample API for testing and prototyping Swashbuckle features")
                     .TermsOfService("Some terms");
                     //.Contact(cc => cc.Name("Some contact").Url("http://tempuri.org/contact").Email("some.contact@tempuri.org"))
                     //.License(lc => lc.Name("Some License").Url("http://tempuri.org/license"));
                 c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                 c.IncludeXmlComments(SwaggerConfig.GetXmlCommentsPath());
             }).EnableSwaggerUi();

            WebApiConfig.Register(config);
            app.UseWebApi(config);

        }
    }
}
