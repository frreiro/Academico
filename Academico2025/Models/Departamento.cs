namespace Academico2025.Models
{

    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int InstuicaoId { get; set; }
        public Instituicao? Instituicao { get; set;}
    }
}
