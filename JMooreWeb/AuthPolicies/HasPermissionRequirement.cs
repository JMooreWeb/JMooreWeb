using Microsoft.AspNetCore.Authorization;

namespace JMooreWeb
{
    public class HasPermissionRequirement : IAuthorizationRequirement
    {
        public string PermissionName { get; set; }
    }
}
