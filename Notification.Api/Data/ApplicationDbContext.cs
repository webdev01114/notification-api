using Microsoft.EntityFrameworkCore;
using Notification.Api.Models;

namespace Notification.Api.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Order> orders { get; set; }
    }
}
