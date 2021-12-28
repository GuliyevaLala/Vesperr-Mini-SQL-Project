using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesperrMiniProject.Models
{
    public class Teamember
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public List <SocialAppIcon> SocialApps { get; set; }
    }
}
