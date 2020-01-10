using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SellIt_ASP.Utils.IdentityUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
   
namespace SellIt_ASP.Models.Security
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            if (this.Database.CreateIfNotExists())
            {
                IdentityRole userRole = RoleUtils.CreateOrGetRole("User");
                IdentityRole adminRole = RoleUtils.CreateOrGetRole("Admin");

                UserManager<ApplicationUser> userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(this));
                ApplicationUser admin = new ApplicationUser() { UserName = "admin", Email = "loic.simonetto@gmail.com", Login = "admin" };
                var result = userManager.Create(admin, "Lolo!421");
                if (!result.Succeeded)
                {
                    this.Database.Delete();
                    throw new System.Exception("database insert fail");
                }
                RoleUtils.AssignRoleToUser(adminRole, admin);
            }
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}