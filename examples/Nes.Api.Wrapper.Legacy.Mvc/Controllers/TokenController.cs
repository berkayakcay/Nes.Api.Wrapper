using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nes.Api.Wrapper.Legacy.Mvc.Models;

namespace Nes.Api.Wrapper.Legacy.Mvc.Controllers
{
    [Route("[controller]")]
    public class TokenController : Controller
    {
        private readonly IApiClient _apiClient;
        private readonly ILogger<HomeController> _logger;

        public TokenController(
            IApiClient apiClient,
            ILogger<HomeController> logger
        )
        {
            _apiClient = apiClient;
            _logger = logger;
        }

        // GET
        [HttpGet("")]
        [HttpGet("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        // POST
        [HttpPost("")]
        [HttpPost("[action]")]
        public async Task<IActionResult> Index(TokenViewModel model)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Hatalı istek");
                return View(model);
            }

            // TOKEN ALL
            var tokenResponse = await _apiClient.Token();
            _logger.LogInformation("Token alındı");
            
            if (!string.IsNullOrWhiteSpace(tokenResponse.error))
            {
                ModelState.AddModelError("token-error", tokenResponse.error);
                _logger.LogWarning("Hatalı istek");
                return View(model);
            }

            HttpContext.Session.SetString("access_token",tokenResponse.access_token);

            return View(model);
        }
    }
}