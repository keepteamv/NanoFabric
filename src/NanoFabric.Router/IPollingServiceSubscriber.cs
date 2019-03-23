using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NanoFabric.Router
{
    /// <summary>
    /// 轮询服务订阅接口
    /// </summary>
    public  interface IPollingServiceSubscriber : IServiceSubscriber
    {
        /// <summary>
        /// 开始订阅
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task StartSubscription(CancellationToken ct = default(CancellationToken));

        event EventHandler EndpointsChanged;
    }
}
