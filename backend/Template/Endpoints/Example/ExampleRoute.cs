using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Template.Services;

namespace Template.Endpoints.Example;

public static class ExampleRoute
{
    public static RouteHandlerBuilder AddExampleRoute(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/", (string name, IExampleService exampleService) => new GetExampleResponse($"Hello, {exampleService.GetExampleName()}!"));
    }
}