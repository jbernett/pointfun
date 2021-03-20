using backend.Models;
using System.Collections.Generic;
using System.Linq;

namespace backend.ViewModel {
    public class SliceViewModel {
        public SliceViewModel(Slice slice)
        {
            Points = slice.points.Select(o => new PointViewModel(o)).ToList();
        }
        public List<PointViewModel> Points { get; set; }
    }
}