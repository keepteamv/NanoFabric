using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace NanoFabric.Swagger
{
    internal static class OperationFilterContextExtensions
    {
        internal static bool HasAuthorize(this OperationFilterContext context)
        {
            var apiDescription = context.ApiDescription;

            return
#pragma warning disable CS0618 // 类型或成员已过时
                apiDescription.ControllerAttributes().OfType<AuthorizeAttribute>().Any() ||
#pragma warning restore CS0618 // 类型或成员已过时
#pragma warning disable CS0618 // 类型或成员已过时
                apiDescription.ActionAttributes().OfType<AuthorizeAttribute>().Any();
#pragma warning restore CS0618 // 类型或成员已过时
        }
    }
}