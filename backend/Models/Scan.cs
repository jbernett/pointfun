using System.Collections.Generic;
using System;
using backend.Models.interfaces;
using System.ComponentModel.DataAnnotations;

namespace backend.Models {
    public class Scan : IHaveGuid {
        public Scan()
        {
            
        }
        [Key]
        public Guid Guid { get; set; }

        public List<Slice> Slices { get; set; }

    }
}