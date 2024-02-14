using System;

namespace Expendedoras_G2_2024_II
{
    internal class Cafe:Expendedora
    {
        internal override string MostrarProducto()
        {
            Console.WriteLine("C1: Americano \t D2: Capuchino");
            Console.WriteLine("Ingrese el código de producto");
            string codigo = "";
            codigo = Console.ReadLine();
            return codigo ;
        }

        internal override void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "C1":
                    Console.WriteLine("Precio :${0}",  );
                    break;
                case "D1":
                    Console.WriteLine("Precio: ${0}",);
                    break;
                default:
                    Console.WriteLine(" Producto no encontrado");
                    break;

            }
            
        }



        //Comentario
        public Cafe()
        {
            Console.WriteLine("Que tal un delicioso Café");
        }
    }
}
