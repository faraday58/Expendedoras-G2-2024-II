﻿using System;


namespace Expendedoras_G2_2024_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Expendedora miExpendedora;
            Console.WriteLine("Desea entrar en modo mantenimiento");
            bool mantenimiento = bool.Parse(Console.ReadLine());
           switch(mantenimiento)
            {
                case true: 
                    miExpendedora = new Expendedora(true);
                    break;
                case false:
                    miExpendedora = new Expendedora();
                    break;
            }
            
            Console.ReadLine();

        }
    }
}
