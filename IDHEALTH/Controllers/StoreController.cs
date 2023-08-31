using IDHEALTH.Collections;
using IDHEALTH.Interface;
using IDHEALTH.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IDHEALTH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private IStore db = new StoreCollection();

        [HttpGet]

        [Route("GetAll")]
        public async Task<IActionResult> GetAllStore()
        {

            return Ok(await db.GetAllStore());
        }

        [HttpPost]

        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] Store store)
        {

            if (store == null)
                return BadRequest();


            await db.InsertStore(store);

            return Created("Created", true);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStore([FromBody] Store store, string id)
        {

            if (store == null)
                return BadRequest();


            store.StoreID = new MongoDB.Bson.ObjectId(id);
            await db.UpdateStore(store);

            return Created("Created", true);
        }
    }
}
