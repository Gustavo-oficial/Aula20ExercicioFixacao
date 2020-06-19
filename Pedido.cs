
using System;

namespace Aula20ExercicioFixacao
{
    public class Pedido
    {
        internal static object pedido1;

        public string Itens { get; set; }

        public Cliente Cliente { get; set; }

        public Restaurante Restaurante { get; set; }

        public string FormaDePegamento { get; set; }

        public bool PedidoPago { get; set; }

        public DateTime Horario { get; set; }
        public string EntregarPedido(){
            if(PedidoPago == true){


            string dadospedido = "Pedido entregue! \n" ;

            Horario = DateTime.Now;

            dadospedido += Itens;
            dadospedido += " \n Pedido entregue as " + Horario;



              return dadospedido;
            }else{
             return "Pedido ainda não foi pago!";
            }
        }


    }
}