using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDb.Pizzas;
            List<PizzaViewModel> pizzaViewModels = pizzas.PizzaToViewModel();


            return View(pizzaViewModels);
             // returns ViewResult
        }

        public IActionResult JsonData()
        {
            Pizza pizza = new Pizza
            {
                Id = 1,
                Name = "Capri",
                Price = 340
            };
            return new JsonResult(pizza); // returns JsonResult
        }

        public IActionResult BackToHome()
        {
            return RedirectToAction("Index", "Home"); //redirects to Action Index in Home Controller
        }

        public IActionResult Details(int? id) // localhost:port/Pizza/Details/1 or  localhost:port/Pizza/Details
        {
            ViewData["Title"] = "Pizza details:";
            if (id != null)
            {
                ViewBag.Pizza = StaticDb.Pizzas.PizzaToViewModel().FirstOrDefault(p => p.Id == id);
                if (ViewBag.Pizza != null)
                {
                    return View();
                }
                return View("No Data");
            }
            return View("BadRequest");
        }
    }
}