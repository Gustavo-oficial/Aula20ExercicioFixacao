
namespace Aula20ExercicioFixacao
{
    public class Pedido
    {
        public string Itens { get; set; }

        public string Cliente { get; set; }

        public string Restaurante { get; set; }

        public string FormaDePegamento { get; set; }

        public bool PedidoPago { get; set; }
        public string EntregarPedido(){
            if(PedidoPago == true){
              return "Pedido a caminho!";
            }else{
             return "Pedido ainda não foi pago!";
            }
        }


    }
}