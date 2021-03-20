using System.Reflection.Emit;
using System.Drawing;
using backend.Models;

namespace backend.ViewModel{
    public class PointViewModel {
        public PointViewModel(Location point)
        {
            x = point.x;
            y = point.y;
        }
        public decimal x { get; set; }
        public decimal y { get; set; }
    }
}