using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagementSystem_CoreMvc.Models;

namespace HotelManagementSystem_CoreMvc.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });
        }
        public DbSet<MenuHelperModel> MenuHelperModel { get; set; }
        public DbSet<MenuModel> MenuModel { get; set; }
        public DbSet<MenuModelManage> MenuModelManage { get; set; }
        public DbSet<HotelManagementSystem_CoreMvc.Models.Adult> Adult { get; set; }
        public DbSet<HotelManagementSystem_CoreMvc.Models.Child> Child { get; set; }
        public DbSet<HotelManagementSystem_CoreMvc.Models.RoomQuantity> RoomQuantity { get; set; }
        public DbSet<HotelManagementSystem_CoreMvc.Models.RoomType> RoomType { get; set; }
        public DbSet<HotelManagementSystem_CoreMvc.Models.BeddingType> BeddingType { get; set; }
        public DbSet<HotelManagementSystem_CoreMvc.Models.Booking> Booking { get; set; }
        public DbSet<HotelManagementSystem_CoreMvc.Models.Food> Food { get; set; }
        public DbSet<HotelManagementSystem_CoreMvc.Models.Guest> Guest { get; set; }
        public DbSet<HotelManagementSystem_CoreMvc.Models.OrderFood> OrderFood { get; set; }
        public DbSet<HotelManagementSystem_CoreMvc.Models.Room> Room { get; set; }
        public DbSet<HotelManagementSystem_CoreMvc.Models.Reservasion> Reservasion { get; set; }
        public DbSet<HotelManagementSystem_CoreMvc.Models.AuthenticModel> AuthenticModel { get; set; }

        public DbSet<ApplicationRole> ApplicationRole { get; set; }


        public DbSet<ApplicationUserRole> ApplicationUserRole { get; set; }
    }
}
