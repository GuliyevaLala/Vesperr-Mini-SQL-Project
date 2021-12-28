using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesperrMiniProject.Models
{
    public class PricingCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public List<PricingCardOffer> PricingCardOffers { get; set; }


    }
}
