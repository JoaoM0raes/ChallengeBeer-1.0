using Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models.Brewerie
{
    public class BreweryVo : Entity
    {
        [Required]
        public string breweryName { get; set; }
    }
}
