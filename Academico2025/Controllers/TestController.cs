using Microsoft.AspNetCore.Mvc;

namespace Academico2025.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Aula()
        {
            return View();
        }
    }
}
