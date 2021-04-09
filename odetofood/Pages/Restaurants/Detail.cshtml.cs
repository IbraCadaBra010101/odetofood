
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace odetofood.Pages.Restaurants
{
    public class DetailModel : PageModel
    { 
        private readonly IRestaurantData restaurantData;
        [TempData]
        public string Added { get; set; }
        [TempData]
        public string Updated { get; set; }
        public Restaurant Restaurant { get; set; }
      

        public DetailModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }
        public IActionResult OnGet(int restaurantId) 
        {
            Restaurant = restaurantData.GetById(restaurantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");

            }
            return Page();
        }
    }
}
