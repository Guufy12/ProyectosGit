using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Actividad_1_unidad_3___Carlos_Perez.Models;

public partial class TiendaDbContext : DbContext
{
    public TiendaDbContext()
    {
    }

    public TiendaDbContext(DbContextOptions<TiendaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<DetallesCompra> DetallesCompras { get; set; }

    public virtual DbSet<DetallesFactura> DetallesFacturas { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=TiendaDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__CATEGORI__D849E75CD7159CAD");

            entity.ToTable("CATEGORIAS");

            entity.Property(e => e.CategoriaId)
                .ValueGeneratedNever()
                .HasColumnName("CATEGORIA_ID");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CATEGORIA");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__CLIENTES__6BEB1D13777ADE1A");

            entity.ToTable("CLIENTES");

            entity.Property(e => e.ClienteId)
                .ValueGeneratedNever()
                .HasColumnName("CLIENTE_ID");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_COMPLETO");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.CompraId).HasName("PK__COMPRAS__7815C4FF1F46CCCE");

            entity.ToTable("COMPRAS");

            entity.Property(e => e.CompraId)
                .ValueGeneratedNever()
                .HasColumnName("COMPRA_ID");
            entity.Property(e => e.FechaCompras).HasColumnName("FECHA_COMPRAS");
            entity.Property(e => e.ProveedoresId).HasColumnName("PROVEEDORES_ID");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("TOTAL");

            entity.HasOne(d => d.Proveedores).WithMany(p => p.Compras)
                .HasForeignKey(d => d.ProveedoresId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__COMPRAS__PROVEED__47DBAE45");
        });

        modelBuilder.Entity<DetallesCompra>(entity =>
        {
            entity.HasKey(e => e.DetalleCompraId).HasName("PK__DETALLES__D696D99CA11EAC54");

            entity.ToTable("DETALLES_COMPRA");

            entity.Property(e => e.DetalleCompraId)
                .ValueGeneratedNever()
                .HasColumnName("DETALLE_COMPRA_ID");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.CompraId).HasColumnName("COMPRA_ID");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("COSTO_UNITARIO");
            entity.Property(e => e.Impuesto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("IMPUESTO");
            entity.Property(e => e.ProductoId).HasColumnName("PRODUCTO_ID");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SUBTOTAL");

            entity.HasOne(d => d.Compra).WithMany(p => p.DetallesCompras)
                .HasForeignKey(d => d.CompraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DETALLES___COMPR__4BAC3F29");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallesCompras)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DETALLES___PRODU__4AB81AF0");
        });

        modelBuilder.Entity<DetallesFactura>(entity =>
        {
            entity.HasKey(e => e.DetalleId).HasName("PK__DETALLES__83681071E5575D77");

            entity.ToTable("DETALLES_FACTURA");

            entity.Property(e => e.DetalleId)
                .ValueGeneratedNever()
                .HasColumnName("DETALLE_ID");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.FacturaId).HasColumnName("FACTURA_ID");
            entity.Property(e => e.Impuestos)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("IMPUESTOS");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.ProductoId).HasColumnName("PRODUCTO_ID");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("SUBTOTAL");

            entity.HasOne(d => d.Factura).WithMany(p => p.DetallesFacturas)
                .HasForeignKey(d => d.FacturaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DETALLES___FACTU__4316F928");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallesFacturas)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DETALLES___PRODU__4222D4EF");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.FacturaId).HasName("PK__FACTURAS__DBCD01C43849DFCC");

            entity.ToTable("FACTURAS");

            entity.Property(e => e.FacturaId)
                .ValueGeneratedNever()
                .HasColumnName("FACTURA_ID");
            entity.Property(e => e.ClienteId).HasColumnName("CLIENTE_ID");
            entity.Property(e => e.FechaFactura).HasColumnName("FECHA_FACTURA");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("TOTAL");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FACTURAS__CLIENT__3F466844");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__PRODUCTO__D0A52463B80BF795");

            entity.ToTable("PRODUCTOS");

            entity.Property(e => e.ProductoId)
                .ValueGeneratedNever()
                .HasColumnName("PRODUCTO_ID");
            entity.Property(e => e.CategoriaId).HasColumnName("CATEGORIA_ID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PRODUCTO");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.Stock).HasColumnName("STOCK");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PRODUCTOS__CATEG__3A81B327");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.ProveedoresId).HasName("PK__PROVEEDO__AF89796311577D41");

            entity.ToTable("PROVEEDORES");

            entity.Property(e => e.ProveedoresId)
                .ValueGeneratedNever()
                .HasColumnName("PROVEEDORES_ID");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO_ELECTRONICO");
            entity.Property(e => e.NombreProveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_PROVEEDOR");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
