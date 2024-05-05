using Model.Interfaces.ApplicationInterfaces;
using Model.Interfaces.RepositoryInterfaces;
using Model.Models.Brewerie;


namespace Application.Services
{
    public class BrewerieService : IBrewerieService
    {
        IBrewerieRepository _repository { get; set; }

        public BrewerieService(IBrewerieRepository repository)
        {
            _repository = repository;
        }

        public Task AddBeer(BeerVo beer)
        {
            _repository.AddBeer(beer);
            return Task.CompletedTask;
        }

        public Task AddBrewerie(BreweryVo brewery)
        {
            _repository.AddBrewerie(brewery);
            return Task.CompletedTask;
        }

        public Task DeleteBeer(BeerVo Beer)
        {
            throw new NotImplementedException();
        }

        public Task EditBeer(BeerVo Beer)
        {
            throw new NotImplementedException();
        }

        public Task<List<BeerVo>> SelectAllBeers()
        {
            throw new NotImplementedException();
        }

        public Task<List<BeerVo>> SelectAllBeersByBrewery(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BreweryVo>> SelectAllBreweries()
        {
            throw new NotImplementedException();
        }
    }
}
