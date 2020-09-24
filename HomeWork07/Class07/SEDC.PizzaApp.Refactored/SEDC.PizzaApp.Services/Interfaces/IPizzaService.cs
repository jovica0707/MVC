using System;
using System.Collections.Generic;
using System.Text;
using SEDC.PizzaApp.ViewModels.Pizza;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaDDViewModel> GetPizzasForDropdown();

        List<PizzaViewModel> GetAllPizzas();
        PizzaViewModel GetPizzaById(int value);
        void CreatePizza(PizzaViewModel pizzaViewModel);
        string GetMostPopularPizza();
        string GetPizzaOnPromotion();
        bool PizzaPromotionValidation();
    }
}
