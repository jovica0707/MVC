using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Domain
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        //1. Add property IsOnPromotion to the Pizza Model and the PizzaViewModel. Use an if expression in the Pizza Details View 
        //and add a h4 tag that will stay whether the pizza is on promotion or not depending on the property IsOnPromotion.

        public bool IsOnPromotion { get; set; }
    }
}
