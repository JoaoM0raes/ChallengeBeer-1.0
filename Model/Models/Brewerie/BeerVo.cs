using Model.Shared;

namespace Model.Models.Brewerie
{
    public class BeerVo : Entity
    {
        public int price { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public BreweryVo brewery { get; set; }
    }
}