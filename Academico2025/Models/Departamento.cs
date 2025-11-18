using System.ComponentModel.DataAnnotations;

namespace Academico2025.Models
{

    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        [Display(Name = ("E-mail"))]
        public string Email { get; set; }
        [Display(Name = ("Instituição"))]
        public int InstituicaoId { get; set; }
        public Instituicao? Instituicao { get; set;}

        [Display(Name = "Coordenador")]
        public string NomeCoordenador { get; set; }
    }
}
