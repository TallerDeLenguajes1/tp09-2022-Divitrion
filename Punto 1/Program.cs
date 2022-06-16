using System.Text.Json;
var JsonList = new List<Archivo>();
string ruta;

Console.WriteLine("Ingrese la ruta de un directorio: ");
ruta=Console.ReadLine();

StreamWriter index = new StreamWriter(@"C:\Users\Alumno\Desktop\Taller\tp09-2022-Divitrion\index.json");
ExtraerArchivos(ruta, JsonList);
ExtraerCarpetas(ruta, JsonList);
string jsonString = JsonSerializer.Serialize(JsonList);
index.WriteLine(jsonString);
index.Close();


static void ExtraerCarpetas(string ruta,List<Archivo> lista)
{
    var carpetas = Directory.GetDirectories(ruta).ToList();
    if (carpetas.Count() > 0)
    {
        foreach (var carpeta in carpetas)
        {
            ExtraerCarpetas(carpeta, lista);
            ExtraerArchivos(carpeta, lista);
        }
    }
}

static void ExtraerArchivos(string ruta,List<Archivo> lista)
{
    var archivos = new List<FileInfo>();
    archivos = new DirectoryInfo(ruta).GetFiles().ToList();
    int contador = 1;
    foreach (var item in archivos)
    {
        var archivo = new Archivo(item.Name,ruta,contador);
        lista.Add(archivo);
        contador++;
    }
}