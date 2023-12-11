using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Models
{
    public class Sessao
    { 
        public int? FilmeId { get; set; }

        public virtual Filme filme { get; set; }
        public int? CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }
    }
}
// ? pode ser null