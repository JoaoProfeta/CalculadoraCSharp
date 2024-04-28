using Calculadora.calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Calc
{
    public class Operar : ICalculator
    {
        #region caso queira fazer com switch ::::
        //public double Calcular(double primeiroIndice, char operador, double segundoIndice)
        //{
        //    switch (operador)
        //    {
        //        case '+': return primeiroIndice + segundoIndice; break;
        //        case '-': return primeiroIndice - segundoIndice; break;
        //        case '*': return primeiroIndice * segundoIndice; break;
        //        case '/': return primeiroIndice / segundoIndice; break;
        //            default: return 0;
        //    }
        //}        
        #endregion
        public double Calcular(string resultado)
        {
            if(resultado == null || resultado == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(new System.Data.DataTable().Compute(resultado, null));
            }
            
        }
    }
}
