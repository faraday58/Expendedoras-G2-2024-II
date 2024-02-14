using System;
using System.Threading;

namespace Expendedoras_G2_2024_II
{
    internal abstract class Expendedora
    {

        #region Atributos
        private string marca;
        private ushort cantProductos;
        private byte temperatura;
        private float precio;

        #endregion

        #region Propiedades
        public byte Temperatura {
            get => temperatura;
            set
            {
                if ( value < 10 || value > 20 )
                {
                    temperatura = 12;
                }
                else
                {
                    temperatura = value;
                }
                
            }
        }
        #endregion


        #region Métodos
        public void Saludar()
        {
            Console.WriteLine("Bienvenido, elige tu producto");
        }

        internal virtual string MostrarProducto()
        {
            string codigo = "";
            Console.WriteLine("1A: Cacahuates  2B: Papas  ");
            Console.WriteLine("Ingrese el código del producto");
            codigo = Console.ReadLine();
            return codigo;
        }

        public void LimpiarDisplay()
        {
            Thread.Sleep(5000); // 5000 [ms]
            Console.Clear();
        }

        internal virtual void MostrarPrecio(string codigo)
        {
            switch(codigo )
            {
                case "1A":
                    Console.WriteLine("Precio: ${0}", precio);
                    break;
                case "2B":
                    Console.WriteLine("Precio: ${0}",precio + 10);
                    break;
                default:
                    Console.WriteLine("Producto no encontrado");
                    break;
            }
        }

        #endregion

        #region Constructor

        public Expendedora()
        {
            
            marca = "AMS";
            Saludar();
            LimpiarDisplay();

        }


        public Expendedora( bool mantenimiento )
        {
            if (mantenimiento)
            {
                Console.WriteLine("Hola, Ingresa la nueva temperatura");
                Temperatura = Convert.ToByte(Console.ReadLine());
                LimpiarDisplay();
                Console.WriteLine("Temperatura: {0}", Temperatura);
            }
        }

        #endregion



    }
}
