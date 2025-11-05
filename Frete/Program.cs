using System;
using Frete;
using Frete.Pedidos;

public class Program
{
    public static void Main(string[] args)
    {
        Pedido meuPedido = new Pedido();
        Console.Write("Digite o peso do pedido: ");
        double pesoDoPedido = Convert.ToDouble(Console.ReadLine());

        try
        {
            double fretePac = meuPedido.calcularFrete("PAC", pesoDoPedido);
            Console.WriteLine($"\nFrete PAC para {pesoDoPedido}kg: R$ {fretePac:F2}");

            double freteSedex = meuPedido.calcularFrete("SEDEX", pesoDoPedido);
            Console.WriteLine($"Frete SEDEX para {pesoDoPedido}kg: R$ {freteSedex:F2}");

            double freteTransportadora = meuPedido.calcularFrete("TRANSPORTADORA", pesoDoPedido);
            Console.WriteLine($"Frete TRANSPORTADORA para {pesoDoPedido}kg: R$ {freteTransportadora:F2}");   
        }

        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}   