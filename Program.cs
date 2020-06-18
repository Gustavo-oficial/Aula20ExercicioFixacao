using System;

namespace Aula20ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Deseja entar como restaurante ou cliente?");
            string cliente = Console.ReadLine();

            if(cliente == "cliente"){
            Restaurante bk = new Restaurante("Burguer King", "Rua Adonina,589");
            System.Console.WriteLine($"O nome do restaurante solicitado é {bk.NomeFantasia}, e se localiza na {bk.Endereço}");

            Pedido solicitar = new Pedido();

            solicitar.Itens = "Whopper, Batata frita, Coca-cola";

            System.Console.WriteLine(solicitar.Itens);


            System.Console.WriteLine("Qual seria a forma de pagamento?");
            string FormaDePagamento = Console.ReadLine();

            solicitar.PedidoPago =true;

            System.Console.WriteLine("Deseja finalizar o pedido e pagar? Digite true se sim, caso ao contrario digite false.");
            bool PedidoPago = Boolean.Parse(Console.ReadLine());

            switch (PedidoPago)
            {
                case true: System.Console.WriteLine(solicitar.EntregarPedido());
                break;


                default:System.Console.WriteLine("Opção Invalida");
                break;
            }
            }else
            {
               Cliente ribamar = new Cliente("Ribamar", "Rua Varsovia,29");
            System.Console.WriteLine($"O nome do cliente é {ribamar.Nome}, e se localiza no {ribamar.EndereçoAtual}"); 
            }
 
        }
    }
}
