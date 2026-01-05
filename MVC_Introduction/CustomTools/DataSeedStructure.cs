using Microsoft.EntityFrameworkCore;
using MVC_Introduction.Models.Entities;

namespace MVC_Introduction.CustomTools
{
    public static class DataSeedStructure
    {
        public static void AddCategories(ModelBuilder modelBuilder)
        {


            Category c = new()
            {
                ID=1,
                CategoryName="Tatlılar"
            };
            Category a = new() 
            {
                ID=2,
                CategoryName="Kitaplar"
            };
            Category b = new() 
            {
                ID=3,
                CategoryName="Giyim"
            };
            modelBuilder.Entity<Category>().HasData(c);
            modelBuilder.Entity<Category>().HasData(a);
            modelBuilder.Entity<Category>().HasData(b);
        }
    }
}
