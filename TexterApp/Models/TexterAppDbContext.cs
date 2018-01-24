using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace TexterApp.Models
{
    public class TexterAppDbContext : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }

      

        public TexterAppDbContext(DbContextOptions<TexterAppDbContext> options)
        {
            
        }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
          options.UseMySql(@"Server=localhost;Port=8889;database=Texter;uid=root;pwd=root;");
		}

        protected override void OnModelCreating(ModelBuilder builder)
        {
			base.OnModelCreating(builder);
        }
    }
}