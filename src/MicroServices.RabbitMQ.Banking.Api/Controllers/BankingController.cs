using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServices.RabbitMQ.Banking.Application.Interfaces;
using MicroServices.RabbitMQ.Banking.Application.Models;
using MicroServices.RabbitMQ.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroServices.RabbitMQ.Banking.Api.Controllers
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
            return Ok(_accountService.GetAccounts());
        }

        [HttpPost]
        public ActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.TransferFunds(accountTransfer);
            return Ok(accountTransfer);
        }

    }
}
