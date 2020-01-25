using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
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

        public Restaurant Add(Restaurant newRestaurant)
        {
            Restaurants.Add(newRestaurant);
            newRestaurant.Id = Restaurants.Max(r => r.Id) + 1;
            return newRestaurant;
        }

        public int Commit()
        {
            return 0;
        }

        public Restaurant Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Restaurant GetRestaurantById(int id)
        {
            return Restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return name == null ? Restaurants : Restaurants.FindAll(x => x.Name.Contains(name));
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = Restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
            if (restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.Cuisine = updatedRestaurant.Cuisine;
            }

            return restaurant;
        }
    }
}
