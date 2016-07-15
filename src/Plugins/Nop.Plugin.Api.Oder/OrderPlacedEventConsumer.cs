using System;
using Nop.Core;
using Nop.Core.Domain.Orders;
using Nop.Core.Plugins;
using Nop.Services.Events;
using Nop.Services.Orders;

namespace Nop.Plugin.Api.Order
{
    public class OrderPlacedEventConsumer : IConsumer<OrderPlacedEvent>
    {

        public OrderPlacedEventConsumer()
        {

        }

        /// <summary>
        /// Handles the event.
        /// </summary>
        /// <param name="eventMessage">The event message.</param>
        public void HandleEvent(OrderPlacedEvent eventMessage)
        {
            // ITT kéne ügyeskedni
        }
    }
}