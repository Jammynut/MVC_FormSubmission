using Microsoft.AspNetCore.Mvc;
using MVC_FormSubmission.Models;
using System;
using System.Diagnostics;


namespace MVC_FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Index(PersonModel person)
        {

            // Does the commented out code below need to be here? Does it need to be within a new object of the class to view the data?

            /* 
            string firstName = person.FirstName;
            string lastName = person.LastName;
            string emailAddress = person.Email;
            string phoneNumber = person.Phone;
            string address = person.Address;
            */

            return View("Success");

        }

       public IActionResult Success()
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