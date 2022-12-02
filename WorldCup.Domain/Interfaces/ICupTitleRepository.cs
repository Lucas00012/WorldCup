using WorldCup.Domain.Entities;

namespace WorldCup.Domain.Interfaces
{
    public interface ICupTitleRepository
    {
        Task<IEnumerable<CupTitle>> GetCupTitlesAsync();

        Task<CupTitle> GetCupTitleByIdAsync(int? id);
        Task<CupTitle> GetCupTitleFootballClubAsync(int? id);
        Task<CupTitle> CreateAsync(CupTitle cupTitle);
        Task<CupTitle> UpdateAsync(CupTitle cupTitle);
        Task<CupTitle> RemoveAsync(CupTitle cupTitle);

    }
}
