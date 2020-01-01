using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> Restaurants;
        public InMemoryRestaurantData()
        {
            Restaurants = new List<Restaurant>()
            {
                new Restaurant() { Id = 0, Name = "PizzaCastle", Location = "Italy", Cuisine = CuisineType.Italian },
                new Restaurant() { Id = 1, Name = "Gulasch", Location = "Hungary", Cuisine = CuisineType.Hungarian },
                new Restaurant() { Id = 2, Name = "Mexico", Location = "Mexico", Cuisine = CuisineType.Mexican }
            };
        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return name == null ? Restaurants : Restaurants.FindAll(x => x.Name.Contains(name));
        }
    }
}
