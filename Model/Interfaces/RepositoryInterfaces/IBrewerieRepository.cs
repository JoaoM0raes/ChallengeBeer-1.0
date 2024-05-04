using Model.Models.Brewerie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces.RepositoryInterfaces
{
    public interface IBrewerieRepository
    {
        public Task AddBeer(BeerVo beer);

        public Task EditBeer(BeerVo Beer);

        public Task DeleteBeer(BeerVo Beer);

        public Task<List<BeerVo>> SelectAllBeers();

        public Task AddBrewerie(BreweryVo brewery);

        public Task<List<BeerVo>> SelectAllBeersByBrewery(Guid id);

        public Task<List<BreweryVo>> SelectAllBreweries();

    }
}
