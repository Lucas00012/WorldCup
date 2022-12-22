using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WorldCup.Domain.Entities;

namespace WorldCup.Application.DTOs
{
    public class CupTitleDTO
    {

        public int Id { get; set; }

        [Display(Name = "Cup Year", Description = "The Cup Year must be between 1930 and 3000.")]
        [Required(ErrorMessage ="The cup year is required")]
        [Range(1930, 3000)]
        [DisplayName("Cup Year")]
        public int CupYear { get;  set; }

        [Required(ErrorMessage = "The location is required")]
        [StringLength(100, MinimumLength = 3)]

        [DisplayName("Location")]
        public string? Location { get;  set; }

        public FootballClub? ChampionFootballClub { get; set; }

        [DisplayName("Champion Football Club")]
        public int? ChampionFootballClubId { get; set; }



    }
}
