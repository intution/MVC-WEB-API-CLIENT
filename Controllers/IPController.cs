using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIClient.Controllers
{
    public class IPController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://api.ipify.org/?format=json");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var ipResponse = JsonSerializer.Deserialize<WebAPIClient.Models.IPResponse>(content);
                    ViewBag.IP = ipResponse;
                }
            }

            return View();
        }
    }
}
