using Microsoft.Extensions.Logging;
using NanoFabric.Core.Json;
using NanoFabric.Core.MqMessages;
using NanoFabric.Core.Threading;
using Rebus.Bus;
using System.Threading.Tasks;

namespace NanoFabric.MqMessages.RebusCore
{
    /// <summary>
    /// RabiitMQ发布
    /// </summary>
    public class RebusRabbitMqPublisher : IMqMessagePublisher
    {
        private readonly IBus _bus;

        public ILogger Logger { get; set; }

        public RebusRabbitMqPublisher(IBus bus, ILoggerFactory factory)
        {
            _bus = bus;
            Logger = factory.CreateLogger<RebusRabbitMqPublisher>();
        }

        /// <summary>
        /// 发布队列消息
        /// </summary>
        /// <param name="mqMessages"></param>
        public void Publish(object mqMessages)
        {
            Logger.LogDebug(mqMessages.GetType().FullName + ":" + mqMessages.ToJsonString());

            AsyncHelper.RunSync(() => _bus.Publish(mqMessages));
        }
        /// <summary>
        /// [异步]发布队列消息
        /// </summary>
        /// <param name="mqMessages"></param>
        /// <returns></returns>
        public async Task PublishAsync(object mqMessages)
        {
            Logger.LogDebug(mqMessages.GetType().FullName + ":" + mqMessages.ToJsonString());

            await _bus.Publish(mqMessages);
        }
    }
}
