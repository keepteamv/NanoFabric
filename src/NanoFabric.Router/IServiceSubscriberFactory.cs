using NanoFabric.Router.Consul;
using NanoFabric.Router.Throttle;
using System;
using System.Collections.Generic;
using System.Text;

namespace NanoFabric.Router
{
    /// <summary>
    /// 服务订阅工厂接口
    /// </summary>
    public interface IServiceSubscriberFactory
    {
        /// <summary>
        /// 创建订阅
        /// </summary>
        /// <param name="serviceName">服务名称</param>
        /// <returns></returns>
        IPollingServiceSubscriber CreateSubscriber(string serviceName);

        /// <summary>
        /// 创建订阅
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="consulOptions"></param>
        /// <param name="throttleOptions"></param>
        /// <returns></returns>
        IPollingServiceSubscriber CreateSubscriber(string serviceName, ConsulSubscriberOptions consulOptions,
            ThrottleSubscriberOptions throttleOptions);
    }
}
