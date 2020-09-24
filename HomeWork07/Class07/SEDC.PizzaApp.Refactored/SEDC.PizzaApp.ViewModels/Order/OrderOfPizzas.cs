using SEDC.PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.Order
{
    public class OrderOfPizzas
    {
        public int OrderId { get; set; }
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
         public PaymentMethod PaymentMethod { get; set; }
        public string PizzaStore { get; set; }
        public bool Deliverd { get; set; }
        [Display(Name = "User")]
        public int UserId { get; set; }
    }
}
