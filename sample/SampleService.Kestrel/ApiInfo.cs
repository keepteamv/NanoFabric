using Microsoft.Extensions.Configuration;
using NanoFabric.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SampleService.Kestrel
{
    /// <summary>
    /// API Informartion
    /// </summary>
    public class ApiInfo : IApiInfo
    {
        private ApiInfo(IConfiguration config)
        {
            AuthenticationAuthority = config["Authority"];
        }

        /// <summary>
        /// 
        /// </summary>
        public string AuthenticationAuthority { get; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title => "SampleService_Kestrel Api";

        /// <summary>
        /// 版本
        /// </summary>
        public string Version => "v1";

        /// <summary>
        /// 
        /// </summary>
        public Assembly ApplicationAssembly => GetType().Assembly;

        /// <summary>
        /// 范围
        /// </summary>
        public IDictionary<string, string> Scopes => new Dictionary<string, string>
        {
            {"api1", Title}
        };

        /// <summary>
        /// 
        /// </summary>
        public SwaggerAuthInfo SwaggerAuthInfo => new SwaggerAuthInfo(
            "echoapiswaggerui", "", ""
            );

        /// <summary>
        /// 实例化
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static IApiInfo Instantiate(IConfiguration config)
        {
            Instance = new ApiInfo(config);
            return Instance;
        }
        /// <summary>
        /// 实例
        /// </summary>
        public static IApiInfo Instance { get; private set; }

        /// <summary>
        /// API名称
        /// </summary>
        public string ApiName => "api1";

        /// <summary>
        /// 
        /// </summary>
        public string ApiSecret => "secret";

        /// <summary>
        /// 绑定的地址
        /// </summary>
        public string BindAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// 绑定的端口
        /// </summary>
        public int BindPort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
