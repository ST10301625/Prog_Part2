using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Prog2bPOEPart2.Models;


//tutorialsEU - C# (2023). CREATE and CONNECT DATABASES in ASP.NET. [online] YouTube. 
//   Available at: https://www.youtube.com/watch?v=ZX12X-ALwGA [Accessed 11 Oct. 2024].
// The tutorial above shows how to connect a database to mvc using ssms‌


 namespace Prog2bPOEPart2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Prog2bPOEPart2.Models.Claim> Claim { get; set; } = default!;
        public DbSet<Prog2bPOEPart2.Models.Document> Document { get; set; } = default!;
    }
}
