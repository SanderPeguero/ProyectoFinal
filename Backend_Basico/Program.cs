//Se crean las categorias y los productos
Categoria categoria1 = new Categoria();
categoria1.Id = 1;
categoria1.Nombre = "No enciende";
categoria1.Descripcion = "El dispositivo no suena, tampoco vibra, ni muestra nada en pantalla";

Producto producto1 = new Producto();
producto1.Id = 1;
producto1.Nombre = "Cambio de Bateria";
producto1.Precio = 800;
producto1.Descripcion = "El tecnico retira la bateria vieja y la cambia por una nueva";



//Primero hay que registrar un cliente
Cliente sander = new Cliente();
sander.Id = 1;
sander.Nombre = "Sander";
sander.Apellido = "Peguero Mendoza";
sander.Cedula = "402-3432812-4";
sander.Telefono = "829-506-3137";


//Segundo hay que registrar un dispositivo
Dispositivo iphonex = new Dispositivo();
iphonex.Id = 1;
iphonex.Marca = "Apple";
iphonex.Modelo = "Iphone X";
iphonex.IMEI = "123456789012345";
iphonex.Color = "Negro";
iphonex.Teclado = false;


//Tercero hay que agregar el dispositivo a una lista y asociarla al cliente
List<Dispositivo> dispositivos = new List<Dispositivo>();
dispositivos.Add(iphonex);

sander.Dispositivos = dispositivos;



//Cuarto se agregan a una lista los problemas que identifico el cliente (Detalle)
List<string> problemas = new List<string>();
problemas.Add("El celular no da señales de vida");



//Quinto se crea una recepcion al cliente, se inserta la lista de problemas, se asigna un tecnico, se selecciona una categoria y un Producto
Recepcion recepcion1 = new Recepcion();
recepcion1.Id = 1;
recepcion1.Fecha = DateTime.Now;
recepcion1.Cliente = sander;
recepcion1.Problemas = problemas;
recepcion1.Tecnico = "Federico";
recepcion1.Categoria = categoria1;
recepcion1.Producto = producto1;



