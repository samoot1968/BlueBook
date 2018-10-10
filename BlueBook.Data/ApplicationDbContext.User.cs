using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlueBook.Data
{
    partial class ApplicationDbContext
    {

       protected static void ConfigureUser(ModelBuilder builder)
       {
           builder.Entity<IdentityUser>().ToTable("Users");
       }
    }
}