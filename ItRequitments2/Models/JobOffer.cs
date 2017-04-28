using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItRequitment.Models
{
    public class JobOffer
    {
        public int JobOfferId { get; protected set; }

        public DateTime StartTime { get; protected set; }

        public DateTime EndTime { get; protected set; }

        public string Title { get; protected set; }

        public string Description { get; protected set; }

        public string Placement { get; protected set; }

        public Company company { get; protected set;}

        public IEnumerable<string> Category { get; protected set; }
         
     }
}