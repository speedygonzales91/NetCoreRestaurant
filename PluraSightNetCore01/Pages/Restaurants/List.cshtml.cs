﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace PluraSightNetCore01.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public ListModel(IConfiguration configuration, IRestaurantData restaurantData)
        {
            this.config = configuration;
            this.restaurantData = restaurantData;
        }
        public void OnGet(string searchterm)
        {
            Message = config["Message"];
            Restaurants = restaurantData.GetRestaurantsByName(searchterm);
        }
    }
}