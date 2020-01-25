using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public Restaurant Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Restaurant GetRestaurantById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            throw new NotImplementedException();
        }
    }
}
