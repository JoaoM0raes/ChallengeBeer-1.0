using Model.Models.Brewerie;


namespace Model.Interfaces.RepositoryInterfaces
{
    public interface IBrewerieRepository
    {
        public Task AddBeer(BeerVo beer);

        public Task EditBeer(BeerVo Beer);

        public Task DeleteBeer(BeerVo beer);

        public Task<List<BeerVo>> SelectAllBeers();

        public Task AddBrewerie(BreweryVo brewery);

        public Task DeleteBrewerie(BreweryVo breweryVo);

        public Task<List<BeerVo>> SelectAllBeersByBrewery(Guid id);

        public Task<List<BreweryVo>> SelectAllBreweries();

        public Task<BreweryVo> SelectBreweryById(Guid id);

        public Task<BeerVo> SelectBeerById(Guid id);

    }
}
