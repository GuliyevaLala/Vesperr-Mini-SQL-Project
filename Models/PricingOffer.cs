using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesperrMiniProject.Models
{
    public class PricingOffer
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Second { get; set; }
        public string Third { get; set; }
        public string Fourth { get; set; }
        public string Fifth { get; set; }
        public List<PricingCardOffer> PricingCardOffers { get; set; }
    }
}
