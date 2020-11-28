using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cloud_project_BL.LocationUOW;
using cloud_project_Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cloud_project_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocationBussinessLogic _locationBl;

        public LocationController(ILocationBussinessLogic locationBussinesslogic)
        {
            _locationBl = locationBussinesslogic;
        }

        [HttpGet("list")]
        public IActionResult GetLocationList()
        {
            return Ok(_locationBl.GetAllLocationList());
        }

        [HttpGet("detail/{id}")]
        public IActionResult GetOneLocationDetail(int id)
        {
            return Ok(_locationBl.GetOneLocation(id));
        }


        [HttpPost("")]
        public IActionResult CreateNewLocation([FromBody] CreateNewLocationModel newLocation)
        {
            _locationBl.CreateNewLocation(newLocation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLocation([FromRoute] int id)
        {
            _locationBl.DeleteLocation(id);
            return Ok();
        }
    }
}
