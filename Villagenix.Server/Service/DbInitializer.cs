using Microsoft.AspNetCore.Identity;
using Villagenix.DataAccess.Data;
using Villagenix.Server.Service.IService;

namespace Villagenix.Server.Service
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public void Initalize()
        {

        }
    }
}
