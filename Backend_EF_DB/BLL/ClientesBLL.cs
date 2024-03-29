using Microsoft.EntityFrameworkCore;

public class ClientesBLL{
    private static Contexto contexto = new Contexto();

    public static bool Create(Cliente cliente){//Inserta un Cliente a la base de datos

        bool successfull = false;
        contexto.Clientes.Add(cliente);
        // contexto.Entry(cliente).State = EntityState.Added;

        successfull = contexto.SaveChanges() > 0;

        return successfull;

    }

    public static Cliente Read(int Id){//Lee el Cliente con el id dado en la base de datos y lo devuelve

        Cliente cliente = new Cliente();

        cliente = contexto.Clientes.Find(Id);

        return cliente;

    }

    public static bool Update(Cliente cliente){//Dado un Cliente, modifica el equivalente en la base de datos
        
        bool successfull = false;

        if(contexto.Clientes.Any(l => l.ClienteId == cliente.ClienteId)){
            contexto.Clientes.Update(cliente);
            //contexto.Entry(cliente).State = EntityState.Modified;
            successfull = contexto.SaveChanges() > 0;

        }

        return successfull;

    }

    public static bool Delete(Cliente cliente){//Dado un Cliente, elimina el equivalente en la base de datos
    
        bool successfull = false;

        // contexto.Entry(cliente).State = EntityState.Deleted;
        contexto.Remove(cliente);
        successfull = contexto.SaveChanges() > 0;
        
        return successfull;

    }

    public static Cliente BuscarNombre(string Nombre){//Busca y retorna el objeto que contiene el nombre
        
        return contexto.Clientes
            .Where(x => x.Nombre == Nombre)
            .FirstOrDefault();

    }

}