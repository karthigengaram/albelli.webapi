using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections;
using Unity;
using albelli.datacontract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace albelli.webservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        #region Public Methods

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult CreateOrder([FromBody] datacontract.RequestOrder value)
        {
            try
            {
                servicelibrary.IOrderService orderService = core.IoC.Container.Resolve<servicelibrary.IOrderService>();
                return Ok(orderService.Create(TransformToOrder(value)));
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

        [HttpGet("byOrderID")]
        public ActionResult GetOrderDetails(int orderId)
        {
            try
            {
                servicelibrary.IOrderService orderService = core.IoC.Container.Resolve<servicelibrary.IOrderService>();
                return Ok(orderService.GetOrder(orderId));
            }
            catch (ArgumentNullException)
            {
                return BadRequest();
            }
            catch(ArgumentOutOfRangeException)
            {
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public ActionResult GetWidthForBin(int Id)
        {
            try
            {
                servicelibrary.IOrderService orderService = core.IoC.Container.Resolve<servicelibrary.IOrderService>();
                return Ok(orderService.GetWidthForBin(Id));
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

        #endregion

        #region Private Methods

        /// <summary>
        /// Transforms the RequestOrder to Order
        /// </summary>
        /// <param name="value">
        /// The RequestOrder <see cref="datacontract.IRequestOrder"/>
        /// </param>
        /// <returns>
        /// The Order <see cref="datacontract.IOrder"/> object.
        /// </returns>
        private IOrder TransformToOrder(RequestOrder value)
        {
            datacontract.IOrder order = core.IoC.Container.Resolve<datacontract.IOrder>();
            order.OrderDetails = value.OrderDetails;
            order.CustomerId = value.CustomerId;
            return order;
        }

        #endregion

    }
}
