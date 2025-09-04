using System;
using System.Globalization;
using System.Collections.Generic;
using System.Collections;
using Automove;

namespace AppCarro{
    internal class Program{
        static void Main(string[]args){
            Carro novoCarro = new Carro{
                Modelo = "Volk",
                Marca = "Gol",
                Motor = 1.6.ToString("f1",CultureInfo.InvariantCulture),
                Quilometro = 40,
                Quilometragem = 0
            };

            Console.WriteLine(novoCarro);
            Console.WriteLine(novoCarro.KmPercorrido());
        }
    }
}

