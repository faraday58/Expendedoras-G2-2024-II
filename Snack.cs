using System;
using System.Text.RegularExpressions;


namespace Expendedoras_G2_2024_II
{
    internal class Snack:Expendedora
    {
        public Snack()
        {
           
            Temperatura = 14;
            Console.WriteLine("Temperatura {0}", Temperatura);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            //string codigo; Esto no es posible, por que no hay valor asignado
            MostrarPrecio(codigo);
        }
    }
}
