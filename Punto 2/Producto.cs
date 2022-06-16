public enum size 
{
    Small=0,
    Medium=1,
    Large=2,
}

public class Producto
{
    public string nombre { get; set; }
    public DateTime fechavencimiento { get; set; }
    public float precio { get; set; }
    public size size { get; set; }

    public Producto()
    {
        this.nombre= "nombre";
        this.fechavencimiento= DateTime.Today;
        this.precio = (float) new Random().Next(1000,5000);
        this.size = (size)new Random().Next(0,3);
    }
}