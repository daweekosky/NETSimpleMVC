using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Models;
using System.Diagnostics;

namespace SimpleMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PhoneBookService _phoneBook;


        public HomeController(ILogger<HomeController> logger, PhoneBookService phoneBook)
        {
            _logger = logger;
            _phoneBook = phoneBook;
        }

        public IActionResult Index()
        {
            return View(_phoneBook.GetContacts());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
