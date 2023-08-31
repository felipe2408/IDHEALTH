using IDHEALTH.Collections;
using IDHEALTH.Interface;
using IDHEALTH.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IDHEALTH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProduct db = new ProductCollection();

        [HttpGet]

        [Route("GetAll")]
        public async Task<IActionResult> GetAllProduct()
        {

            return Ok(await db.GetAllProduct());
        }

        [HttpPost]

        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] Product product)
        {

            if (product == null)
                return BadRequest();


            await db.InsertProduct(product);

            return Created("Created", true);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductID(string id)
        {
            return Ok(await db.FindById(id));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerson([FromBody] Product product, string id)
        {

            if (product == null)
                return BadRequest();


            product.ProductID = new MongoDB.Bson.ObjectId(id);
            await db.UpdateProduct(product);

            return Created("Created", true);
        }
    }
}
