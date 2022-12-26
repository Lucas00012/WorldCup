using Microsoft.EntityFrameworkCore;
using WorldCup.Domain.Entities;
using WorldCup.Domain.Interfaces;
using WorldCup.Infra.Data.Context;

namespace WorldCup.Infra.Data.Repositories
{
    public class CupTitleRepository : ICupTitleRepository
    {
        ApplicationDbContext _cupTitleContext;

        public CupTitleRepository(ApplicationDbContext context)
        {
            _cupTitleContext = context; //realize operation in DB
        }

        public async Task<CupTitle> CreateAsync(CupTitle cupTitle)
        {
            _cupTitleContext.Add(cupTitle);

            await _cupTitleContext.SaveChangesAsync();

            return cupTitle;

        }

        public async Task<CupTitle> GetCupTitleByIdAsync(int? id)
        {
            return await _cupTitleContext.CupTitles.FindAsync(id);
        }

        public async Task<CupTitle> GetCupTitleFootballClubAsync(int? id)
        {
            return await _cupTitleContext.CupTitles
                .Include(f => f.ChampionFootballClub)
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<CupTitle>> GetCupTitlesAsync()
        {
            return await _cupTitleContext.CupTitles.ToListAsync();
        }

        public async Task<CupTitle> RemoveAsync(CupTitle cupTitle)
        {
            _cupTitleContext.Remove(cupTitle);

            await _cupTitleContext.SaveChangesAsync();

            return cupTitle;
        }

        public async Task<CupTitle> UpdateAsync(CupTitle cupTitle)
        {
            _cupTitleContext.Update(cupTitle);

            await _cupTitleContext.SaveChangesAsync();

            return cupTitle;
        }
    }
}
