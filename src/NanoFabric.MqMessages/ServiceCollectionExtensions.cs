using Microsoft.Extensions.DependencyInjection;
using NanoFabric.Core.MqMessages;
using NanoFabric.MqMessages.RebusCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NanoFabric.MqMessages
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加消息列表服务支持
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddMqMessages(this IServiceCollection services 
           )
        {
            services.AddSingleton<IMqMessagePublisher, RebusRabbitMqPublisher>();
            return services;
        }
    }
}
