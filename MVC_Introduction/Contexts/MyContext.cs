using Microsoft.EntityFrameworkCore;
using MVC_Introduction.CustomTools;
using MVC_Introduction.Models.Configs;
using MVC_Introduction.Models.Entities;

namespace MVC_Introduction.Contexts
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt) : base(opt)
        {

        }
        public MyContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            DataSeedStructure.AddCategories(modelBuilder);

        }
        public DbSet<Category> Categories { get; set; }
    }
}
