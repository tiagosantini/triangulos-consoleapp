using System;
using Triangulos.ConsoleApp.Controladores;
using Triangulos.ConsoleApp.Telas;

namespace Triangulos.ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            ControladorTriangulo contraladorTriangulo = new ControladorTriangulo();
            TelaTriangulo telaTriangulo = new TelaTriangulo(contraladorTriangulo);

            telaTriangulo.DefinirLados(3, 5, 4); // insere os valores dos lados (x, y, z)
            telaTriangulo.ApresentarTriangulo();

            Console.ReadLine();
        }
    }
}
