using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Core;
using OdeToFood.Data;

namespace PluraSightNetCore01.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        public IRestaurantData RestaurantData { get; }
        public IHtmlHelper HtmlHelper { get; }

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public IEnumerable<SelectListItem> Cuisines { get; set; }

        public EditModel(IRestaurantData restaurantData, IHtmlHelper htmlHelper)
        {
            RestaurantData = restaurantData;
            HtmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int? restaurantId)
        {
            if (restaurantId.HasValue)
            {
                Restaurant = RestaurantData.GetRestaurantById(restaurantId.Value);
                if (Restaurant == null)
                {
                    return RedirectToPage("./NotFound");
                }
            }
            else
            {
                Restaurant = new Restaurant();
            }


            Cuisines = HtmlHelper.GetEnumSelectList<CuisineType>();
            return Page();
        }

        public IActionResult OnPost()
        {
            //if (ModelState.IsValid)
            //{
            //    Cuisines = HtmlHelper.GetEnumSelectList<CuisineType>();
            //    Restaurant = RestaurantData.Update(Restaurant);
            //    //PRG - Post Redirect to Get
            //    return RedirectToPage("./Detail", new { restaurantId = Restaurant.Id });
            //}
            //RestaurantData.Commit();
            //return Page();

            if (!ModelState.IsValid)
            {
                Cuisines = HtmlHelper.GetEnumSelectList<CuisineType>();
                return Page();
            }

            if (Restaurant.Id > 0)
            {
                Restaurant = RestaurantData.Update(Restaurant);
            }
            else
            {
                RestaurantData.Add(Restaurant);
            }
            TempData["Message"] = "Restaurant Saved";
            RestaurantData.Commit();
            return RedirectToPage("./Detail", new { restaurantId = Restaurant.Id });
        }
    }
}