using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSample07062020.DAL;
using ApiSample07062020.DTOs.Guets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample07062020.Controllers
{
    [Route("api/guests")]
    [ApiController]
    public class GuestsController : ControllerBase

    {
        private readonly IServiceExample _service;
        public GuestsController(IServiceExample service)
        {
            _service = service;
        }
        //  http://localhost:59319/api/guests/test
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("Działa");
        }
        //... Api4 api/guests
        [HttpGet("{id:int}")]
        public IActionResult GetGuets(int id)
        {
            return Ok(_service.GetGuetsById(id));
        }

        [HttpPost]
        public IActionResult AddGuest(GuestRequestDTO requestDTO)
        {
            if (_service.AddGuest(requestDTO))
                return Ok("Nowy gość dodany")
                        else
                return BadRequest("Coś poszło nie tak");
        }
    }

}