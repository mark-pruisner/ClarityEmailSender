using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using EmailWebApp.Models;

namespace EmailWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult SendEmail()
        {
            return View(new EmailViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(EmailViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var json = JsonSerializer.Serialize(new
            {
                to = model.To,
                subject = model.Subject,
                body = model.Body
            });

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:5262/api/email", content);

            model.StatusMessage = response.IsSuccessStatusCode
                ? "Email request sent successfully!"
                : "Failed to send email.";

            return View(model);
        }
    }
}

