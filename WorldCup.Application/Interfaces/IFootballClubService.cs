using WorldCup.Application.DTOs;

namespace WorldCup.Application.Interfaces
{
    public interface IFootballClubService
    {

        Task<IEnumerable<FootballClubDTO>> GetFootballClubAsync();

        Task<FootballClubDTO> GetByIdAsync(int? id);

        Task Add(FootballClubDTO footballClubDto);

        Task Update(FootballClubDTO footballClubDto);

        Task Remove(int? id);


    }
}
