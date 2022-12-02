namespace WorldCup.Domain.Entities
{
    public sealed class CupTitle
    {
        public int Id { get; set; }

        public int CupYear { get; set; }

        public string Location { get; set; }

        public string Opponent { get; set; }

        public int FootballClubId { get; set; } //Foreign Key

        public FootballClub FootballClub { get; set; }




    }
}
