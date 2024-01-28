using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechFit.Core.Entities;
public class Pagamento
{

    
    public int PagamentoId { get; set; }

    public required string Descricao { get; set; }
    public double ValorBruto { get; set; }
    public double Desconto { get; set; } = 0;
    public DateTime DateTime { get; set; } = DateTime.Now;

    // public void RealizarPagamento(Cliente cliente, double valor)
    // {
    //     // Implementação específica do pagamento
    //     Console.WriteLine($"{cliente.Nome} está efetuando o pagamento no valor de {valor}");
    // }
}

// public class CartaoDeCredito : Pagamento
// {
//     public string NumCartao { get; set; }

//     public new void RealizarPagamento(Cliente cliente, double valor)
//     {
//         // Console.WriteLine("Numero do cartão: ");
//         // NumCartao = Console.ReadLine();

//         Console.WriteLine($"O valor de {valor} foi pago com cartão de crédito por {cliente.Nome}.");
//     }
// }

// public class TransfarenciaPix : Pagamento
// {
//     public String Chave { get; set; }

//     public new void RealizarPagamento(Cliente cliente, double valor)
//     {
//         // Console.WriteLine("Chave Pix: ");
//         // string chavePix = Console.ReadLine();

//         Console.WriteLine($"O valor de {valor} foi pago por {cliente.Nome} com Pix");
//     }
// }

// public class EmDinheiro : Pagamento
// {
//     public new void RealizarPagamento(Cliente cliente, double valor)
//     {
//         Console.WriteLine($"O valor de {valor} foi pago em dinheiro por {cliente.Nome}.");
//     }
// }
