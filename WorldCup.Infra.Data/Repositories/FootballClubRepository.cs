using Microsoft.EntityFrameworkCore;
using WorldCup.Domain.Entities;
using WorldCup.Domain.Interfaces;
using WorldCup.Infra.Data.Context;

namespace WorldCup.Infra.Data.Repositories
{
    public class FootballClubRepository : IFootballClubRepository
    {
        ApplicationDbContext _footbalClubContext;
        public FootballClubRepository(ApplicationDbContext context)
        {
            _footbalClubContext = context;
        }

        public async Task<FootballClub> CreateAsync(FootballClub footballClub)
        {
            _footbalClubContext.Add(footballClub);

            await _footbalClubContext.SaveChangesAsync();

            return footballClub;
        }

        public async Task<IEnumerable<FootballClub>> GetFootballClubAsync()
        {
            return await _footbalClubContext.FootballClubs.ToListAsync();
        }

        public async Task<FootballClub> GetFootballClubByIdAsync(int? id)
        {
            return await _footbalClubContext.FootballClubs.FindAsync(id);
        }

        public async Task<FootballClub> RemoveAsync(FootballClub footballClub)
        {
            _footbalClubContext.Remove(footballClub);

            await _footbalClubContext.SaveChangesAsync();

            return footballClub;
        }

        public async Task<FootballClub> UpdateAsync(FootballClub footballClub)
        {
            _footbalClubContext.Update(footballClub);

            await _footbalClubContext.SaveChangesAsync();

            return footballClub;
        }
    }
}
