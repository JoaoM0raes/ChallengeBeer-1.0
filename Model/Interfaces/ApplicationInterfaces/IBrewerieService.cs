using Model.Models.Brewerie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces.ApplicationInterfaces
{
    public interface IBrewerieService
    {
        public Task AddBeer(BeerVo beer);

        public Task EditBeer(BeerVo Beer);

        public Task DeleteBeer(BeerVo Beer);

        public Task<List<BeerVo>> SelectAllBeers();

        public Task AddBrewerie(BreweryVo brewery);

        public Task DeleteBrewerie(BreweryVo brewery);

        public Task<List<BeerVo>> SelectAllBeersByBrewery(Guid id);

        public Task<List<BreweryVo>> SelectAllBreweries();

        public Task<BreweryVo> SelectBrewerieById(Guid id);
    }
}
