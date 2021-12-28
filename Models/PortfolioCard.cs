using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesperrMiniProject.Models
{
    public class PortfolioCard
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Image { get; set; }
            public List<CardType> CardTypes { get; set; }
        
    }

}

