using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShorterLink.Models
{
    public class Link
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string HashCode { get; set; }
    }
}
