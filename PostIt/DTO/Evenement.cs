﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt.DTO
{
    public class Evenement
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Categorie { get; set; }
        public string Operateur { get; set; }
        public string Tiers { get; set; }
        public string Description { get; set; }
        public string Statut { get; set; }
        public DateTime Echeance { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
