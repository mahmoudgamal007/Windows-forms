using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2.models
{
    public class ITIDbcontext : DbContext
    {
        public  DbSet<Owner> Owners { get; set; }
        public  DbSet<Author> Authors { get; set; }
        public  DbSet<Blog> Blogs { get; set; }
        public  DbSet <Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-A1JGNAP\ITISQL;Database=ITIBlog;Trusted_Connection=True;");
        }
    }
}
