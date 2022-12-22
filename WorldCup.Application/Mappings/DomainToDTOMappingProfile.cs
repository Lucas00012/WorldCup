using AutoMapper;
using WorldCup.Application.DTOs;
using WorldCup.Domain.Entities;

namespace WorldCup.Application.Mappings
{
    public class DomainToDTOMappingProfile :Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<CupTitle, CupTitleDTO>().ReverseMap();
            CreateMap<FootballClub, FootballClubDTO>().ReverseMap();
        }



    }
}
