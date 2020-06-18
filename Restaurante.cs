namespace Aula20ExercicioFixacao
{
    public class Restaurante
    {
        public string Endereço { get; set; }

        public string NomeFantasia { get; set; }

        public Restaurante(){

        }
        public Restaurante(string _nomefantasia, string _endereço){
            this.NomeFantasia = _nomefantasia;
            this.Endereço = _endereço;
        }
    }
}