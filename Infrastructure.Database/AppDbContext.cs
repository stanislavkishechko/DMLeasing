using BL.Common.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<BlogItem> BlogItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2D26A077-C0CD-4227-92A4-7F491D4E9FB8",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "B6B515D2-BF75-46ED-BBCE-D6E4C1D94A91",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "stanislavkishechko@gmail.com",
                NormalizedEmail = "STANISLAVKISHECHKO@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "2D26A077-C0CD-4227-92A4-7F491D4E9FB8",
                UserId = "B6B515D2-BF75-46ED-BBCE-D6E4C1D94A91"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("180F7F1F-8F0F-4B5F-8C01-01AC5E82C147"),
                CodeWord = "PageIndex",
                Title = "Home"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("EED99B4E-2757-4680-9EA2-6792614F7910"),
                CodeWord = "PageServices",
                Title = "Services"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("37F4CE07-3D5C-4F97-92E0-136EF206911D"),
                CodeWord = "PageContacts",
                Title = "Contacts"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("D7ACA643-4BD4-4B9E-86FA-959A28FD5104"),
                CodeWord = "PageBlog",
                Title = "Blog"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("03346C28-762E-432C-908C-74F4F955EBC6"),
                CodeWord = "PageFinance",
                Title = "Finance"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("CA606B23-5271-4D95-AFB7-30DA96CBB535"),
                CodeWord = "PageLeaseVSBuy",
                Title = "Lease VS Buy"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("C7BD0218-551A-4A36-88CC-7000F2F00DF4"),
                CodeWord = "PageDealers",
                Title = "Dealers"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("5AF04BAA-A8B6-4D1C-B6C6-A3DD9889181E"),
                CodeWord = "PagePartners",
                Title = "Partners"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("FC80C25C-D652-4C00-BF9D-67DDCA1BBC0A"),
                CodeWord = "PageTerms",
                Title = "Terms of Use"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("988110BB-8C5E-4D52-A734-5FE2A0364FA2"),
                CodeWord = "PagePrivacy",
                Title = "Privacy"
            });

        }
    }
}
