using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LibaryOfGames.Models;
using LibaryOfGames.Models;
namespace LibaryOfGames.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LibaryOfGames.Models.Games> Games { get; set; }
        public DbSet<LibaryOfGames.Models.Reviews> Reviews { get; set; }
       
    }
}
