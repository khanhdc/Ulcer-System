using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models.Framework
{
    public partial class UlcerDbContext : DbContext
    {
        public UlcerDbContext()
            : base("name=UlcerDbContext")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<ACCOUNT_GROUP> ACCOUNT_GROUP { get; set; }
        public virtual DbSet<ACCOUNT_PERMISSION> ACCOUNT_PERMISSION { get; set; }
        public virtual DbSet<ACCOUNT_ROLE> ACCOUNT_ROLE { get; set; }
        public virtual DbSet<AI_GEN_IMAGE> AI_GEN_IMAGE { get; set; }
        public virtual DbSet<QR_HASHTABLE> QR_HASHTABLE { get; set; }
        public virtual DbSet<RECORD_FILE_JSON> RECORD_FILE_JSON { get; set; }
        public virtual DbSet<SUPERVISE> SUPERVISEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.PROFILE_IMAGE)
                .IsUnicode(false);
        }
    }
}
