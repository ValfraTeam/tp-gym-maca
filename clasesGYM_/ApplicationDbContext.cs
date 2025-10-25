using System;
using Microsoft.EntityFrameworkCore;
using clasesGYM_;
public class AplicationDbContext: DbContext
{
    public DbSet<Factura> Facturas { get; set; }
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<Suscripcion> Suscripciones { get; set; }   
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Clase> Clases { get; set; }
    public DbSet<SuscripcionCliente> SuscripcionClientes { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configuración original (comentada)
        // optionsBuilder.UseSqlServer(
        //     "Server=localHost;Database=SistemaGym;Trusted_Connection=True;TrustServerCertificate=True;"
        // );
        
        // Configuración para Docker SQL Server
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=SistemaGym;User Id=sa;Password=TuPassword123;TrustServerCertificate=True;"
        );
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configurar tablas
        modelBuilder.Entity<Factura>().ToTable("Facturas");
        modelBuilder.Entity<Pago>().ToTable("Pagos");
        modelBuilder.Entity<Suscripcion>().ToTable("Suscripciones");
        modelBuilder.Entity<Cliente>().ToTable("Clientes");
        modelBuilder.Entity<Clase>().ToTable("Clases");
        
        // CONFIGURACIÓN DE LA TABLA INTERMEDIA
        // Mapea la clase SuscripcionCliente a la tabla SuscripcionClientes en la BD
        modelBuilder.Entity<SuscripcionCliente>().ToTable("SuscripcionClientes");

        // CONFIGURACIÓN DE LA CLAVE PRIMARIA COMPUESTA
        // Define que la clave primaria es la COMBINACIÓN de ClienteId + SuscripcionId
        // Esto evita que un cliente tenga la misma suscripción duplicada
        modelBuilder.Entity<SuscripcionCliente>()
            .HasKey(sc => new { sc.ClienteId, sc.SuscripcionId });

        // CONFIGURACIÓN DE LA RELACIÓN: Cliente → SuscripcionCliente
        // Una SuscripcionCliente pertenece a UN Cliente
        // Un Cliente puede tener MUCHAS SuscripcionCliente (historial de suscripciones)
        modelBuilder.Entity<SuscripcionCliente>()
            .HasOne(sc => sc.Cliente)           // Una SuscripcionCliente tiene UN Cliente
            .WithMany(c => c.Suscripciones)    // Un Cliente tiene MUCHAS SuscripcionCliente
            .HasForeignKey(sc => sc.ClienteId); // La clave foránea es ClienteId

        // CONFIGURACIÓN DE LA RELACIÓN: Suscripcion → SuscripcionCliente
        // Una SuscripcionCliente pertenece a UNA Suscripcion
        // Una Suscripcion puede tener MUCHOS SuscripcionCliente (diferentes clientes)
        modelBuilder.Entity<SuscripcionCliente>()
            .HasOne(sc => sc.Suscripcion)      // Una SuscripcionCliente tiene UNA Suscripcion
            .WithMany(s => s.Clientes)         // Una Suscripcion tiene MUCHOS SuscripcionCliente
            .HasForeignKey(sc => sc.SuscripcionId); // La clave foránea es SuscripcionId
    }

}
