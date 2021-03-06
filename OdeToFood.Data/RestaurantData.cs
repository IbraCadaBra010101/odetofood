using System.Collections.Generic;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant AddRestaurant(Restaurant newRestaurant);
        Restaurant DeleteRestaurant(int id);
        int GetCountOfRestaurants();
        int Commit();
    }
}
