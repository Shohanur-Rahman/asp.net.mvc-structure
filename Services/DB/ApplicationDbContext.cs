using Services.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DB
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("DefaultConnection")
        {

        }

        public virtual DbSet<BlogCategoryMapper> BlogCategoryMapper { get; set; }
        public virtual DbSet<Categories> Category { get; set; }
        public virtual DbSet<PostComments> PostComments { get; set; }
        public virtual DbSet<POSTS> POST { get; set; }
        public virtual DbSet<UserProfiles> UserProfile { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }

        public virtual DbSet<USERS> USER { get; set; }
    }
}
