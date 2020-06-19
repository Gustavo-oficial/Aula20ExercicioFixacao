namespace Aula20ExercicioFixacao
{
    public class Restaurante
    {
        public string Endereço { get; set; }

        public string NomeFantasia { get; set; }

        public Restaurante(string _nomefant){
            this.NomeFantasia = _nomefant;
        }

        public string MostrarDados(){
            return $"Restaurante: {NomeFantasia} \n {Endereço}";
        }
    }
}