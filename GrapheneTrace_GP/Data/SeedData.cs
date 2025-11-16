using Microsoft.AspNetCore.Identity;

namespace GrapheneTrace_GP.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();

            var roles = new[] { "Patient", "Clinician", "Admin" };
            foreach (var r in roles)
            {
                if (!await roleManager.RoleExistsAsync(r))
                    await roleManager.CreateAsync(new IdentityRole(r));
            }

            // Optional: create a local admin account for testing (use env secret or prompt)
            var adminEmail = "local.admin@dev";
            if (await userManager.FindByEmailAsync(adminEmail) == null)
            {
                var admin = new IdentityUser { UserName = adminEmail, Email = adminEmail, EmailConfirmed = true };
                await userManager.CreateAsync(admin, "AdminP@ssw0rd!"); // change locally and never check in real creds
                await userManager.AddToRoleAsync(admin, "Admin");
            }
        }
    }
}