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
            try
            {
                _repository.AddBeer(beer);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                return Task.FromException(ex);
            }
        }

        public Task AddBrewerie(BreweryVo brewery)
        {
            try
            {
                _repository.AddBrewerie(brewery);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                return Task.FromException(ex);
            }
        }

        public Task DeleteBrewerie(BreweryVo breweryVo)
        {
            try
            {
                _repository.DeleteBrewerie(breweryVo);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                return Task.FromException(ex);
            }
        }

        public Task DeleteBeer(BeerVo beerVo)
        {
            try
            {
                _repository.DeleteBeer(beerVo);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                return Task.FromException(ex);
            }
        }

        public Task EditBeer(BeerVo beerVo)
        {
            try
            {
                _repository.EditBeer(beerVo);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                return Task.FromException(ex);
            }
        }

        public Task<List<BeerVo>> SelectAllBeers()
        {
            try
            {
                Task<List<BeerVo>> response = _repository.SelectAllBeers();
                return response;
            }
            catch (Exception ex)
            {
                return Task.FromException<List<BeerVo>>(ex);
            }
        }

        public Task<List<BeerVo>> SelectAllBeersByBrewery(Guid id)
        {
            try
            {
                Task<List<BeerVo>> response = _repository.SelectAllBeersByBrewery(id);
                return response;
            }
            catch (Exception ex)
            {
                return Task.FromException<List<BeerVo>>(ex);
            }
        }

        public Task<List<BreweryVo>> SelectAllBreweries()
        {
            try
            {
                Task<List<BreweryVo>> response = _repository.SelectAllBreweries();
                return response;
            }
            catch (Exception ex)
            {
                return Task.FromException<List<BreweryVo>>(ex);
            }
        }

        public Task<BreweryVo> SelectBrewerieById(Guid id)
        {
            try
            {
                Task<List<BreweryVo>> response = _repository.SelectAllBreweries();
                return response;
            }
            catch (Exception ex)
            {
                return Task.FromException<BreweryVo>(ex);
            }
        }
    }
}
