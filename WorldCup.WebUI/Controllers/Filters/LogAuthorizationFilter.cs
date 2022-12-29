using Microsoft.AspNetCore.Mvc.Filters;

namespace WorldCup.WebUI.Controllers.Filters
{
    public class LogAuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
      
            Console.WriteLine("Filter Authorization LogAuthorization");
        }
    }
}
