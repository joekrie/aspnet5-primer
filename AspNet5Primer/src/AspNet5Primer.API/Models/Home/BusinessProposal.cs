using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet5Primer.SPA.Models.Home
{
    public class BusinessProposal
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Pitch { get; set; }
        public int CapitalNeeded { get; set; }
    }
}
