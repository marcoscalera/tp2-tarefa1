using Frete.Classes;
using Frete.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Frete.Pedidos
{
    internal class Pedido
    { 
        public double calcularFrete(string modalidade, double peso)
        {
            IModalidadeFrete servicoDeFrete;

            switch (modalidade.ToUpper())
            {
                case "SEDEX":
                    servicoDeFrete = new Sedex();
                    break;
                case "PAC":
                    servicoDeFrete = new Pac();
                    break;
                case "TRANSPORTADORA":
                    servicoDeFrete = new Transporadora();
                    break;
                default:
                    throw new ArgumentException("Modalidade de frete inválida.");
            }

            return servicoDeFrete.Calcular(peso);
        }
    }
}
