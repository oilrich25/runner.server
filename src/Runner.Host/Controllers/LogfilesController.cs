﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GitHub.DistributedTask.WebApi;
using GitHub.Services.Location;
using GitHub.Services.WebApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Runner.Host.Controllers
{
    [ApiController]
    [Route("runner/host/_apis/v1/[controller]")]
    public class LogfilesController : VssControllerBase
    {

        private readonly ILogger<LogfilesController> _logger;
        
        static Dictionary<int, (TaskLog, string)> logs = new Dictionary<int, (TaskLog, string)>();

        public LogfilesController(ILogger<LogfilesController> logger)
        {
            _logger = logger;
        }

        [HttpPost("{scopeIdentifier}/{hubName}/{planId}")]
        public async Task<IActionResult> CreateLog(Guid scopeIdentifier, string hubName, Guid planId)
        {
            var log = await FromBody<TaskLog>();
            log.Id = logs.Keys.LastOrDefault() + 1;
            logs.Add(log.Id, (log, ""));
            return await Ok(log);
        }

        [HttpPost("{scopeIdentifier}/{hubName}/{planId}/{logId}")]
        public async Task AppendLogContent(Guid scopeIdentifier, string hubName, Guid planId, int logId)
        {
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {  
                logs[logId] = (logs[logId].Item1, logs[logId].Item2 +  await reader.ReadToEndAsync());
            }
        }

        [HttpGet("{logId}")]
        public string GetLog(int logId)
        {
            return logs[logId].Item2;
        }
    }
}
