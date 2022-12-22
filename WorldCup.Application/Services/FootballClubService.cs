using AutoMapper;
using System.Collections.Generic;
using WorldCup.Application.DTOs;
using WorldCup.Application.Interfaces;
using WorldCup.Domain.Entities;
using WorldCup.Domain.Interfaces;

namespace WorldCup.Application.Services
{
    public class FootballClubService : IFootballClubService
    {
        private IFootballClubRepository _footballClubRepository;

        private readonly IMapper _mapper;
        public FootballClubService(IFootballClubRepository footballClubRepository, IMapper mapper)
        {
            _footballClubRepository= footballClubRepository;
            _mapper= mapper;
        }


        public async Task<FootballClubDTO> GetByIdAsync(int? id)
        {
            var footballClubEntity = await _footballClubRepository.GetFootballClubByIdAsync(id);

            return _mapper.Map<FootballClubDTO>(footballClubEntity);    
        }

        public async Task<IEnumerable<FootballClubDTO>> GetFootballClubAsync()
        {
            var footballClubEntities = await _footballClubRepository.GetFootballClubAsync();

            return _mapper.Map<IEnumerable<FootballClubDTO>>(footballClubEntities);
        }
        public async Task Add(FootballClubDTO footballClubDto)
        {
            var footballClubEntity = _mapper.Map<FootballClub>(footballClubDto);

            await _footballClubRepository.CreateAsync(footballClubEntity);
        }

        public async Task Update(FootballClubDTO footballClubDto)
        {
            var footballClubEntity = _mapper.Map<FootballClub>(footballClubDto);

            await _footballClubRepository.UpdateAsync(footballClubEntity);
        }

        public async Task Remove(int? id)
        {
            var footballClubEntity = _footballClubRepository.GetFootballClubByIdAsync(id).Result;
            await _footballClubRepository.RemoveAsync(footballClubEntity);

        }


    }
}
