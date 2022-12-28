using FluentAssertions;
using WorldCup.Domain.Entities;

namespace WorldCup.Domain.Test.Domain
{
    public class CupTitleUnitTest
    {

        [Fact]
        public void CreateCupTitle_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new CupTitle(2014, "Brazil");

            action.Should()
                .NotThrow<Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateCupTitle_WithYearCupInvalid_DomainExceptionInvalidYearCup()
        {
            Action action = () => new CupTitle(1920, "England");

            action.Should()
                .Throw<Validation.DomainExceptionValidation>().WithMessage("Invalid year for the FIFA World Cup! Please enter a valid year (It starts from 1930)");
        }



    }
}
