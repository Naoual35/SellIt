using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SellIt_ASP.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SellIt_ASP.Utils.IdentityUtils
{
    public static class RoleUtils
    {
        public static IdentityRole CreateOrGetRole(string roleName)
        {
            using (var ctx = new SecurityDbContext())
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(ctx));
                IdentityRole result = null;

                if (!roleManager.RoleExists(roleName))
                {
                    result = new IdentityRole();
                    result.Name = roleName;
                    roleManager.Create(result);
                }

                return result ?? roleManager.FindByName(roleName);
            }
        }

        public static List<IdentityRole> GetRoles()
        {
            using (var ctx = new SecurityDbContext())
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(ctx));

                return roleManager.Roles.ToList();
            }
        }

        public static void AssignRoleToUser(IdentityRole role, ApplicationUser user)
        {
            using (var ctx = new SecurityDbContext())
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(ctx));

                userManager.AddToRole(user.Id, role.Name);
            }
        }
    }
}