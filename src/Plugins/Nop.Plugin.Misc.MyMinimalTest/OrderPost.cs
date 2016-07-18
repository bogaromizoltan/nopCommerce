using Nop.Core.Domain.Orders;
using Nop.Services.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.MyMinimalTest
{
    class OrderPost : IConsumer<OrderPlacedEvent>
    {
        public void HandleEvent(OrderPlacedEvent eventMessage)
        {
            string model = "sry";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://dummypage.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                List<string> orderedItems = new List<string>();
                foreach (var item in eventMessage.Order.OrderItems)
                {
                    orderedItems.Add(item.Product.Name);
                }

                // HTTP POST
                var gizmo = new
                {
                    Username = "ÚZER",
                    OrderItems = orderedItems,
                    Price = (decimal)12
                };
                var task = client.PostAsJsonAsync("api/Values", gizmo);
                task.ConfigureAwait(false);
                HttpResponseMessage response = task.Result;
                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    //Uri gizmoUrl = response.Headers.Location;
                    model = "success!!"; //gizmoUrl.AbsolutePath;
                }
                else
                {
                    model = "sorry...";
                }
            }
        }
    }
}
