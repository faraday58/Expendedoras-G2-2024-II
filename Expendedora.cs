﻿using System;
using System.Threading;

namespace Expendedoras_G2_2024_II
{
    internal class Expendedora
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

        public string MostrarProducto()
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

        public void MostrarPrecio(string codigo)
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
            precio = 10;
            marca = "AMS";
            Temperatura = 14;
            Saludar();
            Console.WriteLine(" {0} ", marca);
            LimpiarDisplay();
            Console.WriteLine("Temperatura {0}", Temperatura);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            //string codigo; Esto no es posible, por que no hay valor asignado
            MostrarPrecio(codigo);

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
