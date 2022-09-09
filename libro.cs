 //clase principal
 public class garaje
    {
        //metodo principal
        static void Main(string[] args)
        {
 
            // definimos una istancia de garaje como coche y la inicializo con unos parametros
            Coche c = new Coche(1, "BMW", "4", 100, 12000);
 
            //  consultar de precio de coche
            Console.WriteLine(c.precio);
 
            // consultar de marca de coche
            Console.WriteLine(c.marca);
 
            // Modifico el precio del coche con el set
            c.precio = 15000;
 
            // Vuelvo a mostrar para ver si se ha modificado
            Console.WriteLine(c.precio);
 
            // Muestro el estado completo
            Console.WriteLine(c.ToString());
 
            Console.ReadLine();
        }
    }
