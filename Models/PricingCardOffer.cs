using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesperrMiniProject.Models
{
    public class PricingCardOffer
    {
        public int Id { get; set; }
        public int PricingCardId { get; set; }
        public PricingCard PricingCard { get; set; }
        public int PricingOfferId { get; set; }
        public PricingOffer PricingOffers { get; set; }
    }
}
