//Se leen las categorias y los productos
Categoria categoria1 = new Categoria();
categoria1 = CategoriasBLL.Read(1);

Producto producto1 = new Producto();
producto1 = ProductosBLL.Read(1);


//Primero hay que registrar un cliente
Cliente sander = new Cliente();
sander.ClienteId = 1;
sander.Nombre = "Sander";
sander.Apellido = "Peguero Mendoza";
sander.Cedula = "402-3432812-4";
sander.Telefono = "829-506-3137";


//Segundo hay que registrar un dispositivo
Dispositivo iphonex = new Dispositivo();
iphonex.DispositivoId = 1;
iphonex.Marca = "Apple";
iphonex.Modelo = "Iphone X";
iphonex.IMEI = "123456789012345";
iphonex.Color = "Negro";
iphonex.Teclado = false;
// iphonex.ClienteId = 1;

//Tercero hay que agregar el dispositivo a una lista y asociarla al cliente
List<Dispositivo> dispositivos = new List<Dispositivo>();
dispositivos.Add(iphonex);


sander.Dispositivos.Add(new Dispositivo());
Console.WriteLine(sander.Dispositivos.Count());
// sander.Dispositivos.AddRange(dispositivos);


// ClientesBLL.Update(sander);
ClientesBLL.Create(sander);
// ClientesBLL.Delete(sander);


//Cuarto se agregan a una lista los problemas que identifico el cliente (Detalle)
RecepcionDetalle problema = new RecepcionDetalle();
problema.RecepcionDetalleId = 1;
problema.Detalle = "El celular no da señales de vida";



//Quinto se crea una recepcion al cliente, se inserta la lista de problemas, se asigna un tecnico, se selecciona una categoria y un Producto
Recepcion recepcion1 = new Recepcion();
recepcion1.RecepcionId = 1;
recepcion1.Fecha = DateTime.Now;
recepcion1.Cliente = sander;
recepcion1.Problemas.Add(problema);
recepcion1.Tecnico = "Federico";
recepcion1.Categoria = categoria1;
recepcion1.Producto = producto1;