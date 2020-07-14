using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroservicesRabbitMQ.Banking.Application.Interfaces;
using MicroservicesRabbitMQ.Transfer.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesRabbitMQ.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _accountTransferService;
        public TransferController(ITransferService accountTransferService)
        {
            _accountTransferService = accountTransferService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AccountTransferLog>> GetAccountTransferLogs()
        {
            return Ok(_accountTransferService.GetAccountTransferLogs());
        }
    }
}
