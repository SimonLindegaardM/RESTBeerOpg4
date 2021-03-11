using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTBeer.Models;

namespace RESTBeer.Managers
{
    public class BeerManager
    {
        private static int _nextId = 1;
        private static readonly List<Beer> Data = new List<Beer>()
        {
            new Beer(_nextId++, "Corona", 15, 15),

            new Beer(_nextId++, "Carlsberg", 10, 20),
            new Beer(_nextId++, "Pilsner", 12, 10),
            new Beer(_nextId++, "Heineken", 8, 15),
            new Beer(_nextId++, "Tuborg", 20, 25)
        };
        public IEnumerable<Beer> GetAll()
        {
            return Data;
        }

        public Beer GetId(int id)
        {
            return Data.Find(Beer => Beer.Id == id);
        }

        public void Add(Beer value)
        {
            value.Id = _nextId++;
            Data.Add(value);
        }

        public Beer Update(int id, Beer value)
        {
            Beer item = Data.Find(item1 => item1.Id == id);
            if (item == null) return null;
            item.Name = value.Name;
            item.Price = value.Price;
            item.Abv = value.Abv;
            return item;
        }

        public Beer Delete(int id)
        {
            Beer item = Data.Find(item1 => item1.Id == id);
            if (item == null) return null;

            Data.Remove(item);
            return item;
        }
    }
}
