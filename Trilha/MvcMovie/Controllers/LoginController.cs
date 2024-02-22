using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Login
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Login
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            // TODO: Implement login logic here

            if (username == "admin" && password == "password")
            {
                // Redirect to home page or any other page
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Display error message
                ViewBag.ErrorMessage = "Invalid username or password";
                return View();
            }
        }
    }
}
