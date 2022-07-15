using Microsoft.AspNetCore.Mvc;
using SweeftDigital.Interfaces;
using SweeftDigital.Models;
using System.Collections.Generic;

namespace SweeftDigital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : Controller
    {
        private readonly IPupilRepository _pupilRespository;

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pupil>))]
        public IActionResult GetGenres()
        {
            var pupils = _pupilRespository.GetPupils();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pupils);
        }


        [HttpGet("teacher/{pupilName}")]
        public IActionResult GetTeacherByStudent(string PupilName, int pupilId)
        {
            if (!_pupilRespository.PupilExists(pupilId))
                return NotFound();

            var teachers = _pupilRespository.GetTeacherByPupilName(PupilName);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(teachers);
        }
    }
}
