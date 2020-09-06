using SEDC.PizzaApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.ViewModels
{

    /// <summary>
    /// //////////2. Create Pizza ViewModel with the following properties
    /// </summary>
    public class PizzaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public PizzaSize PizzaSize { get; set; }
    }
}
