using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class SqlServerData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;

        public SqlServerData(OdeToFoodDbContext db)
        {
            this.db = db;
        }
        public Restaurant Add(Restaurant newRestaurant)
        {
            db.Restaurants.Add(newRestaurant);
            return newRestaurant;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Restaurant Delete(int id)
        {
            var restaurantToDelete = GetRestaurantById(id);
            if (restaurantToDelete !=null)
            {
                db.Restaurants.Remove(restaurantToDelete);
            }
            return restaurantToDelete;
        }

        public int GetCountOfRestaurants()
        {
            return db.Restaurants.Count();
        }

        public Restaurant GetRestaurantById(int id)
        {
            return db.Restaurants.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            var restaurants = from r in db.Restaurants
                             where r.Name.Contains(name) || string.IsNullOrEmpty(name)
                             orderby r.Name
                             select r;

            return restaurants;
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var entity = db.Restaurants.Attach(updatedRestaurant);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return updatedRestaurant;
        }
    }
}
