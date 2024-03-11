using KuzemBackendDotnet.Application.Repositories.Course;
using Microsoft.AspNetCore.Mvc;

namespace KuzemBackendDotnet.API.Controllers
{
    [Route("api/[Controller]")]    
    [ApiController]
    public class CourseController : Controller
    {
        private readonly ICourseWriteRepository _courseWriteRepository;
        private readonly ICourseReadRepository _courseReadRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        public CourseController(ICourseWriteRepository courseWriteRepository,ICourseReadRepository courseReadRepository,IWebHostEnvironment webHostEnvironment)
        {
            this._courseWriteRepository = courseWriteRepository;

            this._courseReadRepository = courseReadRepository;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> GetCourse() 
        {
            var response=await _courseWriteRepository.AddAsync(new()
            {
                CreatedDate = DateTime.UtcNow,
                Title = "asdasd"
            });
            await _courseWriteRepository.SaveAsync();
            return Ok(response);    
        }

        
        [HttpGet("[action]")]
        public async Task<IActionResult> getAllCourse()
        {
            var list= this._courseReadRepository.GetAll();
            foreach(var item in list)
            {
                Console.WriteLine(item.Title);
            }
            return Json(list);
        }

        [HttpPost]
        public async Task<IActionResult> Upload()
        {
            string uploadPath = Path.Combine(webHostEnvironment.WebRootPath, "filesdoc");

            return Ok("asd");
        }

    }
}
