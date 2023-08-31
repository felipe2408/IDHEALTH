using IDHEALTH.Collections;
using IDHEALTH.Interface;
using IDHEALTH.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IDHEALTH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategory db = new CategoryCollection();

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllCategories()
        {

            return Ok(await db.GetAllCategories());
        }

        [HttpPost]

        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] Category category)
        {

            if (category == null)
                return BadRequest();


            await db.InsertCategory(category);

            return Created("Created", true);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory([FromBody] Category person, string id)
        {

            if (person == null)
                return BadRequest();

          
            person.CategoryID = new MongoDB.Bson.ObjectId(id);
            await db.UpdateCategory(person);

            return Created("Created", true);
        }
    }
}
