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
#pragma warning disable CS0618 // ���ͻ��Ա�ѹ�ʱ
                apiDescription.ControllerAttributes().OfType<AuthorizeAttribute>().Any() ||
#pragma warning restore CS0618 // ���ͻ��Ա�ѹ�ʱ
#pragma warning disable CS0618 // ���ͻ��Ա�ѹ�ʱ
                apiDescription.ActionAttributes().OfType<AuthorizeAttribute>().Any();
#pragma warning restore CS0618 // ���ͻ��Ա�ѹ�ʱ
        }
    }
}