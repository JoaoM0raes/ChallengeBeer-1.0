using Infra.ErmContext;
using Microsoft.EntityFrameworkCore;
using Model.Interfaces.RepositoryInterfaces;
using Model.Models.Brewerie;


namespace Infra.Repositories.BrewerieRepository
{
    internal class BrewerieRepository : IBrewerieRepository
    {
        private DbContextBeer _dbContext { get; set; }

        public BrewerieRepository(DbContextBeer dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddBrewerie(BreweryVo brewery)
        {
            await _dbContext.AddAsync(brewery);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddBeer(BeerVo beer)
        {
            await _dbContext.BeerDbSet.AddAsync(beer);
            await _dbContext.SaveChangesAsync();
        }
        public async Task EditBeer(BeerVo Beer)
        {
            _dbContext.BeerDbSet.Update(Beer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteBeer(BeerVo beer)
        {
            _dbContext.BeerDbSet.Remove(beer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<BeerVo>> SelectAllBeers()
        {
            return await _dbContext.BeerDbSet.ToListAsync();
        }

        public async Task<List<BeerVo>> SelectAllBeersByBrewery(Guid id)
        {
            return await _dbContext.BeerDbSet.Where(beer => beer.brewery.Id == id).ToListAsync();
        }

        public async Task<List<BreweryVo>> SelectAllBreweries()
        {
            return await _dbContext.BreweryDbSet.ToListAsync();
        }
    }
}
