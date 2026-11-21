using Microsoft.AspNetCore.Mvc;

namespace Model1.Models
{
    [ApiController]
    public class RestaurantController
    {
        [HttpGet("system/api/restaurant/list")]
        public ApiResult List(int pageNum = 1, int pageSize = 10,
string? restaurantName = null, string? restaurantType = null)
        {
            var q = db.Restaurants.AsQueryable();
            if (!string.IsNullOrEmpty(restaurantName))
                q = q.Where(x => x.RestaurantName!.Contains(restaurantName));


            return ApiResult.Ok();
        }
    }
}
