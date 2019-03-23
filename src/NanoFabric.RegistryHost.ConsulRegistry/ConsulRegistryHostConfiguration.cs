using System;
using System.Net;

namespace NanoFabric.RegistryHost.ConsulRegistry
{
    /// <summary>
    /// Consul 注册主机配置
    /// </summary>
    public class ConsulRegistryHostConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        public string HttpEndpoint { get; set; }

        /// <summary>
        /// DNS EndPoint
        /// </summary>
        public DnsEndpoint DnsEndpoint { get; set; }

        /// <summary>
        /// 数据中心
        /// </summary>
        public string Datacenter { get; set; }

        /// <summary>
        /// ACLToken
        /// </summary>
        public string AclToken { get; set; }

        /// <summary>
        /// 最大等待时间
        /// </summary>
        public TimeSpan? LongPollMaxWait { get; set; }

        /// <summary>
        /// 重试延迟时间
        /// </summary>
        public TimeSpan? RetryDelay { get; set; } = Defaults.ErrorRetryInterval;
    }

    public class DnsEndpoint
    {
        /// <summary>
        /// 主机地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 主机端口
        /// </summary>
        public int Port { get; set; }

        public IPEndPoint ToIPEndPoint()
        {
            return new IPEndPoint(IPAddress.Parse(Address), Port);
        }
    }

    public static class Defaults
    {
        public static TimeSpan ErrorRetryInterval => TimeSpan.FromSeconds(15);

        public static TimeSpan UpdateMaxInterval => TimeSpan.FromSeconds(15);
    }
}
