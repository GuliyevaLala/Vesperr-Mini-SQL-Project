using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VesperrMiniProject.Models;

namespace VesperrMiniProject.ViewModels
{
    public class HomeVM
    {
        public List<Favpart> Favparts { get; set; }
        public List<Clients> Clients { get; set; }
        public List<AboutUs> AboutCards { get; set; }
        public List<Teamember> Team { get; set; }
        public List<Category> Categories { get; set; }
        public List<Services> Services { get; set; }
        public List<MoreServices> MoreServices { get; set; }
        public List<Testimonials> Testimonials { get; set; }
        public List<Features> Features { get; set; }
        public List<Faqs> Faqqs { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<PricingCard> PricingCards { get; set; }
        public List<PricingOffer> PricingOffers { get; set; }
        public List<PricingCardOffer> PricingCardOffers { get; set; }



    }
}
