using AutoMapper;
using WorldCup.Application.DTOs;
using WorldCup.Application.Interfaces;
using WorldCup.Domain.Entities;
using WorldCup.Domain.Interfaces;

namespace WorldCup.Application.Services
{
    public class CupTitleService : ICupTitleService
    {
        private ICupTitleRepository _cupTitleRepository;

        private readonly IMapper _mapper;

        public CupTitleService(ICupTitleRepository cupTitleRepository,IMapper mapper)
        {
            _cupTitleRepository = cupTitleRepository;
            _mapper= mapper;
        }


        public async Task<CupTitleDTO> GetById(int? id)
        {
            var cupTitleEntity = await _cupTitleRepository.GetCupTitleByIdAsync(id);

            return _mapper.Map<CupTitleDTO>(cupTitleEntity);
        }

        public async Task<IEnumerable<CupTitleDTO>> GetCupTitles()
        {
            var cupTitleEntities = await _cupTitleRepository.GetCupTitlesAsync();

            return _mapper.Map<IEnumerable<CupTitleDTO>>(cupTitleEntities);
        }

        public async Task<IEnumerable<CupTitleDTO>> getCupTitleChampionClub(int? id)
        {
            var cupTitleEntities = await _cupTitleRepository.GetCupTitleFootballClubAsync(id);

            return _mapper.Map<IEnumerable<CupTitleDTO>>(cupTitleEntities);
        }


        public async Task Add(CupTitleDTO cupTitleDto)
        {

            var cupTitleEntity = _mapper.Map<CupTitle>(cupTitleDto);
            await _cupTitleRepository.CreateAsync(cupTitleEntity);

        }

        public async Task Update(CupTitleDTO cupTitleDto)
        {
            var cupTitleEntity = _mapper.Map<CupTitle>(cupTitleDto);

            await _cupTitleRepository.UpdateAsync(cupTitleEntity);

        }
        public async Task Remove(int? id)
        {
            var cupTitleEntity = _cupTitleRepository.GetCupTitleByIdAsync(id).Result;
            await _cupTitleRepository.RemoveAsync(cupTitleEntity);

        }

 
    }
}
