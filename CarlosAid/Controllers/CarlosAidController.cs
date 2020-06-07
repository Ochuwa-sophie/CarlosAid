using System;
using CarlosAid.Models;
using CarlosAid.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarlosAid.Controllers
{
   
    [ApiController]
    public class CarlosController : ControllerBase
    {
        private readonly CarlosService _carlosService;
       
        [HttpGet("/carlos")]
        public IActionResult Get()
        {
            try
            {
                var carlos = _carlosService.GetCarlos();
                return Ok(carlos);
            }
           catch (Exception e)
           {
                return BadRequest(new {message = e.Message});
           }
     
        }

        [HttpPost("/carlos")]
        public IActionResult Post(CarlosModel model)
        {
           try
           {
               var id = _carlosService.AddCarlos(model);
                return new CreatedResult("/Carlos/", new { Id = id, message = "Todo Item Created Succesfully"});
           }
           catch (Exception e)
           {
                return BadRequest(new {message = e.Message});
           }
        }

        [HttpPatch("/carlos")]
        public IActionResult Patch(CarlosModel model)
        {
            try
            {
                var id = _carlosService.UpdateCarlos(model);
                return new OkObjectResult(new { message = "Item Updated Succesfully", id });
            }
            catch(Exception e)
            {
                return BadRequest(new { message = e.Message});
            }
        }
    }

}