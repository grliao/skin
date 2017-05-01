using Skin.Models;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skin.EF
{
    public class SkinDbContext : DbContext
    {
        public SkinDbContext()
            :base("skin")
        {
        }

        public IDbSet<Project> Projects
        {
            get;
            set;
        }

        public IDbSet<Member> Members
        {
            get;
            set;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new SqliteDropCreateDatabaseWhenModelChanges<SkinDbContext>(modelBuilder,typeof(CustomHistory)));
        }
    }

    public class CustomHistory : IHistory
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string Context { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
