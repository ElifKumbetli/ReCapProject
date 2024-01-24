using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
        public class ColorsController : ControllerBase
        {
            private readonly object colorService;
            IColorService _colorService;

            //Loose coupled gevşek bağlılık
            //naming convention
            //IoC Container --Değişimin kontrolü
            public ColorsController(IColorService colorService)
            {
                _colorService = colorService;
            }

            [HttpGet("getall")]

            public IActionResult GetAll()
            {

                //Dependency chain -- bağımlılık zinciri

                var result = _colorService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpGet("getbyid")]
            public IActionResult GetById(int colorId)
            {
                var result = _colorService.GetById(colorId);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }


            [HttpPost("add")]
            public IActionResult Add(Color color)
            {
                var result = _colorService.Add(color);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }




        }

    
}
