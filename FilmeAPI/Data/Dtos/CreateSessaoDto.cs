using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Data.Dtos
{
    public class CreateSessaoDto
    {
        [Required]
        public int FilmeId { get; set; }
        public int CinemaId { get; set; }
    }
}
