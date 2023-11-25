﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Models;

public partial class Sof205FinalTestContext : DbContext
{
    public Sof205FinalTestContext()
    {
    }

    public Sof205FinalTestContext(DbContextOptions<Sof205FinalTestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chunhan> Chunhans { get; set; }

    public virtual DbSet<Cuahang> Cuahangs { get; set; }

    public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }

    public virtual DbSet<Phuhuynh> Phuhuynhs { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Sinhvien> Sinhviens { get; set; }

    public virtual DbSet<Thucung> Thucungs { get; set; }

    public virtual DbSet<Trungtam> Trungtams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-MN98SD2\\SQLEXPRESS;Initial Catalog=SOF205_FINAL_TEST;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chunhan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHUNHAN__3213E83FFBF2D5A3");

            entity.ToTable("CHUNHAN");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("diachi");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<Cuahang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUAHANG__3213E83F4108F233");

            entity.ToTable("CUAHANG");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCn).HasColumnName("idCN");
            entity.Property(e => e.Loaihang)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("loaihang");
            entity.Property(e => e.Mota)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("mota");
            entity.Property(e => e.Ngaydangky)
                .HasColumnType("date")
                .HasColumnName("ngaydangky");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.Cuahangs)
                .HasForeignKey(d => d.IdCn)
                .HasConstraintName("FKCH_TT");
        });

        modelBuilder.Entity<Nhacungcap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NHACUNGC__3213E83F823725C0");

            entity.ToTable("NHACUNGCAP");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("diachi");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<Phuhuynh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PHUHUYNH__3213E83F8C5DAB62");

            entity.ToTable("PHUHUYNH");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nghenghiep)
                .HasMaxLength(50)
                .HasColumnName("nghenghiep");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SANPHAM__3213E83F9ECCBA22");

            entity.ToTable("SANPHAM");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Giatien).HasColumnName("giatien");
            entity.Property(e => e.IdNcc).HasColumnName("idNCC");
            entity.Property(e => e.Mota)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("mota");
            entity.Property(e => e.Soluongtonkho).HasColumnName("soluongtonkho");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");

            entity.HasOne(d => d.IdNccNavigation).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.IdNcc)
                .HasConstraintName("FK_SP_NCC");
        });

        modelBuilder.Entity<Sinhvien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SINHVIEN__3213E83F218BBE7E");

            entity.ToTable("SINHVIEN");

            entity.HasIndex(e => e.Email, "UQ__SINHVIEN__AB6E61649A6240E0").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Diachi)
                .HasMaxLength(100)
                .HasColumnName("diachi");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdPh).HasColumnName("idPH");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sdt");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");

            entity.HasOne(d => d.IdPhNavigation).WithMany(p => p.Sinhviens)
                .HasForeignKey(d => d.IdPh)
                .HasConstraintName("FK_SV_PH");
        });

        modelBuilder.Entity<Thucung>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__THUCUNG__3213E83F27A65B8F");

            entity.ToTable("THUCUNG");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCn).HasColumnName("idCN");
            entity.Property(e => e.Loai)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("loai");
            entity.Property(e => e.Maulong)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maulong");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
            entity.Property(e => e.Tuoi).HasColumnName("tuoi");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.Thucungs)
                .HasForeignKey(d => d.IdCn)
                .HasConstraintName("FK_TC_CN");
        });

        modelBuilder.Entity<Trungtam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TRUNGTAM__3213E83FC8EE4B11");

            entity.ToTable("TRUNGTAM");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("diachi");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
