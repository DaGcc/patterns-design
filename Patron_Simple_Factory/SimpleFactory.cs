namespace Patron_Simple_Factory
{
    public class SimpleFactory
    {

        public static IProducto CrearInstancia(ProductoTipos productoTipos)
        {

            return productoTipos switch
            {
                ProductoTipos.A => new ProductoConcretoA(),
                ProductoTipos.B => new ProductoConcretoB(),
                ProductoTipos.C => new ProductoConcretoC(),
                _ => new ProductoConcretoA()
            }; 

            //switch (productoTipos)
            //{
            //    case ProductoTipos.A:
            //        break;
            //    case ProductoTipos.B:
            //        break;
            //    case ProductoTipos.C:
            //        break;
            //    default:
            //        throw new ArgumentException("El tipo producto no existe");
            //}

        }

    }


    public enum ProductoTipos 
    {
        A,
        B,
        C
    }

}
