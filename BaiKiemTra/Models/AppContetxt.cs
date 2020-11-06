using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTra.Models
{
    public class AppContetxt:DbContext
    {
        public AppContetxt(DbContextOptions<AppContetxt> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Posts> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categories>().HasData(new Categories { Id = 1, Title = "Tin Tuc" });
            modelBuilder.Entity<Categories>().HasData(new Categories { Id = 2, Title = "Van Hoa" });
            modelBuilder.Entity<Categories>().HasData(new Categories { Id = 3, Title = "Am Thuc" });

            modelBuilder.Entity<Tags>().HasData(new Tags { Id = 1, Title = "Tin Nong" });
            modelBuilder.Entity<Tags>().HasData(new Tags { Id = 2, Title = "Con nguoi" });
            modelBuilder.Entity<Tags>().HasData(new Tags { Id = 3, Title = "Mon Ngon" });

            modelBuilder.Entity<Pogtag>().HasKey(posttag => new { posttag.PostId, posttag.TagId });
        }
    }
}


