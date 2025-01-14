﻿using ArzonMarket.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArzonMarket.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class WorkersContoller : ControllerBase
    {
        private IWorkerService workerService;

        public WorkersContoller(IWorkerService workerService)
        {
            this.workerService = workerService;
        }
    }
}
