using System.Text.Json;

var listaProductos = new List<Producto>();
StreamWriter productos = new StreamWriter(@"C:\Users\Alumno\Desktop\Taller\tp09-2022-Divitrion\Punto 2\productos.json");

for (int i = 0; i < new Random().Next(1,5); i++)
{
    var producto = new Producto();
    listaProductos.Add(producto);
}

var jsonString = JsonSerializer.Serialize(listaProductos);

productos.WriteLine(jsonString);
productos.Close();

using (StreamReader sr = new StreamReader(@"C:\Users\Alumno\Desktop\Taller\tp09-2022-Divitrion\Punto 2\productos.json"))
{
    string jsonFile = sr.ReadLine();
    var listaNueva = JsonSerializer.Deserialize<List<Producto>>(jsonFile);
    foreach (var producto in listaNueva)
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine(producto.nombre);
        Console.WriteLine(producto.fechavencimiento);
        Console.WriteLine(producto.size);
        Console.WriteLine(producto.precio);
        Console.WriteLine("-----------------------\n");
    }
}