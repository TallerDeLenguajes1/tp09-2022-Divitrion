public class Archivo
{
    public string nombre { get; set; }
    public string ruta { get; set; }
    public int indice {get; set;}

    public Archivo(string nombre, string ruta, int indice)
    {
        this.nombre = nombre;
        this.ruta = ruta;
        this.indice = indice;
    }
}
