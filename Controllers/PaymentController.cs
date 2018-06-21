using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace livraria_virtual_payment_api.Controllers
{
    [Route("v1/public/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] Payment paymentInfo)
        {
            try
            {
                return Ok("Pagamento efetuado com sucesso!");
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
