using System.Collections.Generic;

namespace NanoFabric.Router.Consul
{
    /// <summary>
    /// Consul 订阅选项类
    /// </summary>
    public class ConsulSubscriberOptions
    {
        public static readonly ConsulSubscriberOptions Default = new ConsulSubscriberOptions();

        public List<string> Tags { get; set; }

        public bool PassingOnly { get; set; } = true;
    }
}