using AzureFunctions.Extensions.Swashbuckle;
using FunctionMonkey.Abstractions;
using FunctionMonkey.Abstractions.Builders;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.Commands;
using Swashbuckle.Customers;
using Swashbuckle.Handlers;

namespace Swashbuckle
{
    public class FunctionAppConfiguration : IFunctionAppConfiguration
    {
        public void Build(IFunctionHostBuilder builder)
        {
            builder
                .Setup((serviceCollection, commandRegistry) =>
                {
                    commandRegistry.Register<HelloWorldCommandHandler>();
                    commandRegistry.Register<CreateCustomerHttpRequestDtoHandler>();
                })
                .Swashbuckle(swashbuckle => swashbuckle
                    .UserInterface()
                )
                .OpenApiEndpoint(openApi => openApi
                    .Title("My API Title")
                    .Version("0.0.0")
                    .UserInterface()
                )
                .Functions(functions => functions
                    .HttpRoute("v1/HelloWorld", route => route
                        .HttpFunction<HelloWorldCommand>()
                    )
                );
        }
    }
}
