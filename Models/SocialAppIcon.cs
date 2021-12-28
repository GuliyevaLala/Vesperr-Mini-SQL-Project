using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesperrMiniProject.Models
{
    public class SocialAppIcon
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int TeamemberId { get; set; }
        public Teamember Team { get; set; }

    }
}
