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

            // Teste Triângulo Equilátero
            telaTriangulo.DefinirLados(5, 5, 5);
            telaTriangulo.ApresentarTriangulo();

            // Teste Triângulo Isósceles
            telaTriangulo.DefinirLados(3, 4, 3);
            telaTriangulo.ApresentarTriangulo();

            // Teste Triângulo Escaleno
            telaTriangulo.DefinirLados(3, 4, 5);
            telaTriangulo.ApresentarTriangulo();

            // Teste Triângulo Inválido
            telaTriangulo.DefinirLados(11, 5, 5);
            telaTriangulo.ApresentarTriangulo();

            Console.ReadLine();
        }
    }
}
