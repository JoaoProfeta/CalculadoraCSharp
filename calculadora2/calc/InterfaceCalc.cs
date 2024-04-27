using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora2.calc
{
    public interface ICalculator
    {
        double result { get; set; }
        double Calcular(string resultado);
    }
}
