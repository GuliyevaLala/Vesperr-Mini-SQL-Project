using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VesperrMiniProject.Models;

namespace VesperrMiniProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)

        {

        }
        public DbSet<Favpart> Favparts { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<AboutUs> AboutCards { get; set; }
        public DbSet<Teamember> Team { get; set; }
        public DbSet<SocialAppIcon> SocialApps { get; set; }
        public DbSet<PortfolioCard> Card { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<MoreServices> MoreServices { get; set; }
        public DbSet<Faqs> Faqqs{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<PricingCard> PricingCards { get; set; }
        public DbSet<PricingOffer> PricingOffers { get; set; }
        public DbSet<PricingCardOffer> PricingCardOffers { get; set; }




    }
}
