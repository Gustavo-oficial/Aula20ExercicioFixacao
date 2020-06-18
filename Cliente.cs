namespace Aula20ExercicioFixacao
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string EndereçoAtual { get; set; }
        
        public Cliente(){

        }

        public Cliente(string _nome, string _endereçoatual){
            this.Nome = _nome;
            this.EndereçoAtual = _endereçoatual;
        }
    }
}