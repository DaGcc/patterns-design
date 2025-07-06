using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Simple_Factory
{
    internal class ProductoConcretoA : IProducto
    {
        public void NombreProducto()
        {
            Console.WriteLine("Producto A");
        }
    }
}
