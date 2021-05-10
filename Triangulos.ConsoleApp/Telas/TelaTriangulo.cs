using System;
using Triangulos.ConsoleApp.Controladores;

namespace Triangulos.ConsoleApp.Telas
{
    public class TelaTriangulo
    {
        ControladorTriangulo controladorTriangulo;

        public TelaTriangulo(ControladorTriangulo controladorTriangulo)
        {
            this.controladorTriangulo = controladorTriangulo;
        }

        public void DefinirLados(double ladoX, double ladoY, double ladoZ) // Pode ser refatorado para pedir input
        {
            controladorTriangulo.RegistrarTriangulo(ladoX, ladoY, ladoZ);
        }

        public void ApresentarTriangulo()
        {
            TrianguloBase triangulo = controladorTriangulo.DefinirTriangulo();

            if (triangulo != null)
                Console.WriteLine(triangulo.Tipo);
            else
                Console.WriteLine("Triângulo Inválido");
        }
    }
}
