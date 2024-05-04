using Microsoft.EntityFrameworkCore;
using Model.Models.Brewerie;
using Model.Models.Wholesalers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ErmContext
{
    public class DbContextBeer : DbContext
    {
        public DbContextBeer(DbContextOptions<DbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<BeerVo> BeerDbSet { get; set; }
        public DbSet<BreweryVo> BreweryDbSet { get; set; }
        public DbSet<WholeSaleBeerInventoryVo> WholeSaleBeerInventory { get; set; }
        public DbSet<WholeSalerVo> WholeSaler { get; set; }
    }
}
