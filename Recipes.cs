using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    class Recipes:ICloneable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string [] Ingredients { get; set; }

        public Recipes(int ID, string Name, string[] Ingredients)
        {
            this.ID = ID;
            this.Name = Name;
            this.Ingredients = Ingredients;
            Console.WriteLine(ToString());
        }


        public object Clone()
        {
            Console.WriteLine("Cloning ...");
            return new Recipes(ID, Name, Ingredients);
        }

        public override string ToString()
        {
            string result = "ID: " + Convert.ToString(ID) +  ", Name: " + Name + ", Ingredients: ";
            foreach(string element in Ingredients)
            {
                result += element + " ";
            }

            return result;
        }


    }
}
