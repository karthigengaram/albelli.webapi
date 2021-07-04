using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace albelli.webservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                servicelibrary.ICustomerService customerService = core.IoC.Container.Resolve<servicelibrary.ICustomerService>();
                return Ok(customerService.GetCustomer(id));
            }
            catch (ArgumentNullException)
            {
                return BadRequest();
            }
            catch (ArgumentOutOfRangeException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult AddCustomer([FromBody] datacontract.Customer value)
        {
            try
            {
                servicelibrary.ICustomerService customerService = core.IoC.Container.Resolve<servicelibrary.ICustomerService>();
                return Ok(customerService.Create(value));
            }
            catch (ArgumentNullException)
            {
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

    }
}
