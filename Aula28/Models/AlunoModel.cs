namespace Aula28.Models
{
    public class AlunoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Status { get; set; }

        public AlunoModel(int id, string nome, string sobrenome, string status)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Status = status;
        }
    }
}
