using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipes sphagetti = new Recipes(1, "Sphagetti", new string[] { "Tomato", "Pasta", "Cheese" });
            Recipes bread = new Recipes(2, "Bread", new string[] { "Flour", "Water", "Yeast" });
            Recipes carbonara = new Recipes(3, "Carbonara", new string[] { "Pasta", "Eggs", "Bacon" });
            Recipes chickenSoup = new Recipes(4, "Chicken Soup", new string[] { "Water", "Chicken", "Spices" });
            Recipes beer = new Recipes(5, "Beer", new string[] { "Hop", "Barley", "Water" });

            Recipes sphagettiBolognese = (Recipes)sphagetti.Clone();
            sphagettiBolognese.ID = 6; 
            sphagettiBolognese.Name = "Sphagetti bolognese"; 
            sphagettiBolognese.Ingredients = new string [] { "Beef", "Tomato", "Mushroom", "Cheese"}; 

            Recipes wheatBeer = (Recipes)beer.Clone();
            wheatBeer.ID = 7;
            wheatBeer.Name = "Wheat beer";
            wheatBeer.Ingredients = new string[] { "Hop", "Wheat", "Water" };    
            
            Recipes beefSoup = (Recipes)chickenSoup.Clone();
            beefSoup.ID = 8;
            beefSoup.Name = "Beef Soup";
            beefSoup.Ingredients[1] = "Beef";

            Console.WriteLine(sphagettiBolognese.ToString());
            Console.WriteLine(wheatBeer.ToString());
            Console.WriteLine(beefSoup.ToString());

            Console.ReadLine();
        }
    }
}
