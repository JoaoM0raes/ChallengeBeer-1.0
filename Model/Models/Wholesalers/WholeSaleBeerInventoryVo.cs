using Model.Models.Brewerie;
using Model.Shared;


namespace Model.Models.Wholesalers
{
    public class WholeSaleBeerInventoryVo : Entity
    {
        public BeerVo beer { get; set; }
        public WholeSalerVo wholeSalerVo { get; set; }
        public int quanitity { get; set; }
    }
}
