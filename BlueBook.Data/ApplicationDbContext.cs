using System;
using System.Collections.Generic;
using System.Text;
using BlueBook.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace BlueBook.Data
{
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ReleaseNote> ReleaseNotes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            ConfigureUser(builder);
        }
    }
}