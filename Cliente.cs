namespace Aula20ExercicioFixacao
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string EndereçoAtual { get; set; }

         public Cliente(string _nome){
            this.Nome = _nome;
        }

        public string MostrarDados(){
            return $"Nome: {Nome} \n Endereço: {EndereçoAtual}";
        }
    }
}