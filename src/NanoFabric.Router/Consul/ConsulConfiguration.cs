using System;
using System.Collections.Generic;
using System.Text;

namespace NanoFabric.Router.Consul
{
    /// <summary>
    /// Consul 配置
    /// </summary>
    public class ConsulConfiguration
    {
        /// <summary>
        /// 主机名
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        public int? Port { get; set; }
    }
}
