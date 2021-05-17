using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNET_Filters.Models
{
    public class IpFilterAttribute: ResultFilterAttribute
    {
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next) 
        {
            if (context.Result is PageResult page)
            {
                page.ViewData["ip"] = context.HttpContext.Connection.RemoteIpAddress;
            }
            await next();
        }
    
    }
}