using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesperrMiniProject.Models
{
    public class CardType
    {
        public int Id { get; set; }
        public int PortfolioCardId { get; set; }
        public PortfolioCard Cards { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }

    }
}