using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaria.Pages.Models;

namespace RazorPizzaria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitile="Margerita", PizzaName="Margerita", BasePrice=2, TomatoSouce=true,Cheese=true, FinalPrice=4},
            new PizzasModel(){ImageTitile = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 2, TomatoSouce = true,Ham = true, FinalPrice = 4},
            new PizzasModel(){ImageTitile = "Carbonara", PizzaName = "Carbonara", BasePrice = 2, TomatoSouce = true,Ham = true,Mushrooms=true, FinalPrice = 5},
            new PizzasModel(){ImageTitile = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 2, TomatoSouce = true,Beef = true, FinalPrice = 4},
            new PizzasModel(){ImageTitile="Mushroom", PizzaName="Mushroom", BasePrice=2, TomatoSouce=true,Mushrooms=true, FinalPrice=4},
            new PizzasModel(){ImageTitile="Pepperoni", PizzaName="Pepperoni", BasePrice=2, TomatoSouce=true,Peperoni=true, FinalPrice=4},
            new PizzasModel(){ImageTitile="Seafood", PizzaName="Seafood", BasePrice=2, TomatoSouce=true,Tuna=true, FinalPrice=4},
            new PizzasModel(){ImageTitile="Bolognese", PizzaName="Bolognese", BasePrice=2, TomatoSouce=true, FinalPrice=3},
            new PizzasModel(){ImageTitile="Vegetarian", PizzaName="Vegetarian", BasePrice=2, TomatoSouce=true,Cheese=true,Mushrooms=true, FinalPrice=5},

        };
        public void OnGet()
        {
        }
    }
}
