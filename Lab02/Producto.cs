using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public DateTime FechaVencimiento { get; set; }
    public string Descripcion { get; set; }
    public bool EstaVencido()
    {
        if (DateTime.Now > FechaVencimiento)
        {
            Console.WriteLine("El producto está vencido.");
            return true;
        }
        else
        {
            Console.WriteLine("El producto no está vencido.");
            return false;
        }
    }
    public double GetPrecioVenta()
    {
        double igv = Precio * 0.18;
        double precioVenta = Precio + igv;
        return precioVenta;
    }
}
