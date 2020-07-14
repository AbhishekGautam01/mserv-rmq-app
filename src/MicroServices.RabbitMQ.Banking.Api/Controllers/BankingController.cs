using System.Collections.Generic;
using MicroservicesRabbitMQ.Banking.Application.Interfaces;
using MicroservicesRabbitMQ.Banking.Application.Models;
using MicroservicesRabbitMQ.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesRabbitMQ.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.TransferFunds(accountTransfer);
            return Ok(accountTransfer);
        }

    }
}
