﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Automobiliu_skelbimu_portalas.Data
{
    public class Searches
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int AdId { get; set; }
        public Ad Ad { get; set; }
        public DateTime Time { get; set; }
    }
}
