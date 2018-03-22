using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace JMooreWeb
{
   public class HasPermissionHandler : AuthorizationHandler<HasPermissionRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HasPermissionRequirement requirement)
        {
            context.Succeed(requirement);

            return null;
        }
    }
}
