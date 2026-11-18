using BlogWebsiteProject.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogWebsiteProject.Models
{
    public class VolunteerContext : DbContext
    {
        public DbSet<SDFoodBankVolunteerData> foodBankVolunteerDatas { get; set; }

        public VolunteerContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
