using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using XenaTech.CalPids.LKPApi.Domain;

namespace XenaTech.CalPids.LKPApi.Data
{
    public class XtCalPidsDbContext : IdentityDbContext
    {
        public XtCalPidsDbContext(DbContextOptions<XtCalPidsDbContext> options)
           : base(options)
        {
        }

        public DbSet<TripLkp> TripLkps { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
