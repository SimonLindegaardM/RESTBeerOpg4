using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTBeer.Models
{
    public class Beer
    {
        public Beer(int id, string name, double price, double abv)
        {
            Id = id;
            Name = name;
            Price = price;
            Abv = abv;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Abv { get; set; }

        public Beer()
        {
            
        }

    }
}
