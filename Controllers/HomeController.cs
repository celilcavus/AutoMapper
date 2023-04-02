using AutoMapper;
using AutoMapperMvc.Dto;
using AutoMapperMvc.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _service;

        public HomeController(IMapper mapper, ICategoryService service)
        {
            _mapper = mapper;
            _service = service;
        }
        public IActionResult Index()
        {
            var categories = _service.GetCategories();

            var result = _mapper.Map<List<CategoryDto>>(categories);
            return View(result);
        }
    }
}