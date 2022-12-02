using WorldCup.Domain.Validation;

namespace WorldCup.Domain.Entities
{
    public sealed class FootballClub :Entity
    {
        public string Country { get; private set; }
        public string Image { get; private set; }

        public ICollection<CupTitle> CupTitles { get; set; }


        public FootballClub(string country, string image)
        {
            ValidateDomain(country, image);
        }

        public FootballClub(int id, string country, string image)
        {
            DomainExceptionValidation.When(id < 0, "Invalid ID");
            Id = id;
            ValidateDomain(country, image);
        }

        private void ValidateDomain(string country, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(country), "Invalid country! Country is required");
            DomainExceptionValidation.When(country.Length < 3, "Invalid country, too short, minimum 3 characters");

            DomainExceptionValidation.When(image.Length > 300, "Path of image too long");

            Country = country;
            Image = image;
        }

        public void Update(string country, string image)
        {
            ValidateDomain(country, image);
        }



    }
}
