using IDHEALTH.Collections;
using IDHEALTH.Interface;
using IDHEALTH.Models;
using IDHEALTH.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IDHEALTH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonCollection db = new PersonCollection();

        [HttpGet]

        [Route("GetAllPerson")]
        public async Task<IActionResult> GetAllPerson()
        {

            return Ok(await db.GetAllPeople());
        }

        [HttpPost]

        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] Person person)
        {

            if (person == null)
                return BadRequest();
            
            if(person.IdentificationNumber == string.Empty)
            {
                ModelState.AddModelError("IdentificationNumber", "El campo IdentificationNumber es requerido");

            }

            await db.InsertPeople(person);

            return Created("Created",true);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonID(string id)
        {
            return Ok(await db.FindById(id));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerson([FromBody] Person person,string id)
        {

            if (person == null)
                return BadRequest();

            if (person.IdentificationNumber == string.Empty)
            {
                ModelState.AddModelError("IdentificationNumber", "El campo IdentificationNumber es requerido");

            }
            person.PersonID = new MongoDB.Bson.ObjectId(id);
            await db.UpdatePeople(person);

            return Created("Created", true);
        }

    }
}
