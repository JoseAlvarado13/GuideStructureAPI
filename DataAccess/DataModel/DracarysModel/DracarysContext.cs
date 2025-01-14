using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.DataModel.DracarysModel
{
    public partial class DracarysContext : DbContext
    {
        public DracarysContext()
        {
        }


        public virtual DbSet<SysErrorLog> SysErrorLogs { get; set; } = null!;

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SysErrorLog>(entity =>
            {
                entity.ToTable("SysErrorLog");

                entity.Property(e => e.CreatedDate)
                    .HasPrecision(2)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorMessage).IsUnicode(false);

                entity.Property(e => e.Host)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsEnable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
