using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projet_freelancers.Models
{
    public class projet
    {
        public int Id { get; set; }
        public string titre { get; set; }
        public string description { get; set; }
        public string budget { get; set; }
        public string statut_projet { get; set; }
        public string date_projet { get; set; }
    }
}