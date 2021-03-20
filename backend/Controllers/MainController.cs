using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using backend.Models;
using backend.Services;
using backend.Services.Interfaces;
using backend.Utilities;
using backend.ViewModel;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {       

        private readonly ILogger<MainController> _logger;
        private IService<Service> Service;

        public MainController(ILogger<MainController> logger, IService<Service> service)
        {
            _logger = logger;
            Service = service;
        }

       

        [HttpGet]
        public IEnumerable<SliceViewModel> Get()
        {
            var whatever = Service.SlideService.GetAllSlides().ToArray();
            return whatever;
        }
    }
}
