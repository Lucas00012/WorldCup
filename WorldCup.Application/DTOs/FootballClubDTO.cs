using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WorldCup.Application.DTOs
{
    public class FootballClubDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The country club is required")]
        [StringLength(100, MinimumLength = 3)]
        [DisplayName("Country")]
        public string Country { get; set; }

        [StringLength(250, MinimumLength = 3)]
        [DisplayName("Image")]
        public string? Image { get; set; }
    }
}
