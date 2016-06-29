using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuterServices.DTO
{
    public class TravelResponse
    {
        public ReisError ReisError { get; set; }
        public List<TravelProposal> TravelProposals { get; set;}
    }
}
