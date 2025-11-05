using Frete.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frete.Classes
{
    public class Transporadora : IModalidadeFrete
    {
        public double Calcular(double peso)
        {
            return peso * 4.00;
        }
    }
}
