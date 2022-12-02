using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCup.Domain.Entities;

namespace WorldCup.Domain.Interfaces
{
    public interface IFootballClubRepository
    {

        Task<IEnumerable<FootballClub>> GetFootballClubAsync();

        Task<FootballClub> GetFootballClubByIdAsync(int? id);

        Task<FootballClub> CreateAsync(FootballClub footballClub);
        Task<FootballClub> UpdateAsync(FootballClub footballClub);
        Task<FootballClub> RemoveAsync(FootballClub footballClub);

    }
}
