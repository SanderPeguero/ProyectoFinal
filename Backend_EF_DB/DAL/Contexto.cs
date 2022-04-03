using Microsoft.EntityFrameworkCore;

public class Contexto:DbContext{
    public DbSet<Categoria> Categorias {get; set;}

    public DbSet<Producto> Productos {get; set;}

    public DbSet<Cliente> Clientes {get; set;}

    public DbSet<Recepcion> Recepciones {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        
        optionsBuilder.UseSqlite("Data Source=Datos.db");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){

        modelBuilder.Entity<Categoria>().HasData(
            new Categoria { CategoriaId = 1, Nombre = "No enciende", Descripcion = "El dispositivo no suena, tampoco vibra, ni muestra nada en pantalla"}
        );

        modelBuilder.Entity<Producto>().HasData(
            new Producto { ProductoId = 1, Nombre = "Cambio de Bateria", Precio = 800, Descripcion ="El tecnico retira la bateria vieja y la cambia por una nueva" }
        );

    }
}
