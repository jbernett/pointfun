using System.IO.Pipes;
using backend.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using backend.Utilities;
using System.Linq;
using backend.ViewModel;

namespace backend.Services{
    public class SlideService {

        private PointsAndSlidesDb Context;
        private Service Service;
        public SlideService(PointsAndSlidesDb context, Service service)
        {
            Context = context;
            Service = service;
        }
        public List<SliceViewModel> GetAllSlides(){
                return Context.Slices.Include(o => o.points).Select(o => new SliceViewModel(o)).ToList();
        }
    }
}