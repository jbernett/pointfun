using backend.Services.Interfaces;
using backend.Utilities;
using Microsoft.EntityFrameworkCore;

namespace backend.Services {
    public class Service : IService<Service> {

        private PointsAndSlidesDb Context;

        
        public Service(DbContextOptions<PointsAndSlidesDb> dbOptions)
        {
            Context = new PointsAndSlidesDb(dbOptions);
        }
        private SlideService _slideService;
        public SlideService SlideService
        {
            get { return _slideService != null ? _slideService : new SlideService(Context, this); }
            set { _slideService = value != null ? _slideService : new SlideService(Context, this); }
        }
        
    }
}