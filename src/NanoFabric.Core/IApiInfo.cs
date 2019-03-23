using System.Collections.Generic;
using System.Reflection;

namespace NanoFabric.Core
{
    /// <summary>
    /// API信息接口
    /// </summary>
    public interface IApiInfo
    {
        /// <summary>
        /// server-side-bound listener address
        /// </summary>
        string BindAddress { get; set; }

        /// <summary>
        /// service-side-bound listening ports
        /// </summary>
        int BindPort { get; set; }

        /// <summary>
        /// 身份验证机构
        /// </summary>
        string AuthenticationAuthority { get; }

        /// <summary>
        /// API名称
        /// </summary>
        string ApiName { get; }
        /// <summary>
        /// ApiSecret
        /// </summary>
        string ApiSecret { get; }

        /// <summary>
        /// 标题
        /// </summary>
        string Title { get; }

        /// <summary>
        /// 版本号
        /// </summary>
        string Version { get; }
        /// <summary>
        /// Assembly
        /// </summary>
        Assembly ApplicationAssembly { get; }

        /// <summary>
        /// 范围
        /// </summary>
        IDictionary<string, string> Scopes { get; }

        /// <summary>
        /// Swagger权限信息
        /// </summary>
        SwaggerAuthInfo SwaggerAuthInfo { get; }
        
    }

    /// <summary>
    /// Swagger权限信息
    /// </summary>
    public class SwaggerAuthInfo
    {
        /// <summary>
        /// 客户端ID
        /// </summary>
        public string ClientId { get; }
        /// <summary>
        /// 
        /// </summary>
        public string Secret { get; }
        /// <summary>
        /// 
        /// </summary>
        public string Realm { get;  }

        public SwaggerAuthInfo(
            string clientId, 
            string secret, 
            string realm
            )
        {
            ClientId = clientId;
            Secret = secret;
            Realm = realm;
        }
    }
}
