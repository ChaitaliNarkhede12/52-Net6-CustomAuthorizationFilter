using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CustomAuthFilterNetCore
{
    public class CustomAuthorizationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(context != null)
            {
                Microsoft.Extensions.Primitives.StringValues authToken;
                context.HttpContext.Request.Headers.TryGetValue("Authorization", out authToken);

                var token = authToken.FirstOrDefault();

                if(token == null)
                {
                    context.Result = new UnauthorizedObjectResult(string.Empty);
                    return;
                }
            }
        }
    }
}
