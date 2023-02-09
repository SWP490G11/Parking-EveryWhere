using Back_end.Entities;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Back_end.Authorization
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {

        private readonly ICollection<Role> _roles;

        public AuthorizeAttribute(params Role[] roles)
        {
            _roles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            throw new NotImplementedException();
        }
    }
}
