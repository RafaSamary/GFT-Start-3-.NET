using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retangulo
{
    public class Retangulo
    {
        public double comprimento;
        public double largura;

        public void DefinirMedidas(double comprimento, double largura)
        {
            this.comprimento = comprimento;
            this.largura = largura;
        }

        public double ObterArea()
        {
            return comprimento * largura;
        }
    }
}