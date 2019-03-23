using NanoFabric.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NanoFabric.Router
{

    /// <summary>
    /// 负载均衡接口
    /// </summary>
    public interface ILoadBalancer
    {
        Task<RegistryInformation> Endpoint(CancellationToken ct = default(CancellationToken));
    }
}
