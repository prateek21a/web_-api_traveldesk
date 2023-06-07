using Microsoft.EntityFrameworkCore;
using TravelDesk.Models;

namespace TravelDesk.Context
{
    public class TravelDeskDbContext : DbContext
    {
        public TravelDeskDbContext()
        {
            
        }
        public TravelDeskDbContext(DbContextOptions<TravelDeskDbContext> options) :base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<ApplicationRequest> ApplicationRequests { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<MasterDataReference> MasterDataReferences { get; set; }

        public DbSet<ApplicationRequestHistory> ApplicationRequestsHistory { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<HistoryDetails> HistoryDetails { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<City> Citys { get; set; } 
        public DbSet<UserRoleMapping> UserRoles { get; set; }
          
     }


}

