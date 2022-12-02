using FluentAssertions;
using WorldCup.Domain.Entities;

namespace WorldCup.Domain.Test
{
    public class FootballClubUnitTest
    {
        [Fact]
        public void CreateFootballClub_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new FootballClub(1, "Brazil", null);

            action.Should()
                .NotThrow<Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateFootBallClub_WithNegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new FootballClub(-1, "Brazil", null);

            action.Should()
                .Throw<Validation.DomainExceptionValidation>().WithMessage("Invalid ID");
        }


    }
}