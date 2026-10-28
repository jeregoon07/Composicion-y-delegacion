//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Composicion_Delegacion;

namespace Project
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        public static void Main()
        {
            Vehiculo electrico = 
            Vehiculo.CrearElectrico(
                "Tesla",
                "Model e");
            Vehiculo combustion=
            Vehiculo.CrearCombustion(
                "Renault",
                "Kwid");
            Console.WriteLine("=== VEHICULO ELECTRICO ===");
            Console.WriteLine(electrico.MostrarEstado());
            Console.WriteLine(electrico.Encender());
            Console.WriteLine(electrico.Frenar());
            Console.WriteLine(electrico.Apagar());

            Console.WriteLine();

            Console.WriteLine("=== VEHICULO COMBUSTION ===");
            Console.WriteLine(combustion.MostrarEstado());
            Console.WriteLine(combustion.Encender());
            Console.WriteLine(combustion.Frenar());
            Console.WriteLine(combustion.Apagar());


        }
    }
}