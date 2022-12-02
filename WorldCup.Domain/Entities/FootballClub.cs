namespace WorldCup.Domain.Entities
{
    public sealed class FootballClub
    {
        public int Id { get; set; }

        public string Country { get; set; }
        public string Image { get; set; }

        public ICollection<CupTitle> CupTitles { get; set; }




    }
}
