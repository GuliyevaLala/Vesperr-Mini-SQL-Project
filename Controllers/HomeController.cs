using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VesperrMiniProject.DAL;
using VesperrMiniProject.ViewModels;

namespace VesperrMiniProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;

        }
        public ActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Favparts = _context.Favparts.ToList(),
                Clients = _context.Clients.ToList(),
                AboutCards = _context.AboutCards.ToList(),
                Team = _context.Team.Include(x => x.SocialApps).ToList(),
                Categories = _context.Categories.Include(x => x.CardTypes).ThenInclude(x => x.Cards).ToList(),
                Services = _context.Services.ToList(),
                MoreServices = _context.MoreServices.ToList(),
                Testimonials = _context.Testimonials.ToList(),
                Features = _context.Features.ToList(),
                Faqqs = _context.Faqqs.ToList(),
                Contacts = _context.Contacts.ToList(),
                PricingCardOffers = _context.PricingCardOffers.Include(p=> p.PricingCard).Include(p => p.PricingOffers).ToList(),





            };
            return View(homeVM);
        }
    }


    
}
