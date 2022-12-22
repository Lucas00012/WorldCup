using WorldCup.Application.DTOs;

namespace WorldCup.Application.Interfaces
{
    public interface ICupTitleService
    {

        Task<IEnumerable<CupTitleDTO>> GetCupTitles();
        Task<CupTitleDTO> GetById(int? id);

        Task Add(CupTitleDTO cupTitleDto);

        Task Update(CupTitleDTO cupTitleDto);

        Task Remove(int? id );

    }
}
