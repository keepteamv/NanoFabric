using NanoFabric.RegistryHost.ConsulRegistry;

namespace NanoFabric.RegistryHost.ConsulRegistry
{
    /// <summary>
    /// Consul 服务发现选项
    /// </summary>
    public class ConsulServiceDiscoveryOption
    {
        /// <summary>
        /// 服务名称
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Consul 配置
        /// </summary>
        public ConsulRegistryHostConfiguration Consul { get; set; }

        /// <summary>
        /// 健康检查模版
        /// </summary>
        public string HealthCheckTemplate { get; set; }

        public string[] Endpoints { get; set; }
    }
}
