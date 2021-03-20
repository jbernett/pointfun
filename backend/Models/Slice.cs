using System;
using System.Collections.Generic;
using backend.Models.interfaces;
using System.ComponentModel.DataAnnotations;

namespace backend.Models {
    public class Slice : IHaveGuid {
        public Slice()
        {
            
        }
        [Key]
        public Guid Guid { get; set; }

        public List<Location> points { get; set; }

        public Scan Scan { get; set; }
        
    }
}