using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo título é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo genêro é obrigatório")]
        [StringLength(50, ErrorMessage ="O tamanho do gênero é no máximo 50 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Campo duração é obrigatório")]
        [Range(70, 600, ErrorMessage ="A duração  deve ter entre 70 e 600 minutos")]
        public int Duracao { get; set; }

        public virtual ICollection<Sessao> Sessoes { get; set; }//1:n
    }
}
