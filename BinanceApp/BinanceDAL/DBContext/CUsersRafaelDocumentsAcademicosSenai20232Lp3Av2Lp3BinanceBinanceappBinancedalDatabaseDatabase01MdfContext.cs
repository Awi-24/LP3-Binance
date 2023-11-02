using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BinanceMODEL;

namespace BinanceDAL.DBContext;



public partial class CUsersRafaelDocumentsAcademicosSenai20232Lp3Av2Lp3BinanceBinanceappBinancedalDatabaseDatabase01MdfContext : DbContext
{
    public CUsersRafaelDocumentsAcademicosSenai20232Lp3Av2Lp3BinanceBinanceappBinancedalDatabaseDatabase01MdfContext()
    {
    }

    public CUsersRafaelDocumentsAcademicosSenai20232Lp3Av2Lp3BinanceBinanceappBinancedalDatabaseDatabase01MdfContext(DbContextOptions<CUsersRafaelDocumentsAcademicosSenai20232Lp3Av2Lp3BinanceBinanceappBinancedalDatabaseDatabase01MdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafael\\Documents\\Academicos\\Senai\\2023.2\\LP3\\Av.2\\LP3-Binance\\BinanceApp\\BinanceDAL\\Database\\Database01.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC27DC1D27F5");

            entity.ToTable("Usuario");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Senha)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
