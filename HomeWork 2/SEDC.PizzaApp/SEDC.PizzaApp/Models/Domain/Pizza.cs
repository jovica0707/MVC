using SEDC.PizzaApp.Models.Enums;
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

        /////1.	Extend the Pizza model with the following properties:
        ///
        public decimal Price { get; set; }

        public PizzaSize PizzaSize { get; set; }

        public bool HasExtras { get; set; }


    }
}
