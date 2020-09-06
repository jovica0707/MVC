using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public Pizza Pizza { get; set; }
        public User User { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        ////3. Extend the OrderViewModel with property address from the address of the user and add it to the OrderDetailsViewModel Mapper.
        ///
        public string Address { get; set; }
    }
}
