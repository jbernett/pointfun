using backend.Models.interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Location : IHaveGuid
    {
        public Location()
        {
            
        }
        [Key]
        public Guid Guid { get; set; }
        public decimal x { get; set; }
        public decimal y { get; set; }
        public Location tail { get; set; }
        public Slice slice { get; set; }
    }
}