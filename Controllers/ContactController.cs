using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FirstApp.Interfaces;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FirstApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _ContactService;
        public ContactController( IContactService _contactService)
        {
            _ContactService = _contactService;
        }

        public IActionResult Index()
        {
            return View(_ContactService.List());
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(ContactModel contact)
        {
            try
            {
                _ContactService.Create(contact);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPatch]
        public ActionResult Edit(int id, ContactModel contact)
        {
            try
            {
                _ContactService.Update(contact);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult DeleteConfirm()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}