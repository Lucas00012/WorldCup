using WorldCup.Domain.Validation;

namespace WorldCup.Domain.Entities
{
    public sealed class CupTitle : Entity
    {
        public int CupYear { get; private set; }

        public string Location { get; private set; }

        public int? ChampionFootballClubId { get; set; } //Foreign Key

        public FootballClub? ChampionFootballClub { get; set; } 

        private void ValidateDomain(int cupYear, string location)
        {
            DomainExceptionValidation.When(cupYear < 1930, "Invalid year for the FIFA World Cup! Please enter a valid year (It starts from 1930)");

            DomainExceptionValidation.When(string.IsNullOrEmpty(location),"Invalid location! Location is required");
            DomainExceptionValidation.When(location.Length <3, "Invalid location, too short, minimum 3 characterss");

            CupYear = cupYear;
            Location = location;

        }

        public void Update(int cupYear, string location, int championFootballClubId)
        {
            ValidateDomain(cupYear, location);

            ChampionFootballClubId = championFootballClubId;

        }

        public CupTitle(int cupYear, string location)
        {
            ValidateDomain(cupYear, location);
        }

        public CupTitle(int id, int cupYear, string location)
        {
            DomainExceptionValidation.When(id < 0, "Invalid ID");
            Id = id;

            ValidateDomain(cupYear, location);
        }


    }
}
