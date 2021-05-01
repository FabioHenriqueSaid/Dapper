using Dapper.Api.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Dapper.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        private readonly ILogger<SensorController> _logger;
        private readonly ISensorRepository _sensorRepository;

        public SensorController(ILogger<SensorController> logger, 
            ISensorRepository sensorRepository)
        {
            _logger = logger;
            _sensorRepository = sensorRepository;
        }
       
        [HttpGet]
        public IActionResult GetAllData() 
        {
            try
            {
                var data = _sensorRepository.ListAll();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter");
                
                return new StatusCodeResult(500);
            }
        }
        
       
        [HttpPost]
        public IActionResult SetData([FromBody]long step)
        {
            try
            {
                var data = _sensorRepository.Insert(step);
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar incluir");
                return new StatusCodeResult(500);
            }
        }
    }
}