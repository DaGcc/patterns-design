using Patron_Simple_Factory;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {


        int valorEntrada;
        bool estaCorrecto, estadoOperacion;

        do
        {

            do
            {
                Console.WriteLine("Ingrese [1: PRODUCTO_A], [2: PRODUCTO_B] O [3: PRODUCTO_C]");
                valorEntrada = int.TryParse(Console.ReadLine(), out int valorParseado) ? valorParseado : 0;
                estaCorrecto = valorEntrada == 1 || valorEntrada == 2 || valorEntrada == 3;
            } while (!estaCorrecto);

            ProductoTipos tipoProducto = valorEntrada switch
            {
                1 => ProductoTipos.A,
                2 => ProductoTipos.B,
                3 => ProductoTipos.C,
                _ => ProductoTipos.A // PRODUCTO POR DEFECTO 
            };

            IProducto producto = SimpleFactory.CrearInstancia(tipoProducto);
            producto.NombreProducto();


            Console.WriteLine("¿Desea seguir ingrasnado un tipo de producto? [Y: si] [N : no]");
            string respuestaUsuario = Console.ReadLine() ?? "N";
            estadoOperacion = (respuestaUsuario == "Y" || respuestaUsuario == "y") ? true : false;

        } while (estadoOperacion);

    }

}
