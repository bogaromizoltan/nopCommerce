using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nop.Plugin.Misc.MyMinimalTest.Controllers
{
    public class TestController : BasePluginController
    {
        public async Task<ActionResult> Index()
        {
            string model = "sry";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://dummypage.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                List<string> orderedItems = new List<string>();
                //foreach (var item in eventMessage.Order.OrderItems)
                //{
                    orderedItems.Add("MyOrder");
                //}

                // HTTP POST
                var gizmo = new
                {
                    Username = "ÚZER",
                    OrderItems = orderedItems,
                    Price = (decimal)12
                };
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Values", gizmo);
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
            return View("~/Plugins/Misc.MyMinimalTest/Views/Index.cshtml", model:model);
        }
    }
}
