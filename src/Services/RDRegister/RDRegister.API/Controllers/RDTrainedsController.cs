using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RDRegister.API.Data;
using RDRegister.API.Models;

namespace RDRegister.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RDTrainedsController : ControllerBase
    {
        public RDTrainedsController(IRegisterRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RDTrained>> GetAllTraineds()
        {
            var trainedItems = _repository.GetAllTraineds();
            return Ok(trainedItems);
        }

        [HttpGet("{id}")]
        public ActionResult<RDTrained> GetTrainedById(int id)
        {
            var trainedItem = _repository.GetTrainedById(id);
            return Ok(trainedItem);
        }
    }
}
