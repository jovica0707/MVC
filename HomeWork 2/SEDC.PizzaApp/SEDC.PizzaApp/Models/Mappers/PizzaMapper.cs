using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enums;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{

    /// <summary>
    /// /////4. Create a Mapper from Pizza Model to Pizza View Model
    /// </summary>
    public static class PizzaMapper
    {
        public static  PizzaViewModel PizzaToViewModel (Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                PizzaSize = pizza.PizzaSize,

            };
        
        }
    }
}
