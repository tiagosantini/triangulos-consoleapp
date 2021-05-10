
namespace Triangulos.ConsoleApp
{
    public class TrianguloBase
    {
        public double ladoX, ladoY, ladoZ;
        public string tipo;

        public TrianguloBase()
        {
        }

        public TrianguloBase(string tipo)
        {
            this.tipo = tipo;
        }

        public bool Validar()
        {
            if (ladoX > ladoY + ladoZ || ladoY > ladoX + ladoZ || ladoZ > ladoX + ladoY)
                return false;

            return true;
        }
    }
}
